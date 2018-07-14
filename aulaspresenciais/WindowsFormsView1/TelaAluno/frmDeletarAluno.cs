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

namespace WindowsFormsView1.TelaAluno
{
    public partial class frmDeletarAluno : Form
    {
        public frmDeletarAluno()
        {
            InitializeComponent();
        }

        private void frmDeletarAluno_Load(object sender, EventArgs e)
        {
            AlunosController alunosController = new AlunosController();
            dataGridView1.DataSource = alunosController.ListarTodos();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Aluno delete = new Aluno
            {
                AlunoID = int.Parse(txtDeletar.Text)
            };


            AlunosController alunosController = new AlunosController();
            alunosController.Excluir(delete.AlunoID);
            MessageBox.Show("O Aluno de ID: " + delete.AlunoID + " Foi deletado!");
            Close();
            frmDeletarAluno dd = new frmDeletarAluno();
            dd.Show();
        }
    }
}
