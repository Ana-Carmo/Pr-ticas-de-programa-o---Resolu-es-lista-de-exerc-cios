using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lista01Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            double gratificacao, impostos, salarioFinal;

            Console.Write("Informe o salário base do funcionário: ");
            double salarioBase = double.Parse(Console.ReadLine());

            gratificacao = salarioBase * 0.05;

            impostos = salarioBase * 0.07;

            salarioFinal = salarioBase + gratificacao - impostos;

            Console.WriteLine("Salário base é: R$ " + salarioBase.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de imposto pago: R$ " + impostos.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor da gratificação é: R$ " + gratificacao.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor final do salário é: R$ " + salarioFinal.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();


        }
    }
}
