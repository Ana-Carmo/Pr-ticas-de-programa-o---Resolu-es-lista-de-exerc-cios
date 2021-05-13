using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lista01Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe uma medida em pés: ");
            double pes = Convert.ToDouble(Console.ReadLine());

            double polegadas = pes * 12;
            double jardas = pes / 3 * 1;
            double milhas = jardas / 1760;

            Console.WriteLine("Medida informada: " + pes + " pés");
            Console.WriteLine("Em polegadas: " + polegadas);
            Console.WriteLine("Em jardas: " + jardas.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em milhas: " + milhas.ToString("F5", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
