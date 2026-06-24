using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AMKH
{
    public partial class FormDashboard : Form
    {
        private DAL dbLogic = new DAL();

        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            MuatDashboard();
        }

        private void MuatDashboard()
        {
            try
            {
                DateTime tgl = DateTime.Today;

                // ── Info kalori hari ini ──
                decimal masuk = dbLogic.GetTotalKaloriHariIni(tgl);
                decimal terbakar = dbLogic.GetTotalKaloriTerbakar(tgl);
                decimal target = dbLogic.GetTargetKalori(tgl);
                decimal bersih = masuk - terbakar;

                lblTanggal.Text = "📅 " + tgl.ToString("dddd, dd MMMM yyyy");
                lblMasuk.Text = "Kalori Masuk    : " + masuk.ToString("N0") + " kkal";
                lblTerbakar.Text = "Kalori Terbakar : " + terbakar.ToString("N0") + " kkal";
                lblBersih.Text = "Kalori Bersih   : " + bersih.ToString("N0") + " kkal";

                if (target > 0)
                {
                    lblTarget.Text = "Target Hari Ini : " + target.ToString("N0") + " kkal";
                    string status = bersih <= target ? "✓ TERCAPAI" : "✗ MELEBIHI TARGET";
                    lblStatus.Text = "Status : " + status;
                    lblStatus.ForeColor = bersih <= target ? Color.LimeGreen : Color.FromArgb(220, 80, 80);
                }
                else
                {
                    lblTarget.Text = "Target Hari Ini : (belum diset)";
                    lblStatus.Text = "Status : -";
                    lblStatus.ForeColor = Color.FromArgb(212, 175, 55);
                }

                // ── Chart 7 hari terakhir ──
                MuatChart();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load dashboard: " + ex.Message);
            }
        }

        private void MuatChart()
        {
            try
            {
                DataTable dt = dbLogic.GetChartKaloriMingguan();

                chartKalori.Series.Clear();
                chartKalori.ChartAreas.Clear();
                chartKalori.Titles.Clear();
                chartKalori.Legends.Clear();

                ChartArea ca = new ChartArea("MainArea");
                ca.BackColor = Color.FromArgb(38, 36, 28);
                ca.AxisX.LabelStyle.ForeColor = Color.FromArgb(200, 185, 120);
                ca.AxisY.LabelStyle.ForeColor = Color.FromArgb(200, 185, 120);
                ca.AxisX.LineColor = Color.FromArgb(100, 90, 50);
                ca.AxisY.LineColor = Color.FromArgb(100, 90, 50);
                ca.AxisX.MajorGrid.LineColor = Color.FromArgb(60, 55, 30);
                ca.AxisY.MajorGrid.LineColor = Color.FromArgb(60, 55, 30);
                ca.AxisX.Title = "Tanggal";
                ca.AxisY.Title = "Kalori (kkal)";
                ca.AxisX.TitleForeColor = Color.FromArgb(212, 175, 55);
                ca.AxisY.TitleForeColor = Color.FromArgb(212, 175, 55);
                ca.AxisX.LabelStyle.Angle = -45;
                chartKalori.ChartAreas.Add(ca);

                // Series Kalori Masuk
                Series sMasuk = new Series("Kalori Masuk");
                sMasuk.ChartType = SeriesChartType.Column;
                sMasuk.Color = Color.FromArgb(212, 175, 55);
                sMasuk.IsValueShownAsLabel = true;
                sMasuk.LabelForeColor = Color.White;
                sMasuk.Font = new Font("Segoe UI", 7f);

                // Series Kalori Terbakar
                Series sTerbakar = new Series("Kalori Terbakar");
                sTerbakar.ChartType = SeriesChartType.Column;
                sTerbakar.Color = Color.FromArgb(80, 160, 80);
                sTerbakar.IsValueShownAsLabel = true;
                sTerbakar.LabelForeColor = Color.White;
                sTerbakar.Font = new Font("Segoe UI", 7f);

                // Series Target
                Series sTarget = new Series("Target");
                sTarget.ChartType = SeriesChartType.Line;
                sTarget.Color = Color.FromArgb(220, 80, 80);
                sTarget.BorderWidth = 2;
                sTarget.BorderDashStyle = ChartDashStyle.Dash;

                foreach (DataRow row in dt.Rows)
                {
                    string tgl = Convert.ToDateTime(row["tanggal"]).ToString("dd/MM");
                    decimal masuk = row.IsNull("total_masuk") ? 0 : Convert.ToDecimal(row["total_masuk"]);
                    decimal bakar = row.IsNull("total_terbakar") ? 0 : Convert.ToDecimal(row["total_terbakar"]);
                    decimal tgt = row.IsNull("target_kalori") ? 0 : Convert.ToDecimal(row["target_kalori"]);

                    sMasuk.Points.AddXY(tgl, masuk);
                    sTerbakar.Points.AddXY(tgl, bakar);
                    sTarget.Points.AddXY(tgl, tgt);
                }

                chartKalori.Series.Add(sMasuk);
                chartKalori.Series.Add(sTerbakar);
                chartKalori.Series.Add(sTarget);

                // Legend
                Legend legend = new Legend("MainLegend");
                legend.BackColor = Color.FromArgb(38, 36, 28);
                legend.ForeColor = Color.FromArgb(200, 185, 120);
                legend.Docking = Docking.Bottom;
                chartKalori.Legends.Add(legend);

                // Title
                Title title = new Title(
                    "Kalori 7 Hari Terakhir",
                    Docking.Top,
                    new Font("Segoe UI", 11f, FontStyle.Bold),
                    Color.FromArgb(212, 175, 55));
                chartKalori.Titles.Add(title);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load chart: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MuatDashboard();
        }
    }
}