using System;

namespace Lista01Exercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o seu ano de nascimento: ");
            int dataNasc = Convert.ToInt32(Console.ReadLine());

            int dataHoje = DateTime.Now.Year;

            int idadeAnos = dataHoje - dataNasc;
            int idadeMeses = idadeAnos * 12;
            int idadeSemanas = idadeMeses * 4;
            int idadeDias = idadeMeses * 31;

            Console.WriteLine($"Idade em anos: {idadeAnos}");
            Console.WriteLine($"Idade em meses: {idadeMeses}");
            Console.WriteLine($"Idade em semanas: {idadeSemanas}");
            Console.WriteLine($"Idade em dias: {idadeDias}");

            Console.ReadKey();
        }
    }
}
