using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int sorteado = random.Next(10);
        int vidas = 3;

        Console.WriteLine("Bem-vindo ao Sorteador de Números!");
        Console.WriteLine("Tente adivinhar o número de 0 a 9.");

        while (vidas > 0)
        {
            Console.Write("Digite sua resposta: ");
            int resposta;

            if (int.TryParse(Console.ReadLine(), out resposta))
            {
                if (resposta == sorteado)
                {
                    Console.WriteLine("Parabéns! Você acertou o número.");
                    Console.WriteLine($"O número sorteado foi: {sorteado}");
                    break;
                }
                else if (resposta < sorteado)
                {
                    Console.WriteLine("Tente novamente! O número sorteado é maior.");
                }
                else if (resposta > sorteado)
                {
                    Console.WriteLine("Tente novamente! O número sorteado é menor.");
                }

                vidas--;
                Console.WriteLine($"Tentativas restantes: {vidas}");
            }
            else
            {
                Console.WriteLine("Por favor, insira um número válido.");
            }
        }

        if (vidas == 0)
        {
            Console.WriteLine($"Você esgotou suas tentativas. O número sorteado era {sorteado}.");
        }
    }
}




        /* Extenso demais e desnecessário, usar o while é mais simples e eficiente alem de ser possivel criar um sistema de vidas
que comprime o codigo e o torna mais clean.
        
        inacabado pq eu nao sou maluco de fazer ate o fim kkskskskksskksk
        
        else if (resposta > sorteado)
        {
            Console.WriteLine("O numero esta acima do sorteado!" + "Restam 2 chances!");
            int resposta2 = int.Parse(Console.ReadLine());
            if (resposta2 == sorteado)
            {
                Console.WriteLine("Você ganhou!");
                Console.WriteLine($"O numero sorteado foi: {sorteado}");
                Console.ReadKey();
            }
            else if (resposta2 > sorteado)
            {
                Console.WriteLine("O numero esta acima do sorteado!"+ "Resta 1 chance !");
                int resposta3 = int.Parse(Console.ReadLine());
                if (resposta3 == sorteado)
                {
                    Console.WriteLine("Você ganhou!");
                    Console.WriteLine($"O numero sorteado foi: {sorteado}");
                    Console.ReadKey();
                }
                else if (resposta3 != sorteado)
                {
                    Console.WriteLine("Você perdeu!");
                    Console.WriteLine($"O numero sorteado foi: {sorteado}");
                    Console.ReadKey();
                }
            }
        }*/
    
