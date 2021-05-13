using System;
using System.Globalization;

namespace Lista02Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, media;

            Console.Write("Informe a nota 01: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a nota 02: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a nota 03: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("Média do aluno: " + media.ToString("F2", CultureInfo.InvariantCulture));

            if (media >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else if (media >= 3 && media < 7)
            {
                Console.WriteLine("Exame");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }

            Console.ReadKey();
        }
    }
}
