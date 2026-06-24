using ExcelDataReader;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AMKH
{
    public partial class FormAktivitas : Form
    {
        private DAL dbLogic = new DAL();
        private int selectedId = -1;
        private DataTable dtImport = null;

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
            btnImportDB.Enabled = false;

            AturKolom();
            TampilkanInfoAktivitas();
            HitungTotal();
        }

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

        private void HitungTotal()
        {
            try
            {
                lblTotalRecord.Text = "Total: " + dbLogic.CountAktivitas() + " record aktif";
            }
            catch { }
        }

        private void TampilkanInfoAktivitas()
        {
            try
            {
                DateTime tgl = dtpTanggal.Value.Date;
                decimal totalTerbakar = dbLogic.GetTotalKaloriTerbakar(tgl);
                decimal target = dbLogic.GetTargetKalori(tgl);
                decimal totalMasuk = dbLogic.GetTotalKaloriHariIni(tgl);
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
                MessageBox.Show(
                    "Target berhasil " + (isUpdate ? "diperbarui" : "disimpan") + "!",
                    "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTargetKalori.Clear();
                TampilkanInfoAktivitas();
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
                dbLogic.TambahAktivitas(
                    txtNamaAktivitas.Text.Trim(),
                    decimal.Parse(txtKaloriTerbakar.Text.Trim()),
                    dtpTanggal.Value.Date);

                MessageBox.Show("Aktivitas berhasil ditambahkan!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                BersihkanForm();
                MuatData();
                TampilkanInfoAktivitas();
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
                dbLogic.UpdateAktivitas(
                    selectedId,
                    txtNamaAktivitas.Text.Trim(),
                    decimal.Parse(txtKaloriTerbakar.Text.Trim()),
                    dtpTanggal.Value.Date);

                MessageBox.Show("Aktivitas berhasil diubah!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                BersihkanForm();
                MuatData();
                TampilkanInfoAktivitas();
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
                dbLogic.HapusAktivitas(selectedId);
                MessageBox.Show("Aktivitas berhasil dihapus!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                BersihkanForm();
                MuatData();
                TampilkanInfoAktivitas();
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

        // ── IMPORT EXCEL ──────────────────────────────────

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Excel Files|*.xlsx;*.xls";
                ofd.Title = "Pilih File Excel Aktivitas";

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
                        dgvAktivitas.DataSource = dtImport;

                        btnImportDB.Enabled = true;
                        MessageBox.Show(
                            dtImport.Rows.Count + " baris data berhasil dibaca!\n" +
                            "Cek preview di tabel, lalu klik Import ke Database.",
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
                    string namaAktivitas = row["nama_aktivitas"].ToString().Trim();
                    string kaloriStr = row["kalori_terbakar"].ToString().Trim();
                    string tglStr = row["tanggal"].ToString().Trim();

                    if (string.IsNullOrEmpty(namaAktivitas)) { gagal++; continue; }
                    if (!decimal.TryParse(kaloriStr, out decimal kalori)) { gagal++; continue; }
                    if (!DateTime.TryParse(tglStr, out DateTime tanggal)) { gagal++; continue; }

                    string status = dbLogic.ImportAktivitas(namaAktivitas, kalori, tanggal.Date);
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
            TampilkanInfoAktivitas();
        }

        private void panelSubHeader_Paint(object sender, PaintEventArgs e) { }
    }
}