using System;

namespace Lista02Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escolha umas das opções do menu:");
            Console.WriteLine("1 - Somar dois número");
            Console.WriteLine("2 - Raiz quadrada de um número.");
            Console.Write("Digite a opção desejada: ");

            int opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1)
            {
                Console.Write("Informe o primeiro número: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Informe o segundo número: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int soma = num1 + num2;

                Console.Write("A soma do dois número é: " + soma);
            }
            else if (opcao == 2)
            {
                Console.Write("Informe um número: ");
                double num1 = Convert.ToInt32(Console.ReadLine());

                double raiz = Math.Sqrt(num1);

                Console.Write("A raiz quadrada do número é: " + raiz.ToString("F2"));
            } else
            {
                Console.WriteLine("Opção inválida.");
            }
            Console.ReadKey();
        }
    }
}
