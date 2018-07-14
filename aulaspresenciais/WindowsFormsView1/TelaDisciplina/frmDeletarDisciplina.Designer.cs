namespace WindowsFormsView1.TelaDisciplina
{
    partial class frmDeletarDisciplina
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
            this.dgvdisciplinadel = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtidd = new System.Windows.Forms.TextBox();
            this.btnDeletarD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdisciplinadel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdisciplinadel
            // 
            this.dgvdisciplinadel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdisciplinadel.Location = new System.Drawing.Point(66, 59);
            this.dgvdisciplinadel.Name = "dgvdisciplinadel";
            this.dgvdisciplinadel.Size = new System.Drawing.Size(431, 150);
            this.dgvdisciplinadel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de disciplinas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite o ID: ";
            // 
            // txtidd
            // 
            this.txtidd.Location = new System.Drawing.Point(189, 216);
            this.txtidd.Name = "txtidd";
            this.txtidd.Size = new System.Drawing.Size(124, 20);
            this.txtidd.TabIndex = 3;
            // 
            // btnDeletarD
            // 
            this.btnDeletarD.Location = new System.Drawing.Point(319, 216);
            this.btnDeletarD.Name = "btnDeletarD";
            this.btnDeletarD.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarD.TabIndex = 4;
            this.btnDeletarD.Text = "Deletar";
            this.btnDeletarD.UseVisualStyleBackColor = true;
            this.btnDeletarD.Click += new System.EventHandler(this.btnDeletarD_Click);
            // 
            // frmDeletarDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 283);
            this.Controls.Add(this.btnDeletarD);
            this.Controls.Add(this.txtidd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvdisciplinadel);
            this.Name = "frmDeletarDisciplina";
            this.Text = "frmDeletarDisciplina";
            this.Load += new System.EventHandler(this.frmDeletarDisciplina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdisciplinadel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdisciplinadel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtidd;
        private System.Windows.Forms.Button btnDeletarD;
    }
}