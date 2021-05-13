using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lista01Exercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o custo do espetáculo: ");
            double espetaculo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o valor do convite: ");
            double convite = Convert.ToDouble(Console.ReadLine());

            double quantidadeConvites = espetaculo / convite;

            Console.WriteLine("Deverão ser vendidos, pelo menos, " + quantidadeConvites.ToString("F0", CultureInfo.InvariantCulture) + " convites para pagar o valor do espetáculo.");

            Console.ReadKey();
        }
    }
}
