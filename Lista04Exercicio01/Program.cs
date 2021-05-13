using System;
using System.Globalization;

namespace Lista04Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            double [] notas = new double[5];
            double soma = 0, media, n = 5;

            Console.Write("Digite a nota de 5 alunos: ");
            string [] vetorNotas = Console.ReadLine().Split(',');

            for (int coluna = 0; coluna < n; coluna++)
            {
                notas[coluna] = Convert.ToDouble(vetorNotas[1]);
                soma += notas[coluna];
            }

            for (int coluna = 0; coluna < n; coluna++)
            {
                Console.Write(vetorNotas [coluna] + " ");
            }
            
            Console.WriteLine();

            media = soma / n;

            Console.WriteLine("A média das notas é: " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
