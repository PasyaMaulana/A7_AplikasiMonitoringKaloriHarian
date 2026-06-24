using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AMKH
{
    public partial class FormRiwayat : Form
    {
        private DAL dbLogic = new DAL();

        public FormRiwayat()
        {
            InitializeComponent();
        }

        private void FormRiwayat_Load(object sender, EventArgs e)
        {
            dtpRiwayat.Value = DateTime.Today.AddDays(-1);
            dtpRiwayat.MaxDate = DateTime.Today.AddDays(-1);

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

        private void btnTampilkanRiwayat_Click(object sender, EventArgs e)
        {
            TampilkanRiwayat();
        }

        private void TampilkanRiwayat()
        {
            DateTime tgl = dtpRiwayat.Value.Date;

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

        private void MuatRiwayatKonsumsi(DateTime tgl)
        {
            try
            {
                DataTable dt = dbLogic.GetRiwayatKonsumsi(tgl);
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
            catch (Exception ex)
            {
                MessageBox.Show("Error riwayat konsumsi: " + ex.Message);
            }
        }

        private void MuatRiwayatAktivitas(DateTime tgl)
        {
            try
            {
                DataTable dt = dbLogic.GetRiwayatAktivitas(tgl);
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
            catch (Exception ex)
            {
                MessageBox.Show("Error riwayat aktivitas: " + ex.Message);
            }
        }

        private void TampilkanRingkasan(DateTime tgl)
        {
            try
            {
                DataTable dt = dbLogic.GetRingkasanRiwayat(tgl);

                if (dt.Rows.Count > 0)
                {
                    DataRow r = dt.Rows[0];
                    decimal masuk = r.IsNull("total_kalori_masuk") ? 0 : (decimal)r["total_kalori_masuk"];
                    decimal terbakar = r.IsNull("total_kalori_bakar") ? 0 : (decimal)r["total_kalori_bakar"];
                    decimal bersih = r.IsNull("kalori_bersih") ? 0 : (decimal)r["kalori_bersih"];
                    decimal target = r.IsNull("target_kalori") ? 0 : (decimal)r["target_kalori"];
                    string status = r.IsNull("status") ? "-" : r["status"].ToString();

                    lblTotalKonsumsi.Text = "Kalori Masuk   : " + masuk.ToString("N0") + " kkal";
                    lblTotalTerbakar.Text = "Kalori Terbakar: " + terbakar.ToString("N0") + " kkal";
                    lblTargetRiwayat.Text = "Target Kalori  : " +
                        (target > 0 ? target.ToString("N0") + " kkal" : "(belum diset)");
                    lblKaloriBersih.Text = "Kalori Bersih  : " + bersih.ToString("N0") + " kkal";
                    lblStatus.Text = "Status         : " + status;

                    lblStatus.ForeColor = status == "TERCAPAI" ? Color.LimeGreen : Color.Red;
                    lblKaloriBersih.ForeColor = bersih <= target && target > 0
                        ? Color.LimeGreen : Color.FromArgb(255, 200, 60);
                }
                else
                {
                    lblTotalKonsumsi.Text = "Kalori Masuk   : 0 kkal";
                    lblTotalTerbakar.Text = "Kalori Terbakar: 0 kkal";
                    lblTargetRiwayat.Text = "Target Kalori  : (tidak ada data)";
                    lblKaloriBersih.Text = "Kalori Bersih  : 0 kkal";
                    lblStatus.Text = "Status         : TIDAK ADA DATA";
                    lblStatus.ForeColor = Color.Gray;
                    lblKaloriBersih.ForeColor = Color.Gray;
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

        private void panelSubHeader_Paint(object sender, PaintEventArgs e) { }
    }
}