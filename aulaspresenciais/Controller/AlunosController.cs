using Controller.DAL;
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
        Contexto contexto = new Contexto();
        //List<Aluno> TabelaAlunos = new List<Aluno>();

        public void inserir(Aluno novoAluno)
        {
            contexto.Alunos.Add(novoAluno);
            contexto.SaveChanges();
            //TabelaAlunos.Add(a);
        }

        public List<Aluno> ListarTodos()
        {
            return contexto.Alunos.ToList();
        }

        public Aluno BuscarPorMatricula(int matricula)
        {
            var aluno = (Aluno)from a in contexto.Alunos
                                 where a.Matricula == matricula
                                 select a;
            return (Aluno)aluno;
        }

        public Aluno BuscarPorID(int AlunoID)
        {
            return contexto.Alunos.Find(AlunoID);
        }

        public void Atualizar(Aluno aluno)
        {
            contexto.Entry(aluno).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Excluir(int AlunoID)
        {
            Aluno aluno = BuscarPorID(AlunoID);
            contexto.Alunos.Remove(aluno);
            contexto.SaveChanges();
        }
     
    }
}
