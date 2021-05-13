using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, anterior, atual, fibonacci;

            Console.Write("Informe um número: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.Write("0 ");
            }
            if (num > 1)
            {
                Console.Write("1 ");
            }
            if (num > 2)

            {
                anterior = 0;
                atual = 1;

                for (int i = 3; i <= num; i++)
                {

                    fibonacci = anterior + atual;
                    Console.Write(fibonacci + " ");

                    anterior = atual;
                    atual = fibonacci;
                }

            }
            Console.ReadKey();
        }
    }
}
