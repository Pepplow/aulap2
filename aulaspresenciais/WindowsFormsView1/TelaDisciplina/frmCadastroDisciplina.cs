using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Modelos;

namespace WindowsFormsView1.TelaDisciplina
{
    public partial class frmCadastroDisciplina : Form
    {
        public frmCadastroDisciplina()
        {
            InitializeComponent();
        }

        private void btnSalvarD_Click(object sender, EventArgs e)
        {
            Disciplina novaDisciplina = new Disciplina();
            novaDisciplina.Disciplinad = txtDisciplinad.Text;
            novaDisciplina.CargaHoraria = int.Parse(txtCargaHoraria.Text);
            novaDisciplina.ProfessorD = txtProfessord.Text;

            DisciplinaController disciplinaController = new DisciplinaController();
            disciplinaController.inserird(novaDisciplina);
            txtDisciplinad.Text = string.Empty;
            txtCargaHoraria.Text = string.Empty;
            txtProfessord.Text = string.Empty;
            MessageBox.Show("Disciplina Cadastrado Com Sucesso!");
        }
    }
}
