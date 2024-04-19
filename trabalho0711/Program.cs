using System;

class Program
{
    static string[] RA = new string[10];
    static double[] mediaNotas = new double[10];
    static string[] cidade = new string[10];
    static int quantidadeAlunosCadastrados = 0;

    static void Main(string[] args)
    {
        int opcao;

        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Cadastrar Aluno");
            Console.WriteLine("2 - Pesquisar Aluno");
            Console.WriteLine("3 - Listar Alunos");
            Console.WriteLine("4 - Listar Média de Todos os Alunos");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 1:
                        CadastrarAluno();
                        break;
                    case 2:
                        PesquisarAluno();
                        break;
                    case 3:
                        ListarAlunos();
                        break;
                    case 4:
                        ListarMediaAlunos();
                        break;
                    case 0:
                        Console.WriteLine("Saindo do programa. Até logo!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
        } while (opcao != 0);
    }

    static void CadastrarAluno()
    {
        if (quantidadeAlunosCadastrados >= 10)
        {
            Console.WriteLine("Cadastro Completo. Não é possível cadastrar mais alunos.");
            return;
        }

        Console.WriteLine("Cadastro de Aluno:");
        Console.Write("Número de Registro Acadêmico (RA): ");
        string ra = Console.ReadLine();
        Console.Write("Nota 1: ");
        if (double.TryParse(Console.ReadLine(), out double nota1))
        {
            Console.Write("Nota 2: ");
            if (double.TryParse(Console.ReadLine(), out double nota2))
            {
                Console.Write("Cidade: ");
                string city = Console.ReadLine();
                double media = (nota1 + nota2) / 2;
                RA[quantidadeAlunosCadastrados] = ra;
                mediaNotas[quantidadeAlunosCadastrados] = media;
                cidade[quantidadeAlunosCadastrados] = city;
                quantidadeAlunosCadastrados++;
                Console.WriteLine("Aluno cadastrado com sucesso.");
            }
            else
            {
                Console.WriteLine("Valor de nota 2 inválido. O aluno não foi cadastrado.");
            }
        }
        else
        {
            Console.WriteLine("Valor de nota 1 inválido. O aluno não foi cadastrado.");
        }
    }

    static void PesquisarAluno()
    {
        if (quantidadeAlunosCadastrados == 0)
        {
            Console.WriteLine("Nenhum aluno cadastrado até o momento.");
            return;
        }

        Console.Write("Digite o RA do aluno: ");
        string ra = Console.ReadLine();
        int index = Array.IndexOf(RA, ra);

        if (index >= 0)
        {
            Console.WriteLine($"RA: {RA[index]}, Média de Notas: {mediaNotas[index]}, Cidade: {cidade[index]}");
        }
        else
        {
            Console.WriteLine("RA Inexistente.");
        }
    }

    static void ListarAlunos()
    {
        if (quantidadeAlunosCadastrados == 0)
        {
            Console.WriteLine("Nenhum aluno cadastrado até o momento.");
            return;
        }

        Console.WriteLine("Alunos cadastrados até o momento:");
        for (int i = 0; i < quantidadeAlunosCadastrados; i++)
        {
            Console.WriteLine(RA[i]);
        }
    }

    static void ListarMediaAlunos()
    {
        if (quantidadeAlunosCadastrados == 0)
        {
            Console.WriteLine("Nenhum aluno cadastrado até o momento.");
            return;
        }

        Console.WriteLine("Média de notas de todos os alunos:");
        for (int i = 0; i < quantidadeAlunosCadastrados; i++)
        {
            Console.WriteLine($"RA: {RA[i]}, Média de Notas: {mediaNotas[i]}");
        }
    }
}
