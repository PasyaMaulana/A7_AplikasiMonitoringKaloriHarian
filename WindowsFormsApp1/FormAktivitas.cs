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
    public partial class FormAktivitas : Form
    {
        private string connectionString =
             "Server=PASYA\\PASYA;Database=AMKH;Integrated Security=True;";

        private BindingSource bindingSource = new BindingSource();
        private int selectedId = -1;

        public FormAktivitas()
        {
            InitializeComponent();
        }

        private void FormAktivitas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aMKHDataSet.vw_AktivitasAktif' table. You can move, or remove it, as needed.
            this.vw_AktivitasAktifTableAdapter.Fill(this.aMKHDataSet.vw_AktivitasAktif);
            dgvAktivitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAktivitas.MultiSelect = false;
            dgvAktivitas.ReadOnly = true;
            dgvAktivitas.AllowUserToAddRows = false;
            dgvAktivitas.DataSource = bindingSource;


            btnUpdate.Enabled = false;
            btnHapus.Enabled = false;

            MuatData();
            TampilkanInfoAktivitas();

        }

        // ── Load data via VIEW vw_AktivitasAktif ─────────
        private void MuatData()
        {
            try
            {
                using (var c = new SqlConnection(connectionString))
                {
                    c.Open();
                    var da = new SqlDataAdapter(
                        "SELECT * FROM vw_AktivitasAktif ORDER BY tanggal DESC, id_aktivitas DESC", c);
                    var dt = new DataTable();
                    da.Fill(dt);
                    bindingSource.DataSource = dt;
                    AturKolom();
                }
                HitungTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load data: " + ex.Message);
            }
        }
    }
}