using System;

namespace ValidacaoLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario = "Alan";
            string senha = "admin";

            Console.WriteLine("Digite o usuario: ");
            string usuarioDigitado = Console.ReadLine();
            Console.WriteLine("Digite a senha: ");
            string senhaDigitada = Console.ReadLine();

            if (usuario == usuarioDigitado && senha == senhaDigitada)
            {
                Console.WriteLine($"{usuarioDigitado}, Login sucess!");
            }
            else
            {
                Console.WriteLine($"{usuarioDigitado}, Failed login.");
            }
            Console.ReadKey();
        }
    }
}

           //int numero = int.Parse(Console.ReadLine());
