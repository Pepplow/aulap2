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
    public partial class frmProcurarAluno : Form
    {
        public frmProcurarAluno()
        {
            InitializeComponent();
        }

        private void btnProcura_Click(object sender, EventArgs e)
        {
            Aluno buscar = new Aluno()
            {
                AlunoID = int.Parse(txtID.Text)
            };
            AlunosController alunosController = new AlunosController();
            alunosController.BuscarPorID(buscar.AlunoID);
           
        }
    }
}
