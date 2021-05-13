using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o seu ano de nascimento: ");
            int dataNasc = Convert.ToInt32(Console.ReadLine());

            int dataHoje = DateTime.Now.Year;

            int idade = dataHoje - dataNasc;

            int idadeCinq = 2050 - dataNasc;

            Console.Write($"Sua idade é: {idade} anos\n");
            Console.Write($"Em 2050 você terá: {idadeCinq} anos");

            Console.ReadKey();
        }
    }
}
