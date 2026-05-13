namespace AMKH_TESTING
{
    partial class FormUtama
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblStatusKoneksi = new System.Windows.Forms.Label();
            this.panelGoldLine = new System.Windows.Forms.Panel();
            this.panelNavbar = new System.Windows.Forms.Panel();
            this.btnNavKonsumsi = new System.Windows.Forms.Button();
            this.btnNavAktivitas = new System.Windows.Forms.Button();
            this.btnNavRiwayat = new System.Windows.Forms.Button();
            this.panelKonten = new System.Windows.Forms.Panel();

            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.panelNavbar.SuspendLayout();
            this.SuspendLayout();

            // ── panelHeader ──────────────────────────────
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(28, 28, 24);
            this.panelHeader.Controls.Add(this.pictureLogo);
            this.panelHeader.Controls.Add(this.lblJudul);
            this.panelHeader.Controls.Add(this.lblStatusKoneksi);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1100, 80);
            this.panelHeader.TabIndex = 0;

            // ── pictureLogo ──────────────────────────────
            this.pictureLogo.Image = global::AMKH_TESTING.Properties.Resources._30579cc699708d1_removebg_preview;
            this.pictureLogo.Location = new System.Drawing.Point(15, 8);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(64, 64);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;

            // ── lblJudul ─────────────────────────────────
            this.lblJudul.AutoSize = false;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblJudul.Location = new System.Drawing.Point(90, 22);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(500, 36);
            this.lblJudul.TabIndex = 1;
            this.lblJudul.Text = "Aplikasi Monitoring Kalori Harian";
            this.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── lblStatusKoneksi ─────────────────────────
            this.lblStatusKoneksi.AutoSize = true;
            this.lblStatusKoneksi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatusKoneksi.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblStatusKoneksi.Location = new System.Drawing.Point(900, 32);
            this.lblStatusKoneksi.Name = "lblStatusKoneksi";
            this.lblStatusKoneksi.Size = new System.Drawing.Size(60, 15);
            this.lblStatusKoneksi.TabIndex = 2;
            this.lblStatusKoneksi.Text = "● Memeriksa...";

            // ── panelGoldLine ────────────────────────────
            this.panelGoldLine.BackColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.panelGoldLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGoldLine.Location = new System.Drawing.Point(0, 80);
            this.panelGoldLine.Name = "panelGoldLine";
            this.panelGoldLine.Size = new System.Drawing.Size(1100, 3);
            this.panelGoldLine.TabIndex = 1;

            // ── panelNavbar ──────────────────────────────
            this.panelNavbar.BackColor = System.Drawing.Color.FromArgb(35, 34, 28);
            this.panelNavbar.Controls.Add(this.btnNavKonsumsi);
            this.panelNavbar.Controls.Add(this.btnNavAktivitas);
            this.panelNavbar.Controls.Add(this.btnNavRiwayat);
            this.panelNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavbar.Location = new System.Drawing.Point(0, 83);
            this.panelNavbar.Name = "panelNavbar";
            this.panelNavbar.Size = new System.Drawing.Size(1100, 46);
            this.panelNavbar.TabIndex = 2;

            // ── btnNavKonsumsi ───────────────────────────
            this.btnNavKonsumsi.BackColor = System.Drawing.Color.FromArgb(50, 50, 45);
            this.btnNavKonsumsi.FlatAppearance.BorderSize = 0;
            this.btnNavKonsumsi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavKonsumsi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavKonsumsi.ForeColor = System.Drawing.Color.FromArgb(200, 185, 120);
            this.btnNavKonsumsi.Location = new System.Drawing.Point(0, 0);
            this.btnNavKonsumsi.Name = "btnNavKonsumsi";
            this.btnNavKonsumsi.Size = new System.Drawing.Size(160, 46);
            this.btnNavKonsumsi.TabIndex = 0;
            this.btnNavKonsumsi.Text = "🍽  Konsumsi";
            this.btnNavKonsumsi.UseVisualStyleBackColor = false;
            this.btnNavKonsumsi.Click += new System.EventHandler(this.btnNavKonsumsi_Click);

            // ── btnNavAktivitas ──────────────────────────
            this.btnNavAktivitas.BackColor = System.Drawing.Color.FromArgb(50, 50, 45);
            this.btnNavAktivitas.FlatAppearance.BorderSize = 0;
            this.btnNavAktivitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavAktivitas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavAktivitas.ForeColor = System.Drawing.Color.FromArgb(200, 185, 120);
            this.btnNavAktivitas.Location = new System.Drawing.Point(160, 0);
            this.btnNavAktivitas.Name = "btnNavAktivitas";
            this.btnNavAktivitas.Size = new System.Drawing.Size(160, 46);
            this.btnNavAktivitas.TabIndex = 1;
            this.btnNavAktivitas.Text = "⚡  Aktivitas";
            this.btnNavAktivitas.UseVisualStyleBackColor = false;
            this.btnNavAktivitas.Click += new System.EventHandler(this.btnNavAktivitas_Click);

            // ── btnNavRiwayat ────────────────────────────
            this.btnNavRiwayat.BackColor = System.Drawing.Color.FromArgb(50, 50, 45);
            this.btnNavRiwayat.FlatAppearance.BorderSize = 0;
            this.btnNavRiwayat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavRiwayat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavRiwayat.ForeColor = System.Drawing.Color.FromArgb(200, 185, 120);
            this.btnNavRiwayat.Location = new System.Drawing.Point(320, 0);
            this.btnNavRiwayat.Name = "btnNavRiwayat";
            this.btnNavRiwayat.Size = new System.Drawing.Size(160, 46);
            this.btnNavRiwayat.TabIndex = 2;
            this.btnNavRiwayat.Text = "📜  Riwayat";
            this.btnNavRiwayat.UseVisualStyleBackColor = false;
            this.btnNavRiwayat.Click += new System.EventHandler(this.btnNavRiwayat_Click);

            // ── panelKonten ──────────────────────────────
            this.panelKonten.BackColor = System.Drawing.Color.FromArgb(28, 28, 24);
            this.panelKonten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKonten.Location = new System.Drawing.Point(0, 129);
            this.panelKonten.Name = "panelKonten";
            this.panelKonten.Size = new System.Drawing.Size(1100, 571);
            this.panelKonten.TabIndex = 3;

            // ── FormUtama ────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(28, 28, 24);
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.panelKonten);
            this.Controls.Add(this.panelNavbar);
            this.Controls.Add(this.panelGoldLine);
            this.Controls.Add(this.panelHeader);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "FormUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AMKH — Aplikasi Monitoring Kalori Harian";
            this.Load += new System.EventHandler(this.FormUtama_Load);

            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.panelNavbar.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblStatusKoneksi;
        private System.Windows.Forms.Panel panelGoldLine;
        private System.Windows.Forms.Panel panelNavbar;
        private System.Windows.Forms.Button btnNavKonsumsi;
        private System.Windows.Forms.Button btnNavAktivitas;
        private System.Windows.Forms.Button btnNavRiwayat;
        private System.Windows.Forms.Panel panelKonten;
    }
}