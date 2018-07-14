using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsView1.TelaDisciplina;
using WindowsFormsView1.TelaAluno;
using WindowsFormsView1.TelaProfessor;

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

        private void btnCadastrarDD_Click(object sender, EventArgs e)
        {
            frmCadastroDisciplina cadd = new frmCadastroDisciplina();
            cadd.Show();
        }

        private void btnListarD_Click(object sender, EventArgs e)
        {
            frmListaDisciplina listDisc = new frmListaDisciplina();
            listDisc.Show();
        }

        private void btnDeletarDisciplina_Click(object sender, EventArgs e)
        {
            frmDeletarDisciplina deldisc = new frmDeletarDisciplina();
            deldisc.Show();
        }

        private void btnCadastrarP_Click(object sender, EventArgs e)
        {
            frmCadastroProfessor cadprof = new frmCadastroProfessor();
            cadprof.Show();
        }

        private void btnListarP_Click(object sender, EventArgs e)
        {
            frmListaProfessor listprof = new frmListaProfessor();
            listprof.Show();
        }
    }
}
