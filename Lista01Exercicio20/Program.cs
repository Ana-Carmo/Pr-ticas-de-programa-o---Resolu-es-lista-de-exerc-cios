using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01Exercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o raio da esfera: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            double comprimento = 2 * Math.PI * raio;
            double area = 4 * Math.PI * Math.Pow(raio, 2);
            double volume = 4 * Math.PI * Math.Pow(raio, 3)/3;

            Console.WriteLine($"Raio: {raio:F2}");
            Console.WriteLine($"Comprimento: {comprimento:F2}");
            Console.WriteLine($"Área: {area:F2}");
            Console.WriteLine($"Volume: {volume:F2}");

            Console.ReadKey();
        }
    }
}
