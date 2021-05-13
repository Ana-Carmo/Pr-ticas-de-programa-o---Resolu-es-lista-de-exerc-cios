using System;
using System.Globalization;

namespace Lista01Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número positivo diferente de 0: ");
            double numero = double.Parse(Console.ReadLine());

            while (numero <= 0)
            {
                Console.Write("Informe um número positivo e diferente de 0: ");
                numero = double.Parse(Console.ReadLine());
            }

            double numeroQ = Math.Pow(numero, 2);
            Console.WriteLine("Seu número ao quadrado é igual a: " + numeroQ.ToString("F2", CultureInfo.InvariantCulture));

            double numeroC = Math.Pow(numero, 3);
            Console.WriteLine("Seu número ao cubo é igual a: " + numeroC.ToString("F2", CultureInfo.InvariantCulture));

            double numeroRq = Math.Sqrt(numero);
            Console.WriteLine("A raíz quadrada do seu número é igual a: " + numeroRq.ToString("F2", CultureInfo.InvariantCulture));

            double numeroRc = Math.Sqrt(numero / 3);
            Console.WriteLine("A raíz cúbica do seu número é igual a: " + numeroRc.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
