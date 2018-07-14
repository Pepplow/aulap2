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
    public partial class frmDeletarProfessor : Form
    {
        public frmDeletarProfessor()
        {
            InitializeComponent();
        }

        private void frmDeletarProfessor_Load(object sender, EventArgs e)
        {
            ProfessorController professorController = new ProfessorController();
            dataGridView1.DataSource = professorController.ListarTodosP();
        }

        private void btnDeletarP_Click(object sender, EventArgs e)
        {
            Professor delp = new Professor()
            {
                IDProfessor = int.Parse(txtIDP.Text)
            };

            ProfessorController professorController = new ProfessorController();
            professorController.ExcluirP(delp.IDProfessor);
            MessageBox.Show("O Professor de ID: " + delp.IDProfessor + " Foi deletado!");
            Close();
            frmDeletarProfessor dp = new frmDeletarProfessor();
            dp.Show();
        }
    }
}
