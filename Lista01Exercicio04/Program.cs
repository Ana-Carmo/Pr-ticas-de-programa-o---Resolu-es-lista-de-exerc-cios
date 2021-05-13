using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, percentualAumento, salarioAumento, valorAumentado;

            Console.Write("Infome o salário do funcionário: ");
            salario = double.Parse(Console.ReadLine());

            Console.Write("Informe o percentual de aumento do salário: ");
            percentualAumento = double.Parse(Console.ReadLine());

            salarioAumento = salario + (salario * (percentualAumento / 100));

            valorAumentado = salarioAumento - salario;

            Console.Write("O valor aumentado no salário foi de R$ " + valorAumentado);

            Console.Write("O salário atualizado será de: R$ " + salarioAumento);

            Console.ReadKey();

        }
    }
}
