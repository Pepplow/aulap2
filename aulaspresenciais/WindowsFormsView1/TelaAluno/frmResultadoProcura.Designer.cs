namespace WindowsFormsView1.TelaAluno
{
    partial class frmResultadoProcura
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
            this.dgvProcura = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcura)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProcura
            // 
            this.dgvProcura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcura.Location = new System.Drawing.Point(235, 108);
            this.dgvProcura.Name = "dgvProcura";
            this.dgvProcura.Size = new System.Drawing.Size(240, 150);
            this.dgvProcura.TabIndex = 0;
            // 
            // frmResultadoProcura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvProcura);
            this.Name = "frmResultadoProcura";
            this.Text = "frmResultadoProcura";
            this.Load += new System.EventHandler(this.frmResultadoProcura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProcura;
    }
}