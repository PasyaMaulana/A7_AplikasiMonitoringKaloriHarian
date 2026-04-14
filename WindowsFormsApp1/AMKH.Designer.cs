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
            // 
            // lblStatusKoneksi
            // 
            this.lblStatusKoneksi.AutoSize = true;
            this.lblStatusKoneksi.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblStatusKoneksi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblStatusKoneksi.Location = new System.Drawing.Point(700, 28);
            this.lblStatusKoneksi.Name = "lblStatusKoneksi";
            this.lblStatusKoneksi.Size = new System.Drawing.Size(127, 15);
            this.lblStatusKoneksi.TabIndex = 1;
            this.lblStatusKoneksi.Text = "● Memeriksa koneksi...";
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblJudul.Location = new System.Drawing.Point(85, 14);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(331, 28);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Aplikasi Monitoring Kalori Harian";
            // 
            // lblSubJudul
            // 
            this.lblSubJudul.Location = new System.Drawing.Point(0, 0);
            this.lblSubJudul.Name = "lblSubJudul";
            this.lblSubJudul.Size = new System.Drawing.Size(100, 23);
            this.lblSubJudul.TabIndex = 4;
            // 
            // panelGoldLine
            // 
            this.panelGoldLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.panelGoldLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelGoldLine.Location = new System.Drawing.Point(0, 72);
            this.panelGoldLine.Name = "panelGoldLine";
            this.panelGoldLine.Size = new System.Drawing.Size(984, 3);
            this.panelGoldLine.TabIndex = 5;
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Controls.Add(this.lblTotalKaloriHariIni);
            this.panelInfo.Controls.Add(this.lblTotalTarget);
            this.panelInfo.Controls.Add(this.lblTotalKonsumsi);
            this.panelInfo.Location = new System.Drawing.Point(10, 83);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(960, 40);
            this.panelInfo.TabIndex = 1;
            // 
            // lblTotalKaloriHariIni
            // 
            this.lblTotalKaloriHariIni.AutoSize = true;
            this.lblTotalKaloriHariIni.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalKaloriHariIni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.lblTotalKaloriHariIni.Location = new System.Drawing.Point(530, 10);
            this.lblTotalKaloriHariIni.Name = "lblTotalKaloriHariIni";
            this.lblTotalKaloriHariIni.Size = new System.Drawing.Size(50, 15);
            this.lblTotalKaloriHariIni.TabIndex = 2;
            this.lblTotalKaloriHariIni.Text = "Kalori: -";
            // 
            // lblTotalTarget
            // 
            this.lblTotalTarget.AutoSize = true;
            this.lblTotalTarget.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.lblTotalTarget.Location = new System.Drawing.Point(300, 10);
            this.lblTotalTarget.Name = "lblTotalTarget";
            this.lblTotalTarget.Size = new System.Drawing.Size(113, 15);
            this.lblTotalTarget.TabIndex = 1;
            this.lblTotalTarget.Text = "Total Data Target: -";
            // 
            // lblTotalKonsumsi
            // 
            this.lblTotalKonsumsi.AutoSize = true;
            this.lblTotalKonsumsi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalKonsumsi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblTotalKonsumsi.Location = new System.Drawing.Point(10, 10);
            this.lblTotalKonsumsi.Name = "lblTotalKonsumsi";
            this.lblTotalKonsumsi.Size = new System.Drawing.Size(130, 15);
            this.lblTotalKonsumsi.TabIndex = 0;
            this.lblTotalKonsumsi.Text = "Total Data Konsumsi: -";
            // 
            // grpTarget
            // 
            this.grpTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(38)))));
            this.grpTarget.Controls.Add(this.lblInfoTarget);
            this.grpTarget.Controls.Add(this.btnSetTarget);
            this.grpTarget.Controls.Add(this.lblSatuanTarget);
            this.grpTarget.Controls.Add(this.txtTargetKalori);
            this.grpTarget.Controls.Add(this.lblTargetKalori);
            this.grpTarget.Controls.Add(this.dtpTanggalTarget);
            this.grpTarget.Controls.Add(this.lblTanggalTarget);
            this.grpTarget.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.grpTarget.Location = new System.Drawing.Point(10, 133);
            this.grpTarget.Name = "grpTarget";
            this.grpTarget.Size = new System.Drawing.Size(960, 60);
            this.grpTarget.TabIndex = 2;
            this.grpTarget.TabStop = false;
            this.grpTarget.Text = "Set Target Kalori per Tanggal";
            // 
            // lblInfoTarget
            // 
            this.lblInfoTarget.AutoSize = true;
            this.lblInfoTarget.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblInfoTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(80)))));
            this.lblInfoTarget.Location = new System.Drawing.Point(625, 28);
            this.lblInfoTarget.Name = "lblInfoTarget";
            this.lblInfoTarget.Size = new System.Drawing.Size(282, 13);
            this.lblInfoTarget.TabIndex = 6;
            this.lblInfoTarget.Text = "* Pilih tanggal dan isi target kalori, lalu klik Set Target";
            // 
            // btnSetTarget
            //
            this.btnSetTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(140)))), ((int)(((byte)(20)))));
            this.btnSetTarget.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnSetTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetTarget.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSetTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnSetTarget.Location = new System.Drawing.Point(500, 22);
            this.btnSetTarget.Name = "btnSetTarget";
            this.btnSetTarget.Size = new System.Drawing.Size(110, 28);
            this.btnSetTarget.TabIndex = 5;
            this.btnSetTarget.Text = "Set Target";
            this.btnSetTarget.UseVisualStyleBackColor = false;
            this.btnSetTarget.Click += new System.EventHandler(this.btnSetTarget_Click);
            // 
            // lblSatuanTarget
            // 
            this.lblSatuanTarget.AutoSize = true;
            this.lblSatuanTarget.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSatuanTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(160)))), ((int)(((byte)(80)))));
            this.lblSatuanTarget.Location = new System.Drawing.Point(467, 28);
            this.lblSatuanTarget.Name = "lblSatuanTarget";
            this.lblSatuanTarget.Size = new System.Drawing.Size(28, 15);
            this.lblSatuanTarget.TabIndex = 4;
            this.lblSatuanTarget.Text = "kkal";
            // 
            // txtTargetKalori
            // 
            this.txtTargetKalori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(40)))));
            this.txtTargetKalori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTargetKalori.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTargetKalori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(200)))), ((int)(((byte)(80)))));
            this.txtTargetKalori.Location = new System.Drawing.Point(360, 25);
            this.txtTargetKalori.Name = "txtTargetKalori";
            this.txtTargetKalori.Size = new System.Drawing.Size(100, 23);
            this.txtTargetKalori.TabIndex = 3;
            // 
            // lblTargetKalori
            // 
            this.lblTargetKalori.AutoSize = true;
            this.lblTargetKalori.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTargetKalori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.lblTargetKalori.Location = new System.Drawing.Point(270, 28);
            this.lblTargetKalori.Name = "lblTargetKalori";
            this.lblTargetKalori.Size = new System.Drawing.Size(79, 15);
            this.lblTargetKalori.TabIndex = 2;
            this.lblTargetKalori.Text = "Target Kalori :";
            // 
            // dtpTanggalTarget
            // 
            this.dtpTanggalTarget.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.dtpTanggalTarget.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
            this.dtpTanggalTarget.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTanggalTarget.Location = new System.Drawing.Point(120, 25);
            this.dtpTanggalTarget.Name = "dtpTanggalTarget";
            this.dtpTanggalTarget.Size = new System.Drawing.Size(130, 23);
            this.dtpTanggalTarget.TabIndex = 1;
            this.dtpTanggalTarget.Value = new System.DateTime(2026, 4, 15, 0, 0, 0, 0);
            // 
            // lblTanggalTarget
            //
            this.lblTanggalTarget.AutoSize = true;
            this.lblTanggalTarget.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTanggalTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.lblTanggalTarget.Location = new System.Drawing.Point(15, 28);
            this.lblTanggalTarget.Name = "lblTanggalTarget";
            this.lblTanggalTarget.Size = new System.Drawing.Size(91, 15);
            this.lblTanggalTarget.TabIndex = 0;
            this.lblTanggalTarget.Text = "Tanggal Target :";
            // 
            // grpInput
            // 
            this.grpInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(34)))));
            this.grpInput.Controls.Add(this.btnBersihkan);
            this.grpInput.Controls.Add(this.btnHapus);
            this.grpInput.Controls.Add(this.btnUpdate);
            this.grpInput.Controls.Add(this.btnTambah);
            this.grpInput.Controls.Add(this.cmbTarget);
            this.grpInput.Controls.Add(this.lblTarget);
            this.grpInput.Controls.Add(this.dtpTanggalKonsumsi);
            this.grpInput.Controls.Add(this.lblTanggal);
            this.grpInput.Controls.Add(this.txtKalori);
            this.grpInput.Controls.Add(this.lblKalori);
            this.grpInput.Controls.Add(this.txtNamaMakanan);
            this.grpInput.Controls.Add(this.lblNamaMakanan);
            this.grpInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.grpInput.Location = new System.Drawing.Point(10, 203);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(960, 130);
            this.grpInput.TabIndex = 3;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input Data Konsumsi";
        }
    }
}