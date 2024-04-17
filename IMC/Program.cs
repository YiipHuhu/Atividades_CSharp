using System;
using System.Xml.Serialization;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu peso: EX: '70,5'");
            float peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a sua altura: EX: '1,70' ");
            float altura = float.Parse(Console.ReadLine());

            float imc = peso / (altura * altura);

            switch (imc)
            {
            case < 18:
                Console.WriteLine("Abaixo do peso");
                break;
            case >= 18 and < 25:
                Console.WriteLine("Peso normal");
                break;
            case >= 25 and < 30:
                Console.WriteLine("Sobrepeso");
                break;
            case >= 30 and < 35:
                Console.WriteLine("Obesidade grau 1");
                break;
            case >= 35 and < 40:
                Console.WriteLine("Obesidade grau 2");
                break;
            case >= 40:
                Console.WriteLine("Obesidade grau 3");
                break;
            default:
                Console.WriteLine("Valor inválido");
                break;
            }
            Console.WriteLine($"Seu IMC é: {imc}");
            
            Console.ReadKey();
        }
    }
}
/*
            Console.WriteLine("Digite seu peso: EX: '70,5' ");
            float peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a sua altura: ");
            float altura = float.Parse(Console.ReadLine());
            float imc = peso / (altura * altura);

            //usando if e else if pra fazer e testar
            
            if (imc <18){
            Console.WriteLine("Abaixo do peso");
            }
            else if (imc >=18 && imc <=25){
            Console.WriteLine("Peso normal");
            }
            else if (imc >25 && imc <=30){
            Console.WriteLine("Sobrepeso");
            }
            else if (imc >30 && imc <=35){
            Console.WriteLine("Obesidade grau 1");
            }
            else if (imc >35 && imc <=40){
            Console.WriteLine("Obesidade grau 2");
            }
            else if (imc >40){
            Console.WriteLine("Obesidade grau 3");
            }
            Console.WriteLine($"Seu IMC é: {imc}");
            
            Console.ReadKey();
        }
    }
}
*/