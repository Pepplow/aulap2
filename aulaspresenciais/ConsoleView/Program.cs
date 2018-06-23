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
            Aluno a = CadastrarAluno();
            ImprimirDados(a);
            //Cadastrar Alunos
            AlunosController alunoscontroller = new AlunosController();
            alunoscontroller.inserir(a);

            
            Aluno b = CadastrarAluno();
            alunoscontroller.inserir(b);
            Aluno c = CadastrarAluno();
            alunoscontroller.inserir(c);

            foreach(Aluno aluno in alunoscontroller.ListarTodos())
            {
                ImprimirDados(aluno);
            }



            Console.ReadKey();
        }

        private static void ImprimirDados(Aluno a)
        {
            Console.WriteLine("Aluno : " + a.nome);
            Console.WriteLine("Matricula: " + a.matricula);
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
    }
}
