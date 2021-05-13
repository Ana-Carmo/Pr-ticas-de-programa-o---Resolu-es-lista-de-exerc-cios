using System;

namespace Lista02Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o terceiro número: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 < num2 && num1 < num3)
            {
                Console.Write("O número menor é: " + num1);
            }
            else if (num2 < num1 && num2 < num3)
            {
                Console.WriteLine("O número menor é: " + num2);
            }
            else
            {
                Console.WriteLine("O número menor é: " + num3);
            }

            Console.ReadLine();
        }
    }
}
