using Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.DAL
{
    public class Contexto : DbContext
    {
        public Contexto() : base("strCon")
        {
          
        }
        public DbSet<Aluno> Alunos { get; set; } //Tabela Alunos    
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Professor> Professors { get; set; }
    }

}
