namespace WindowsFormsApp1
{
    partial class AMKH
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblStatusKoneksi = new System.Windows.Forms.Label();
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblSubJudul = new System.Windows.Forms.Label();
            this.panelGoldLine = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblTotalKaloriHariIni = new System.Windows.Forms.Label();
            this.lblTotalTarget = new System.Windows.Forms.Label();
            this.lblTotalKonsumsi = new System.Windows.Forms.Label();
            this.grpTarget = new System.Windows.Forms.GroupBox();
            this.lblInfoTarget = new System.Windows.Forms.Label();
            this.btnSetTarget = new System.Windows.Forms.Button();
            this.lblSatuanTarget = new System.Windows.Forms.Label();
            this.txtTargetKalori = new System.Windows.Forms.TextBox();
            this.lblTargetKalori = new System.Windows.Forms.Label();
            this.dtpTanggalTarget = new System.Windows.Forms.DateTimePicker();
            this.lblTanggalTarget = new System.Windows.Forms.Label();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.btnBersihkan = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.cmbTarget = new System.Windows.Forms.ComboBox();
            this.lblTarget = new System.Windows.Forms.Label();
            this.dtpTanggalKonsumsi = new System.Windows.Forms.DateTimePicker();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.txtKalori = new System.Windows.Forms.TextBox();
            this.lblKalori = new System.Windows.Forms.Label();
            this.txtNamaMakanan = new System.Windows.Forms.TextBox();
            this.lblNamaMakanan = new System.Windows.Forms.Label();
            this.panelCari = new System.Windows.Forms.Panel();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.lblCari = new System.Windows.Forms.Label();
            this.dgvKonsumsi = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.grpTarget.SuspendLayout();
            this.grpInput.SuspendLayout();
            this.panelCari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKonsumsi)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelHeader.Controls.Add(this.pbLogo);
            this.panelHeader.Controls.Add(this.lblStatusKoneksi);
            this.panelHeader.Controls.Add(this.lblJudul);
            this.panelHeader.Controls.Add(this.lblSubJudul);
            this.panelHeader.Controls.Add(this.panelGoldLine);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(984, 75);
            this.panelHeader.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::WindowsFormsApp1.Properties.Resources._30579cc699708d1_removebg_preview;
            this.pbLogo.Location = new System.Drawing.Point(15, 5);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(65, 65);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
        }
    }
}