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

        // ============================================================
        // BAGIAN E - Pencarian
        // ============================================================
        private void btnCari_Click(object sender, EventArgs e)
        {
            string keyword = txtCari.Text.Trim();
            if (string.IsNullOrEmpty(keyword)) { TampilkanData(); return; }

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
                        WHERE  k.nama_makanan LIKE @keyword
                        ORDER  BY k.tanggal DESC";

                    SqlCommand cmd = new SqlCommand(query, c);
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable     dt     = new DataTable();
                    dt.Load(reader);
                    dgvKonsumsi.DataSource = dt;

                    if (dgvKonsumsi.Columns.Count > 0)
                    {
                        dgvKonsumsi.Columns["id_konsumsi"].Visible = false;
                        dgvKonsumsi.Columns["id_target"].Visible   = false;
                    }

                    lblTotalKonsumsi.Text = "Hasil Pencarian: " + dt.Rows.Count + " record";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error pencarian: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // BAGIAN E - Klik grid -> isi TextBox
        // ============================================================
        private void dgvKonsumsi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvKonsumsi.Rows[e.RowIndex];
            selectedIdKonsumsi = Convert.ToInt32(row.Cells["id_konsumsi"].Value);
            selectedIdTarget   = Convert.ToInt32(row.Cells["id_target"].Value);

            txtNamaMakanan.Text      = row.Cells["nama_makanan"].Value.ToString();
            txtKalori.Text           = row.Cells["kalori"].Value.ToString();
            dtpTanggalKonsumsi.Value = Convert.ToDateTime(row.Cells["tanggal"].Value);
            cmbTarget.SelectedValue  = selectedIdTarget;

            btnUpdate.Enabled = true;
            btnHapus.Enabled  = true;

            TampilkanJumlahData();
        }

        // ============================================================
        // Set Target per Tanggal
        // ============================================================
        private void btnSetTarget_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTargetKalori.Text))
            {
                MessageBox.Show("Masukkan target kalori terlebih dahulu!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTargetKalori.Focus(); return;
            }
            if (!decimal.TryParse(txtTargetKalori.Text, out decimal targetBaru) || targetBaru <= 0)
            {
                MessageBox.Show("Target kalori harus berupa angka lebih dari 0!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTargetKalori.Focus(); return;
            }

            DateTime tglTarget = dtpTanggalTarget.Value.Date;

            try
            {
                using (SqlConnection c = new SqlConnection(connectionString))
                {
                    c.Open();
                    SqlCommand cmdCek = new SqlCommand(
                        "SELECT id_target FROM Target WHERE tanggal = @tgl", c);
                    cmdCek.Parameters.AddWithValue("@tgl", tglTarget);
                    object result = cmdCek.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        if (MessageBox.Show(
                            "Target untuk tanggal " + tglTarget.ToString("dd/MM/yyyy") + " sudah ada.\nYakin ingin mengubahnya?",
                            "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                        SqlCommand cmdUpd = new SqlCommand(
                            "UPDATE Target SET target_kalori = @tk WHERE tanggal = @tgl", c);
                        cmdUpd.Parameters.AddWithValue("@tk",  targetBaru);
                        cmdUpd.Parameters.AddWithValue("@tgl", tglTarget);
                        cmdUpd.ExecuteNonQuery();
                        MessageBox.Show("Target tanggal " + tglTarget.ToString("dd/MM/yyyy") + " diperbarui ke " + targetBaru.ToString("N0") + " kkal!",
                            "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        SqlCommand cmdIns = new SqlCommand(
                            "INSERT INTO Target (target_kalori, tanggal) VALUES (@tk, @tgl)", c);
                        cmdIns.Parameters.AddWithValue("@tk",  targetBaru);
                        cmdIns.Parameters.AddWithValue("@tgl", tglTarget);
                        cmdIns.ExecuteNonQuery();
                        MessageBox.Show("Target tanggal " + tglTarget.ToString("dd/MM/yyyy") + " diset ke " + targetBaru.ToString("N0") + " kkal!",
                            "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                txtTargetKalori.Clear();
                LoadComboTarget();
                TampilkanJumlahData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error set target: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // Saat tanggal konsumsi berubah -> update label + sync ComboBox
        // ============================================================
        private void dtpTanggalKonsumsi_ValueChanged(object sender, EventArgs e)
        {
            TampilkanJumlahData();
            LoadComboTargetByTanggal(dtpTanggalKonsumsi.Value.Date);
        }

        private void LoadComboTargetByTanggal(DateTime tgl)
        {
            try
            {
                using (SqlConnection c = new SqlConnection(connectionString))
                {
                    c.Open();
                    SqlDataAdapter da = new SqlDataAdapter(
                        @"SELECT id_target,
                                 CAST(target_kalori AS VARCHAR) + ' kkal - ' +
                                 CONVERT(VARCHAR, tanggal, 103) AS keterangan
                          FROM Target WHERE tanggal = @tgl", c);
                    da.SelectCommand.Parameters.AddWithValue("@tgl", tgl);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        cmbTarget.DataSource    = dt;
                        cmbTarget.DisplayMember = "keterangan";
                        cmbTarget.ValueMember   = "id_target";
                    }
                    else
                    {
                        LoadComboTarget();
                    }
                }
            }
            catch { LoadComboTarget(); }
        }

        // ============================================================
        // BAGIAN D - INSERT
        // ============================================================
        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput()) return;

            try
            {
                using (SqlConnection c = new SqlConnection(connectionString))
                {
                    c.Open();
                    DateTime tglKonsumsi = dtpTanggalKonsumsi.Value.Date;

                    SqlCommand cmdCek = new SqlCommand(
                        "SELECT id_target FROM Target WHERE tanggal = @tgl", c);
                    cmdCek.Parameters.AddWithValue("@tgl", tglKonsumsi);
                    object result = cmdCek.ExecuteScalar();

                    int idTarget;
                    if (result == null || result == DBNull.Value)
                    {
                        SqlCommand cmdTarget = new SqlCommand(
                            "INSERT INTO Target (target_kalori, tanggal) OUTPUT INSERTED.id_target VALUES (@tk, @tgl)", c);
                        cmdTarget.Parameters.AddWithValue("@tk",  2000);
                        cmdTarget.Parameters.AddWithValue("@tgl", tglKonsumsi);
                        idTarget = (int)cmdTarget.ExecuteScalar();
                    }
                    else idTarget = Convert.ToInt32(result);

                    SqlCommand cmd = new SqlCommand(
                        @"INSERT INTO Konsumsi (id_target, nama_makanan, kalori, tanggal)
                          VALUES (@id_target, @nama, @kalori, @tgl)", c);
                    cmd.Parameters.AddWithValue("@id_target", idTarget);
                    cmd.Parameters.AddWithValue("@nama",      txtNamaMakanan.Text.Trim());
                    cmd.Parameters.AddWithValue("@kalori",    decimal.Parse(txtKalori.Text.Trim()));
                    cmd.Parameters.AddWithValue("@tgl",       tglKonsumsi);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Data berhasil ditambahkan!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BersihkanForm();
                        TampilkanData();
                        LoadComboTarget();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error INSERT: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // BAGIAN D - UPDATE
        // ============================================================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedIdKonsumsi == -1)
            {
                MessageBox.Show("Pilih data yang ingin diubah!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidasiInput()) return;

            if (MessageBox.Show("Yakin ingin mengubah data ini?", "Konfirmasi Update",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            try
            {
                using (SqlConnection c = new SqlConnection(connectionString))
                {
                    c.Open();
                    SqlCommand cmd = new SqlCommand(
                        @"UPDATE Konsumsi
                          SET nama_makanan = @nama, kalori = @kalori, tanggal = @tgl
                          WHERE id_konsumsi = @id", c);
                    cmd.Parameters.AddWithValue("@nama",   txtNamaMakanan.Text.Trim());
                    cmd.Parameters.AddWithValue("@kalori", decimal.Parse(txtKalori.Text.Trim()));
                    cmd.Parameters.AddWithValue("@tgl",    dtpTanggalKonsumsi.Value.Date);
                    cmd.Parameters.AddWithValue("@id",     selectedIdKonsumsi);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Data berhasil diubah!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BersihkanForm();
                        TampilkanData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error UPDATE: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // BAGIAN D - DELETE
        // ============================================================
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedIdKonsumsi == -1)
            {
                MessageBox.Show("Pilih data yang ingin dihapus!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Yakin ingin menghapus data ini?\nTidak dapat dibatalkan!",
                    "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            try
            {
                using (SqlConnection c = new SqlConnection(connectionString))
                {
                    c.Open();
                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Konsumsi WHERE id_konsumsi = @id", c);
                    cmd.Parameters.AddWithValue("@id", selectedIdKonsumsi);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BersihkanForm();
                        TampilkanData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error DELETE: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // Tombol Tampilkan & Bersihkan
        // ============================================================
        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            txtCari.Clear();
            TampilkanData();
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            BersihkanForm();
        }

        private void BersihkanForm()
        {
            txtNamaMakanan.Clear();
            txtKalori.Clear();
            txtCari.Clear();
            dtpTanggalKonsumsi.Value = DateTime.Today;
            selectedIdKonsumsi       = -1;
            selectedIdTarget         = -1;
            btnUpdate.Enabled        = false;
            btnHapus.Enabled         = false;
            if (cmbTarget.Items.Count > 0) cmbTarget.SelectedIndex = 0;
        }
    }
}