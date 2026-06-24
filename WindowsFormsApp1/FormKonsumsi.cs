using ExcelDataReader;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AMKH
{
    public partial class FormKonsumsi : Form
    {
        private DAL dbLogic = new DAL();
        private int selectedId = -1;
        private DataTable dtImport = null;

        public FormKonsumsi()
        {
            InitializeComponent();
        }

        private void FormKonsumsi_Load(object sender, EventArgs e)
        {
            this.vw_KonsumsiAktifTableAdapter.Fill(this.aMKH_DBDataSet.vw_KonsumsiAktif);

            cmbTipe.Items.Clear();
            cmbTipe.Items.Add("Makanan");
            cmbTipe.Items.Add("Minuman");
            cmbTipe.SelectedIndex = 0;

            dgvKonsumsi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKonsumsi.MultiSelect = false;
            dgvKonsumsi.ReadOnly = true;
            dgvKonsumsi.AllowUserToAddRows = false;

            btnUpdate.Enabled = false;
            btnHapus.Enabled = false;

            AturKolom();
            TampilkanInfoKalori();
            HitungTotal();
        }

        private void MuatData()
        {
            try
            {
                this.vw_KonsumsiAktifTableAdapter.Fill(this.aMKH_DBDataSet.vw_KonsumsiAktif);
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
            if (dgvKonsumsi.Columns.Count == 0) return;
            if (dgvKonsumsi.Columns.Contains("idkonsumsiDataGridViewTextBoxColumn"))
                dgvKonsumsi.Columns["idkonsumsiDataGridViewTextBoxColumn"].Visible = false;
            if (dgvKonsumsi.Columns.Contains("idtargetDataGridViewTextBoxColumn"))
                dgvKonsumsi.Columns["idtargetDataGridViewTextBoxColumn"].Visible = false;
            if (dgvKonsumsi.Columns.Contains("targetkaloriDataGridViewTextBoxColumn"))
                dgvKonsumsi.Columns["targetkaloriDataGridViewTextBoxColumn"].HeaderText = "Target Kalori";
            if (dgvKonsumsi.Columns.Contains("namaitemDataGridViewTextBoxColumn"))
                dgvKonsumsi.Columns["namaitemDataGridViewTextBoxColumn"].HeaderText = "Nama Item";
            if (dgvKonsumsi.Columns.Contains("kaloriDataGridViewTextBoxColumn"))
                dgvKonsumsi.Columns["kaloriDataGridViewTextBoxColumn"].HeaderText = "Kalori (kkal)";
            if (dgvKonsumsi.Columns.Contains("tipeDataGridViewTextBoxColumn"))
                dgvKonsumsi.Columns["tipeDataGridViewTextBoxColumn"].HeaderText = "Tipe";
            if (dgvKonsumsi.Columns.Contains("tanggalDataGridViewTextBoxColumn"))
                dgvKonsumsi.Columns["tanggalDataGridViewTextBoxColumn"].HeaderText = "Tanggal";
        }

        private void HitungTotal()
        {
            try
            {
                lblTotalRecord.Text = "Total: " + dbLogic.CountKonsumsi() + " record aktif";
            }
            catch { }
        }

        private void TampilkanInfoKalori()
        {
            try
            {
                DateTime tgl = dtpTanggal.Value.Date;
                decimal totalKal = dbLogic.GetTotalKaloriHariIni(tgl);
                decimal target = dbLogic.GetTargetKalori(tgl);

                if (target > 0)
                {
                    decimal sisa = target - totalKal;
                    string status = sisa >= 0
                        ? "Sisa: " + sisa.ToString("N0") + " kkal"
                        : "MELEBIHI " + Math.Abs(sisa).ToString("N0") + " kkal!";
                    lblInfoKalori.Text = tgl.ToString("dd/MM/yyyy") + " — " +
                        totalKal.ToString("N0") + " / " + target.ToString("N0") + " kkal | " + status;
                    lblInfoKalori.ForeColor = sisa >= 0 ? Color.LimeGreen : Color.Red;
                }
                else
                {
                    lblInfoKalori.Text = tgl.ToString("dd/MM/yyyy") + " — " +
                        totalKal.ToString("N0") + " kkal | (belum ada target)";
                    lblInfoKalori.ForeColor = Color.FromArgb(255, 200, 60);
                }
            }
            catch { }
        }

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
                dbLogic.SetTarget(dtpTanggalTarget.Value.Date, target, out bool isUpdate);
                MessageBox.Show("Target berhasil " + (isUpdate ? "diperbarui" : "disimpan") + "!",
                    "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTargetKalori.Clear();
                TampilkanInfoKalori();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error set target: " + ex.Message);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput()) return;
            try
            {
                dbLogic.TambahKonsumsi(
                    txtNamaItem.Text.Trim(),
                    decimal.Parse(txtKalori.Text.Trim()),
                    cmbTipe.SelectedItem.ToString(),
                    dtpTanggal.Value.Date);

                MessageBox.Show("Data berhasil ditambahkan!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                BersihkanForm();
                MuatData();
                TampilkanInfoKalori();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error tambah: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;
            if (!ValidasiInput()) return;
            if (MessageBox.Show("Yakin ingin mengubah?", "Konfirmasi",
                MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            try
            {
                string pesan = dbLogic.UpdateKonsumsi(
                    selectedId,
                    txtNamaItem.Text.Trim(),
                    decimal.Parse(txtKalori.Text.Trim()),
                    cmbTipe.SelectedItem.ToString(),
                    dtpTanggal.Value.Date);

                if (pesan != "OK")
                    MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Data berhasil diubah!", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                BersihkanForm();
                MuatData();
                TampilkanInfoKalori();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error update: " + ex.Message);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;
            if (MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            try
            {
                bool tHapus = dbLogic.HapusKonsumsi(selectedId);
                MessageBox.Show("Data dihapus!" +
                    (tHapus ? "\n(Target hari itu ikut dihapus.)" : ""),
                    "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BersihkanForm();
                MuatData();
                TampilkanInfoKalori();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error hapus: " + ex.Message);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCari.Text)) { MuatData(); return; }
            try
            {
                this.vwKonsumsiAktifBindingSource1.Filter =
                    "nama_item LIKE '%" + txtCari.Text.Trim() + "%'";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cari: " + ex.Message);
            }
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            txtCari.Clear();
            this.vwKonsumsiAktifBindingSource1.Filter = "";
            MuatData();
        }

        private void dgvKonsumsi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvKonsumsi.Rows[e.RowIndex];
            selectedId = Convert.ToInt32(row.Cells["idkonsumsiDataGridViewTextBoxColumn"].Value);
            txtNamaItem.Text = row.Cells["namaitemDataGridViewTextBoxColumn"].Value.ToString();
            txtKalori.Text = row.Cells["kaloriDataGridViewTextBoxColumn"].Value.ToString();
            cmbTipe.SelectedItem = row.Cells["tipeDataGridViewTextBoxColumn"].Value.ToString();
            dtpTanggal.Value = Convert.ToDateTime(row.Cells["tanggalDataGridViewTextBoxColumn"].Value);
            btnUpdate.Enabled = true;
            btnHapus.Enabled = true;
            TampilkanInfoKalori();
        }

        private void dtpTanggal_ValueChanged(object sender, EventArgs e)
        {
            TampilkanInfoKalori();
        }

        private void btnBersihkan_Click(object sender, EventArgs e) => BersihkanForm();

        private void BersihkanForm()
        {
            txtNamaItem.Clear();
            txtKalori.Clear();
            txtCari.Clear();
            cmbTipe.SelectedIndex = 0;
            dtpTanggal.Value = DateTime.Today;
            selectedId = -1;
            btnUpdate.Enabled = false;
            btnHapus.Enabled = false;
            this.vwKonsumsiAktifBindingSource1.Filter = "";
        }

        private bool ValidasiInput()
        {
            if (string.IsNullOrWhiteSpace(txtNamaItem.Text) ||
                txtNamaItem.Text.Trim().Length < 3)
            {
                MessageBox.Show("Nama item minimal 3 karakter!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamaItem.Focus(); return false;
            }
            if (!decimal.TryParse(txtKalori.Text, out decimal kal) || kal < 0 || kal > 5000)
            {
                MessageBox.Show("Kalori harus angka antara 0-5000!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKalori.Focus(); return false;
            }
            if (cmbTipe.SelectedIndex < 0)
            {
                MessageBox.Show("Pilih tipe Makanan atau Minuman!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // ── SIMULASI SQL INJECTION ────────────────────────

        private void btnBackupData_Click(object sender, EventArgs e)
        {
            try
            {
                using (var c = new SqlConnection(dbLogic.GetConnectionString()))
                {
                    c.Open();
                    var cmdCek = new SqlCommand(
                        "SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES " +
                        "WHERE TABLE_NAME = 'Konsumsi_Backup'", c);
                    int exists = (int)cmdCek.ExecuteScalar();

                    if (exists > 0)
                        new SqlCommand("DROP TABLE Konsumsi_Backup", c).ExecuteNonQuery();

                    new SqlCommand(
                        "SELECT * INTO Konsumsi_Backup FROM Konsumsi", c).ExecuteNonQuery();

                    MessageBox.Show("Backup berhasil dibuat!\nTabel Konsumsi_Backup sudah siap.",
                        "Backup OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error backup: " + ex.Message);
            }
        }

        private void btnTestInjection_Click(object sender, EventArgs e)
        {
            string inputDariUser = txtNamaItem.Text;
            string queryBerbahaya =
                "UPDATE Konsumsi SET nama_item = 'HACKED' " +
                "WHERE nama_item = '" + inputDariUser + "'";

            try
            {
                using (var c = new SqlConnection(dbLogic.GetConnectionString()))
                {
                    c.Open();
                    var cmd = new SqlCommand(queryBerbahaya, c);
                    int baris = cmd.ExecuteNonQuery();
                    MessageBox.Show(
                        "Query dijalankan!\nBaris terupdate: " + baris + "\n\n" +
                        "Query yang dieksekusi:\n" + queryBerbahaya,
                        "Hasil SQL Injection Demo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MuatData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnResetData_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Reset akan mengembalikan semua data ke kondisi awal backup.\nLanjutkan?",
                "Konfirmasi Reset",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                using (var c = new SqlConnection(dbLogic.GetConnectionString()))
                {
                    c.Open();
                    string query = @"
                        IF OBJECT_ID('dbo.Konsumsi_Backup') IS NOT NULL
                        BEGIN
                            DELETE FROM dbo.Konsumsi;
                            SET IDENTITY_INSERT dbo.Konsumsi ON;
                            INSERT INTO dbo.Konsumsi (id_konsumsi, id_target, nama_item, kalori, tipe, tanggal)
                            SELECT id_konsumsi, id_target, nama_item, kalori, tipe, tanggal
                            FROM dbo.Konsumsi_Backup;
                            SET IDENTITY_INSERT dbo.Konsumsi OFF;
                        END";
                    new SqlCommand(query, c).ExecuteNonQuery();
                    MessageBox.Show("Data berhasil direset dari backup!",
                        "Reset OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MuatData();
                    TampilkanInfoKalori();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reset: " + ex.Message);
            }
        }

        private void btnQueryAman_Click(object sender, EventArgs e)
        {
            string inputDariUser = txtNamaItem.Text;
            string queryAman = "UPDATE Konsumsi SET nama_item = 'AMAN' WHERE nama_item = @nama";

            try
            {
                using (var c = new SqlConnection(dbLogic.GetConnectionString()))
                {
                    c.Open();
                    var cmd = new SqlCommand(queryAman, c);
                    cmd.Parameters.AddWithValue("@nama", inputDariUser);
                    int baris = cmd.ExecuteNonQuery();
                    MessageBox.Show(
                        "Query AMAN dijalankan!\nBaris terupdate: " + baris + "\n\n" +
                        "Input '" + inputDariUser + "' diperlakukan sebagai literal string,\n" +
                        "bukan sebagai perintah SQL.",
                        "Parameterized Query — AMAN",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MuatData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Excel Files|*.xlsx;*.xls";
                ofd.Title = "Pilih File Excel Konsumsi";

                if (ofd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    using (var stream = System.IO.File.Open(
                        ofd.FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    using (var reader = ExcelDataReader.ExcelReaderFactory.CreateReader(stream))
                    {
                        var result = reader.AsDataSet(new ExcelDataReader.ExcelDataSetConfiguration()
                        {
                            ConfigureDataTable = _ => new ExcelDataReader.ExcelDataTableConfiguration()
                            {
                                UseHeaderRow = true
                            }
                        });

                        dtImport = result.Tables[0];
                        dgvKonsumsi.DataSource = dtImport;

                        btnImportDB.Enabled = true;
                        MessageBox.Show(
                            dtImport.Rows.Count + " baris data berhasil dibaca!\nCek preview di tabel, lalu klik Import ke Database.",
                            "Preview Excel",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error baca Excel: " + ex.Message);
                }
            }
        }

        private void btnImportDB_Click(object sender, EventArgs e)
        {
            if (dtImport == null || dtImport.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada data untuk diimport!");
                return;
            }

            int sukses = 0, gagal = 0, duplikat = 0;

            foreach (DataRow row in dtImport.Rows)
            {
                try
                {
                    string namaItem = row["nama_item"].ToString().Trim();
                    string tipe = row["tipe"].ToString().Trim();
                    string kaloriStr = row["kalori"].ToString().Trim();
                    string tglStr = row["tanggal"].ToString().Trim();

                    if (string.IsNullOrEmpty(namaItem)) { gagal++; continue; }
                    if (!decimal.TryParse(kaloriStr, out decimal kalori)) { gagal++; continue; }
                    if (!DateTime.TryParse(tglStr, out DateTime tanggal)) { gagal++; continue; }

                    string status = dbLogic.ImportKonsumsi(namaItem, kalori, tipe, tanggal.Date);
                    if (status == "INSERTED") sukses++;
                    else duplikat++;
                }
                catch { gagal++; }
            }

            MessageBox.Show(
                $"Import selesai!\n" +
                $"Berhasil  : {sukses} baris\n" +
                $"Duplikat  : {duplikat} baris (diskip)\n" +
                $"Gagal     : {gagal} baris",
                "Hasil Import",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            dtImport = null;
            btnImportDB.Enabled = false;
            MuatData();
            TampilkanInfoKalori();
        }
    }
}