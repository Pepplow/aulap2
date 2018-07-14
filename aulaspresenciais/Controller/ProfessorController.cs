using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller.DAL;
using Modelos;


namespace Controller
{
    public class ProfessorController
    {
        Contexto contexto = new Contexto();

        public void inserirp(Professor novoProfessor)
        {
            contexto.Professors.Add(novoProfessor);
            contexto.SaveChanges();
        }

        public List<Professor> ListarTodosP()
        {
            return contexto.Professors.ToList();
        }
        public Professor BuscarPorIDP(int IDProfessor)
        {
            return contexto.Professors.Find(IDProfessor);
        }

        public void ExcluirP(int IDProfessor)
        {
            Professor professor = BuscarPorIDP(IDProfessor);
            contexto.Professors.Remove(professor);
            contexto.SaveChanges();
        }

    }
}
