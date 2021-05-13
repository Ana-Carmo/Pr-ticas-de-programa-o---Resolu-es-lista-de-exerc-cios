using System;

namespace Lista02Exercicio05
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

            if (num1 < num2 && num1 < num3 && num2 < num3)
            {
                Console.WriteLine($"{num1}, {num2} e {num3}");
            }
            else if (num1 < num2 && num1 < num3 && num3 < num2)
            {
                Console.WriteLine($"{num1}, {num3} e {num2}");
            }
            else if (num2 < num1 && num2 < num3 && num1 < num3)
            {
                Console.WriteLine($"{num2}, {num1} e {num3}");
            }
            else if (num2 < num1 && num2 < num3 && num3 < num1)
            {
                Console.WriteLine($"{num2}, {num3} e {num1}");
            }
            else if (num3 < num1 && num3 < num2 && num1 < num2)
            {
                Console.WriteLine($"{num3}, {num1} e {num2}");
            }
            else if (num3 < num1 && num3 < num2 && num2 < num1)
            {
                Console.WriteLine($"{num3}, {num2} e {num1}");
            }

            Console.ReadKey();
        }
    }
}
