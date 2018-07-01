using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class AlunosController
    {
        List<Aluno> TabelaAlunos = new List<Aluno>();

        public void inserir(Aluno a)
        {
            TabelaAlunos.Add(a);
        }
        public List<Aluno> ListarTodos()
        {
            return TabelaAlunos;
        }
        public void Delete(Aluno a)
        {
            TabelaAlunos.Remove(a);
        }
    }
}
