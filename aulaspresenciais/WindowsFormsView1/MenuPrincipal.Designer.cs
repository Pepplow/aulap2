namespace WindowsFormsView1
{
    partial class MenuPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnListarAluno = new System.Windows.Forms.Button();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCadastrarP = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDeletarDisciplina = new System.Windows.Forms.Button();
            this.btnListarD = new System.Windows.Forms.Button();
            this.btnCadastrarDD = new System.Windows.Forms.Button();
            this.btnListarP = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeletar);
            this.groupBox1.Controls.Add(this.btnProcurar);
            this.groupBox1.Controls.Add(this.btnListarAluno);
            this.groupBox1.Controls.Add(this.btnCadastrarAluno);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(92, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aluno";
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(6, 127);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 3;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(6, 98);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 2;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // btnListarAluno
            // 
            this.btnListarAluno.Location = new System.Drawing.Point(6, 69);
            this.btnListarAluno.Name = "btnListarAluno";
            this.btnListarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnListarAluno.TabIndex = 1;
            this.btnListarAluno.Text = "Listar";
            this.btnListarAluno.UseVisualStyleBackColor = true;
            this.btnListarAluno.Click += new System.EventHandler(this.btnListarAluno_Click);
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.Location = new System.Drawing.Point(6, 40);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarAluno.TabIndex = 0;
            this.btnCadastrarAluno.Text = "Cadastrar";
            this.btnCadastrarAluno.UseVisualStyleBackColor = true;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnCadastrarAluno_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnListarP);
            this.groupBox2.Controls.Add(this.btnCadastrarP);
            this.groupBox2.Location = new System.Drawing.Point(110, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(90, 225);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Professor";
            // 
            // btnCadastrarP
            // 
            this.btnCadastrarP.Location = new System.Drawing.Point(7, 39);
            this.btnCadastrarP.Name = "btnCadastrarP";
            this.btnCadastrarP.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarP.TabIndex = 0;
            this.btnCadastrarP.Text = "Cadastrar";
            this.btnCadastrarP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrarP.UseVisualStyleBackColor = true;
            this.btnCadastrarP.Click += new System.EventHandler(this.btnCadastrarP_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDeletarDisciplina);
            this.groupBox3.Controls.Add(this.btnListarD);
            this.groupBox3.Controls.Add(this.btnCadastrarDD);
            this.groupBox3.Location = new System.Drawing.Point(206, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(86, 225);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Disciplina";
            // 
            // btnDeletarDisciplina
            // 
            this.btnDeletarDisciplina.Location = new System.Drawing.Point(6, 127);
            this.btnDeletarDisciplina.Name = "btnDeletarDisciplina";
            this.btnDeletarDisciplina.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarDisciplina.TabIndex = 2;
            this.btnDeletarDisciplina.Text = "Deletar";
            this.btnDeletarDisciplina.UseVisualStyleBackColor = true;
            this.btnDeletarDisciplina.Click += new System.EventHandler(this.btnDeletarDisciplina_Click);
            // 
            // btnListarD
            // 
            this.btnListarD.Location = new System.Drawing.Point(6, 68);
            this.btnListarD.Name = "btnListarD";
            this.btnListarD.Size = new System.Drawing.Size(75, 23);
            this.btnListarD.TabIndex = 1;
            this.btnListarD.Text = "Listar";
            this.btnListarD.UseVisualStyleBackColor = true;
            this.btnListarD.Click += new System.EventHandler(this.btnListarD_Click);
            // 
            // btnCadastrarDD
            // 
            this.btnCadastrarDD.Location = new System.Drawing.Point(6, 38);
            this.btnCadastrarDD.Name = "btnCadastrarDD";
            this.btnCadastrarDD.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarDD.TabIndex = 0;
            this.btnCadastrarDD.Text = "Cadastrar";
            this.btnCadastrarDD.UseVisualStyleBackColor = true;
            this.btnCadastrarDD.Click += new System.EventHandler(this.btnCadastrarDD_Click);
            // 
            // btnListarP
            // 
            this.btnListarP.Location = new System.Drawing.Point(7, 68);
            this.btnListarP.Name = "btnListarP";
            this.btnListarP.Size = new System.Drawing.Size(75, 23);
            this.btnListarP.TabIndex = 1;
            this.btnListarP.Text = "Listar";
            this.btnListarP.UseVisualStyleBackColor = true;
            this.btnListarP.Click += new System.EventHandler(this.btnListarP_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 485);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnListarAluno;
        private System.Windows.Forms.Button btnCadastrarAluno;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCadastrarP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCadastrarDD;
        private System.Windows.Forms.Button btnListarD;
        private System.Windows.Forms.Button btnDeletarDisciplina;
        private System.Windows.Forms.Button btnListarP;
    }
}