using System;

namespace Lista02Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o segundo número, maior que o primeiro: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o terceiro número, maior que o primeiro e o segundo: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe um quarto número qualquer: ");
            int num4 = Convert.ToInt32(Console.ReadLine());

            if (num4 > num3)
            {
                Console.Write($"{num4}, {num3}, {num2} e {num1}");
            }
            else if (num4 > num2)
            {
                Console.Write($"{num3}, {num4}, {num2} e {num1}");
            }
            else if (num4 > num1)
            {
                Console.WriteLine($"{num3}, {num2}, {num4} e {num1}");
            }
            else
            {
                Console.WriteLine($"{num3}, {num2}, {num1} e {num4}");
            }

            Console.ReadLine();
        }
    }
}
