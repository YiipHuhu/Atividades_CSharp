using System;

namespace exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o exercicio: ");
            Console.WriteLine("1 - Classificação de Idade");
            Console.WriteLine("2 - Validação de cadastro");
            Console.WriteLine("3 - Calculadora Simples+");
            Console.WriteLine("4 - Conversor de temperatura");
            Console.WriteLine("5 - Calculadora de IMC");
            Console.WriteLine("6 - Classificar vogais e consoantes");
            Console.WriteLine("7 - Calculadora de Descontos");
            Console.WriteLine("8 - Sorteador de números");
            
            int exercicio = int.Parse(Console.ReadLine());
            
            if (exercicio == 1){
                Console.WriteLine("Digite sua idade: ");
                int idade = int.Parse(Console.ReadLine());
                if (idade >= 18){
                    Console.WriteLine("Você é maior de idade");
                }else if (idade < 18){
                    Console.WriteLine("Você é menor de idade");
                }
                else if (idade >=70){
                    Console.WriteLine("Você é idoso");
                }
            }
            if (exercicio == 2){
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
            if (exercicio == 3){
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

            
            if (exercicio == 4){
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
            if (exercicio == 5){
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
            if (exercicio == 6){
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
            
            if (exercicio == 7){

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
            if (exercicio == 8){
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
                    Console.ReadKey();
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
            Console.ReadKey();
        }
                        
            }
        }
    }
}


