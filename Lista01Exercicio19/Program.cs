using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lista01Exercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o valor do cateto oposto: ");
            double catetoOposto = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o valor do cateto adjacente: ");
            double catetoAdjacente = Convert.ToDouble(Console.ReadLine());

            double hipotenusa = Math.Sqrt((Math.Pow(catetoOposto, 2) + Math.Pow(catetoAdjacente, 2)));

            Console.Write("O valor da hipotenusa é igual a " + hipotenusa.ToString("F2", CultureInfo.InvariantCulture));
            
            Console.ReadKey();
        }

    }
}
