using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Litsa01Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o valor do veículo: ");
            double valorVeic = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o percentual de lucro do distribuidor: ");
            double comissao = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o percentual do imposto: ");
            double imposto = Convert.ToDouble(Console.ReadLine());

            comissao = ((comissao / 100) * valorVeic);
            Console.WriteLine("Valor de lucro do distribuidor: R$" + comissao.ToString("F2", CultureInfo.InvariantCulture));

            imposto = ((imposto / 100) * valorVeic);
            Console.WriteLine("Valor do imposto: R$" + imposto.ToString("F2", CultureInfo.InvariantCulture));

            double valorTotal = valorVeic + comissao + imposto;
            Console.WriteLine("Valor total do veículo: R$" + valorTotal.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
