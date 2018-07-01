
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



            /*Imprimindo Dados Aluno           
            Console.Clear();
            Console.WriteLine("-----ALUNOS CADASTRADOS------");
            foreach (Aluno aluno in alunoscontroller.ListarTodos())
            {
                ImprimirDados(aluno);
            }
            //Imprimindo Dados Professor

            Console.WriteLine("\n-------PROFESSORES CADASTRADOS-------");
            foreach (Professor professor in professorcontroller.ListarTodos())
            {
                ImprimirDadosP(professor);
            }
            //Imprimindo Dados Disciplina

            Console.WriteLine("\n------DISCIPLINAS CADASTRADAS-------");
            foreach (Disciplina disciplina in disciplinaController.ListarTodos())
            {
                ImprimirDadosD(disciplina);
            }*/
            //deletar aluno
            Console.Clear();
            int opcao;
            do
            {
                Console.WriteLine("--------------------MENU DE OPÇÔES-------------");
                Console.WriteLine("1 - Deletar o Aluno na primeira posição", a);
                Console.WriteLine("2 - Deletar o Aluno na Segunda posição", b);
                Console.WriteLine("3 - Deletar o Aluno na Terceira posição", c);
                Console.WriteLine("4 - Para listar 'Alunos'");
                Console.WriteLine("5 - Para listar 'Professores'");
                Console.WriteLine("6 - Para listar 'Disciplinas'");
                Console.WriteLine("0 - Para Finalizar");
                Console.WriteLine("Digite a opção que deseja: ");
                opcao = Int32.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        alunoscontroller.Delete(a);                        
                        break;
                    case 2:
                        alunoscontroller.Delete(b);                       
                        break;
                    case 3:
                        alunoscontroller.Delete(c);                        
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("-----ALUNOS CADASTRADOS------");
                        Console.WriteLine("Sua lista de alunos foi Atualizada!");
                        foreach (Aluno aluno in alunoscontroller.ListarTodos())
                        {
                            ImprimirDados(aluno);
                        }
                        Console.WriteLine("\nAperte 'Enter' Para Voltar ao Menu!");
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("\n-------PROFESSORES CADASTRADOS-------");
                        foreach (Professor professor in professorcontroller.ListarTodos())
                        {
                            ImprimirDadosP(professor);
                        }
                        Console.WriteLine("\nAperte 'Enter' Para Voltar ao Menu!");
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("\n-------DISCIPLINAS CADASTRADaS-------");
                        foreach (Disciplina disciplina in disciplinaController.ListarTodos())
                        {
                            ImprimirDadosD(disciplina);
                        }
                        Console.WriteLine("\nAperte 'Enter' Para Voltar ao Menu!");
                        break;
                }
                Console.ReadKey();
                Console.Clear();

            } while (opcao != 0);

            foreach (Aluno aluno in alunoscontroller.ListarTodos())
            {
                ImprimirDados(aluno);
            }



          
        }

        private static void ImprimirDados(Aluno a)
        {
            Console.WriteLine("\nAluno: " + a.nome);
            Console.WriteLine("Matricula: " + a.matricula);
            
        }

        private static void ImprimirDadosP(Professor d)
        {
            Console.WriteLine("\nProfessor: " + d.nomep);
            Console.WriteLine("Matricula: " + d.matriculap);
        }

        private static void ImprimirDadosD(Disciplina g)
        {
            Console.WriteLine("\nID:  " + g.id);
            Console.WriteLine("Disciplina: " + g.nome);
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
    
