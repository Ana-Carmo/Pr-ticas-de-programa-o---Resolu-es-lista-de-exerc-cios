using System;

namespace Lista03Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, h, a;
            do
            {
                Console.Write("Informe a base do triângulo: ");
                b = Convert.ToDouble(Console.ReadLine());
            } while (b <= 0);

            do
            {
                Console.Write("Informe a altura do triângulo: ");
                h = Convert.ToDouble(Console.ReadLine());
            } while (h <= 0);

            a = b * h / 2;

            Console.Write("Área do triângulo é " + a);

            Console.ReadKey();

        }
    }
}
