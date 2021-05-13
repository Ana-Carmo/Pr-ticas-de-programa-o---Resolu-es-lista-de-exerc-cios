using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lista01Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o primeiro número positivo diferente de 0:");
            double numero1 = double.Parse(Console.ReadLine());

            while (numero1 <= 0)
            {
                Console.Write("Número inválido!! Informe novamente o primeiro número positivo e diferente de 0: ");
                numero1 = double.Parse(Console.ReadLine());
            }

            Console.Write("Informe o segundo número positivo diferente de 0:");
            double numero2 = double.Parse(Console.ReadLine());

            while (numero2 <= 0)
            {
                Console.Write("Número inválido!! Informe novamente o segundo número positivo e diferente de 0: ");
                numero2 = double.Parse(Console.ReadLine());
            }

            double numeroE = Math.Pow(numero1, numero2);
            Console.WriteLine("O primeiro número elevado pelo segundo número é igual a: " + numeroE.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
