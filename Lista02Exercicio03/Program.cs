using System;

namespace Lista02Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("Número maior é: " + num1);
            }
            else
            {
                Console.WriteLine("Número maior é: " + num2);
            }

            Console.ReadKey();
        }
    }
}
