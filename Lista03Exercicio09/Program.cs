using System;

namespace Lista03Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            double mod, somaDivisores = 0;

            string tipoDeNumero = null;

            Console.Write("Informe um número: ");
            double x = Convert.ToDouble(Console.ReadLine());

            for (double i = 1; i <= x; i++)
            {
                mod = x % i;

                if (mod == 0)
                {
                    somaDivisores += i;
                }
            }

            if (somaDivisores == x + 1)
            {
                tipoDeNumero = "é primo";
            }
            else 
            {
                tipoDeNumero = "não é primo";
            }
            Console.WriteLine("O número digitado " + tipoDeNumero);

            Console.ReadKey();
        }
    }

}

