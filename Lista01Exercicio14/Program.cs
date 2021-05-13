using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lista01Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número real: ");
            double num = Convert.ToDouble(Console.ReadLine());

            double numAbaixo = Math.Floor(num);
            Console.WriteLine($"A parte inteira do número é {numAbaixo}");

            double numFrac = num - numAbaixo;
            Console.WriteLine($"A parte fracionada do número é {numFrac.ToString("F2", CultureInfo.InvariantCulture)}");

            num = Math.Round(num);
            Console.WriteLine($"O número arredondado é {num}");

            Console.ReadKey();
        }
    }
}
