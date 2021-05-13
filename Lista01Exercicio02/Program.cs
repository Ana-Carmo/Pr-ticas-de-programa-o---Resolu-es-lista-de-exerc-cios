using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lista01Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, media;

            Console.Write("Digite a nota 01: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota 02: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota 03: ");
            nota3 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("A média das notas: " + nota1 + ", " + nota2 + " e "+ nota3 + " é: " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
