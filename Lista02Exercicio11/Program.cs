using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista02Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, delta, x1, x2;

            Console.WriteLine("Entre com o coeficiente A da equação: ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o coeficiente B da equação: ");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o coeficiente C da equação: ");
            C = int.Parse(Console.ReadLine());

            delta = (Math.Pow(B, 2)) - 4 * A * C;

            x1 = ((-B + (Math.Sqrt(delta))) / 2 * A);
            x2 = ((-B - (Math.Sqrt(delta))) / 2 * A);

            Console.WriteLine("O valor do delta é " + delta);
            Console.WriteLine("O valor de X1 é " + x1);
            Console.WriteLine("O valor de X2 é " + x2);

            Console.ReadLine();
        }
    }
}
