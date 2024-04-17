using System;

namespace TesteVogalConsoante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma letra: ");
            string letra = Console.ReadLine();

            if (letra == "1" || letra == "2" || letra == "3" || letra == "4" || letra == "5" || letra == "6" || letra == "7" || letra == "8" || letra == "9" || letra == "0")
            {
                Console.WriteLine("O valor digitado é um número");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
            }

            else if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
            {
                Console.WriteLine("A letra digitada é uma vogal");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
            }
            else
            {
                Console.WriteLine("A letra digitada é uma consoante");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
            }

            Console.ReadKey();
                Console.Clear();
                Main(args);
        }
    }
}