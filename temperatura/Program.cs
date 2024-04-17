using System;

namespace ValidacaoLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            float celsius = 0;
            float fahren = 0;

            Console.WriteLine("Digite: ");
            Console.WriteLine("A = Para converter de Celsius para Fahrenheit");
            Console.WriteLine("B = Para converter de Fahrenheit para Celsius");
            string opcao = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite a temperatura: ");
            float tempDigitado = float.Parse(Console.ReadLine());

            switch (opcao)
            {
                case "A":
                    fahren = (tempDigitado * 9 / 5) + 32;
                    Console.WriteLine($"A temperatura em Fahrenheit é: {fahren}");
                    break;
                case "B":
                    celsius = (tempDigitado - 32) * 5 / 9;
                    Console.WriteLine($"A temperatura em Celsius é: {celsius}");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
            Console.ReadKey();
        }
    }
}
