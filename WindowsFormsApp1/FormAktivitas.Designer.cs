namespace WindowsFormsApp1
{
    partial class FormAktivitas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAktivitas));
            this.panelSubHeader = new System.Windows.Forms.Panel();
            this.lblPageIcon = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.panelGoldAccent = new System.Windows.Forms.Panel();
            this.panelInfoAktivitas = new System.Windows.Forms.Panel();
            this.lblInfoAktivitas = new System.Windows.Forms.Label();
            this.lblTotalRecord = new System.Windows.Forms.Label();
            this.grpTarget = new System.Windows.Forms.GroupBox();
            this.lblTanggalTarget = new System.Windows.Forms.Label();
            this.dtpTanggalTarget = new System.Windows.Forms.DateTimePicker();
            this.lblTargetKalori = new System.Windows.Forms.Label();
            this.txtTargetKalori = new System.Windows.Forms.TextBox();
            this.lblSatuanTarget = new System.Windows.Forms.Label();
            this.btnSetTarget = new System.Windows.Forms.Button();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblNamaAktivitas = new System.Windows.Forms.Label();
            this.txtNamaAktivitas = new System.Windows.Forms.TextBox();
            this.lblKaloriTerbakar = new System.Windows.Forms.Label();
            this.txtKaloriTerbakar = new System.Windows.Forms.TextBox();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBersihkan = new System.Windows.Forms.Button();
            this.panelCari = new System.Windows.Forms.Panel();
            this.lblCari = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvAktivitas = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aMKHDataSet = new AMKH_TESTING.AMKHDataSet();
            this.vwAktivitasAktifBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_AktivitasAktifTableAdapter = new AMKH_TESTING.AMKHDataSetTableAdapters.vw_AktivitasAktifTableAdapter();
            this.idaktivitasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtargetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetkaloriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaaktivitasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kaloriterbakarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSubHeader.SuspendLayout();
            this.panelInfoAktivitas.SuspendLayout();
            this.grpTarget.SuspendLayout();
            this.grpInput.SuspendLayout();
            this.panelCari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktivitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aMKHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAktivitasAktifBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSubHeader
            // 
            this.panelSubHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(36)))), ((int)(((byte)(28)))));
            this.panelSubHeader.Controls.Add(this.lblPageIcon);
            this.panelSubHeader.Controls.Add(this.lblPageTitle);
            this.panelSubHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubHeader.Location = new System.Drawing.Point(0, 0);
            this.panelSubHeader.Name = "panelSubHeader";
            this.panelSubHeader.Size = new System.Drawing.Size(1050, 50);
            this.panelSubHeader.TabIndex = 0;
            // 
            // lblPageIcon
            // 
            this.lblPageIcon.AutoSize = true;
            this.lblPageIcon.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblPageIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblPageIcon.Location = new System.Drawing.Point(12, 9);
            this.lblPageIcon.Name = "lblPageIcon";
            this.lblPageIcon.Size = new System.Drawing.Size(43, 30);
            this.lblPageIcon.TabIndex = 0;
            this.lblPageIcon.Text = "⚡";
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblPageTitle.Location = new System.Drawing.Point(54, 13);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(300, 26);
            this.lblPageTitle.TabIndex = 1;
            this.lblPageTitle.Text = "Input Data Aktivitas";
            // 
            // panelGoldAccent
            // 
            this.panelGoldAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.panelGoldAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGoldAccent.Location = new System.Drawing.Point(0, 50);
            this.panelGoldAccent.Name = "panelGoldAccent";
            this.panelGoldAccent.Size = new System.Drawing.Size(1050, 3);
            this.panelGoldAccent.TabIndex = 1;
            // 
            // panelInfoAktivitas
            // 
            this.panelInfoAktivitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(28)))));
            this.panelInfoAktivitas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfoAktivitas.Controls.Add(this.lblInfoAktivitas);
            this.panelInfoAktivitas.Controls.Add(this.lblTotalRecord);
            this.panelInfoAktivitas.Location = new System.Drawing.Point(9, 60);
            this.panelInfoAktivitas.Name = "panelInfoAktivitas";
            this.panelInfoAktivitas.Size = new System.Drawing.Size(1026, 38);
            this.panelInfoAktivitas.TabIndex = 2;
            // 
            // lblInfoAktivitas
            // 
            this.lblInfoAktivitas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblInfoAktivitas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblInfoAktivitas.Location = new System.Drawing.Point(10, 10);
            this.lblInfoAktivitas.Name = "lblInfoAktivitas";
            this.lblInfoAktivitas.Size = new System.Drawing.Size(680, 18);
            this.lblInfoAktivitas.TabIndex = 0;
            this.lblInfoAktivitas.Text = "Pilih tanggal untuk melihat info aktivitas...";
            // 
            // lblTotalRecord
            // 
            this.lblTotalRecord.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTotalRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(80)))));
            this.lblTotalRecord.Location = new System.Drawing.Point(720, 11);
            this.lblTotalRecord.Name = "lblTotalRecord";
            this.lblTotalRecord.Size = new System.Drawing.Size(290, 16);
            this.lblTotalRecord.TabIndex = 1;
            this.lblTotalRecord.Text = "Total: 0 record aktif";
            this.lblTotalRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpTarget
            // 
            this.grpTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(38)))));
            this.grpTarget.Controls.Add(this.lblTanggalTarget);
            this.grpTarget.Controls.Add(this.dtpTanggalTarget);
            this.grpTarget.Controls.Add(this.lblTargetKalori);
            this.grpTarget.Controls.Add(this.txtTargetKalori);
            this.grpTarget.Controls.Add(this.lblSatuanTarget);
            this.grpTarget.Controls.Add(this.btnSetTarget);
            this.grpTarget.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.grpTarget.Location = new System.Drawing.Point(9, 105);
            this.grpTarget.Name = "grpTarget";
            this.grpTarget.Size = new System.Drawing.Size(1027, 60);
            this.grpTarget.TabIndex = 3;
            this.grpTarget.TabStop = false;
            this.grpTarget.Text = "Set Target Kalori per Tanggal";
            // 
            // lblTanggalTarget
            // 
            this.lblTanggalTarget.AutoSize = true;
            this.lblTanggalTarget.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTanggalTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.lblTanggalTarget.Location = new System.Drawing.Point(14, 26);
            this.lblTanggalTarget.Name = "lblTanggalTarget";
            this.lblTanggalTarget.Size = new System.Drawing.Size(91, 15);
            this.lblTanggalTarget.TabIndex = 0;
            this.lblTanggalTarget.Text = "Tanggal Target :";
            // 
            // dtpTanggalTarget
            // 
            this.dtpTanggalTarget.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTanggalTarget.Location = new System.Drawing.Point(138, 23);
            this.dtpTanggalTarget.Name = "dtpTanggalTarget";
            this.dtpTanggalTarget.Size = new System.Drawing.Size(148, 23);
            this.dtpTanggalTarget.TabIndex = 1;
            // 
            // lblTargetKalori
            // 
            this.lblTargetKalori.AutoSize = true;
            this.lblTargetKalori.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTargetKalori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.lblTargetKalori.Location = new System.Drawing.Point(310, 26);
            this.lblTargetKalori.Name = "lblTargetKalori";
            this.lblTargetKalori.Size = new System.Drawing.Size(79, 15);
            this.lblTargetKalori.TabIndex = 2;
            this.lblTargetKalori.Text = "Target Kalori :";
            // 
            // txtTargetKalori
            // 
            this.txtTargetKalori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(40)))));
            this.txtTargetKalori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTargetKalori.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTargetKalori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(200)))), ((int)(((byte)(80)))));
            this.txtTargetKalori.Location = new System.Drawing.Point(418, 23);
            this.txtTargetKalori.Name = "txtTargetKalori";
            this.txtTargetKalori.Size = new System.Drawing.Size(110, 23);
            this.txtTargetKalori.TabIndex = 3;
            // 
            // lblSatuanTarget
            // 
            this.lblSatuanTarget.AutoSize = true;
            this.lblSatuanTarget.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSatuanTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(160)))), ((int)(((byte)(80)))));
            this.lblSatuanTarget.Location = new System.Drawing.Point(536, 26);
            this.lblSatuanTarget.Name = "lblSatuanTarget";
            this.lblSatuanTarget.Size = new System.Drawing.Size(28, 15);
            this.lblSatuanTarget.TabIndex = 4;
            this.lblSatuanTarget.Text = "kkal";
            // 
            // btnSetTarget
            // 
            this.btnSetTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(140)))), ((int)(((byte)(20)))));
            this.btnSetTarget.FlatAppearance.BorderSize = 0;
            this.btnSetTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetTarget.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSetTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnSetTarget.Location = new System.Drawing.Point(572, 21);
            this.btnSetTarget.Name = "btnSetTarget";
            this.btnSetTarget.Size = new System.Drawing.Size(120, 28);
            this.btnSetTarget.TabIndex = 5;
            this.btnSetTarget.Text = "Set Target";
            this.btnSetTarget.UseVisualStyleBackColor = false;
            this.btnSetTarget.Click += new System.EventHandler(this.btnSetTarget_Click);
            // 
            // grpInput
            // 
            this.grpInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(34)))));
            this.grpInput.Controls.Add(this.lblNamaAktivitas);
            this.grpInput.Controls.Add(this.txtNamaAktivitas);
            this.grpInput.Controls.Add(this.lblKaloriTerbakar);
            this.grpInput.Controls.Add(this.txtKaloriTerbakar);
            this.grpInput.Controls.Add(this.lblTanggal);
            this.grpInput.Controls.Add(this.dtpTanggal);
            this.grpInput.Controls.Add(this.btnTambah);
            this.grpInput.Controls.Add(this.btnUpdate);
            this.grpInput.Controls.Add(this.btnHapus);
            this.grpInput.Controls.Add(this.btnBersihkan);
            this.grpInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.grpInput.Location = new System.Drawing.Point(9, 172);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(1027, 110);
            this.grpInput.TabIndex = 4;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input Data Aktivitas";
            // 
            // lblNamaAktivitas
            // 
            this.lblNamaAktivitas.AutoSize = true;
            this.lblNamaAktivitas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNamaAktivitas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.lblNamaAktivitas.Location = new System.Drawing.Point(14, 28);
            this.lblNamaAktivitas.Name = "lblNamaAktivitas";
            this.lblNamaAktivitas.Size = new System.Drawing.Size(93, 15);
            this.lblNamaAktivitas.TabIndex = 0;
            this.lblNamaAktivitas.Text = "Nama Aktivitas :";
            // 
            // txtNamaAktivitas
            // 
            this.txtNamaAktivitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(40)))));
            this.txtNamaAktivitas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamaAktivitas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwAktivitasAktifBindingSource, "nama_aktivitas", true));
            this.txtNamaAktivitas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNamaAktivitas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(200)))), ((int)(((byte)(80)))));
            this.txtNamaAktivitas.Location = new System.Drawing.Point(138, 25);
            this.txtNamaAktivitas.Name = "txtNamaAktivitas";
            this.txtNamaAktivitas.Size = new System.Drawing.Size(260, 23);
            this.txtNamaAktivitas.TabIndex = 1;
            // 
            // lblKaloriTerbakar
            // 
            this.lblKaloriTerbakar.AutoSize = true;
            this.lblKaloriTerbakar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKaloriTerbakar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.lblKaloriTerbakar.Location = new System.Drawing.Point(420, 28);
            this.lblKaloriTerbakar.Name = "lblKaloriTerbakar";
            this.lblKaloriTerbakar.Size = new System.Drawing.Size(91, 15);
            this.lblKaloriTerbakar.TabIndex = 2;
            this.lblKaloriTerbakar.Text = "Kalori Terbakar :";
            // 
            // txtKaloriTerbakar
            // 
            this.txtKaloriTerbakar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(40)))));
            this.txtKaloriTerbakar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKaloriTerbakar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwAktivitasAktifBindingSource, "kalori_terbakar", true));
            this.txtKaloriTerbakar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKaloriTerbakar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(200)))), ((int)(((byte)(80)))));
            this.txtKaloriTerbakar.Location = new System.Drawing.Point(538, 25);
            this.txtKaloriTerbakar.Name = "txtKaloriTerbakar";
            this.txtKaloriTerbakar.Size = new System.Drawing.Size(120, 23);
            this.txtKaloriTerbakar.TabIndex = 3;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTanggal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.lblTanggal.Location = new System.Drawing.Point(678, 28);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(55, 15);
            this.lblTanggal.TabIndex = 4;
            this.lblTanggal.Text = "Tanggal :";
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwAktivitasAktifBindingSource, "tanggal", true));
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTanggal.Location = new System.Drawing.Point(748, 25);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(155, 23);
            this.dtpTanggal.TabIndex = 5;
            this.dtpTanggal.ValueChanged += new System.EventHandler(this.dtpTanggal_ValueChanged);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTambah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnTambah.Location = new System.Drawing.Point(138, 62);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(100, 32);
            this.btnTambah.TabIndex = 6;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(140)))), ((int)(((byte)(20)))));
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnUpdate.Location = new System.Drawing.Point(248, 62);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 32);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnHapus.Enabled = false;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(358, 62);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(100, 32);
            this.btnHapus.TabIndex = 8;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnBersihkan
            // 
            this.btnBersihkan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(65)))));
            this.btnBersihkan.FlatAppearance.BorderSize = 0;
            this.btnBersihkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBersihkan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBersihkan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(205)))), ((int)(((byte)(150)))));
            this.btnBersihkan.Location = new System.Drawing.Point(468, 62);
            this.btnBersihkan.Name = "btnBersihkan";
            this.btnBersihkan.Size = new System.Drawing.Size(100, 32);
            this.btnBersihkan.TabIndex = 9;
            this.btnBersihkan.Text = "Bersihkan";
            this.btnBersihkan.UseVisualStyleBackColor = false;
            this.btnBersihkan.Click += new System.EventHandler(this.btnBersihkan_Click);
            // 
            // panelCari
            // 
            this.panelCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(34)))));
            this.panelCari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCari.Controls.Add(this.lblCari);
            this.panelCari.Controls.Add(this.txtCari);
            this.panelCari.Controls.Add(this.btnCari);
            this.panelCari.Controls.Add(this.btnTampilkan);
            this.panelCari.Location = new System.Drawing.Point(9, 290);
            this.panelCari.Name = "panelCari";
            this.panelCari.Size = new System.Drawing.Size(1027, 42);
            this.panelCari.TabIndex = 5;
            // 
            // lblCari
            // 
            this.lblCari.AutoSize = true;
            this.lblCari.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.lblCari.Location = new System.Drawing.Point(9, 12);
            this.lblCari.Name = "lblCari";
            this.lblCari.Size = new System.Drawing.Size(86, 15);
            this.lblCari.TabIndex = 0;
            this.lblCari.Text = "Cari Aktivitas :";
            // 
            // txtCari
            // 
            this.txtCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(40)))));
            this.txtCari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCari.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(200)))), ((int)(((byte)(80)))));
            this.txtCari.Location = new System.Drawing.Point(120, 8);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(270, 23);
            this.txtCari.TabIndex = 1;
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(140)))), ((int)(((byte)(20)))));
            this.btnCari.FlatAppearance.BorderSize = 0;
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCari.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCari.Location = new System.Drawing.Point(400, 6);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(90, 30);
            this.btnCari.TabIndex = 2;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(65)))));
            this.btnTampilkan.FlatAppearance.BorderSize = 0;
            this.btnTampilkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTampilkan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTampilkan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(205)))), ((int)(((byte)(150)))));
            this.btnTampilkan.Location = new System.Drawing.Point(500, 6);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(148, 30);
            this.btnTampilkan.TabIndex = 3;
            this.btnTampilkan.Text = "Tampilkan Semua";
            this.btnTampilkan.UseVisualStyleBackColor = false;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // dgvAktivitas
            // 
            this.dgvAktivitas.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(46)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(200)))), ((int)(((byte)(140)))));
            this.dgvAktivitas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAktivitas.AutoGenerateColumns = false;
            this.dgvAktivitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAktivitas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(28)))));
            this.dgvAktivitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAktivitas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(140)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAktivitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAktivitas.ColumnHeadersHeight = 30;
            this.dgvAktivitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAktivitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idaktivitasDataGridViewTextBoxColumn,
            this.idtargetDataGridViewTextBoxColumn,
            this.targetkaloriDataGridViewTextBoxColumn,
            this.namaaktivitasDataGridViewTextBoxColumn,
            this.kaloriterbakarDataGridViewTextBoxColumn,
            this.tanggalDataGridViewTextBoxColumn});
            this.dgvAktivitas.DataSource = this.vwAktivitasAktifBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(36)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAktivitas.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAktivitas.EnableHeadersVisualStyles = false;
            this.dgvAktivitas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvAktivitas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(65)))), ((int)(((byte)(40)))));
            this.dgvAktivitas.Location = new System.Drawing.Point(9, 369);
            this.dgvAktivitas.Name = "dgvAktivitas";
            this.dgvAktivitas.ReadOnly = true;
            this.dgvAktivitas.RowHeadersVisible = false;
            this.dgvAktivitas.RowTemplate.Height = 26;
            this.dgvAktivitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAktivitas.Size = new System.Drawing.Size(1027, 310);
            this.dgvAktivitas.TabIndex = 7;
            this.dgvAktivitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAktivitas_CellClick);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.vwAktivitasAktifBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 675);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1050, 25);
            this.bindingNavigator1.TabIndex = 8;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // aMKHDataSet
            // 
            this.aMKHDataSet.DataSetName = "AMKHDataSet";
            this.aMKHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwAktivitasAktifBindingSource
            // 
            this.vwAktivitasAktifBindingSource.DataMember = "vw_AktivitasAktif";
            this.vwAktivitasAktifBindingSource.DataSource = this.aMKHDataSet;
            // 
            // vw_AktivitasAktifTableAdapter
            // 
            this.vw_AktivitasAktifTableAdapter.ClearBeforeFill = true;
            // 
            // idaktivitasDataGridViewTextBoxColumn
            // 
            this.idaktivitasDataGridViewTextBoxColumn.DataPropertyName = "id_aktivitas";
            this.idaktivitasDataGridViewTextBoxColumn.HeaderText = "id_aktivitas";
            this.idaktivitasDataGridViewTextBoxColumn.Name = "idaktivitasDataGridViewTextBoxColumn";
            this.idaktivitasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idtargetDataGridViewTextBoxColumn
            // 
            this.idtargetDataGridViewTextBoxColumn.DataPropertyName = "id_target";
            this.idtargetDataGridViewTextBoxColumn.HeaderText = "id_target";
            this.idtargetDataGridViewTextBoxColumn.Name = "idtargetDataGridViewTextBoxColumn";
            this.idtargetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // targetkaloriDataGridViewTextBoxColumn
            // 
            this.targetkaloriDataGridViewTextBoxColumn.DataPropertyName = "target_kalori";
            this.targetkaloriDataGridViewTextBoxColumn.HeaderText = "target_kalori";
            this.targetkaloriDataGridViewTextBoxColumn.Name = "targetkaloriDataGridViewTextBoxColumn";
            this.targetkaloriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaaktivitasDataGridViewTextBoxColumn
            // 
            this.namaaktivitasDataGridViewTextBoxColumn.DataPropertyName = "nama_aktivitas";
            this.namaaktivitasDataGridViewTextBoxColumn.HeaderText = "nama_aktivitas";
            this.namaaktivitasDataGridViewTextBoxColumn.Name = "namaaktivitasDataGridViewTextBoxColumn";
            this.namaaktivitasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kaloriterbakarDataGridViewTextBoxColumn
            // 
            this.kaloriterbakarDataGridViewTextBoxColumn.DataPropertyName = "kalori_terbakar";
            this.kaloriterbakarDataGridViewTextBoxColumn.HeaderText = "kalori_terbakar";
            this.kaloriterbakarDataGridViewTextBoxColumn.Name = "kaloriterbakarDataGridViewTextBoxColumn";
            this.kaloriterbakarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tanggalDataGridViewTextBoxColumn
            // 
            this.tanggalDataGridViewTextBoxColumn.DataPropertyName = "tanggal";
            this.tanggalDataGridViewTextBoxColumn.HeaderText = "tanggal";
            this.tanggalDataGridViewTextBoxColumn.Name = "tanggalDataGridViewTextBoxColumn";
            this.tanggalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormAktivitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1050, 700);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dgvAktivitas);
            this.Controls.Add(this.panelCari);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.grpTarget);
            this.Controls.Add(this.panelInfoAktivitas);
            this.Controls.Add(this.panelGoldAccent);
            this.Controls.Add(this.panelSubHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.Name = "FormAktivitas";
            this.Text = "Input Data Aktivitas";
            this.Load += new System.EventHandler(this.FormAktivitas_Load);
            this.panelSubHeader.ResumeLayout(false);
            this.panelSubHeader.PerformLayout();
            this.panelInfoAktivitas.ResumeLayout(false);
            this.grpTarget.ResumeLayout(false);
            this.grpTarget.PerformLayout();
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.panelCari.ResumeLayout(false);
            this.panelCari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktivitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aMKHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAktivitasAktifBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panelSubHeader;
        private System.Windows.Forms.Label lblPageIcon;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Panel panelGoldAccent;
        private System.Windows.Forms.Panel panelInfoAktivitas;
        private System.Windows.Forms.Label lblInfoAktivitas;
        private System.Windows.Forms.Label lblTotalRecord;
        private System.Windows.Forms.GroupBox grpTarget;
        private System.Windows.Forms.Label lblTanggalTarget;
        private System.Windows.Forms.DateTimePicker dtpTanggalTarget;
        private System.Windows.Forms.Label lblTargetKalori;
        private System.Windows.Forms.TextBox txtTargetKalori;
        private System.Windows.Forms.Label lblSatuanTarget;
        private System.Windows.Forms.Button btnSetTarget;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblNamaAktivitas;
        private System.Windows.Forms.TextBox txtNamaAktivitas;
        private System.Windows.Forms.Label lblKaloriTerbakar;
        private System.Windows.Forms.TextBox txtKaloriTerbakar;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBersihkan;
        private System.Windows.Forms.Panel panelCari;
        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dgvAktivitas;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private AMKHDataSet aMKHDataSet;
        private System.Windows.Forms.BindingSource vwAktivitasAktifBindingSource;
        private AMKHDataSetTableAdapters.vw_AktivitasAktifTableAdapter vw_AktivitasAktifTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idaktivitasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtargetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetkaloriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaaktivitasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kaloriterbakarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn;
    }
}