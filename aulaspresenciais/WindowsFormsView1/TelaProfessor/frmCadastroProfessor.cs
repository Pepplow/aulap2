using Controller;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsView1.TelaProfessor
{
    public partial class frmCadastroProfessor : Form
    {
        public frmCadastroProfessor()
        {
            InitializeComponent();
        }

        private void btnSalvarP_Click(object sender, EventArgs e)
        {
            Professor novoProfessor = new Professor();
            novoProfessor.nomep = txtnomep.Text;
            novoProfessor.cpf = int.Parse(txtCPF.Text);
            novoProfessor.matriculap = int.Parse(txtMatriculaP.Text);

            ProfessorController professorController = new ProfessorController();
            professorController.inserirp(novoProfessor);

            txtnomep.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtMatriculaP.Text = string.Empty;
            MessageBox.Show("Professor Cadastrado Com Sucesso!");


        }

        private void btnCancelarP_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
