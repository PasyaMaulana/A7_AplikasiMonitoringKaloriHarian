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

        private void AturKolom()
        {
            if (dgvAktivitas.Columns.Count == 0) return;
            if (dgvAktivitas.Columns.Contains("id_aktivitas"))
                dgvAktivitas.Columns["id_aktivitas"].Visible = false;
            if (dgvAktivitas.Columns.Contains("id_target"))
                dgvAktivitas.Columns["id_target"].Visible = false;
            if (dgvAktivitas.Columns.Contains("target_kalori"))
                dgvAktivitas.Columns["target_kalori"].HeaderText = "Target Kalori";
            if (dgvAktivitas.Columns.Contains("nama_aktivitas"))
                dgvAktivitas.Columns["nama_aktivitas"].HeaderText = "Nama Aktivitas";
            if (dgvAktivitas.Columns.Contains("kalori_terbakar"))
                dgvAktivitas.Columns["kalori_terbakar"].HeaderText = "Kalori Terbakar";
            if (dgvAktivitas.Columns.Contains("tanggal"))
                dgvAktivitas.Columns["tanggal"].HeaderText = "Tanggal";
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
    }
}