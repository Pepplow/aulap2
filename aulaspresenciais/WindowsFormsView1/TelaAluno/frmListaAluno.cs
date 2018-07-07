using Controller;
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
    public partial class frmListaAluno : Form
    {
        public frmListaAluno()
        {
            InitializeComponent();
        }

        private void frmListaAluno_Load(object sender, EventArgs e)
        {
            AlunosController alunoscontroller = new AlunosController();
            dgvAlunos.DataSource = alunoscontroller.ListarTodos();
        }
    }
}
