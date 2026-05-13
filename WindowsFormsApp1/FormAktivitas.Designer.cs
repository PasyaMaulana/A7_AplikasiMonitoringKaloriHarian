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
            this.SuspendLayout();
            // 
            // FormAktivitas
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "FormAktivitas";
            this.Load += new System.EventHandler(this.FormAktivitas_Load);
            this.ResumeLayout(false);

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