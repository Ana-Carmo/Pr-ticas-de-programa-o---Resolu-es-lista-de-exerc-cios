using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista02Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número inteiro: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 % 2 != 0)
            {
                Console.WriteLine("O número é ímpar.");

            } else
            {
                Console.WriteLine("O número é par");
            }

            Console.ReadKey();
        }
    }
}
