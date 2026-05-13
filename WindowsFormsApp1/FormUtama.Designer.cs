namespace WindowsFormsApp1
{
    partial class FormUtama
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
            this.SuspendLayout();
            // 
            // FormUtama
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "FormUtama";
            this.Load += new System.EventHandler(this.FormUtama_Load);
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