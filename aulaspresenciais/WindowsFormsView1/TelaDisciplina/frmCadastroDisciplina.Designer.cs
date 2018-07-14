namespace WindowsFormsView1.TelaDisciplina
{
    partial class frmCadastroDisciplina
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDisciplinad = new System.Windows.Forms.TextBox();
            this.txtCargaHoraria = new System.Windows.Forms.TextBox();
            this.txtProfessord = new System.Windows.Forms.TextBox();
            this.btnSalvarD = new System.Windows.Forms.Button();
            this.btnCancelarD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Disciplina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carga Horaria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Professor";
            // 
            // txtDisciplinad
            // 
            this.txtDisciplinad.Location = new System.Drawing.Point(15, 46);
            this.txtDisciplinad.Name = "txtDisciplinad";
            this.txtDisciplinad.Size = new System.Drawing.Size(179, 20);
            this.txtDisciplinad.TabIndex = 3;
            // 
            // txtCargaHoraria
            // 
            this.txtCargaHoraria.Location = new System.Drawing.Point(13, 97);
            this.txtCargaHoraria.Name = "txtCargaHoraria";
            this.txtCargaHoraria.Size = new System.Drawing.Size(181, 20);
            this.txtCargaHoraria.TabIndex = 4;
            // 
            // txtProfessord
            // 
            this.txtProfessord.Location = new System.Drawing.Point(13, 143);
            this.txtProfessord.Name = "txtProfessord";
            this.txtProfessord.Size = new System.Drawing.Size(181, 20);
            this.txtProfessord.TabIndex = 5;
            // 
            // btnSalvarD
            // 
            this.btnSalvarD.Location = new System.Drawing.Point(13, 194);
            this.btnSalvarD.Name = "btnSalvarD";
            this.btnSalvarD.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarD.TabIndex = 6;
            this.btnSalvarD.Text = "Salvar";
            this.btnSalvarD.UseVisualStyleBackColor = true;
            this.btnSalvarD.Click += new System.EventHandler(this.btnSalvarD_Click);
            // 
            // btnCancelarD
            // 
            this.btnCancelarD.Location = new System.Drawing.Point(119, 193);
            this.btnCancelarD.Name = "btnCancelarD";
            this.btnCancelarD.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarD.TabIndex = 7;
            this.btnCancelarD.Text = "Cancelar";
            this.btnCancelarD.UseVisualStyleBackColor = true;
            // 
            // frmCadastroDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 261);
            this.Controls.Add(this.btnCancelarD);
            this.Controls.Add(this.btnSalvarD);
            this.Controls.Add(this.txtProfessord);
            this.Controls.Add(this.txtCargaHoraria);
            this.Controls.Add(this.txtDisciplinad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastroDisciplina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroDisciplina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDisciplinad;
        private System.Windows.Forms.TextBox txtCargaHoraria;
        private System.Windows.Forms.TextBox txtProfessord;
        private System.Windows.Forms.Button btnSalvarD;
        private System.Windows.Forms.Button btnCancelarD;
    }
}