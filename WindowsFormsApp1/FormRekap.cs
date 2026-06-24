using System;
using System.Data;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace AMKH
{
    public partial class FormRekap : Form
    {
        private DAL dbLogic = new DAL();
        private DataTable dtKonsumsi = null;
        private DataTable dtAktivitas = null;

        public FormRekap()
        {
            InitializeComponent();
        }

        private void FormRekap_Load(object sender, EventArgs e)
        {
            // default tanggal kemarin karena data aktif >= hari ini tidak bisa dicetak
            dtpTanggal.Value = DateTime.Today.AddDays(-1);
            dtpTanggal.MaxDate = DateTime.Today.AddDays(-1);

            dgvKonsumsi.ReadOnly = true;
            dgvKonsumsi.AllowUserToAddRows = false;
            dgvKonsumsi.MultiSelect = false;

            dgvAktivitas.ReadOnly = true;
            dgvAktivitas.AllowUserToAddRows = false;
            dgvAktivitas.MultiSelect = false;

            btnCetak.Enabled = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string tglStr = dtpTanggal.Value.ToString("dd/MM/yyyy");
            DateTime tgl = dtpTanggal.Value.Date;

            try
            {
                // load konsumsi
                dtKonsumsi = dbLogic.GetDataReport(tgl);

                // load aktivitas
                dtAktivitas = dbLogic.GetDataReportAktivitas(tgl);

                // load ringkasan
                DataTable dtRingkasan = dbLogic.GetDataReportRingkasan(tgl);

                // cek apakah ada data sama sekali
                if (dtKonsumsi.Rows.Count == 0 && dtAktivitas.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Tidak ada data untuk tanggal " + tglStr,
                        "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetTampilan();
                    return;
                }

                // tampilkan data konsumsi di DGV
                dgvKonsumsi.DataSource = dtKonsumsi;
                AturKolomKonsumsi();

                // tampilkan data aktivitas di DGV
                dgvAktivitas.DataSource = dtAktivitas;
                AturKolomAktivitas();

                // tampilkan ringkasan di panel
                if (dtRingkasan.Rows.Count > 0)
                {
                    DataRow r = dtRingkasan.Rows[0];
                    decimal target = r.IsNull("TargetKalori") ? 0 : Convert.ToDecimal(r["TargetKalori"]);
                    decimal masuk = r.IsNull("TotalMasuk") ? 0 : Convert.ToDecimal(r["TotalMasuk"]);
                    decimal terbakar = r.IsNull("TotalTerbakar") ? 0 : Convert.ToDecimal(r["TotalTerbakar"]);
                    decimal bersih = r.IsNull("KaloriBersih") ? 0 : Convert.ToDecimal(r["KaloriBersih"]);
                    string status = r.IsNull("Status") ? "-" : r["Status"].ToString();

                    lblTarget.Text = "Target    : " + target.ToString("N0") + " kkal";
                    lblTotalMasuk.Text = "Masuk     : " + masuk.ToString("N0") + " kkal";
                    lblTotalTerbakar.Text = "Terbakar  : " + terbakar.ToString("N0") + " kkal";
                    lblKaloriBersih.Text = "Bersih    : " + bersih.ToString("N0") + " kkal";
                    lblStatus.Text = "Status : " + status;

                    // warna status
                    if (status == "TERCAPAI")
                    {
                        lblStatus.ForeColor = System.Drawing.Color.LimeGreen;
                        lblKaloriBersih.ForeColor = System.Drawing.Color.LimeGreen;
                    }
                    else
                    {
                        lblStatus.ForeColor = System.Drawing.Color.FromArgb(220, 80, 80);
                        lblKaloriBersih.ForeColor = System.Drawing.Color.FromArgb(220, 80, 80);
                    }
                }

                lblJmlData.Text = tglStr + "  |  Konsumsi: " + dtKonsumsi.Rows.Count +
                                  " item  |  Aktivitas: " + dtAktivitas.Rows.Count +
                                  " item  →  Klik Cetak Laporan";
                btnCetak.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load data: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AturKolomKonsumsi()
        {
            if (dgvKonsumsi.Columns.Contains("TargetKalori"))
                dgvKonsumsi.Columns["TargetKalori"].Visible = false;
            if (dgvKonsumsi.Columns.Contains("NamaItem"))
                dgvKonsumsi.Columns["NamaItem"].HeaderText = "Nama Item";
            if (dgvKonsumsi.Columns.Contains("Kalori"))
                dgvKonsumsi.Columns["Kalori"].HeaderText = "Kalori (kkal)";
            if (dgvKonsumsi.Columns.Contains("Tipe"))
                dgvKonsumsi.Columns["Tipe"].HeaderText = "Tipe";
            if (dgvKonsumsi.Columns.Contains("TanggalKonsumsi"))
                dgvKonsumsi.Columns["TanggalKonsumsi"].HeaderText = "Tanggal";
        }

        private void AturKolomAktivitas()
        {
            if (dgvAktivitas.Columns.Contains("NamaAktivitas"))
                dgvAktivitas.Columns["NamaAktivitas"].HeaderText = "Nama Aktivitas";
            if (dgvAktivitas.Columns.Contains("KaloriTerbakar"))
                dgvAktivitas.Columns["KaloriTerbakar"].HeaderText = "Kalori Terbakar (kkal)";
            if (dgvAktivitas.Columns.Contains("TanggalAktivitas"))
                dgvAktivitas.Columns["TanggalAktivitas"].HeaderText = "Tanggal";
        }

        private void ResetTampilan()
        {
            dgvKonsumsi.DataSource = null;
            dgvAktivitas.DataSource = null;
            lblTarget.Text = "Target    : -";
            lblTotalMasuk.Text = "Masuk     : -";
            lblTotalTerbakar.Text = "Terbakar  : -";
            lblKaloriBersih.Text = "Bersih    : -";
            lblStatus.Text = "Status : -";
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            lblKaloriBersih.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            lblJmlData.Text = "Tidak ada data untuk tanggal yang dipilih.";
            btnCetak.Enabled = false;
            dtKonsumsi = null;
            dtAktivitas = null;
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            if ((dtKonsumsi == null || dtKonsumsi.Rows.Count == 0) &&
                (dtAktivitas == null || dtAktivitas.Rows.Count == 0))
            {
                MessageBox.Show("Load data dulu sebelum cetak!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                FormReport frmReport = new FormReport(
                    dtpTanggal.Value.Date, dtKonsumsi, dtAktivitas);
                frmReport.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error buka report: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelSubHeader_Paint(object sender, System.Windows.Forms.PaintEventArgs e) { }
    }
}