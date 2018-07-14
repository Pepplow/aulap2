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
    public partial class frmResultadoProcura : Form
    {
        public frmResultadoProcura()
        {
            InitializeComponent();
        }

        private void frmResultadoProcura_Load(object sender, EventArgs e)
        {
            AlunosController alunosController = new AlunosController();

        }
    }
}
