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
    }
}
