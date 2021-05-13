using System;

namespace Lista03Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0, mult;
            Console.Write("Digite um número: ");
            double n = Convert.ToDouble(Console.ReadLine());

            while (x <= 10)
            {
                mult = n * x;

                Console.WriteLine(n + " X " + x + " = " + mult);

                x += 1;
            }

            Console.ReadKey();
        }
    }
}
