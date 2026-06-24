using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace AMKH
{
    public partial class FormReport : Form
    {
        private DateTime tanggal;
        private DataTable dtKonsumsi;
        private DataTable dtAktivitas;

        public FormReport(DateTime tanggal, DataTable dtKonsumsi, DataTable dtAktivitas)
        {
            InitializeComponent();
            this.tanggal = tanggal;
            this.dtKonsumsi = dtKonsumsi;
            this.dtAktivitas = dtAktivitas;
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            try
            {
                List<ListKonsumsi> listData = new List<ListKonsumsi>();

                foreach (DataRow row in dtKonsumsi.Rows)
                {
                    listData.Add(new ListKonsumsi
                    {
                        NamaItem = row["NamaItem"].ToString(),
                        Kalori = Convert.ToDecimal(row["Kalori"]),
                        Tipe = row["Tipe"].ToString(),
                        TanggalKonsumsi = Convert.ToDateTime(row["TanggalKonsumsi"]),
                        TargetKalori = Convert.ToDecimal(row["TargetKalori"])
                    });
                }

                LaporanHarian report = new LaporanHarian();
                report.SetDataSource(listData);

                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load report: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is FormRekap)
                {
                    f.Show();
                    break;
                }
            }
        }
    }
}