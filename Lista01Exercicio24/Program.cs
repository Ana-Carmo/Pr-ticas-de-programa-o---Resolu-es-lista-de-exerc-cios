using System;

namespace Lista01Exercicio24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o valor em reais: ");
            double reais = Convert.ToDouble(Console.ReadLine());

            double dolar = reais * 1.80;
            double marco = reais * 2.00;
            double libra = reais * 3.70;

            Console.WriteLine("Valor em dólar: " + dolar.ToString("F2"));
            Console.WriteLine("Valor em marco alemão: " + marco.ToString("F2"));
            Console.WriteLine("Valor em libra esterlina: " + libra.ToString("F2"));

            Console.ReadKey();
        }
    }
}
