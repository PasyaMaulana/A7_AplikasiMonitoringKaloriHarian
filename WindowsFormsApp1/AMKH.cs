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
    public partial class AMKH : Form
    {
        private string connectionString = "Server=PASYA\\PASYA;Database=AMKH_DB;Integrated Security=True;";
        private int selectedIdKonsumsi = -1;
        private int selectedIdTarget   = -1;

        public AMKH()
        {
            InitializeComponent();
        }

        // ============================================================
        // BAGIAN B - Status Koneksi
        // ============================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            CekStatusKoneksi();
            LoadComboTarget();
            TampilkanJumlahData();
            TampilkanData();
        }

        private void CekStatusKoneksi()
        {
            try
            {
                using (SqlConnection c = new SqlConnection(connectionString))
                {
                    c.Open();
                    lblStatusKoneksi.Text      = "● Status Koneksi: TERHUBUNG";
                    lblStatusKoneksi.ForeColor = Color.LimeGreen;
                }
            }
            catch (Exception ex)
            {
                lblStatusKoneksi.Text      = "● Status Koneksi: GAGAL";
                lblStatusKoneksi.ForeColor = Color.Red;
                MessageBox.Show("Gagal terhubung ke database!\n\n" + ex.Message,
                    "Error Koneksi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}