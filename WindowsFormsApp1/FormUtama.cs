using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AMKH
{
    public partial class FormUtama : Form
    {
        private string connectionString =
            "Server=PASYA\\PASYA;Database=AMKH_DB;Integrated Security=True;";
        private Form formAktif = null;

        public FormUtama()
        {
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            CekKoneksi();
            BukaForm(new FormDashboard());
            SetNavbarAktif(btnNavDashboard);
        }

        private void CekKoneksi()
        {
            try
            {
                using (var c = new SqlConnection(connectionString))
                {
                    c.Open();
                    lblStatusKoneksi.Text = "● TERHUBUNG";
                    lblStatusKoneksi.ForeColor = Color.LimeGreen;
                }
            }
            catch
            {
                lblStatusKoneksi.Text = "● GAGAL";
                lblStatusKoneksi.ForeColor = Color.Red;
            }
        }

        private void BukaForm(Form form)
        {
            if (formAktif != null)
            {
                formAktif.Close();
                formAktif = null;
            }
            formAktif = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelKonten.Controls.Clear();
            panelKonten.Controls.Add(form);
            form.Show();
        }

        private void btnNavKonsumsi_Click(object sender, EventArgs e)
        {
            BukaForm(new FormKonsumsi());
            SetNavbarAktif(btnNavKonsumsi);
        }

        private void btnNavAktivitas_Click(object sender, EventArgs e)
        {
            BukaForm(new FormAktivitas());
            SetNavbarAktif(btnNavAktivitas);
        }

        private void btnNavRiwayat_Click(object sender, EventArgs e)
        {
            BukaForm(new FormRiwayat());
            SetNavbarAktif(btnNavRiwayat);
        }

        private void btnNavRekap_Click(object sender, EventArgs e)
        {
            BukaForm(new FormRekap());
            SetNavbarAktif(btnNavRekap);
        }

        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            BukaForm(new FormDashboard());
            SetNavbarAktif(btnNavDashboard);
        }

        private void SetNavbarAktif(Button btnAktif)
        {
            Button[] nav = { btnNavKonsumsi, btnNavAktivitas, btnNavRiwayat, btnNavRekap, btnNavDashboard };
            foreach (var btn in nav)
            {
                btn.BackColor = Color.FromArgb(50, 50, 45);
                btn.ForeColor = Color.FromArgb(200, 185, 120);
            }
            btnAktif.BackColor = Color.FromArgb(180, 140, 20);
            btnAktif.ForeColor = Color.FromArgb(28, 28, 28);
        }
    }
}