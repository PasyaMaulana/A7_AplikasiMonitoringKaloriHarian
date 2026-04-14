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
        private int selectedIdTarget = -1;

        public AMKH()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}