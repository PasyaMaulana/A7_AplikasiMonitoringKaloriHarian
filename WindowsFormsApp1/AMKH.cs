using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AMKH : Form
    {
        private string connectionString = "Server=PASYA\\PASYA;Database=AMKH_DB;Integrated Security=True;";
        private int selectedIdKonsumsi = -1;
        private int selectedIdTarget   = -1;

        public AMKH()
        {
            InitializeComponent();
        }

        // ============================================================
        // BAGIAN B - Status Koneksi
        // ============================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            CekStatusKoneksi();
            LoadComboTarget();
            TampilkanJumlahData();
            TampilkanData();
        }

        private void CekStatusKoneksi()
        {
            try
            {
                using (SqlConnection c = new SqlConnection(connectionString))
                {
                    c.Open();
                    lblStatusKoneksi.Text      = "● Status Koneksi: TERHUBUNG";
                    lblStatusKoneksi.ForeColor = Color.LimeGreen;
                }
            }
            catch (Exception ex)
            {
                lblStatusKoneksi.Text      = "● Status Koneksi: GAGAL";
                lblStatusKoneksi.ForeColor = Color.Red;
                MessageBox.Show("Gagal terhubung ke database!\n\n" + ex.Message,
                    "Error Koneksi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // BAGIAN D - ExecuteScalar
        // ============================================================
        private void TampilkanJumlahData()
        {
            try
            {
                using (SqlConnection c = new SqlConnection(connectionString))
                {
                    c.Open();

                    SqlCommand cmdK = new SqlCommand("SELECT COUNT(*) FROM Konsumsi", c);
                    lblTotalKonsumsi.Text = "Total Data Konsumsi: " + (int)cmdK.ExecuteScalar() + " record";

                    SqlCommand cmdT = new SqlCommand("SELECT COUNT(*) FROM Target", c);
                    lblTotalTarget.Text = "Total Data Target: " + (int)cmdT.ExecuteScalar() + " record";

                    DateTime tglDipilih = dtpTanggalKonsumsi.Value.Date;

                    SqlCommand cmdKal = new SqlCommand(
                        "SELECT ISNULL(SUM(kalori),0) FROM Konsumsi WHERE tanggal = @tgl", c);
                    cmdKal.Parameters.AddWithValue("@tgl", tglDipilih);
                    decimal totalKal = (decimal)cmdKal.ExecuteScalar();

                    SqlCommand cmdTargetTgl = new SqlCommand(
                        "SELECT ISNULL(target_kalori,0) FROM Target WHERE tanggal = @tgl", c);
                    cmdTargetTgl.Parameters.AddWithValue("@tgl", tglDipilih);

                    // FIX: cek DBNull supaya tidak error saat DB kosong
                    decimal targetTgl = 0;
                    object tResult = cmdTargetTgl.ExecuteScalar();
                    if (tResult != null && tResult != DBNull.Value)
                        targetTgl = (decimal)tResult;

                    string tglStr = tglDipilih.ToString("dd/MM/yyyy");
                    if (targetTgl > 0)
                    {
                        decimal sisa   = targetTgl - totalKal;
                        string  status = sisa >= 0
                            ? "Sisa: " + sisa.ToString("N0") + " kkal"
                            : "MELEBIHI " + Math.Abs(sisa).ToString("N0") + " kkal!";
                        lblTotalKaloriHariIni.Text      = tglStr + " — " + totalKal.ToString("N0") + " / " + targetTgl.ToString("N0") + " kkal  |  " + status;
                        lblTotalKaloriHariIni.ForeColor = sisa >= 0 ? Color.LimeGreen : Color.Red;
                    }
                    else
                    {
                        lblTotalKaloriHariIni.Text      = tglStr + " — Kalori: " + totalKal.ToString("N0") + " kkal  |  (belum ada target)";
                        lblTotalKaloriHariIni.ForeColor = Color.FromArgb(255, 200, 60);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ExecuteScalar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // BAGIAN E - SqlDataReader
        // ============================================================
        private void TampilkanData()
        {
            try
            {
                using (SqlConnection c = new SqlConnection(connectionString))
                {
                    c.Open();
                    string query = @"
                        SELECT k.id_konsumsi, k.id_target, t.target_kalori,
                               k.nama_makanan, k.kalori, k.tanggal
                        FROM   Konsumsi k
                        INNER JOIN Target t ON k.id_target = t.id_target
                        ORDER  BY k.tanggal DESC, k.id_konsumsi DESC";

                    SqlCommand    cmd    = new SqlCommand(query, c);
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable     dt     = new DataTable();
                    dt.Load(reader);
                    dgvKonsumsi.DataSource = dt;

                    if (dgvKonsumsi.Columns.Count > 0)
                    {
                        dgvKonsumsi.Columns["id_konsumsi"].HeaderText   = "ID Konsumsi";
                        dgvKonsumsi.Columns["id_target"].HeaderText     = "ID Target";
                        dgvKonsumsi.Columns["target_kalori"].HeaderText = "Target Kalori";
                        dgvKonsumsi.Columns["nama_makanan"].HeaderText  = "Nama Makanan";
                        dgvKonsumsi.Columns["kalori"].HeaderText        = "Kalori (kkal)";
                        dgvKonsumsi.Columns["tanggal"].HeaderText       = "Tanggal";
                        dgvKonsumsi.Columns["id_konsumsi"].Visible      = false;
                        dgvKonsumsi.Columns["id_target"].Visible        = false;
                    }
                }
                TampilkanJumlahData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error menampilkan data: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        }
    }
}