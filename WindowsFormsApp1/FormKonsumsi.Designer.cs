namespace AMKH_TESTING
{
    partial class FormKonsumsi
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKonsumsi));
            this.panelSubHeader = new System.Windows.Forms.Panel();
            this.lblPageIcon = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.panelGoldAccent = new System.Windows.Forms.Panel();
            this.panelInfoKalori = new System.Windows.Forms.Panel();
            this.lblInfoKalori = new System.Windows.Forms.Label();
            this.lblTotalRecord = new System.Windows.Forms.Label();
            this.grpTarget = new System.Windows.Forms.GroupBox();
            this.lblTanggalTarget = new System.Windows.Forms.Label();
            this.dtpTanggalTarget = new System.Windows.Forms.DateTimePicker();
            this.lblTargetKalori = new System.Windows.Forms.Label();
            this.txtTargetKalori = new System.Windows.Forms.TextBox();
            this.lblSatuanTarget = new System.Windows.Forms.Label();
            this.btnSetTarget = new System.Windows.Forms.Button();
            this.lblInfoTarget = new System.Windows.Forms.Label();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblNamaItem = new System.Windows.Forms.Label();
            this.txtNamaItem = new System.Windows.Forms.TextBox();
            this.vwKonsumsiAktifBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aMKH_DBDataSet = new WindowsFormsApp1.AMKH_DBDataSet();
            this.lblKalori = new System.Windows.Forms.Label();
            this.txtKalori = new System.Windows.Forms.TextBox();
            this.lblTipe = new System.Windows.Forms.Label();
            this.cmbTipe = new System.Windows.Forms.ComboBox();
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
            this.grpSqlInjection = new System.Windows.Forms.GroupBox();
            this.lblInjectionInfo = new System.Windows.Forms.Label();
            this.btnBackupData = new System.Windows.Forms.Button();
            this.btnTestInjection = new System.Windows.Forms.Button();
            this.btnQueryAman = new System.Windows.Forms.Button();
            this.btnResetData = new System.Windows.Forms.Button();
            this.dgvKonsumsi = new System.Windows.Forms.DataGridView();
            this.idkonsumsiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtargetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetkaloriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaitemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kaloriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwKonsumsiAktifBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_KonsumsiAktifTableAdapter = new WindowsFormsApp1.AMKH_DBDataSetTableAdapters.vw_KonsumsiAktifTableAdapter();
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
            this.panelSubHeader.SuspendLayout();
            this.panelInfoKalori.SuspendLayout();
            this.grpTarget.SuspendLayout();
            this.grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwKonsumsiAktifBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMKH_DBDataSet)).BeginInit();
            this.panelCari.SuspendLayout();
            this.grpSqlInjection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKonsumsi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwKonsumsiAktifBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
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
            this.lblPageIcon.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblPageIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblPageIcon.Location = new System.Drawing.Point(12, 10);
            this.lblPageIcon.Name = "lblPageIcon";
            this.lblPageIcon.Size = new System.Drawing.Size(33, 25);
            this.lblPageIcon.TabIndex = 0;
            this.lblPageIcon.Text = "🍽";
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblPageTitle.Location = new System.Drawing.Point(50, 13);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(300, 26);
            this.lblPageTitle.TabIndex = 1;
            this.lblPageTitle.Text = "Input Data Konsumsi";
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
            // panelInfoKalori
            // 
            this.panelInfoKalori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(28)))));
            this.panelInfoKalori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfoKalori.Controls.Add(this.lblInfoKalori);
            this.panelInfoKalori.Controls.Add(this.lblTotalRecord);
            this.panelInfoKalori.Location = new System.Drawing.Point(9, 60);
            this.panelInfoKalori.Name = "panelInfoKalori";
            this.panelInfoKalori.Size = new System.Drawing.Size(1027, 38);
            this.panelInfoKalori.TabIndex = 2;
            // 
            // lblInfoKalori
            // 
            this.lblInfoKalori.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblInfoKalori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblInfoKalori.Location = new System.Drawing.Point(10, 10);
            this.lblInfoKalori.Name = "lblInfoKalori";
            this.lblInfoKalori.Size = new System.Drawing.Size(680, 18);
            this.lblInfoKalori.TabIndex = 0;
            this.lblInfoKalori.Text = "Pilih tanggal untuk melihat info kalori...";
            // 
            // lblTotalRecord
            // 
            this.lblTotalRecord.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTotalRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(80)))));
            this.lblTotalRecord.Location = new System.Drawing.Point(720, 11);
            this.lblTotalRecord.Name = "lblTotalRecord";
            this.lblTotalRecord.Size = new System.Drawing.Size(290, 16);
            this.lblTotalRecord.TabIndex = 1;
            this.lblTotalRecord.Text = "Total: 0 record";
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
            this.grpTarget.Controls.Add(this.lblInfoTarget);
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
            // lblInfoTarget
            // 
            this.lblInfoTarget.AutoSize = true;
            this.lblInfoTarget.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblInfoTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(120)))), ((int)(((byte)(75)))));
            this.lblInfoTarget.Location = new System.Drawing.Point(706, 27);
            this.lblInfoTarget.Name = "lblInfoTarget";
            this.lblInfoTarget.Size = new System.Drawing.Size(227, 13);
            this.lblInfoTarget.TabIndex = 6;
            this.lblInfoTarget.Text = "* Pilih tanggal lalu isi target, klik Set Target";
            // 
            // grpInput
            // 
            this.grpInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(34)))));
            this.grpInput.Controls.Add(this.lblNamaItem);
            this.grpInput.Controls.Add(this.txtNamaItem);
            this.grpInput.Controls.Add(this.lblKalori);
            this.grpInput.Controls.Add(this.txtKalori);
            this.grpInput.Controls.Add(this.lblTipe);
            this.grpInput.Controls.Add(this.cmbTipe);
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
            this.grpInput.Text = "Input Data Konsumsi";
            // 
            // lblNamaItem
            // 
            this.lblNamaItem.AutoSize = true;
            this.lblNamaItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNamaItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.lblNamaItem.Location = new System.Drawing.Point(14, 28);
            this.lblNamaItem.Name = "lblNamaItem";
            this.lblNamaItem.Size = new System.Drawing.Size(72, 15);
            this.lblNamaItem.TabIndex = 0;
            this.lblNamaItem.Text = "Nama Item :";
            // 
            // txtNamaItem
            // 
            this.txtNamaItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(40)))));
            this.txtNamaItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamaItem.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwKonsumsiAktifBindingSource1, "nama_item", true));
            this.txtNamaItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNamaItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(200)))), ((int)(((byte)(80)))));
            this.txtNamaItem.Location = new System.Drawing.Point(110, 25);
            this.txtNamaItem.Name = "txtNamaItem";
            this.txtNamaItem.Size = new System.Drawing.Size(220, 23);
            this.txtNamaItem.TabIndex = 1;
            // 
            // vwKonsumsiAktifBindingSource1
            // 
            this.vwKonsumsiAktifBindingSource1.DataMember = "vw_KonsumsiAktif";
            this.vwKonsumsiAktifBindingSource1.DataSource = this.aMKH_DBDataSet;
            // 
            // aMKH_DBDataSet
            // 
            this.aMKH_DBDataSet.DataSetName = "AMKH_DBDataSet";
            this.aMKH_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblKalori
            // 
            this.lblKalori.AutoSize = true;
            this.lblKalori.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKalori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.lblKalori.Location = new System.Drawing.Point(348, 28);
            this.lblKalori.Name = "lblKalori";
            this.lblKalori.Size = new System.Drawing.Size(75, 15);
            this.lblKalori.TabIndex = 2;
            this.lblKalori.Text = "Kalori (kkal) :";
            // 
            // txtKalori
            // 
            this.txtKalori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(40)))));
            this.txtKalori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKalori.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwKonsumsiAktifBindingSource1, "kalori", true));
            this.txtKalori.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKalori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(200)))), ((int)(((byte)(80)))));
            this.txtKalori.Location = new System.Drawing.Point(460, 25);
            this.txtKalori.Name = "txtKalori";
            this.txtKalori.Size = new System.Drawing.Size(110, 23);
            this.txtKalori.TabIndex = 3;
            // 
            // lblTipe
            // 
            this.lblTipe.AutoSize = true;
            this.lblTipe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTipe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.lblTipe.Location = new System.Drawing.Point(588, 28);
            this.lblTipe.Name = "lblTipe";
            this.lblTipe.Size = new System.Drawing.Size(36, 15);
            this.lblTipe.TabIndex = 4;
            this.lblTipe.Text = "Tipe :";
            // 
            // cmbTipe
            // 
            this.cmbTipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(40)))));
            this.cmbTipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbTipe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(200)))), ((int)(((byte)(80)))));
            this.cmbTipe.Location = new System.Drawing.Point(630, 25);
            this.cmbTipe.Name = "cmbTipe";
            this.cmbTipe.Size = new System.Drawing.Size(130, 23);
            this.cmbTipe.TabIndex = 5;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTanggal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.lblTanggal.Location = new System.Drawing.Point(778, 28);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(55, 15);
            this.lblTanggal.TabIndex = 6;
            this.lblTanggal.Text = "Tanggal :";
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwKonsumsiAktifBindingSource1, "tanggal", true));
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTanggal.Location = new System.Drawing.Point(845, 25);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(155, 23);
            this.dtpTanggal.TabIndex = 7;
            this.dtpTanggal.ValueChanged += new System.EventHandler(this.dtpTanggal_ValueChanged);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTambah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnTambah.Location = new System.Drawing.Point(110, 62);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(100, 32);
            this.btnTambah.TabIndex = 8;
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
            this.btnUpdate.Location = new System.Drawing.Point(220, 62);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 32);
            this.btnUpdate.TabIndex = 9;
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
            this.btnHapus.Location = new System.Drawing.Point(330, 62);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(100, 32);
            this.btnHapus.TabIndex = 10;
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
            this.btnBersihkan.Location = new System.Drawing.Point(440, 62);
            this.btnBersihkan.Name = "btnBersihkan";
            this.btnBersihkan.Size = new System.Drawing.Size(100, 32);
            this.btnBersihkan.TabIndex = 11;
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
            this.lblCari.Size = new System.Drawing.Size(64, 15);
            this.lblCari.TabIndex = 0;
            this.lblCari.Text = "Cari Item :";
            // 
            // txtCari
            // 
            this.txtCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(40)))));
            this.txtCari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCari.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(200)))), ((int)(((byte)(80)))));
            this.txtCari.Location = new System.Drawing.Point(100, 8);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(280, 23);
            this.txtCari.TabIndex = 1;
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(140)))), ((int)(((byte)(20)))));
            this.btnCari.FlatAppearance.BorderSize = 0;
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCari.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCari.Location = new System.Drawing.Point(390, 6);
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
            this.btnTampilkan.Location = new System.Drawing.Point(490, 6);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(148, 30);
            this.btnTampilkan.TabIndex = 3;
            this.btnTampilkan.Text = "Tampilkan Semua";
            this.btnTampilkan.UseVisualStyleBackColor = false;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // grpSqlInjection
            // 
            this.grpSqlInjection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.grpSqlInjection.Controls.Add(this.lblInjectionInfo);
            this.grpSqlInjection.Controls.Add(this.btnBackupData);
            this.grpSqlInjection.Controls.Add(this.btnTestInjection);
            this.grpSqlInjection.Controls.Add(this.btnQueryAman);
            this.grpSqlInjection.Controls.Add(this.btnResetData);
            this.grpSqlInjection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpSqlInjection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.grpSqlInjection.Location = new System.Drawing.Point(9, 339);
            this.grpSqlInjection.Name = "grpSqlInjection";
            this.grpSqlInjection.Size = new System.Drawing.Size(1027, 58);
            this.grpSqlInjection.TabIndex = 6;
            this.grpSqlInjection.TabStop = false;
            this.grpSqlInjection.Text = "⚠ Demo SQL Injection";
            // 
            // lblInjectionInfo
            // 
            this.lblInjectionInfo.AutoSize = true;
            this.lblInjectionInfo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblInjectionInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblInjectionInfo.Location = new System.Drawing.Point(12, 26);
            this.lblInjectionInfo.Name = "lblInjectionInfo";
            this.lblInjectionInfo.Size = new System.Drawing.Size(396, 13);
            this.lblInjectionInfo.TabIndex = 0;
            this.lblInjectionInfo.Text = "Ketik  \' OR \'1\'=\'1  di Nama Item lalu klik Test Injection untuk melihat efeknya";
            // 
            // btnBackupData
            // 
            this.btnBackupData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(40)))));
            this.btnBackupData.FlatAppearance.BorderSize = 0;
            this.btnBackupData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackupData.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnBackupData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(220)))), ((int)(((byte)(120)))));
            this.btnBackupData.Location = new System.Drawing.Point(550, 18);
            this.btnBackupData.Name = "btnBackupData";
            this.btnBackupData.Size = new System.Drawing.Size(100, 28);
            this.btnBackupData.TabIndex = 1;
            this.btnBackupData.Text = "1. Backup";
            this.btnBackupData.UseVisualStyleBackColor = false;
            this.btnBackupData.Click += new System.EventHandler(this.btnBackupData_Click);
            // 
            // btnTestInjection
            // 
            this.btnTestInjection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnTestInjection.FlatAppearance.BorderSize = 0;
            this.btnTestInjection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestInjection.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnTestInjection.ForeColor = System.Drawing.Color.White;
            this.btnTestInjection.Location = new System.Drawing.Point(660, 18);
            this.btnTestInjection.Name = "btnTestInjection";
            this.btnTestInjection.Size = new System.Drawing.Size(110, 28);
            this.btnTestInjection.TabIndex = 2;
            this.btnTestInjection.Text = "2. Test Inject";
            this.btnTestInjection.UseVisualStyleBackColor = false;
            this.btnTestInjection.Click += new System.EventHandler(this.btnTestInjection_Click);
            // 
            // btnQueryAman
            // 
            this.btnQueryAman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.btnQueryAman.FlatAppearance.BorderSize = 0;
            this.btnQueryAman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQueryAman.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnQueryAman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnQueryAman.Location = new System.Drawing.Point(780, 18);
            this.btnQueryAman.Name = "btnQueryAman";
            this.btnQueryAman.Size = new System.Drawing.Size(110, 28);
            this.btnQueryAman.TabIndex = 3;
            this.btnQueryAman.Text = "3. Query Aman";
            this.btnQueryAman.UseVisualStyleBackColor = false;
            this.btnQueryAman.Click += new System.EventHandler(this.btnQueryAman_Click);
            // 
            // btnResetData
            // 
            this.btnResetData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(70)))), ((int)(((byte)(20)))));
            this.btnResetData.FlatAppearance.BorderSize = 0;
            this.btnResetData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetData.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnResetData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(200)))), ((int)(((byte)(80)))));
            this.btnResetData.Location = new System.Drawing.Point(900, 18);
            this.btnResetData.Name = "btnResetData";
            this.btnResetData.Size = new System.Drawing.Size(110, 28);
            this.btnResetData.TabIndex = 4;
            this.btnResetData.Text = "4. Reset Data";
            this.btnResetData.UseVisualStyleBackColor = false;
            this.btnResetData.Click += new System.EventHandler(this.btnResetData_Click);
            // 
            // dgvKonsumsi
            // 
            this.dgvKonsumsi.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(46)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(200)))), ((int)(((byte)(140)))));
            this.dgvKonsumsi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKonsumsi.AutoGenerateColumns = false;
            this.dgvKonsumsi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKonsumsi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(28)))));
            this.dgvKonsumsi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKonsumsi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(140)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKonsumsi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKonsumsi.ColumnHeadersHeight = 30;
            this.dgvKonsumsi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvKonsumsi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkonsumsiDataGridViewTextBoxColumn,
            this.idtargetDataGridViewTextBoxColumn,
            this.targetkaloriDataGridViewTextBoxColumn,
            this.namaitemDataGridViewTextBoxColumn,
            this.kaloriDataGridViewTextBoxColumn,
            this.tipeDataGridViewTextBoxColumn,
            this.tanggalDataGridViewTextBoxColumn});
            this.dgvKonsumsi.DataSource = this.vwKonsumsiAktifBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(36)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKonsumsi.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKonsumsi.EnableHeadersVisualStyles = false;
            this.dgvKonsumsi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvKonsumsi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(65)))), ((int)(((byte)(40)))));
            this.dgvKonsumsi.Location = new System.Drawing.Point(9, 434);
            this.dgvKonsumsi.Name = "dgvKonsumsi";
            this.dgvKonsumsi.ReadOnly = true;
            this.dgvKonsumsi.RowHeadersVisible = false;
            this.dgvKonsumsi.RowTemplate.Height = 26;
            this.dgvKonsumsi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKonsumsi.Size = new System.Drawing.Size(1027, 248);
            this.dgvKonsumsi.TabIndex = 8;
            this.dgvKonsumsi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKonsumsi_CellClick);
            // 
            // idkonsumsiDataGridViewTextBoxColumn
            // 
            this.idkonsumsiDataGridViewTextBoxColumn.DataPropertyName = "id_konsumsi";
            this.idkonsumsiDataGridViewTextBoxColumn.HeaderText = "id_konsumsi";
            this.idkonsumsiDataGridViewTextBoxColumn.Name = "idkonsumsiDataGridViewTextBoxColumn";
            this.idkonsumsiDataGridViewTextBoxColumn.ReadOnly = true;
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
            // namaitemDataGridViewTextBoxColumn
            // 
            this.namaitemDataGridViewTextBoxColumn.DataPropertyName = "nama_item";
            this.namaitemDataGridViewTextBoxColumn.HeaderText = "nama_item";
            this.namaitemDataGridViewTextBoxColumn.Name = "namaitemDataGridViewTextBoxColumn";
            this.namaitemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kaloriDataGridViewTextBoxColumn
            // 
            this.kaloriDataGridViewTextBoxColumn.DataPropertyName = "kalori";
            this.kaloriDataGridViewTextBoxColumn.HeaderText = "kalori";
            this.kaloriDataGridViewTextBoxColumn.Name = "kaloriDataGridViewTextBoxColumn";
            this.kaloriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipeDataGridViewTextBoxColumn
            // 
            this.tipeDataGridViewTextBoxColumn.DataPropertyName = "tipe";
            this.tipeDataGridViewTextBoxColumn.HeaderText = "tipe";
            this.tipeDataGridViewTextBoxColumn.Name = "tipeDataGridViewTextBoxColumn";
            this.tipeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tanggalDataGridViewTextBoxColumn
            // 
            this.tanggalDataGridViewTextBoxColumn.DataPropertyName = "tanggal";
            this.tanggalDataGridViewTextBoxColumn.HeaderText = "tanggal";
            this.tanggalDataGridViewTextBoxColumn.Name = "tanggalDataGridViewTextBoxColumn";
            this.tanggalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vwKonsumsiAktifBindingSource
            // 
            this.vwKonsumsiAktifBindingSource.DataMember = "vw_KonsumsiAktif";
            this.vwKonsumsiAktifBindingSource.DataSource = this.aMKH_DBDataSet;
            // 
            // vw_KonsumsiAktifTableAdapter
            // 
            this.vw_KonsumsiAktifTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.vwKonsumsiAktifBindingSource1;
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
            this.bindingNavigator1.TabIndex = 9;
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
            // FormKonsumsi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1050, 700);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dgvKonsumsi);
            this.Controls.Add(this.grpSqlInjection);
            this.Controls.Add(this.panelCari);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.grpTarget);
            this.Controls.Add(this.panelInfoKalori);
            this.Controls.Add(this.panelGoldAccent);
            this.Controls.Add(this.panelSubHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.Name = "FormKonsumsi";
            this.Text = "Input Data Konsumsi";
            this.Load += new System.EventHandler(this.FormKonsumsi_Load);
            this.panelSubHeader.ResumeLayout(false);
            this.panelSubHeader.PerformLayout();
            this.panelInfoKalori.ResumeLayout(false);
            this.grpTarget.ResumeLayout(false);
            this.grpTarget.PerformLayout();
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwKonsumsiAktifBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMKH_DBDataSet)).EndInit();
            this.panelCari.ResumeLayout(false);
            this.panelCari.PerformLayout();
            this.grpSqlInjection.ResumeLayout(false);
            this.grpSqlInjection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKonsumsi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwKonsumsiAktifBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panelSubHeader;
        private System.Windows.Forms.Label lblPageIcon;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Panel panelGoldAccent;
        private System.Windows.Forms.Panel panelInfoKalori;
        private System.Windows.Forms.Label lblInfoKalori;
        private System.Windows.Forms.Label lblTotalRecord;
        private System.Windows.Forms.GroupBox grpTarget;
        private System.Windows.Forms.Label lblTanggalTarget;
        private System.Windows.Forms.DateTimePicker dtpTanggalTarget;
        private System.Windows.Forms.Label lblTargetKalori;
        private System.Windows.Forms.TextBox txtTargetKalori;
        private System.Windows.Forms.Label lblSatuanTarget;
        private System.Windows.Forms.Button btnSetTarget;
        private System.Windows.Forms.Label lblInfoTarget;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblNamaItem;
        private System.Windows.Forms.TextBox txtNamaItem;
        private System.Windows.Forms.Label lblKalori;
        private System.Windows.Forms.TextBox txtKalori;
        private System.Windows.Forms.Label lblTipe;
        private System.Windows.Forms.ComboBox cmbTipe;
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
        private System.Windows.Forms.GroupBox grpSqlInjection;
        private System.Windows.Forms.Label lblInjectionInfo;
        private System.Windows.Forms.Button btnBackupData;
        private System.Windows.Forms.Button btnTestInjection;
        private System.Windows.Forms.Button btnQueryAman;
        private System.Windows.Forms.Button btnResetData;
        private System.Windows.Forms.DataGridView dgvKonsumsi;
        private WindowsFormsApp1.AMKH_DBDataSet aMKH_DBDataSet;
        private System.Windows.Forms.BindingSource vwKonsumsiAktifBindingSource;
        private WindowsFormsApp1.AMKH_DBDataSetTableAdapters.vw_KonsumsiAktifTableAdapter vw_KonsumsiAktifTableAdapter;
        private System.Windows.Forms.BindingSource vwKonsumsiAktifBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkonsumsiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtargetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetkaloriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaitemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kaloriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn;
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
    }
}