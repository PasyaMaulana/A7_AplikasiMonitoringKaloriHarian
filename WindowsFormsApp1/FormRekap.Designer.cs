namespace AMKH
{
    partial class FormRekap
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelSubHeader = new System.Windows.Forms.Panel();
            this.lblPageIcon = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.panelGoldAccent = new System.Windows.Forms.Panel();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.btnLoad = new System.Windows.Forms.Button();
            this.panelRingkasan = new System.Windows.Forms.Panel();
            this.lblRingkasanJudul = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.lblTotalMasuk = new System.Windows.Forms.Label();
            this.lblTotalTerbakar = new System.Windows.Forms.Label();
            this.lblKaloriBersih = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpKonsumsi = new System.Windows.Forms.GroupBox();
            this.dgvKonsumsi = new System.Windows.Forms.DataGridView();
            this.grpAktivitas = new System.Windows.Forms.GroupBox();
            this.dgvAktivitas = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lblJmlData = new System.Windows.Forms.Label();
            this.btnCetak = new System.Windows.Forms.Button();
            this.panelSubHeader.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelRingkasan.SuspendLayout();
            this.grpKonsumsi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKonsumsi)).BeginInit();
            this.grpAktivitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktivitas)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();

            // panelSubHeader
            this.panelSubHeader.BackColor = System.Drawing.Color.FromArgb(38, 36, 28);
            this.panelSubHeader.Controls.Add(this.lblPageIcon);
            this.panelSubHeader.Controls.Add(this.lblPageTitle);
            this.panelSubHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubHeader.Location = new System.Drawing.Point(0, 0);
            this.panelSubHeader.Name = "panelSubHeader";
            this.panelSubHeader.Size = new System.Drawing.Size(1000, 50);
            this.panelSubHeader.TabIndex = 0;
            this.panelSubHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSubHeader_Paint);

            this.lblPageIcon.AutoSize = true;
            this.lblPageIcon.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblPageIcon.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblPageIcon.Location = new System.Drawing.Point(12, 10);
            this.lblPageIcon.Name = "lblPageIcon";
            this.lblPageIcon.TabIndex = 0;
            this.lblPageIcon.Text = "📋";

            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblPageTitle.Location = new System.Drawing.Point(50, 13);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(500, 26);
            this.lblPageTitle.TabIndex = 1;
            this.lblPageTitle.Text = "Rekap & Cetak Laporan Harian";

            // panelGoldAccent
            this.panelGoldAccent.BackColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.panelGoldAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGoldAccent.Location = new System.Drawing.Point(0, 50);
            this.panelGoldAccent.Name = "panelGoldAccent";
            this.panelGoldAccent.Size = new System.Drawing.Size(1000, 3);
            this.panelGoldAccent.TabIndex = 1;

            // panelFilter
            this.panelFilter.BackColor = System.Drawing.Color.FromArgb(42, 42, 38);
            this.panelFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFilter.Controls.Add(this.lblTanggal);
            this.panelFilter.Controls.Add(this.dtpTanggal);
            this.panelFilter.Controls.Add(this.btnLoad);
            this.panelFilter.Location = new System.Drawing.Point(10, 63);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(978, 50);
            this.panelFilter.TabIndex = 2;

            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTanggal.ForeColor = System.Drawing.Color.FromArgb(200, 185, 120);
            this.lblTanggal.Location = new System.Drawing.Point(12, 16);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.TabIndex = 0;
            this.lblTanggal.Text = "Pilih Tanggal :";

            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTanggal.Location = new System.Drawing.Point(130, 12);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(160, 23);
            this.dtpTanggal.TabIndex = 1;

            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(180, 140, 20);
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLoad.ForeColor = System.Drawing.Color.FromArgb(28, 28, 28);
            this.btnLoad.Location = new System.Drawing.Point(305, 10);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(110, 30);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load Data";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);

            // panelRingkasan
            this.panelRingkasan.BackColor = System.Drawing.Color.FromArgb(35, 35, 28);
            this.panelRingkasan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRingkasan.Controls.Add(this.lblRingkasanJudul);
            this.panelRingkasan.Controls.Add(this.lblTarget);
            this.panelRingkasan.Controls.Add(this.lblTotalMasuk);
            this.panelRingkasan.Controls.Add(this.lblTotalTerbakar);
            this.panelRingkasan.Controls.Add(this.lblKaloriBersih);
            this.panelRingkasan.Controls.Add(this.lblStatus);
            this.panelRingkasan.Location = new System.Drawing.Point(10, 122);
            this.panelRingkasan.Name = "panelRingkasan";
            this.panelRingkasan.Size = new System.Drawing.Size(978, 60);
            this.panelRingkasan.TabIndex = 3;

            this.lblRingkasanJudul.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblRingkasanJudul.ForeColor = System.Drawing.Color.FromArgb(140, 130, 80);
            this.lblRingkasanJudul.Location = new System.Drawing.Point(10, 5);
            this.lblRingkasanJudul.Name = "lblRingkasanJudul";
            this.lblRingkasanJudul.Size = new System.Drawing.Size(150, 15);
            this.lblRingkasanJudul.Text = "RINGKASAN HARIAN";

            this.lblTarget.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTarget.ForeColor = System.Drawing.Color.FromArgb(200, 185, 120);
            this.lblTarget.Location = new System.Drawing.Point(10, 28);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(200, 18);
            this.lblTarget.Text = "Target    : -";

            this.lblTotalMasuk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalMasuk.ForeColor = System.Drawing.Color.FromArgb(200, 185, 120);
            this.lblTotalMasuk.Location = new System.Drawing.Point(220, 28);
            this.lblTotalMasuk.Name = "lblTotalMasuk";
            this.lblTotalMasuk.Size = new System.Drawing.Size(200, 18);
            this.lblTotalMasuk.Text = "Masuk     : -";

            this.lblTotalTerbakar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalTerbakar.ForeColor = System.Drawing.Color.FromArgb(200, 185, 120);
            this.lblTotalTerbakar.Location = new System.Drawing.Point(430, 28);
            this.lblTotalTerbakar.Name = "lblTotalTerbakar";
            this.lblTotalTerbakar.Size = new System.Drawing.Size(200, 18);
            this.lblTotalTerbakar.Text = "Terbakar  : -";

            this.lblKaloriBersih.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKaloriBersih.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblKaloriBersih.Location = new System.Drawing.Point(640, 28);
            this.lblKaloriBersih.Name = "lblKaloriBersih";
            this.lblKaloriBersih.Size = new System.Drawing.Size(200, 18);
            this.lblKaloriBersih.Text = "Bersih    : -";

            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblStatus.Location = new System.Drawing.Point(850, 28);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(120, 18);
            this.lblStatus.Text = "Status : -";

            // grpKonsumsi
            this.grpKonsumsi.BackColor = System.Drawing.Color.FromArgb(38, 38, 34);
            this.grpKonsumsi.Controls.Add(this.dgvKonsumsi);
            this.grpKonsumsi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpKonsumsi.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.grpKonsumsi.Location = new System.Drawing.Point(10, 192);
            this.grpKonsumsi.Name = "grpKonsumsi";
            this.grpKonsumsi.Size = new System.Drawing.Size(978, 200);
            this.grpKonsumsi.TabIndex = 4;
            this.grpKonsumsi.TabStop = false;
            this.grpKonsumsi.Text = "Data Konsumsi";

            this.dgvKonsumsi.AllowUserToAddRows = false;
            this.dgvKonsumsi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKonsumsi.BackgroundColor = System.Drawing.Color.FromArgb(32, 32, 28);
            this.dgvKonsumsi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKonsumsi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKonsumsi.EnableHeadersVisualStyles = false;
            this.dgvKonsumsi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvKonsumsi.GridColor = System.Drawing.Color.FromArgb(70, 65, 40);
            this.dgvKonsumsi.Location = new System.Drawing.Point(10, 22);
            this.dgvKonsumsi.Name = "dgvKonsumsi";
            this.dgvKonsumsi.ReadOnly = true;
            this.dgvKonsumsi.RowHeadersVisible = false;
            this.dgvKonsumsi.RowTemplate.Height = 26;
            this.dgvKonsumsi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKonsumsi.Size = new System.Drawing.Size(956, 165);
            this.dgvKonsumsi.TabIndex = 0;

            System.Windows.Forms.DataGridViewCellStyle headerStyleK = new System.Windows.Forms.DataGridViewCellStyle();
            headerStyleK.BackColor = System.Drawing.Color.FromArgb(180, 140, 20);
            headerStyleK.ForeColor = System.Drawing.Color.FromArgb(28, 28, 28);
            headerStyleK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvKonsumsi.ColumnHeadersDefaultCellStyle = headerStyleK;
            this.dgvKonsumsi.ColumnHeadersHeight = 30;
            this.dgvKonsumsi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            System.Windows.Forms.DataGridViewCellStyle rowStyleK = new System.Windows.Forms.DataGridViewCellStyle();
            rowStyleK.BackColor = System.Drawing.Color.FromArgb(38, 36, 28);
            rowStyleK.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            rowStyleK.SelectionBackColor = System.Drawing.Color.FromArgb(212, 175, 55);
            rowStyleK.SelectionForeColor = System.Drawing.Color.FromArgb(28, 28, 28);
            this.dgvKonsumsi.DefaultCellStyle = rowStyleK;

            System.Windows.Forms.DataGridViewCellStyle altStyleK = new System.Windows.Forms.DataGridViewCellStyle();
            altStyleK.BackColor = System.Drawing.Color.FromArgb(48, 46, 36);
            altStyleK.ForeColor = System.Drawing.Color.FromArgb(220, 200, 140);
            this.dgvKonsumsi.AlternatingRowsDefaultCellStyle = altStyleK;

            // grpAktivitas
            this.grpAktivitas.BackColor = System.Drawing.Color.FromArgb(38, 38, 34);
            this.grpAktivitas.Controls.Add(this.dgvAktivitas);
            this.grpAktivitas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpAktivitas.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.grpAktivitas.Location = new System.Drawing.Point(10, 400);
            this.grpAktivitas.Name = "grpAktivitas";
            this.grpAktivitas.Size = new System.Drawing.Size(978, 175);
            this.grpAktivitas.TabIndex = 5;
            this.grpAktivitas.TabStop = false;
            this.grpAktivitas.Text = "Data Aktivitas";

            this.dgvAktivitas.AllowUserToAddRows = false;
            this.dgvAktivitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAktivitas.BackgroundColor = System.Drawing.Color.FromArgb(32, 32, 28);
            this.dgvAktivitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAktivitas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAktivitas.EnableHeadersVisualStyles = false;
            this.dgvAktivitas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvAktivitas.GridColor = System.Drawing.Color.FromArgb(70, 65, 40);
            this.dgvAktivitas.Location = new System.Drawing.Point(10, 22);
            this.dgvAktivitas.Name = "dgvAktivitas";
            this.dgvAktivitas.ReadOnly = true;
            this.dgvAktivitas.RowHeadersVisible = false;
            this.dgvAktivitas.RowTemplate.Height = 26;
            this.dgvAktivitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAktivitas.Size = new System.Drawing.Size(956, 140);
            this.dgvAktivitas.TabIndex = 0;

            System.Windows.Forms.DataGridViewCellStyle headerStyleA = new System.Windows.Forms.DataGridViewCellStyle();
            headerStyleA.BackColor = System.Drawing.Color.FromArgb(180, 140, 20);
            headerStyleA.ForeColor = System.Drawing.Color.FromArgb(28, 28, 28);
            headerStyleA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvAktivitas.ColumnHeadersDefaultCellStyle = headerStyleA;
            this.dgvAktivitas.ColumnHeadersHeight = 30;
            this.dgvAktivitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            System.Windows.Forms.DataGridViewCellStyle rowStyleA = new System.Windows.Forms.DataGridViewCellStyle();
            rowStyleA.BackColor = System.Drawing.Color.FromArgb(38, 36, 28);
            rowStyleA.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            rowStyleA.SelectionBackColor = System.Drawing.Color.FromArgb(212, 175, 55);
            rowStyleA.SelectionForeColor = System.Drawing.Color.FromArgb(28, 28, 28);
            this.dgvAktivitas.DefaultCellStyle = rowStyleA;

            System.Windows.Forms.DataGridViewCellStyle altStyleA = new System.Windows.Forms.DataGridViewCellStyle();
            altStyleA.BackColor = System.Drawing.Color.FromArgb(48, 46, 36);
            altStyleA.ForeColor = System.Drawing.Color.FromArgb(220, 200, 140);
            this.dgvAktivitas.AlternatingRowsDefaultCellStyle = altStyleA;

            // panelBottom
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(38, 36, 28);
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBottom.Controls.Add(this.lblJmlData);
            this.panelBottom.Controls.Add(this.btnCetak);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 635);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1000, 50);
            this.panelBottom.TabIndex = 6;

            this.lblJmlData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblJmlData.ForeColor = System.Drawing.Color.FromArgb(140, 130, 80);
            this.lblJmlData.Location = new System.Drawing.Point(12, 15);
            this.lblJmlData.Name = "lblJmlData";
            this.lblJmlData.Size = new System.Drawing.Size(700, 18);
            this.lblJmlData.TabIndex = 0;
            this.lblJmlData.Text = "Belum ada data dimuat.";

            this.btnCetak.BackColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.btnCetak.Enabled = false;
            this.btnCetak.FlatAppearance.BorderSize = 0;
            this.btnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCetak.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCetak.ForeColor = System.Drawing.Color.FromArgb(28, 28, 28);
            this.btnCetak.Location = new System.Drawing.Point(840, 10);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(145, 32);
            this.btnCetak.TabIndex = 1;
            this.btnCetak.Text = "Cetak Laporan";
            this.btnCetak.UseVisualStyleBackColor = false;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);

            // FormRekap
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(28, 28, 24);
            this.ClientSize = new System.Drawing.Size(1000, 685);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.grpAktivitas);
            this.Controls.Add(this.grpKonsumsi);
            this.Controls.Add(this.panelRingkasan);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelGoldAccent);
            this.Controls.Add(this.panelSubHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormRekap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rekap & Cetak Laporan Harian — AMKH";
            this.Load += new System.EventHandler(this.FormRekap_Load);
            this.panelSubHeader.ResumeLayout(false);
            this.panelSubHeader.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelRingkasan.ResumeLayout(false);
            this.grpKonsumsi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKonsumsi)).EndInit();
            this.grpAktivitas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktivitas)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelSubHeader;
        private System.Windows.Forms.Label lblPageIcon;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Panel panelGoldAccent;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Panel panelRingkasan;
        private System.Windows.Forms.Label lblRingkasanJudul;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label lblTotalMasuk;
        private System.Windows.Forms.Label lblTotalTerbakar;
        private System.Windows.Forms.Label lblKaloriBersih;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpKonsumsi;
        private System.Windows.Forms.DataGridView dgvKonsumsi;
        private System.Windows.Forms.GroupBox grpAktivitas;
        private System.Windows.Forms.DataGridView dgvAktivitas;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label lblJmlData;
        private System.Windows.Forms.Button btnCetak;
    }
}