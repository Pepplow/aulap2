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

namespace WindowsFormsView1.TelaDisciplina
{
    public partial class frmDeletarDisciplina : Form
    {
        public frmDeletarDisciplina()
        {
            InitializeComponent();
        }

        private void frmDeletarDisciplina_Load(object sender, EventArgs e)
        {
            DisciplinaController disciplinaController = new DisciplinaController();
            dgvdisciplinadel.DataSource = disciplinaController.ListarTodosD();
        }

        private void btnDeletarD_Click(object sender, EventArgs e)
        {
            Disciplina del = new Disciplina()
            {
                idd = int.Parse(txtidd.Text)
            };

            DisciplinaController disciplinaController = new DisciplinaController();
            disciplinaController.ExcluirD(del.idd);
            MessageBox.Show("Disciplina Excluida com Sucesso!");
            Close();
            frmDeletarDisciplina deld = new frmDeletarDisciplina();
            deld.Show();
        }
    }
}
