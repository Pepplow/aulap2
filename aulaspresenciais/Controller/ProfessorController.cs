using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;


namespace Controller
{
    public class ProfessorController
    {
        List<Professor> TabelaProfessor = new List<Professor>();

        public void inserir(Professor a)
        {
            TabelaProfessor.Add(a);
        }
        public List<Professor> ListarTodos()
        {
            return TabelaProfessor; 
        }
    }
}
