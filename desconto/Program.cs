using System;

namespace Desconto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do produto: ");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do desconto: ");
            double desconto = double.Parse(Console.ReadLine());

            double valorDesconto = valor * (desconto / 100);
            double valorFinal = valor - valorDesconto;

            Console.WriteLine($"O valor do desconto é: {valorDesconto}");
            Console.WriteLine($"O valor final é: {valorFinal}");
            Console.WriteLine("Deseja calcular novamente? (S/N)");
            string resposta = Console.ReadLine().ToUpper();
            if (resposta == "S" || resposta == "s")
            {
                Console.Clear();
                Main(args);
            }
            else
            {
                Console.WriteLine("Obrigado por utilizar nosso sistema!");
            }
            Console.ReadKey();
        }
    }
}
