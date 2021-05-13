using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lista02Exercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a sua altura em cm: ");
            double h = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o seu sexo (m/f): ");
            char s = Convert.ToChar(Console.ReadLine());

            if (s == 'm')
            {
                double peso = (72 * h/100) - 58;
                Console.WriteLine("Seu peso ideal é: " + peso.ToString("F1"));
            } else
            {
                double peso = (62.1 * h/100) - 44.7;
                Console.WriteLine("Seu peso ideal é: " + peso.ToString("F1"));
            }

            Console.ReadKey();

        }
    }
}
