using System;
using System.Globalization;

namespace Lista02Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            double notaTL, notaAS, notaEF, pesoTL = 2, pesoAS = 3, pesoEF = 5, mediaPonderada;
            
            Console.Write("Informe a nota do trabalho de laboratório (0 - 10): ");
            notaTL = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a nota da avaliação semestral (0 - 10): ");
            notaAS = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a nota do exame final (0 - 10): ");
            notaEF = Convert.ToDouble(Console.ReadLine());

            mediaPonderada = (notaTL * pesoTL + notaAS * pesoAS + notaEF * pesoEF) / (pesoTL + pesoAS + pesoEF);

            Console.WriteLine("Média Ponderado do aluno: " + mediaPonderada.ToString("F2", CultureInfo.InvariantCulture));

            if (mediaPonderada >= 8)
            {
                Console.WriteLine("Conceito: A");

            }
            else if (mediaPonderada >= 7 && mediaPonderada < 8)
            {
                Console.WriteLine("Conceito: B");
            }
            else if (mediaPonderada >= 6 && mediaPonderada < 7)
            {

                Console.WriteLine("Conceito: C");
            }
            else if (mediaPonderada >= 5 && mediaPonderada < 6)
            {
                Console.WriteLine("Conceito: D");
            }
            else
            {
                Console.WriteLine("Conceito: E");
            }

            Console.ReadKey();

        }
    }
}
