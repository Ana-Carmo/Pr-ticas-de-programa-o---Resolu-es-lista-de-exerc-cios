using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lista01Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, peso1, nota2, peso2, nota3, peso3, mediaP;
            
            Console.Write("Digite a nota 01: ");
            nota1 = double.Parse(Console.ReadLine());
            
            Console.Write("Digite o peso da nota 01: ");
            peso1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota 02: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o peso da nota 02: ");
            peso2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota 03: ");
            nota3 = double.Parse(Console.ReadLine());

            Console.Write("Digite o peso da nota 02: ");
            peso3 = double.Parse(Console.ReadLine());

            mediaP = ((nota1 * peso1) + (nota2 * peso2) + (nota3 * peso3)) / (peso1 + peso2 + peso3);

            Console.WriteLine("A média ponderada é " + mediaP.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
