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
    public partial class ListaDisciplina : Form
    {
        public ListaDisciplina()
        {
            InitializeComponent();
        }

        private void ListaDisciplina_Load(object sender, EventArgs e)
        {
            DisciplinaController disciplinaController = new DisciplinaController();
            dataGridView1.DataSource = disciplinaController.ListarTodosD();
        }
    }
}
