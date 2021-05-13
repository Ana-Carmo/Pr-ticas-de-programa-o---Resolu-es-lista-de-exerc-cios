using System;

namespace Lista01Exercicio23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a medida do angulo 1: ");
            double anguloUm = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a medida do angulo 2: ");
            double anguloDois = Convert.ToDouble(Console.ReadLine());

            double anguloTres = 180 - anguloUm - anguloDois;

            Console.Write("Medida do angulo 3: " + anguloTres + " graus");

            Console.ReadKey();
        }
    }
}
