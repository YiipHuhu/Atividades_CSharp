using System;
using System.Collections;

namespace ValidacaoLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Operador: ");
            Console.WriteLine("A = Adição");
            Console.WriteLine("S = Subtração");
            Console.WriteLine("M = Multiplicação");
            Console.WriteLine("D = Divisão");
            Console.WriteLine("E = Exponenciação");
            Console.WriteLine("P = Porcentagem (se escolher porcentagem, o primeiro numero será o valor total e o segundo numero será a porcentagem que deseja saber)");
            Console.WriteLine("Exemplo: bolsa de R$300 e desconto de 15%, o desconto será R$45");
            string operador = Console.ReadLine().ToUpper(); //ToUpper() para deixar o texto em maiusculo
            Console.WriteLine("Digite o primeiro numero: ");
            float n1Digitado = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            float n2Digitado = float.Parse(Console.ReadLine());
            float resultado = 0;
            
            switch (operador) //uso de switch para deixar o codigo mais compacto pq ninguem merece escrever 300 else if
            {

            case "A":
                resultado = n1Digitado + n2Digitado;
                Console.WriteLine($"O resultado da soma é: {resultado}");
                break;

            case "S":
                resultado = n1Digitado - n2Digitado;
                Console.WriteLine($"O resultado da subtração é: {resultado}");
                break;

            case "M":
                resultado = n1Digitado * n2Digitado;
                Console.WriteLine($"O resultado da multiplicação é: {resultado}");
                break;

            case "D":
                resultado = n1Digitado / n2Digitado;
                Console.WriteLine($"O resultado da divisão é: {resultado}");
                break;
            
            case "E":
                double resultado1 = Math.Pow(n1Digitado, n2Digitado);
                //float resultado = n1Digitado ^ n2Digitado; nao realiza exponenciação com numeros float(use variavel double e Math.Pow)
                Console.WriteLine($"O resultado da exponenciação é: {resultado1}");
                break;

            case "P":
                resultado = (n1Digitado * n2Digitado) / 100;
                Console.WriteLine($"O resultado da porcentagem é: {resultado}");
                break;
            
            default:
                Console.WriteLine("Operador inválido");
                break;
            }
            Console.WriteLine("Continuar calculando? (S/N)");
            string resposta2 = Console.ReadLine().ToUpper();
            if (resposta2 == "S")
            {             
            Console.WriteLine("Digite o Operador: ");
            Console.WriteLine("A = Adição");
            Console.WriteLine("S = Subtração");
            Console.WriteLine("M = Multiplicação");
            Console.WriteLine("D = Divisão");
            Console.WriteLine("E = Exponenciação");
            Console.WriteLine("P = Porcentagem (se escolher porcentagem, o primeiro numero será o valor total e o segundo numero será a porcentagem que deseja saber)");
            Console.WriteLine("Exemplo: bolsa de R$300 e desconto de 15%, o desconto será R$45");
            string operador2 = Console.ReadLine().ToUpper();

            Console.WriteLine("Digite o novo numero: ");
            float n3Digitado = float.Parse(Console.ReadLine());

            switch (operador2)
            {
            case "A":
                float resultado3 = resultado + n3Digitado;
                Console.WriteLine($"O resultado da soma é: {resultado3}");
                break;

            case "S":
                resultado3 = resultado - n3Digitado;
                Console.WriteLine($"O resultado da subtração é: {resultado3}");
                break;

            case "M":
                resultado3 = resultado * n3Digitado;
                Console.WriteLine($"O resultado da multiplicação é: {resultado3}");
                break;

            case "D":
                resultado3 = resultado / n3Digitado;
                Console.WriteLine($"O resultado da divisão é: {resultado3}");
                break;

            case "E":
                double resultado4 = Math.Pow(resultado, n3Digitado);
                //float resultado = n1Digitado ^ n2Digitado; nao realiza exponenciação com numeros float(use variavel double e Math.Pow)
                Console.WriteLine($"O resultado da exponenciação é: {resultado4}");
                break;

            case "P":
                resultado3 = (resultado * n3Digitado) / 100;
                Console.WriteLine($"O resultado da porcentagem é: {resultado3}");
                break;

            default:
                Console.WriteLine("Operador inválido");
                break;
            }
            }
            else
            {
                Console.WriteLine("Obrigado por usar nossa calculadora!");
            }


            Console.WriteLine("Realizar uma nova operação? (S/N)");
            string resposta = Console.ReadLine().ToUpper();
            if (resposta == "S")
            {
                Console.Clear();
                Main(args);
            }
            else
            {
                Console.WriteLine("Obrigado por usar nossa calculadora!");
            }
            Console.ReadKey();
        }
    }
}
            /*
            ---------------------------------------------------------------------
            Usando if e else if, o codigo fica grande e bangunçado, mas funciona
            ---------------------------------------------------------------------
            if (operador == "A")
            {
                float resultado = n1Digitado + n2Digitado;
                Console.WriteLine($"O resultado da soma é: {resultado}");
            }
            else if (operador == "S")
            {
                float resultado = n1Digitado - n2Digitado;
                Console.WriteLine($"O resultado da subtração é: {resultado}");
            }
            else if (operador == "M")
            {
                float resultado = n1Digitado * n2Digitado;
                Console.WriteLine($"O resultado da multiplicação é: {resultado}");
            }
            else if (operador == "D")
            {
                float resultado = n1Digitado / n2Digitado;
                Console.WriteLine($"O resultado da divisão é: {resultado}");
            }
            else if (operador == "E")
            {
            double resultado = Math.Pow(n1Digitado, n2Digitado);
                //float resultado = n1Digitado ^ n2Digitado; nao realiza exponenciação com numeros float(use variavel double e Math.Pow)
                Console.WriteLine($"O resultado da exponenciação é: {resultado}");
            }
            else if (operador == "P")
            {
                float resultado = (n1Digitado * n2Digitado) / 100;
                Console.WriteLine($"O resultado da porcentagem é: {resultado}");
            }
            else
            {
                Console.WriteLine("Operador inválido");
                
            }
             Console.ReadKey();
            */
            
            
            
            
            
            
            /*if (usuario == usuarioDigitado && senha == senhaDigitada)
            {
                Console.WriteLine($"{usuarioDigitado}, Login sucess!");
            }
            else
            {
                Console.WriteLine($"{usuarioDigitado}, Failed login.");
            }
            Console.ReadKey();
            */

           //int numero = int.Parse(Console.ReadLine());
