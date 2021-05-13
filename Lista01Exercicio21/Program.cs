using System;

namespace Lista01Exercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a largura do cômodo: ");
            double largura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o comprimento do cômodo: ");
            double comprimento = Convert.ToDouble(Console.ReadLine());

            double area = largura * comprimento;
            double iluminacao = 18 * area;

            Console.WriteLine($"Área do cômodo {area:F2} metros quadrados");
            Console.WriteLine($"Potência de iluminação: {iluminacao}W");

            Console.ReadKey();
        }
    }
}
