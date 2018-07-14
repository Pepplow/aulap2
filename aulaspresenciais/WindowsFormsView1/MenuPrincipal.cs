using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsView1.TelaAluno;


namespace WindowsFormsView1
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }


        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            frmCadastroAluno cadAluno = new frmCadastroAluno();
            cadAluno.Show();
        }

        private void btnListarAluno_Click(object sender, EventArgs e)
        {
            frmListaAluno listaAlunos = new frmListaAluno();
            listaAlunos.Show();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            frmProcurarAluno procaluno = new frmProcurarAluno();
            procaluno.Show();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            frmDeletarAluno delaluno = new frmDeletarAluno();
            delaluno.Show();
        }


    }
}
