using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lista01Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Infome a altura de cada degrau em centímetros: ");
            double altDegrau = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a altura que deseja alcançar em centímetros: ");
            double altTotal = Convert.ToDouble(Console.ReadLine());

            double degrausTotal = altTotal / altDegrau;
            Console.Write("A sua escada terá " + degrausTotal.ToString("F0", CultureInfo.InvariantCulture) + " degraus");

            Console.ReadKey();
        }
    }
}
