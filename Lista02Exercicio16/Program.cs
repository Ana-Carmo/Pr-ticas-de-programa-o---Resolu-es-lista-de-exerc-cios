using System;

namespace Lista02Exercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha;

            Console.Write("Informe a senha de 4 dígitos: ");
            senha = Convert.ToInt32(Console.ReadLine());

            while (senha != 4351)
            {
                Console.WriteLine("Acesso negado.");
                Console.Write("Senha incorreta. Informe a senha de 4 dígitos: ");
                senha = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Acesso permitido.");

            Console.ReadKey();
        }
    }
}
