namespace AMKH_TESTING
{
    partial class FormRiwayat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRiwayat));
            this.panelSubHeader = new System.Windows.Forms.Panel();
            this.lblPageIcon = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.panelGoldAccent = new System.Windows.Forms.Panel();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.lblTanggalRiwayat = new System.Windows.Forms.Label();
            this.dtpRiwayat = new System.Windows.Forms.DateTimePicker();
            this.btnTampilkanRiwayat = new System.Windows.Forms.Button();
            this.panelRingkasan = new System.Windows.Forms.Panel();
            this.lblTotalKonsumsi = new System.Windows.Forms.Label();
            this.lblTotalTerbakar = new System.Windows.Forms.Label();
            this.lblTargetRiwayat = new System.Windows.Forms.Label();
            this.lblKaloriBersih = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.grpKonsumsi = new System.Windows.Forms.GroupBox();
            this.lblJmlKonsumsi = new System.Windows.Forms.Label();
            this.dgvRiwayatKonsumsi = new System.Windows.Forms.DataGridView();
            this.idkonsumsiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtargetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetkaloriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaitemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kaloriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwKonsumsiAktifBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aMKH_DBDataSet = new WindowsFormsApp1.AMKH_DBDataSet();
            this.grpAktivitas = new System.Windows.Forms.GroupBox();
            this.lblJmlAktivitas = new System.Windows.Forms.Label();
            this.dgvRiwayatAktivitas = new System.Windows.Forms.DataGridView();
            this.idaktivitasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtargetDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetkaloriDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaaktivitasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kaloriterbakarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwRiwayatAktivitasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.vw_KonsumsiAktifTableAdapter = new WindowsFormsApp1.AMKH_DBDataSetTableAdapters.vw_KonsumsiAktifTableAdapter();
            this.vwAktivitasAktifBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_AktivitasAktifTableAdapter = new WindowsFormsApp1.AMKH_DBDataSetTableAdapters.vw_AktivitasAktifTableAdapter();
            this.vw_RiwayatAktivitasTableAdapter = new WindowsFormsApp1.AMKH_DBDataSetTableAdapters.vw_RiwayatAktivitasTableAdapter();
            this.vwRiwayatKonsumsiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_RiwayatKonsumsiTableAdapter = new WindowsFormsApp1.AMKH_DBDataSetTableAdapters.vw_RiwayatKonsumsiTableAdapter();
            this.panelSubHeader.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelRingkasan.SuspendLayout();
            this.grpKonsumsi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayatKonsumsi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwKonsumsiAktifBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMKH_DBDataSet)).BeginInit();
            this.grpAktivitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayatAktivitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRiwayatAktivitasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwAktivitasAktifBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRiwayatKonsumsiBindingSource)).BeginInit();
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
            this.panelSubHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSubHeader_Paint);
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
            this.lblPageIcon.Text = "📜";
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblPageTitle.Location = new System.Drawing.Point(54, 13);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(340, 26);
            this.lblPageTitle.TabIndex = 1;
            this.lblPageTitle.Text = "Riwayat Konsumsi & Aktivitas";
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
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(38)))));
            this.panelFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFilter.Controls.Add(this.lblTanggalRiwayat);
            this.panelFilter.Controls.Add(this.dtpRiwayat);
            this.panelFilter.Controls.Add(this.btnTampilkanRiwayat);
            this.panelFilter.Location = new System.Drawing.Point(9, 60);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(1027, 46);
            this.panelFilter.TabIndex = 2;
            // 
            // lblTanggalRiwayat
            // 
            this.lblTanggalRiwayat.AutoSize = true;
            this.lblTanggalRiwayat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTanggalRiwayat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblTanggalRiwayat.Location = new System.Drawing.Point(14, 14);
            this.lblTanggalRiwayat.Name = "lblTanggalRiwayat";
            this.lblTanggalRiwayat.Size = new System.Drawing.Size(81, 15);
            this.lblTanggalRiwayat.TabIndex = 0;
            this.lblTanggalRiwayat.Text = "Pilih Tanggal :";
            // 
            // dtpRiwayat
            // 
            this.dtpRiwayat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRiwayat.Location = new System.Drawing.Point(120, 11);
            this.dtpRiwayat.Name = "dtpRiwayat";
            this.dtpRiwayat.Size = new System.Drawing.Size(148, 23);
            this.dtpRiwayat.TabIndex = 1;
            this.dtpRiwayat.ValueChanged += new System.EventHandler(this.dtpRiwayat_ValueChanged);
            // 
            // btnTampilkanRiwayat
            // 
            this.btnTampilkanRiwayat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(140)))), ((int)(((byte)(20)))));
            this.btnTampilkanRiwayat.FlatAppearance.BorderSize = 0;
            this.btnTampilkanRiwayat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTampilkanRiwayat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTampilkanRiwayat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnTampilkanRiwayat.Location = new System.Drawing.Point(280, 9);
            this.btnTampilkanRiwayat.Name = "btnTampilkanRiwayat";
            this.btnTampilkanRiwayat.Size = new System.Drawing.Size(130, 28);
            this.btnTampilkanRiwayat.TabIndex = 2;
            this.btnTampilkanRiwayat.Text = "Tampilkan";
            this.btnTampilkanRiwayat.UseVisualStyleBackColor = false;
            this.btnTampilkanRiwayat.Click += new System.EventHandler(this.btnTampilkanRiwayat_Click);
            // 
            // panelRingkasan
            // 
            this.panelRingkasan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(34)))));
            this.panelRingkasan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRingkasan.Controls.Add(this.lblTotalKonsumsi);
            this.panelRingkasan.Controls.Add(this.lblTotalTerbakar);
            this.panelRingkasan.Controls.Add(this.lblTargetRiwayat);
            this.panelRingkasan.Controls.Add(this.lblKaloriBersih);
            this.panelRingkasan.Controls.Add(this.lblStatus);
            this.panelRingkasan.Controls.Add(this.lblSaldo);
            this.panelRingkasan.Location = new System.Drawing.Point(9, 113);
            this.panelRingkasan.Name = "panelRingkasan";
            this.panelRingkasan.Size = new System.Drawing.Size(1027, 90);
            this.panelRingkasan.TabIndex = 3;
            // 
            // lblTotalKonsumsi
            // 
            this.lblTotalKonsumsi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalKonsumsi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblTotalKonsumsi.Location = new System.Drawing.Point(12, 10);
            this.lblTotalKonsumsi.Name = "lblTotalKonsumsi";
            this.lblTotalKonsumsi.Size = new System.Drawing.Size(300, 18);
            this.lblTotalKonsumsi.TabIndex = 0;
            this.lblTotalKonsumsi.Text = "Kalori Masuk  : -";
            // 
            // lblTotalTerbakar
            // 
            this.lblTotalTerbakar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalTerbakar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblTotalTerbakar.Location = new System.Drawing.Point(340, 10);
            this.lblTotalTerbakar.Name = "lblTotalTerbakar";
            this.lblTotalTerbakar.Size = new System.Drawing.Size(300, 18);
            this.lblTotalTerbakar.TabIndex = 1;
            this.lblTotalTerbakar.Text = "Kalori Terbakar: -";
            // 
            // lblTargetRiwayat
            // 
            this.lblTargetRiwayat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTargetRiwayat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblTargetRiwayat.Location = new System.Drawing.Point(670, 10);
            this.lblTargetRiwayat.Name = "lblTargetRiwayat";
            this.lblTargetRiwayat.Size = new System.Drawing.Size(300, 18);
            this.lblTargetRiwayat.TabIndex = 2;
            this.lblTargetRiwayat.Text = "Target Kalori  : -";
            // 
            // lblKaloriBersih
            // 
            this.lblKaloriBersih.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKaloriBersih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.lblKaloriBersih.Location = new System.Drawing.Point(12, 38);
            this.lblKaloriBersih.Name = "lblKaloriBersih";
            this.lblKaloriBersih.Size = new System.Drawing.Size(300, 18);
            this.lblKaloriBersih.TabIndex = 3;
            this.lblKaloriBersih.Text = "Kalori Bersih  : -";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblStatus.Location = new System.Drawing.Point(340, 38);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(300, 20);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status         : -";
            // 
            // lblSaldo
            // 
            this.lblSaldo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSaldo.ForeColor = System.Drawing.Color.Gray;
            this.lblSaldo.Location = new System.Drawing.Point(12, 62);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(400, 18);
            this.lblSaldo.TabIndex = 5;
            this.lblSaldo.Visible = false;
            // 
            // grpKonsumsi
            // 
            this.grpKonsumsi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(34)))));
            this.grpKonsumsi.Controls.Add(this.lblJmlKonsumsi);
            this.grpKonsumsi.Controls.Add(this.dgvRiwayatKonsumsi);
            this.grpKonsumsi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpKonsumsi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.grpKonsumsi.Location = new System.Drawing.Point(9, 210);
            this.grpKonsumsi.Name = "grpKonsumsi";
            this.grpKonsumsi.Size = new System.Drawing.Size(1027, 200);
            this.grpKonsumsi.TabIndex = 4;
            this.grpKonsumsi.TabStop = false;
            this.grpKonsumsi.Text = "Riwayat Konsumsi";
            // 
            // lblJmlKonsumsi
            // 
            this.lblJmlKonsumsi.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblJmlKonsumsi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(80)))));
            this.lblJmlKonsumsi.Location = new System.Drawing.Point(160, 0);
            this.lblJmlKonsumsi.Name = "lblJmlKonsumsi";
            this.lblJmlKonsumsi.Size = new System.Drawing.Size(120, 16);
            this.lblJmlKonsumsi.TabIndex = 1;
            this.lblJmlKonsumsi.Text = "(0 item)";
            // 
            // dgvRiwayatKonsumsi
            // 
            this.dgvRiwayatKonsumsi.AllowUserToAddRows = false;
            this.dgvRiwayatKonsumsi.AutoGenerateColumns = false;
            this.dgvRiwayatKonsumsi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRiwayatKonsumsi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(28)))));
            this.dgvRiwayatKonsumsi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRiwayatKonsumsi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkonsumsiDataGridViewTextBoxColumn,
            this.idtargetDataGridViewTextBoxColumn,
            this.targetkaloriDataGridViewTextBoxColumn,
            this.namaitemDataGridViewTextBoxColumn,
            this.kaloriDataGridViewTextBoxColumn,
            this.tipeDataGridViewTextBoxColumn,
            this.tanggalDataGridViewTextBoxColumn});
            this.dgvRiwayatKonsumsi.DataSource = this.vwKonsumsiAktifBindingSource;
            this.dgvRiwayatKonsumsi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRiwayatKonsumsi.Location = new System.Drawing.Point(3, 19);
            this.dgvRiwayatKonsumsi.Name = "dgvRiwayatKonsumsi";
            this.dgvRiwayatKonsumsi.ReadOnly = true;
            this.dgvRiwayatKonsumsi.RowHeadersVisible = false;
            this.dgvRiwayatKonsumsi.Size = new System.Drawing.Size(1021, 178);
            this.dgvRiwayatKonsumsi.TabIndex = 0;
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
            // aMKH_DBDataSet
            // 
            this.aMKH_DBDataSet.DataSetName = "AMKH_DBDataSet";
            this.aMKH_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpAktivitas
            // 
            this.grpAktivitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(34)))));
            this.grpAktivitas.Controls.Add(this.lblJmlAktivitas);
            this.grpAktivitas.Controls.Add(this.dgvRiwayatAktivitas);
            this.grpAktivitas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpAktivitas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.grpAktivitas.Location = new System.Drawing.Point(9, 435);
            this.grpAktivitas.Name = "grpAktivitas";
            this.grpAktivitas.Size = new System.Drawing.Size(1027, 200);
            this.grpAktivitas.TabIndex = 5;
            this.grpAktivitas.TabStop = false;
            this.grpAktivitas.Text = "Riwayat Aktivitas";
            // 
            // lblJmlAktivitas
            // 
            this.lblJmlAktivitas.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblJmlAktivitas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(80)))));
            this.lblJmlAktivitas.Location = new System.Drawing.Point(160, 0);
            this.lblJmlAktivitas.Name = "lblJmlAktivitas";
            this.lblJmlAktivitas.Size = new System.Drawing.Size(130, 16);
            this.lblJmlAktivitas.TabIndex = 1;
            this.lblJmlAktivitas.Text = "(0 aktivitas)";
            // 
            // dgvRiwayatAktivitas
            // 
            this.dgvRiwayatAktivitas.AllowUserToAddRows = false;
            this.dgvRiwayatAktivitas.AutoGenerateColumns = false;
            this.dgvRiwayatAktivitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRiwayatAktivitas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(28)))));
            this.dgvRiwayatAktivitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRiwayatAktivitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idaktivitasDataGridViewTextBoxColumn,
            this.idtargetDataGridViewTextBoxColumn1,
            this.targetkaloriDataGridViewTextBoxColumn1,
            this.namaaktivitasDataGridViewTextBoxColumn,
            this.kaloriterbakarDataGridViewTextBoxColumn,
            this.tanggalDataGridViewTextBoxColumn1});
            this.dgvRiwayatAktivitas.DataSource = this.vwRiwayatAktivitasBindingSource;
            this.dgvRiwayatAktivitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRiwayatAktivitas.Location = new System.Drawing.Point(3, 19);
            this.dgvRiwayatAktivitas.Name = "dgvRiwayatAktivitas";
            this.dgvRiwayatAktivitas.ReadOnly = true;
            this.dgvRiwayatAktivitas.RowHeadersVisible = false;
            this.dgvRiwayatAktivitas.Size = new System.Drawing.Size(1021, 178);
            this.dgvRiwayatAktivitas.TabIndex = 0;
            // 
            // idaktivitasDataGridViewTextBoxColumn
            // 
            this.idaktivitasDataGridViewTextBoxColumn.DataPropertyName = "id_aktivitas";
            this.idaktivitasDataGridViewTextBoxColumn.HeaderText = "id_aktivitas";
            this.idaktivitasDataGridViewTextBoxColumn.Name = "idaktivitasDataGridViewTextBoxColumn";
            this.idaktivitasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idtargetDataGridViewTextBoxColumn1
            // 
            this.idtargetDataGridViewTextBoxColumn1.DataPropertyName = "id_target";
            this.idtargetDataGridViewTextBoxColumn1.HeaderText = "id_target";
            this.idtargetDataGridViewTextBoxColumn1.Name = "idtargetDataGridViewTextBoxColumn1";
            this.idtargetDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // targetkaloriDataGridViewTextBoxColumn1
            // 
            this.targetkaloriDataGridViewTextBoxColumn1.DataPropertyName = "target_kalori";
            this.targetkaloriDataGridViewTextBoxColumn1.HeaderText = "target_kalori";
            this.targetkaloriDataGridViewTextBoxColumn1.Name = "targetkaloriDataGridViewTextBoxColumn1";
            this.targetkaloriDataGridViewTextBoxColumn1.ReadOnly = true;
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
            // tanggalDataGridViewTextBoxColumn1
            // 
            this.tanggalDataGridViewTextBoxColumn1.DataPropertyName = "tanggal";
            this.tanggalDataGridViewTextBoxColumn1.HeaderText = "tanggal";
            this.tanggalDataGridViewTextBoxColumn1.Name = "tanggalDataGridViewTextBoxColumn1";
            this.tanggalDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // vwRiwayatAktivitasBindingSource
            // 
            this.vwRiwayatAktivitasBindingSource.DataMember = "vw_RiwayatAktivitas";
            this.vwRiwayatAktivitasBindingSource.DataSource = this.aMKH_DBDataSet;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem2;
            this.bindingNavigator1.BindingSource = this.vwRiwayatAktivitasBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem2;
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
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorAddNewItem2,
            this.bindingNavigatorDeleteItem2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 675);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1050, 25);
            this.bindingNavigator1.TabIndex = 6;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem2
            // 
            this.bindingNavigatorAddNewItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem2.Image")));
            this.bindingNavigatorAddNewItem2.Name = "bindingNavigatorAddNewItem2";
            this.bindingNavigatorAddNewItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem2.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem2
            // 
            this.bindingNavigatorDeleteItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem2.Image")));
            this.bindingNavigatorDeleteItem2.Name = "bindingNavigatorDeleteItem2";
            this.bindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem2.Text = "Delete";
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
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.bindingNavigatorAddNewItem3;
            this.bindingNavigator2.BindingSource = this.vwRiwayatKonsumsiBindingSource;
            this.bindingNavigator2.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator2.DeleteItem = this.bindingNavigatorDeleteItem3;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator6,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator7,
            this.bindingNavigatorAddNewItem3,
            this.bindingNavigatorDeleteItem3});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 650);
            this.bindingNavigator2.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator2.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator2.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator2.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator2.Size = new System.Drawing.Size(1050, 25);
            this.bindingNavigator2.TabIndex = 7;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // bindingNavigatorAddNewItem3
            // 
            this.bindingNavigatorAddNewItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem3.Image")));
            this.bindingNavigatorAddNewItem3.Name = "bindingNavigatorAddNewItem3";
            this.bindingNavigatorAddNewItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem3.Text = "Add new";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem3
            // 
            this.bindingNavigatorDeleteItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem3.Image")));
            this.bindingNavigatorDeleteItem3.Name = "bindingNavigatorDeleteItem3";
            this.bindingNavigatorDeleteItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem3.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator6
            // 
            this.bindingNavigatorSeparator6.Name = "bindingNavigatorSeparator6";
            this.bindingNavigatorSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator7
            // 
            this.bindingNavigatorSeparator7.Name = "bindingNavigatorSeparator7";
            this.bindingNavigatorSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // vw_KonsumsiAktifTableAdapter
            // 
            this.vw_KonsumsiAktifTableAdapter.ClearBeforeFill = true;
            // 
            // vwAktivitasAktifBindingSource
            // 
            this.vwAktivitasAktifBindingSource.DataMember = "vw_AktivitasAktif";
            this.vwAktivitasAktifBindingSource.DataSource = this.aMKH_DBDataSet;
            // 
            // vw_AktivitasAktifTableAdapter
            // 
            this.vw_AktivitasAktifTableAdapter.ClearBeforeFill = true;
            // 
            // vw_RiwayatAktivitasTableAdapter
            // 
            this.vw_RiwayatAktivitasTableAdapter.ClearBeforeFill = true;
            // 
            // vwRiwayatKonsumsiBindingSource
            // 
            this.vwRiwayatKonsumsiBindingSource.DataMember = "vw_RiwayatKonsumsi";
            this.vwRiwayatKonsumsiBindingSource.DataSource = this.aMKH_DBDataSet;
            // 
            // vw_RiwayatKonsumsiTableAdapter
            // 
            this.vw_RiwayatKonsumsiTableAdapter.ClearBeforeFill = true;
            // 
            // FormRiwayat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1050, 700);
            this.Controls.Add(this.bindingNavigator2);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.grpAktivitas);
            this.Controls.Add(this.grpKonsumsi);
            this.Controls.Add(this.panelRingkasan);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelGoldAccent);
            this.Controls.Add(this.panelSubHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.Name = "FormRiwayat";
            this.Text = "Riwayat Konsumsi & Aktivitas";
            this.Load += new System.EventHandler(this.FormRiwayat_Load);
            this.panelSubHeader.ResumeLayout(false);
            this.panelSubHeader.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelRingkasan.ResumeLayout(false);
            this.grpKonsumsi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayatKonsumsi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwKonsumsiAktifBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMKH_DBDataSet)).EndInit();
            this.grpAktivitas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayatAktivitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRiwayatAktivitasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwAktivitasAktifBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRiwayatKonsumsiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panelSubHeader;
        private System.Windows.Forms.Label lblPageIcon;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Panel panelGoldAccent;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lblTanggalRiwayat;
        private System.Windows.Forms.DateTimePicker dtpRiwayat;
        private System.Windows.Forms.Button btnTampilkanRiwayat;
        private System.Windows.Forms.Panel panelRingkasan;
        private System.Windows.Forms.Label lblTotalKonsumsi;
        private System.Windows.Forms.Label lblTotalTerbakar;
        private System.Windows.Forms.Label lblTargetRiwayat;
        private System.Windows.Forms.Label lblKaloriBersih;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.GroupBox grpKonsumsi;
        private System.Windows.Forms.Label lblJmlKonsumsi;
        private System.Windows.Forms.DataGridView dgvRiwayatKonsumsi;
        private System.Windows.Forms.GroupBox grpAktivitas;
        private System.Windows.Forms.Label lblJmlAktivitas;
        private System.Windows.Forms.DataGridView dgvRiwayatAktivitas;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem2;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem3;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator6;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator7;
        private WindowsFormsApp1.AMKH_DBDataSet aMKH_DBDataSet;
        private System.Windows.Forms.BindingSource vwKonsumsiAktifBindingSource;
        private WindowsFormsApp1.AMKH_DBDataSetTableAdapters.vw_KonsumsiAktifTableAdapter vw_KonsumsiAktifTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkonsumsiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtargetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetkaloriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaitemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kaloriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vwAktivitasAktifBindingSource;
        private WindowsFormsApp1.AMKH_DBDataSetTableAdapters.vw_AktivitasAktifTableAdapter vw_AktivitasAktifTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idaktivitasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtargetDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetkaloriDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaaktivitasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kaloriterbakarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource vwRiwayatAktivitasBindingSource;
        private WindowsFormsApp1.AMKH_DBDataSetTableAdapters.vw_RiwayatAktivitasTableAdapter vw_RiwayatAktivitasTableAdapter;
        private System.Windows.Forms.BindingSource vwRiwayatKonsumsiBindingSource;
        private WindowsFormsApp1.AMKH_DBDataSetTableAdapters.vw_RiwayatKonsumsiTableAdapter vw_RiwayatKonsumsiTableAdapter;
    }
}