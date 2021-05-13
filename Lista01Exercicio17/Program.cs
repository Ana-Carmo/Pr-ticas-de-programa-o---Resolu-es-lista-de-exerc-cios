using System;

namespace Lista01Exercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                int multiplicacao = num * i;

                Console.WriteLine(num + " x " + i + " = " + multiplicacao);
            }

            Console.ReadKey();
        }
    }
}
