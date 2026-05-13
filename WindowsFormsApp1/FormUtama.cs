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
    public partial class FormUtama : Form
    {
        private string connectionString =
            "Server=PASYA\\PASYA;Database=AMKH;Integrated Security=True;";

        // Form child yang aktif
        private Form formAktif = null;

        public FormUtama()
        {
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            CekKoneksi();

            // Buka konsumsi sebagai default
            BukaForm(new FormKonsumsi());
            SetNavbarAktif(btnNavKonsumsi);
        }

        // ── Cek Koneksi ──────────────────────────────────
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

        // ── Buka Form di Panel Konten ─────────────────────
        private void BukaForm(Form form)
        {
            // Tutup form sebelumnya
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

        // ── Navbar Handlers ──────────────────────────────
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

        // ── Highlight tombol navbar yang aktif ───────────
        private void SetNavbarAktif(Button btnAktif)
        {
            Button[] tombolNav =
            {
                btnNavKonsumsi,
                btnNavAktivitas,
                btnNavRiwayat
            };

            foreach (var btn in tombolNav)
            {
                btn.BackColor = Color.FromArgb(50, 50, 45);
                btn.ForeColor = Color.FromArgb(200, 185, 120);
            }

            btnAktif.BackColor = Color.FromArgb(180, 140, 20);
            btnAktif.ForeColor = Color.FromArgb(28, 28, 28);
        }
    }
}