using Controller.DAL;
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
        Contexto contexto = new Contexto();

        public void inserird(Disciplina novoDisciplina)
        {
            contexto.Disciplinas.Add(novoDisciplina);
            contexto.SaveChanges();

        }

        public List<Disciplina> ListarTodosD()
        {
            return contexto.Disciplinas.ToList();
        }

        public Disciplina BuscarPorIDD(int Idd)
        {
            return contexto.Disciplinas.Find(Idd);
        }

        public void ExcluirD(int Idd)
        {
            Disciplina disciplina = BuscarPorIDD(Idd);
            contexto.Disciplinas.Remove(disciplina);
            contexto.SaveChanges();
        }

    }

}

