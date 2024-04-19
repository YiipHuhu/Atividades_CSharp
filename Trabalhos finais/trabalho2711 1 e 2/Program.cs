using System;

namespace Taffe3010
{
    class Program
    {
        static string[] codigos = new string[10];
        static string[] nomes = new string[10];
        static string[] descricoes = new string[10];
        static double[] precos = new double[10];
        static int[] estoque = new int[10]; 
        static int quantidadeProdutosCadastrados = 0;

        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Pesquisar por Código do Produto");
                Console.WriteLine("3 - Pesquisar por Nome do Produto");
                Console.WriteLine("4 - Listar produtos cadastrados");
                Console.WriteLine("5 - Alterar produto");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            CadastrarProduto();
                            break;
                        case 2:
                            PesquisarPorCodigo();
                            break;
                        case 3:
                            PesquisarPorNome();
                            break;
                        case 4:
                            ListarProdutos();
                            break;
                        case 5:
                            AlterarProdutos();
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

        static void CadastrarProduto()
        {
            if (quantidadeProdutosCadastrados >= 10)
            {
                Console.WriteLine("Cadastro Completo. Não é possível cadastrar mais produtos.");
                return;
            }

            Console.WriteLine("Cadastro de Produto:");
            Console.Write("Nome do Produto: ");
            string nome = Console.ReadLine();
            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();
            Console.Write("Preço: R$");
            if (double.TryParse(Console.ReadLine(), out double preco))
            {
                Console.Write("Quantidade em estoque: ");
                if (int.TryParse(Console.ReadLine(), out int quantidade))
                {
                    codigos[quantidadeProdutosCadastrados] = (quantidadeProdutosCadastrados + 1).ToString();
                    nomes[quantidadeProdutosCadastrados] = nome;
                    descricoes[quantidadeProdutosCadastrados] = descricao;
                    precos[quantidadeProdutosCadastrados] = preco;
                    estoque[quantidadeProdutosCadastrados] = quantidade;
                    quantidadeProdutosCadastrados++;
                    Console.WriteLine("Produto cadastrado com sucesso.");
                }
                else
                {
                    Console.WriteLine("Valor de quantidade em estoque inválido. O produto não foi cadastrado.");
                }
            }
            else
            {
                Console.WriteLine("Valor de preço inválido. O produto não foi cadastrado.");
            }
        }

    static void PesquisarPorCodigo()
    {
        if (quantidadeProdutosCadastrados == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado até o momento.");
            return;
        }

        Console.Write("Digite o código do produto: ");
        string codigo = Console.ReadLine();
        int index = Array.IndexOf(codigos, codigo);

        if (index >= 0)
        {
            Console.WriteLine($"Código: {codigos[index]}, Nome: {nomes[index]}, Descrição: {descricoes[index]}, Preço: R${precos[index]}");
        }
        else
        {
            Console.WriteLine("Código Inexistente.");
        }
    }

    static void PesquisarPorNome()
    {
        if (quantidadeProdutosCadastrados == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado até o momento.");
            return;
        }

        Console.Write("Digite o nome do produto: ");
        string nome = Console.ReadLine();
        int index = Array.IndexOf(nomes, nome);

        if (index >= 0)
        {
            Console.WriteLine($"Código: {codigos[index]}, Nome: {nomes[index]}, Descrição: {descricoes[index]}, Preço: R${precos[index]}");
        }
        else
        {
            Console.WriteLine("Produto Inexistente.");
        }
    }

    static void ListarProdutos()
    {
        if (quantidadeProdutosCadastrados == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado até o momento.");
            return;
        }

        Console.WriteLine("Produtos cadastrados até o momento:");
        for (int i = 0; i < quantidadeProdutosCadastrados; i++)
        {
            Console.WriteLine(nomes[i]);
        }
    }

    static void AlterarProdutos()
    {
        if (quantidadeProdutosCadastrados == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado até o momento.");
            return;
        }

        Console.Write("Digite o nome do produto: ");
        string nome = Console.ReadLine();
        int index = Array.IndexOf(nomes, nome);

        if (index >= 0)
        {
            Console.WriteLine($"Código: {codigos[index]}, Nome: {nomes[index]}, Descrição: {descricoes[index]}, Preço: R${precos[index]}");
            Console.WriteLine("Deseja alterar esse produto? S/N");
            string resp = Console.ReadLine().ToUpper();
            if (resp == "S")
            {
                Console.WriteLine("Cadastro de Produto:");
                Console.Write("Nome do Produto: ");
                string novonome = Console.ReadLine();
                Console.Write("Descrição: ");
                string novadescricao = Console.ReadLine();
                Console.Write("Preço: R$");
                if (double.TryParse(Console.ReadLine(), out double novopreco))
                {
                    nomes[index] = novonome;
                    descricoes[index] = novadescricao;
                    precos[index] = novopreco;
                    Console.WriteLine("Produto alterado com sucesso.");
                }
        else
        {
            Console.WriteLine("Valor de preço inválido. O produto não foi cadastrado.");
        }
            }
        }
        else
        {
            Console.WriteLine("Produto Inexistente.");
        }
    }
}
}




/* v2

namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        string[] nomes = new string[10];
        string[] desc = new string[10];
        int[] codigo = new int[10];
        double[] preco = new double[10];

        while (true)
        {
        Console.WriteLine("Software de mercado");
        Console.WriteLine("1- Cadastrar produto");
        Console.WriteLine("2- Pesquisar por código do produto");
        Console.WriteLine("3- Pesquisar por nome do produto");
        Console.WriteLine("4- Listar produtos");

        

        int atividade = int.Parse(Console.ReadLine());

        if (atividade == 1)
        {
            while(true){

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o nome do {i + 1}º produto: ");
                nomes[i] = Console.ReadLine();
                Console.Write($"Digite a descrição do {i + 1}º produto: ");
                desc[i] = Console.ReadLine();
                Console.Write($"Digite o Valor do {i + 1}º produto: ");
                preco[i] = double.Parse(Console.ReadLine());
                codigo[i] = i + 1;
                if (i == 9)
                {
                    Console.WriteLine("Limite de produtos cadastrados atingido");
                    break;
                }
                else
                {
                    Console.WriteLine("Produto cadastrado com sucesso");
                }
            }

            }   
        }
        else if (atividade == 2)
        {
        
        }
    }
}
}*/

// v1
/* teste


while (true)
            {
                Console.Write("Digite um nome para pesquisar: ");
                string Pesquisado = Console.ReadLine();
                int ocorrencias = 0;

                for (int i = 0; i < 5; i++)
                {
                    if (nomes[i].Equals(Pesquisado, StringComparison.OrdinalIgnoreCase))
                    {
                        ocorrencias++;
                    }
                }

                Console.WriteLine($"O nome '{Pesquisado}' apareceu {ocorrencias} vezes.");

                Console.Write("Deseja realizar outra pesquisa? (S/N): ");
                string resposta = Console.ReadLine();

                if (resposta.ToLower() != "s")
                {
                    break;
                }
                */