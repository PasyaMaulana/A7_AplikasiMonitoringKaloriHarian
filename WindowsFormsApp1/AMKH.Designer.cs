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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pbLogo.Location = new System.Drawing.Point(10, 5);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(65, 65);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
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
            // 
            // btnBersihkan
            // 
            this.btnBersihkan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(65)))));
            this.btnBersihkan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(110)))), ((int)(((byte)(70)))));
            this.btnBersihkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBersihkan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBersihkan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(205)))), ((int)(((byte)(150)))));
            this.btnBersihkan.Location = new System.Drawing.Point(730, 62);
            this.btnBersihkan.Name = "btnBersihkan";
            this.btnBersihkan.Size = new System.Drawing.Size(90, 30);
            this.btnBersihkan.TabIndex = 11;
            this.btnBersihkan.Text = "Bersihkan";
            this.btnBersihkan.UseVisualStyleBackColor = false;
            this.btnBersihkan.Click += new System.EventHandler(this.btnBersihkan_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnHapus.Enabled = false;
            this.btnHapus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(630, 62);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(90, 30);
            this.btnHapus.TabIndex = 10;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(140)))), ((int)(((byte)(20)))));
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnUpdate.Location = new System.Drawing.Point(530, 62);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 30);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnTambah.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(210)))), ((int)(((byte)(80)))));
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTambah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnTambah.Location = new System.Drawing.Point(430, 62);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(90, 30);
            this.btnTambah.TabIndex = 8;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // cmbTarget
            // 
            this.cmbTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(40)))));
            this.cmbTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTarget.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(200)))), ((int)(((byte)(80)))));
            this.cmbTarget.FormattingEnabled = true;
            this.cmbTarget.Location = new System.Drawing.Point(125, 65);
            this.cmbTarget.Name = "cmbTarget";
            this.cmbTarget.Size = new System.Drawing.Size(280, 23);
            this.cmbTarget.TabIndex = 7;
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.lblTarget.Location = new System.Drawing.Point(15, 68);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(79, 15);
            this.lblTarget.TabIndex = 6;
            this.lblTarget.Text = "Target Kalori :";
            // 
            // dtpTanggalKonsumsi
            // 
            this.dtpTanggalKonsumsi.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.dtpTanggalKonsumsi.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
            this.dtpTanggalKonsumsi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTanggalKonsumsi.Location = new System.Drawing.Point(635, 27);
            this.dtpTanggalKonsumsi.Name = "dtpTanggalKonsumsi";
            this.dtpTanggalKonsumsi.Size = new System.Drawing.Size(155, 23);
            this.dtpTanggalKonsumsi.TabIndex = 5;
            this.dtpTanggalKonsumsi.Value = new System.DateTime(2026, 4, 15, 0, 0, 0, 0);
            this.dtpTanggalKonsumsi.ValueChanged += new System.EventHandler(this.dtpTanggalKonsumsi_ValueChanged);
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTanggal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.lblTanggal.Location = new System.Drawing.Point(570, 30);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(55, 15);
            this.lblTanggal.TabIndex = 4;
            this.lblTanggal.Text = "Tanggal :";
            // 
            // txtKalori
            // 
            this.txtKalori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(40)))));
            this.txtKalori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKalori.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKalori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(200)))), ((int)(((byte)(80)))));
            this.txtKalori.Location = new System.Drawing.Point(440, 27);
            this.txtKalori.Name = "txtKalori";
            this.txtKalori.Size = new System.Drawing.Size(110, 23);
            this.txtKalori.TabIndex = 3;
            // 
            // lblKalori
            // 
            this.lblKalori.AutoSize = true;
            this.lblKalori.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKalori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.lblKalori.Location = new System.Drawing.Point(345, 30);
            this.lblKalori.Name = "lblKalori";
            this.lblKalori.Size = new System.Drawing.Size(75, 15);
            this.lblKalori.TabIndex = 2;
            this.lblKalori.Text = "Kalori (kkal) :";
            // 
            // txtNamaMakanan
            // 
            this.txtNamaMakanan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(40)))));
            this.txtNamaMakanan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamaMakanan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNamaMakanan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(200)))), ((int)(((byte)(80)))));
            this.txtNamaMakanan.Location = new System.Drawing.Point(125, 27);
            this.txtNamaMakanan.Name = "txtNamaMakanan";
            this.txtNamaMakanan.Size = new System.Drawing.Size(200, 23);
            this.txtNamaMakanan.TabIndex = 1;
            // 
            // lblNamaMakanan
            // 
            this.lblNamaMakanan.AutoSize = true;
            this.lblNamaMakanan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNamaMakanan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.lblNamaMakanan.Location = new System.Drawing.Point(15, 30);
            this.lblNamaMakanan.Name = "lblNamaMakanan";
            this.lblNamaMakanan.Size = new System.Drawing.Size(97, 15);
            this.lblNamaMakanan.TabIndex = 0;
            this.lblNamaMakanan.Text = "Nama Makanan :";
            // 
            // panelCari
            // 
            this.panelCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(34)))));
            this.panelCari.Controls.Add(this.btnTampilkan);
            this.panelCari.Controls.Add(this.btnCari);
            this.panelCari.Controls.Add(this.txtCari);
            this.panelCari.Controls.Add(this.lblCari);
            this.panelCari.Location = new System.Drawing.Point(10, 343);
            this.panelCari.Name = "panelCari";
            this.panelCari.Size = new System.Drawing.Size(960, 40);
            this.panelCari.TabIndex = 4;
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(65)))));
            this.btnTampilkan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(110)))), ((int)(((byte)(70)))));
            this.btnTampilkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTampilkan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTampilkan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(205)))), ((int)(((byte)(150)))));
            this.btnTampilkan.Location = new System.Drawing.Point(490, 5);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(130, 28);
            this.btnTampilkan.TabIndex = 3;
            this.btnTampilkan.Text = "Tampilkan Semua";
            this.btnTampilkan.UseVisualStyleBackColor = false;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(140)))), ((int)(((byte)(20)))));
            this.btnCari.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCari.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCari.Location = new System.Drawing.Point(400, 5);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(80, 28);
            this.btnCari.TabIndex = 2;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // txtCari
            // 
            this.txtCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(40)))));
            this.txtCari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCari.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(200)))), ((int)(((byte)(80)))));
            this.txtCari.Location = new System.Drawing.Point(110, 7);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(280, 23);
            this.txtCari.TabIndex = 1;
            // 
            // lblCari
            // 
            this.lblCari.AutoSize = true;
            this.lblCari.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.lblCari.Location = new System.Drawing.Point(0, 10);
            this.lblCari.Name = "lblCari";
            this.lblCari.Size = new System.Drawing.Size(87, 15);
            this.lblCari.TabIndex = 0;
            this.lblCari.Text = "Cari Makanan :";
            // 
            // dgvKonsumsi
            // 
            this.dgvKonsumsi.AllowUserToAddRows = false;
            this.dgvKonsumsi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(46)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(200)))), ((int)(((byte)(140)))));
            this.dgvKonsumsi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKonsumsi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKonsumsi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(28)))));
            this.dgvKonsumsi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKonsumsi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(140)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKonsumsi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(36)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(200)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKonsumsi.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKonsumsi.EnableHeadersVisualStyles = false;
            this.dgvKonsumsi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvKonsumsi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(65)))), ((int)(((byte)(40)))));
            this.dgvKonsumsi.Location = new System.Drawing.Point(10, 393);
            this.dgvKonsumsi.Name = "dgvKonsumsi";
            this.dgvKonsumsi.ReadOnly = true;
            this.dgvKonsumsi.RowHeadersVisible = false;
            this.dgvKonsumsi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKonsumsi.Size = new System.Drawing.Size(960, 250);
            this.dgvKonsumsi.TabIndex = 5;
            this.dgvKonsumsi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKonsumsi_CellClick);
            // 
            // AMKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.dgvKonsumsi);
            this.Controls.Add(this.panelCari);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.grpTarget);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelHeader);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "AMKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikasi Monitoring Kalori Harian";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.grpTarget.ResumeLayout(false);
            this.grpTarget.PerformLayout();
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.panelCari.ResumeLayout(false);
            this.panelCari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKonsumsi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblSubJudul;
        private System.Windows.Forms.Label lblStatusKoneksi;
        private System.Windows.Forms.Panel panelGoldLine;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblTotalKonsumsi;
        private System.Windows.Forms.Label lblTotalTarget;
        private System.Windows.Forms.Label lblTotalKaloriHariIni;
        private System.Windows.Forms.GroupBox grpTarget;
        private System.Windows.Forms.Label lblTanggalTarget;
        private System.Windows.Forms.DateTimePicker dtpTanggalTarget;
        private System.Windows.Forms.Label lblTargetKalori;
        private System.Windows.Forms.TextBox txtTargetKalori;
        private System.Windows.Forms.Label lblSatuanTarget;
        private System.Windows.Forms.Button btnSetTarget;
        private System.Windows.Forms.Label lblInfoTarget;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblNamaMakanan;
        private System.Windows.Forms.TextBox txtNamaMakanan;
        private System.Windows.Forms.Label lblKalori;
        private System.Windows.Forms.TextBox txtKalori;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.DateTimePicker dtpTanggalKonsumsi;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.ComboBox cmbTarget;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBersihkan;
        private System.Windows.Forms.Panel panelCari;
        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.DataGridView dgvKonsumsi;
    }
}