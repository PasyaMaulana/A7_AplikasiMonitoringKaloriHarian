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

namespace AMKH_TESTING
{
    public partial class FormRiwayat : Form
    {
        private string connectionString =
            "Server=PASYA\\PASYA;Database=AMKH;Integrated Security=True;";

        public FormRiwayat()
        {
            InitializeComponent();
        }

        private void FormRiwayat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aMKHDataSet.vw_RiwayatAktivitas' table. You can move, or remove it, as needed.
            this.vw_RiwayatAktivitasTableAdapter.Fill(this.aMKHDataSet.vw_RiwayatAktivitas);
            // TODO: This line of code loads data into the 'aMKHDataSet.vw_RiwayatKonsumsi' table. You can move, or remove it, as needed.
            this.vw_RiwayatKonsumsiTableAdapter.Fill(this.aMKHDataSet.vw_RiwayatKonsumsi);
            // Default tanggal = kemarin
            dtpRiwayat.Value = DateTime.Today.AddDays(-1);
            dtpRiwayat.MaxDate = DateTime.Today.AddDays(-1); // Blokir pilih hari ini ke depan

            AturDGV(dgvRiwayatKonsumsi);
            AturDGV(dgvRiwayatAktivitas);

            TampilkanRiwayat();
        }

        private void AturDGV(DataGridView dgv)
        {
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
        }

        // ── Tombol Tampilkan ─────────────────────────────
        private void btnTampilkanRiwayat_Click(object sender, EventArgs e)
        {
            TampilkanRiwayat();
        }

        private void TampilkanRiwayat()
        {
            DateTime tgl = dtpRiwayat.Value.Date;

            // Validasi — pastikan tanggal yang dipilih memang masa lalu
            if (tgl >= DateTime.Today)
            {
                MessageBox.Show("Riwayat hanya menampilkan tanggal sebelum hari ini!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MuatRiwayatKonsumsi(tgl);
            MuatRiwayatAktivitas(tgl);
            TampilkanRingkasan(tgl);
        }

        // ── Load riwayat konsumsi via vw_RiwayatKonsumsi ─
        private void MuatRiwayatKonsumsi(DateTime tgl)
        {
            try
            {
                using (var c = new SqlConnection(connectionString))
                {
                    c.Open();
                    var cmd = new SqlCommand(
                        "SELECT * FROM vw_RiwayatKonsumsi " +
                        "WHERE tanggal = @tgl ORDER BY id_konsumsi", c);
                    cmd.Parameters.AddWithValue("@tgl", tgl);

                    var da = new SqlDataAdapter(cmd);
                    var dt = new DataTable();
                    da.Fill(dt);
                    dgvRiwayatKonsumsi.DataSource = dt;

                    if (dgvRiwayatKonsumsi.Columns.Count > 0)
                    {
                        if (dgvRiwayatKonsumsi.Columns.Contains("id_konsumsi"))
                            dgvRiwayatKonsumsi.Columns["id_konsumsi"].Visible = false;
                        if (dgvRiwayatKonsumsi.Columns.Contains("id_target"))
                            dgvRiwayatKonsumsi.Columns["id_target"].Visible = false;
                        if (dgvRiwayatKonsumsi.Columns.Contains("target_kalori"))
                            dgvRiwayatKonsumsi.Columns["target_kalori"].Visible = false;
                        if (dgvRiwayatKonsumsi.Columns.Contains("tanggal"))
                            dgvRiwayatKonsumsi.Columns["tanggal"].Visible = false;
                        if (dgvRiwayatKonsumsi.Columns.Contains("nama_item"))
                            dgvRiwayatKonsumsi.Columns["nama_item"].HeaderText = "Nama Item";
                        if (dgvRiwayatKonsumsi.Columns.Contains("kalori"))
                            dgvRiwayatKonsumsi.Columns["kalori"].HeaderText = "Kalori (kkal)";
                        if (dgvRiwayatKonsumsi.Columns.Contains("tipe"))
                            dgvRiwayatKonsumsi.Columns["tipe"].HeaderText = "Tipe";
                    }

                    lblJmlKonsumsi.Text = "(" + dt.Rows.Count + " item)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error riwayat konsumsi: " + ex.Message);
            }
        }

        // ── Load riwayat aktivitas via vw_RiwayatAktivitas
        private void MuatRiwayatAktivitas(DateTime tgl)
        {
            try
            {
                using (var c = new SqlConnection(connectionString))
                {
                    c.Open();
                    var cmd = new SqlCommand(
                        "SELECT * FROM vw_RiwayatAktivitas " +
                        "WHERE tanggal = @tgl ORDER BY id_aktivitas", c);
                    cmd.Parameters.AddWithValue("@tgl", tgl);

                    var da = new SqlDataAdapter(cmd);
                    var dt = new DataTable();
                    da.Fill(dt);
                    dgvRiwayatAktivitas.DataSource = dt;

                    if (dgvRiwayatAktivitas.Columns.Count > 0)
                    {
                        if (dgvRiwayatAktivitas.Columns.Contains("id_aktivitas"))
                            dgvRiwayatAktivitas.Columns["id_aktivitas"].Visible = false;
                        if (dgvRiwayatAktivitas.Columns.Contains("id_target"))
                            dgvRiwayatAktivitas.Columns["id_target"].Visible = false;
                        if (dgvRiwayatAktivitas.Columns.Contains("target_kalori"))
                            dgvRiwayatAktivitas.Columns["target_kalori"].Visible = false;
                        if (dgvRiwayatAktivitas.Columns.Contains("tanggal"))
                            dgvRiwayatAktivitas.Columns["tanggal"].Visible = false;
                        if (dgvRiwayatAktivitas.Columns.Contains("nama_aktivitas"))
                            dgvRiwayatAktivitas.Columns["nama_aktivitas"].HeaderText = "Nama Aktivitas";
                        if (dgvRiwayatAktivitas.Columns.Contains("kalori_terbakar"))
                            dgvRiwayatAktivitas.Columns["kalori_terbakar"].HeaderText = "Kalori Terbakar";
                    }

                    lblJmlAktivitas.Text = "(" + dt.Rows.Count + " aktivitas)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error riwayat aktivitas: " + ex.Message);
            }
        }

        // ── Ringkasan via vw_RingkasanRiwayat ───────────
        // Nama kolom disesuaikan dengan view yang sudah dibuat:
        // total_kalori_masuk, total_kalori_bakar, kalori_bersih,
        // target_kalori, status
        private void TampilkanRingkasan(DateTime tgl)
        {
            try
            {
                using (var c = new SqlConnection(connectionString))
                {
                    c.Open();
                    var cmd = new SqlCommand(
                        "SELECT total_kalori_masuk, total_kalori_bakar, " +
                        "       kalori_bersih, target_kalori, status " +
                        "FROM vw_RingkasanRiwayat WHERE tanggal = @tgl", c);
                    cmd.Parameters.AddWithValue("@tgl", tgl);

                    using (var r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            decimal masuk = r.IsDBNull(0) ? 0 : r.GetDecimal(0);
                            decimal terbakar = r.IsDBNull(1) ? 0 : r.GetDecimal(1);
                            decimal bersih = r.IsDBNull(2) ? 0 : r.GetDecimal(2);
                            decimal target = r.IsDBNull(3) ? 0 : r.GetDecimal(3);
                            string status = r.IsDBNull(4) ? "-" : r.GetString(4);

                            lblTotalKonsumsi.Text = "Kalori Masuk  : " + masuk.ToString("N0") + " kkal";
                            lblTotalTerbakar.Text = "Kalori Terbakar: " + terbakar.ToString("N0") + " kkal";
                            lblTargetRiwayat.Text = "Target Kalori  : " +
                                (target > 0 ? target.ToString("N0") + " kkal" : "(belum diset)");
                            lblKaloriBersih.Text = "Kalori Bersih  : " + bersih.ToString("N0") + " kkal";
                            lblStatus.Text = "Status         : " + status;

                            lblStatus.ForeColor = status == "TERCAPAI"
                                ? Color.LimeGreen
                                : Color.Red;
                            lblKaloriBersih.ForeColor = bersih <= target && target > 0
                                ? Color.LimeGreen
                                : Color.FromArgb(255, 200, 60);
                        }
                        else
                        {
                            // Tidak ada data di tanggal itu
                            lblTotalKonsumsi.Text = "Kalori Masuk  : 0 kkal";
                            lblTotalTerbakar.Text = "Kalori Terbakar: 0 kkal";
                            lblTargetRiwayat.Text = "Target Kalori  : (tidak ada data)";
                            lblKaloriBersih.Text = "Kalori Bersih  : 0 kkal";
                            lblStatus.Text = "Status         : TIDAK ADA DATA";
                            lblStatus.ForeColor = Color.Gray;
                            lblKaloriBersih.ForeColor = Color.Gray;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ringkasan: " + ex.Message);
            }
        }

        private void dtpRiwayat_ValueChanged(object sender, EventArgs e)
        {
            TampilkanRiwayat();
        }
    }
}