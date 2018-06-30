
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Controller;

namespace ConsoleView
{
    class Program
    {
        static void Main(string[] args)
        {
            
      
            Console.WriteLine("-----------------------------LISTA DE CADASTRO DE ALUNOS, PROFESSORES E DISCIPLINAS----------------------------\n");

            //Cadastrar Alunos
            AlunosController alunoscontroller = new AlunosController();

            Console.WriteLine("----------------------");
            Console.WriteLine("Cadastro de Alunos");
            Console.WriteLine("----------------------");

            Console.WriteLine("-Insira o Primeiro Aluno-");
            Aluno a = CadastrarAluno();
            alunoscontroller.inserir(a);
            Console.WriteLine("\n-Insira o Segundo Aluno-");
            Aluno b = CadastrarAluno();
            alunoscontroller.inserir(b);
            Console.WriteLine("\n-Insira o Terceiro Aluno-");
            Aluno c = CadastrarAluno();
            alunoscontroller.inserir(c);
            Console.Clear();


            Console.WriteLine("-----------------------------LISTA DE CADASTRO DE ALUNOS, PROFESSORES E DISCIPLINAS----------------------------\n");
            //Cadastrar Professor

            ProfessorController professorcontroller = new ProfessorController();

            Console.WriteLine("-------------------------");
            Console.WriteLine("Cadastro de Professores");
            Console.WriteLine("-------------------------");

            Console.WriteLine("-Insira o Primeiro Professor-");
            Professor d = CadastrarProfessor();
            professorcontroller.inserir(d);
            Console.WriteLine("\n-Insira o Segundo Professor-");
            Professor e = CadastrarProfessor();
            professorcontroller.inserir(e);
            Console.WriteLine("\n-Insira o Terceiro Professor-");
            Professor f = CadastrarProfessor();
            professorcontroller.inserir(f);
            Console.Clear();

            //Cadastrar Disciplina
            Console.WriteLine("-----------------------------LISTA DE CADASTRO DE ALUNOS, PROFESSORES E DISCIPLINAS----------------------------\n");

            DisciplinaController disciplinaController = new DisciplinaController();

            Console.WriteLine("-------------------------");
            Console.WriteLine("Cadastro de Disciplinas");
            Console.WriteLine("-------------------------");

            Console.WriteLine("-Insira a Primeira Disciplina-");
            Disciplina g = CadastrarDisciplina();
            disciplinaController.inserir(g);

            Console.WriteLine("-Insira a Segunda Disciplina-");
            Disciplina h = CadastrarDisciplina();
            disciplinaController.inserir(h);



            //Imprimindo Dados Aluno           
            Console.Clear();
            Console.WriteLine("Segue abaixo a lista de 'alunos' cadastrados");
            foreach (Aluno aluno in alunoscontroller.ListarTodos())
            {
                ImprimirDados(aluno);
            }
            //Imprimindo Dados Professor
            
            Console.WriteLine("\nSegue abaixo a lista de 'Professores' cadastrados");
            foreach (Professor professor in professorcontroller.ListarTodos())
            {
                ImprimirDadosP(professor);
            }
            //Imprimindo Dados Disciplina
            
            Console.WriteLine("\nSegue abaixo a lista de 'Disciplinas' cadastradas");
            foreach (Disciplina disciplina in disciplinaController.ListarTodos())
            {
                ImprimirDadosD(disciplina);
            }

            Console.ReadKey();
        }

        private static void ImprimirDados(Aluno a)
        {
            Console.WriteLine("\nAluno : " + a.nome);
            Console.WriteLine("Matricula: " + a.matricula);
        }

        private static void ImprimirDadosP(Professor d)
        {
            Console.WriteLine("\nProfessor : " + d.nomep);
            Console.WriteLine("Matricula: " + d.matriculap);
        }

        private static void ImprimirDadosD(Disciplina g)
        {
            Console.WriteLine("\nProfessor : " + g.id);
            Console.WriteLine("Matricula: " + g.nome);
        }

        private static Aluno CadastrarAluno()
        {
            Aluno a = new Aluno();

            Console.Write("Digite o nome do aluno: ");
            a.nome = Console.ReadLine();
            Console.Write("Digite a matricula do aluno: ");
            a.matricula = int.Parse(Console.ReadLine());
            return a;
        }

        private static Professor CadastrarProfessor()
        {
            Professor d = new Professor();

            Console.Write("Digite o nome do Professor: ");
            d.nomep = Console.ReadLine();
            Console.Write("Digite a matricula do Professor: ");
            d.matriculap = int.Parse(Console.ReadLine());
            return d;
        } 
        
        private static Disciplina CadastrarDisciplina()
        {
            Disciplina g = new Disciplina();
     
            Console.Write("Digite o id da Disciplina: ");
            g.id = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome da disciplina: ");
            g.nome = Console.ReadLine();
            return g;



        }

        
         }
        
}
    
