namespace AMKH
{
    partial class FormDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.panelSubHeader = new System.Windows.Forms.Panel();
            this.lblPageIcon = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.panelGoldAccent = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.lblMasuk = new System.Windows.Forms.Label();
            this.lblTerbakar = new System.Windows.Forms.Label();
            this.lblBersih = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.chartKalori = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelSubHeader.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartKalori)).BeginInit();
            this.SuspendLayout();

            // panelSubHeader
            this.panelSubHeader.BackColor = System.Drawing.Color.FromArgb(38, 36, 28);
            this.panelSubHeader.Controls.Add(this.lblPageIcon);
            this.panelSubHeader.Controls.Add(this.lblPageTitle);
            this.panelSubHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubHeader.Location = new System.Drawing.Point(0, 0);
            this.panelSubHeader.Name = "panelSubHeader";
            this.panelSubHeader.Size = new System.Drawing.Size(1050, 50);
            this.panelSubHeader.TabIndex = 0;

            // lblPageIcon
            this.lblPageIcon.AutoSize = true;
            this.lblPageIcon.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblPageIcon.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblPageIcon.Location = new System.Drawing.Point(12, 10);
            this.lblPageIcon.Name = "lblPageIcon";
            this.lblPageIcon.TabIndex = 0;
            this.lblPageIcon.Text = "📊";

            // lblPageTitle
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblPageTitle.Location = new System.Drawing.Point(50, 13);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(300, 26);
            this.lblPageTitle.TabIndex = 1;
            this.lblPageTitle.Text = "Dashboard Kalori";

            // panelGoldAccent
            this.panelGoldAccent.BackColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.panelGoldAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGoldAccent.Location = new System.Drawing.Point(0, 50);
            this.panelGoldAccent.Name = "panelGoldAccent";
            this.panelGoldAccent.Size = new System.Drawing.Size(1050, 3);
            this.panelGoldAccent.TabIndex = 1;

            // panelInfo
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(42, 42, 38);
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Controls.Add(this.lblTanggal);
            this.panelInfo.Controls.Add(this.lblTarget);
            this.panelInfo.Controls.Add(this.lblMasuk);
            this.panelInfo.Controls.Add(this.lblTerbakar);
            this.panelInfo.Controls.Add(this.lblBersih);
            this.panelInfo.Controls.Add(this.lblStatus);
            this.panelInfo.Controls.Add(this.btnRefresh);
            this.panelInfo.Location = new System.Drawing.Point(9, 60);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1027, 110);
            this.panelInfo.TabIndex = 2;

            // lblTanggal
            this.lblTanggal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTanggal.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblTanggal.Location = new System.Drawing.Point(10, 10);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(600, 24);
            this.lblTanggal.TabIndex = 0;
            this.lblTanggal.Text = "📅 ...";

            // lblTarget
            this.lblTarget.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTarget.ForeColor = System.Drawing.Color.FromArgb(200, 185, 120);
            this.lblTarget.Location = new System.Drawing.Point(10, 40);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(300, 18);
            this.lblTarget.TabIndex = 1;
            this.lblTarget.Text = "Target Hari Ini : -";

            // lblMasuk
            this.lblMasuk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMasuk.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblMasuk.Location = new System.Drawing.Point(10, 62);
            this.lblMasuk.Name = "lblMasuk";
            this.lblMasuk.Size = new System.Drawing.Size(300, 18);
            this.lblMasuk.TabIndex = 2;
            this.lblMasuk.Text = "Kalori Masuk    : -";

            // lblTerbakar
            this.lblTerbakar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTerbakar.ForeColor = System.Drawing.Color.FromArgb(120, 200, 120);
            this.lblTerbakar.Location = new System.Drawing.Point(320, 62);
            this.lblTerbakar.Name = "lblTerbakar";
            this.lblTerbakar.Size = new System.Drawing.Size(300, 18);
            this.lblTerbakar.TabIndex = 3;
            this.lblTerbakar.Text = "Kalori Terbakar : -";

            // lblBersih
            this.lblBersih.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBersih.ForeColor = System.Drawing.Color.FromArgb(200, 185, 120);
            this.lblBersih.Location = new System.Drawing.Point(320, 40);
            this.lblBersih.Name = "lblBersih";
            this.lblBersih.Size = new System.Drawing.Size(300, 18);
            this.lblBersih.TabIndex = 4;
            this.lblBersih.Text = "Kalori Bersih   : -";

            // lblStatus
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblStatus.Location = new System.Drawing.Point(10, 84);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(600, 22);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status : -";

            // btnRefresh
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(180, 140, 20);
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(28, 28, 28);
            this.btnRefresh.Location = new System.Drawing.Point(900, 38);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 32);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "🔄 Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // chartKalori
            chartArea1.Name = "ChartArea1";
            this.chartKalori.BackColor = System.Drawing.Color.FromArgb(38, 36, 28);
            this.chartKalori.ChartAreas.Add(chartArea1);
            this.chartKalori.Location = new System.Drawing.Point(9, 178);
            this.chartKalori.Name = "chartKalori";
            this.chartKalori.Size = new System.Drawing.Size(1027, 450);
            this.chartKalori.TabIndex = 3;

            // FormDashboard
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(28, 28, 24);
            this.ClientSize = new System.Drawing.Size(1050, 650);
            this.Controls.Add(this.chartKalori);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelGoldAccent);
            this.Controls.Add(this.panelSubHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.Name = "FormDashboard";
            this.Text = "Dashboard Kalori";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.panelSubHeader.ResumeLayout(false);
            this.panelSubHeader.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartKalori)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelSubHeader;
        private System.Windows.Forms.Label lblPageIcon;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Panel panelGoldAccent;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label lblMasuk;
        private System.Windows.Forms.Label lblTerbakar;
        private System.Windows.Forms.Label lblBersih;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKalori;
    }
}