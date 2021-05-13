using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, soma;

            Console.Write("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            num3 = int.Parse(Console.ReadLine());

            Console.Write("Digite o quarto número: ");
            num4 = int.Parse(Console.ReadLine());

            soma = num1 + num2 + num3 + num4;

            Console.Write($"A soma dos números {num1}, {num2}, {num3} e {num4} é igual a {soma}.");

            Console.ReadLine();
        }
    }
}
