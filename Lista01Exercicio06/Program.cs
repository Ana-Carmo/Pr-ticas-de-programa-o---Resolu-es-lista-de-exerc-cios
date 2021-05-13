using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lista01Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a base do triângulo: ");
            double baseT = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura do triângulo: ");
            double alturaT = double.Parse(Console.ReadLine());

            double area = (baseT * alturaT) / 2;

            Console.WriteLine("A área do triângulo é: " + area.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
