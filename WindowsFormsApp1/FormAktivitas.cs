using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AMKH_TESTING
{
    public partial class FormAktivitas : Form
    {
        private string connectionString =
            "Server=PASYA\\PASYA;Database=AMKH_DB;Integrated Security=True;";
        private int selectedId = -1;

        public FormAktivitas()
        {
            InitializeComponent();
        }

        private void FormAktivitas_Load(object sender, EventArgs e)
        {
            this.vw_AktivitasAktifTableAdapter.Fill(this.aMKH_DBDataSet.vw_AktivitasAktif);

            dgvAktivitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAktivitas.MultiSelect = false;
            dgvAktivitas.ReadOnly = true;
            dgvAktivitas.AllowUserToAddRows = false;

            btnUpdate.Enabled = false;
            btnHapus.Enabled = false;

            AturKolom();
            TampilkanInfoAktivitas();
            HitungTotal();
        }

        // ── Load data via VIEW vw_AktivitasAktif ─────────
        private void MuatData()
        {
            try
            {
                this.vw_AktivitasAktifTableAdapter.Fill(this.aMKH_DBDataSet.vw_AktivitasAktif);
                AturKolom();
                HitungTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load data: " + ex.Message);
            }
        }

        private void AturKolom()
        {
            if (dgvAktivitas.Columns.Count == 0) return;
            if (dgvAktivitas.Columns.Contains("dataGridViewTextBoxColumn1"))
                dgvAktivitas.Columns["dataGridViewTextBoxColumn1"].Visible = false;
            if (dgvAktivitas.Columns.Contains("dataGridViewTextBoxColumn2"))
                dgvAktivitas.Columns["dataGridViewTextBoxColumn2"].Visible = false;
            if (dgvAktivitas.Columns.Contains("dataGridViewTextBoxColumn3"))
                dgvAktivitas.Columns["dataGridViewTextBoxColumn3"].HeaderText = "Target Kalori";
            if (dgvAktivitas.Columns.Contains("dataGridViewTextBoxColumn4"))
                dgvAktivitas.Columns["dataGridViewTextBoxColumn4"].HeaderText = "Nama Aktivitas";
            if (dgvAktivitas.Columns.Contains("dataGridViewTextBoxColumn5"))
                dgvAktivitas.Columns["dataGridViewTextBoxColumn5"].HeaderText = "Kalori Terbakar";
            if (dgvAktivitas.Columns.Contains("dataGridViewTextBoxColumn6"))
                dgvAktivitas.Columns["dataGridViewTextBoxColumn6"].HeaderText = "Tanggal";
        }

        // ── Hitung total via OUTPUT PARAMETER ────────────
        private void HitungTotal()
        {
            try
            {
                using (var c = new SqlConnection(connectionString))
                {
                    c.Open();
                    var cmd = new SqlCommand("sp_CountAktivitas", c)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    var pTotal = cmd.Parameters.Add("@total", SqlDbType.Int);
                    pTotal.Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    lblTotalRecord.Text = "Total: " + pTotal.Value + " record aktif";
                }
            }
            catch { }
        }

        // ── Info kalori terbakar hari ini ─────────────────
        private void TampilkanInfoAktivitas()
        {
            try
            {
                using (var c = new SqlConnection(connectionString))
                {
                    c.Open();
                    DateTime tgl = dtpTanggal.Value.Date;

                    var cmd = new SqlCommand(
                        "SELECT ISNULL(SUM(kalori_terbakar),0) FROM Aktivitas WHERE tanggal=@tgl", c);
                    cmd.Parameters.AddWithValue("@tgl", tgl);
                    decimal totalTerbakar = (decimal)cmd.ExecuteScalar();

                    var cmdTgt = new SqlCommand(
                        "SELECT ISNULL(target_kalori,0) FROM Target WHERE tanggal=@tgl", c);
                    cmdTgt.Parameters.AddWithValue("@tgl", tgl);
                    object tRes = cmdTgt.ExecuteScalar();
                    decimal target = (tRes != null && tRes != DBNull.Value) ? (decimal)tRes : 0;

                    var cmdKon = new SqlCommand(
                        "SELECT ISNULL(SUM(kalori),0) FROM Konsumsi WHERE tanggal=@tgl", c);
                    cmdKon.Parameters.AddWithValue("@tgl", tgl);
                    decimal totalMasuk = (decimal)cmdKon.ExecuteScalar();

                    decimal bersih = totalMasuk - totalTerbakar;

                    lblInfoAktivitas.Text =
                        tgl.ToString("dd/MM/yyyy") +
                        " — Masuk: " + totalMasuk.ToString("N0") + " kkal" +
                        " | Terbakar: " + totalTerbakar.ToString("N0") + " kkal" +
                        " | Bersih: " + bersih.ToString("N0") + " kkal";

                    if (target > 0)
                        lblInfoAktivitas.ForeColor = bersih <= target ? Color.LimeGreen : Color.Red;
                    else
                        lblInfoAktivitas.ForeColor = Color.FromArgb(255, 200, 60);
                }
            }
            catch { }
        }

        // ── Set Target via SP ─────────────────────────────
        private void btnSetTarget_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtTargetKalori.Text, out decimal target) || target <= 0)
            {
                MessageBox.Show("Target kalori harus angka lebih dari 0!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (var c = new SqlConnection(connectionString))
                {
                    c.Open();
                    var cmd = new SqlCommand("sp_SetTarget", c)
                    { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.AddWithValue("@tanggal", dtpTanggalTarget.Value.Date);
                    cmd.Parameters.AddWithValue("@target_kalori", target);
                    var pIsUpdate = cmd.Parameters.Add("@is_update", SqlDbType.Bit);
                    pIsUpdate.Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();

                    bool isUpdate = (bool)pIsUpdate.Value;
                    MessageBox.Show(
                        "Target berhasil " + (isUpdate ? "diperbarui" : "disimpan") + "!",
                        "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTargetKalori.Clear();
                    TampilkanInfoAktivitas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error set target: " + ex.Message);
            }
        }

        // ── Tambah via SP sp_TambahAktivitas ─────────────
        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput()) return;
            try
            {
                using (var c = new SqlConnection(connectionString))
                {
                    c.Open();
                    var cmd = new SqlCommand("sp_TambahAktivitas", c)
                    { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.AddWithValue("@nama_aktivitas", txtNamaAktivitas.Text.Trim());
                    cmd.Parameters.AddWithValue("@kalori_terbakar", decimal.Parse(txtKaloriTerbakar.Text.Trim()));
                    cmd.Parameters.AddWithValue("@tanggal", dtpTanggal.Value.Date);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Aktivitas berhasil ditambahkan!", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BersihkanForm();
                    MuatData();
                    TampilkanInfoAktivitas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error tambah: " + ex.Message);
            }
        }

        // ── Update via SP sp_UpdateAktivitas ─────────────
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;
            if (!ValidasiInput()) return;
            if (MessageBox.Show("Yakin ingin mengubah?", "Konfirmasi",
                MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            try
            {
                using (var c = new SqlConnection(connectionString))
                {
                    c.Open();
                    var cmd = new SqlCommand("sp_UpdateAktivitas", c)
                    { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.AddWithValue("@id_aktivitas", selectedId);
                    cmd.Parameters.AddWithValue("@nama_aktivitas", txtNamaAktivitas.Text.Trim());
                    cmd.Parameters.AddWithValue("@kalori_terbakar", decimal.Parse(txtKaloriTerbakar.Text.Trim()));
                    cmd.Parameters.AddWithValue("@tanggal", dtpTanggal.Value.Date);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Aktivitas berhasil diubah!", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BersihkanForm();
                    MuatData();
                    TampilkanInfoAktivitas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error update: " + ex.Message);
            }
        }

        // ── Hapus via SP sp_HapusAktivitas ───────────────
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;
            if (MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            try
            {
                using (var c = new SqlConnection(connectionString))
                {
                    c.Open();
                    var cmd = new SqlCommand("sp_HapusAktivitas", c)
                    { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.AddWithValue("@id_aktivitas", selectedId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Aktivitas berhasil dihapus!", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BersihkanForm();
                    MuatData();
                    TampilkanInfoAktivitas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error hapus: " + ex.Message);
            }
        }

        // ── Cari via BindingSource Filter ────────────────
        private void btnCari_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCari.Text)) { MuatData(); return; }
            try
            {
                this.vwAktivitasAktifBindingSource.Filter =
                    "nama_aktivitas LIKE '%" + txtCari.Text.Trim() + "%'";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cari: " + ex.Message);
            }
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            txtCari.Clear();
            this.vwAktivitasAktifBindingSource.Filter = "";
            MuatData();
        }

        // ── Klik baris grid ──────────────────────────────
        private void dgvAktivitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvAktivitas.Rows[e.RowIndex];

            selectedId = Convert.ToInt32(row.Cells["dataGridViewTextBoxColumn1"].Value);
            txtNamaAktivitas.Text = row.Cells["dataGridViewTextBoxColumn4"].Value.ToString();
            txtKaloriTerbakar.Text = row.Cells["dataGridViewTextBoxColumn5"].Value.ToString();
            dtpTanggal.Value = Convert.ToDateTime(row.Cells["dataGridViewTextBoxColumn6"].Value);

            btnUpdate.Enabled = true;
            btnHapus.Enabled = true;
            TampilkanInfoAktivitas();
        }

        private void dtpTanggal_ValueChanged(object sender, EventArgs e)
        {
            TampilkanInfoAktivitas();
        }

        private void btnBersihkan_Click(object sender, EventArgs e) => BersihkanForm();

        private void BersihkanForm()
        {
            txtNamaAktivitas.Clear();
            txtKaloriTerbakar.Clear();
            txtCari.Clear();
            dtpTanggal.Value = DateTime.Today;
            selectedId = -1;
            btnUpdate.Enabled = false;
            btnHapus.Enabled = false;
            this.vwAktivitasAktifBindingSource.Filter = "";
        }

        private bool ValidasiInput()
        {
            string nama = txtNamaAktivitas.Text.Trim();
            if (string.IsNullOrWhiteSpace(nama) || nama.Length < 3)
            {
                MessageBox.Show("Nama aktivitas minimal 3 karakter!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamaAktivitas.Focus();
                return false;
            }
            if (!decimal.TryParse(txtKaloriTerbakar.Text, out decimal kal) || kal < 0 || kal > 5000)
            {
                MessageBox.Show("Kalori terbakar harus angka antara 0-5000!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKaloriTerbakar.Focus();
                return false;
            }
            return true;
        }

        private void panelSubHeader_Paint(object sender, PaintEventArgs e) { }
    }
}