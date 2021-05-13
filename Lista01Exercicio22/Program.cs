using System;
using System.Globalization;

namespace Lista01Exercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o número de lados do polígano: ");
            int lados = Convert.ToInt32(Console.ReadLine());

            int numLados = lados * (lados - 3) / 2;

            Console.WriteLine("O polígono possui " + numLados + " diagonais.");

            Console.ReadKey();

        }
    }
}
