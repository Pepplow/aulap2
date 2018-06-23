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

            Console.WriteLine("-----------------------------LISTA DE CADASTRO DE ALUNOS E PROFESSORES----------------------------\n");

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


            Console.WriteLine("-----------------------------LISTA DE CADASTRO DE ALUNOS E PROFESSORES----------------------------\n");
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

            //Imprimindo Dados            
            Console.Clear();
            Console.WriteLine("Segue abaixo a lista de 'alunos' cadastrados");
            foreach (Aluno aluno in alunoscontroller.ListarTodos())
            {
                ImprimirDados(aluno);
            }
            Console.WriteLine("\nSegue abaixo a lista de 'Professores' cadastrados");
            foreach (Professor professor in professorcontroller.ListarTodos())
            {
                ImprimirDadosP(professor);
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
    }
}
