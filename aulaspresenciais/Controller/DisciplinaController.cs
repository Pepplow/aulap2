using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class DisciplinaController
    {
        List<Disciplina> TabelaDisciplina = new List<Disciplina>();

        public void inserir(Disciplina a)
        {
            TabelaDisciplina.Add(a);
        }
        public List<Disciplina> ListarTodos()
        {
            return TabelaDisciplina;
        }
    }
}
