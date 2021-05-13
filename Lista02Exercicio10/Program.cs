using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista02Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            string cargo;
            double aumento, salario;
            int codigo;

            Console.Write("Informe o código do funcionário: ");
            codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o salário do funcionário: ");
            salario = Convert.ToDouble(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    cargo = "Escriturário";
                    aumento = salario * 0.5;
                    salario += aumento;
                    break;

                case 2:
                    cargo = "Secretário";
                    aumento = salario * 0.35;
                    salario += aumento;
                    break;

                case 3:
                    cargo = "Caixa";
                    aumento = salario * 0.2;
                    salario += aumento;
                    break;

                case 4:
                    cargo = "Gerente";
                    aumento = salario * 0.1;
                    salario += aumento;
                    break;

                case 5:
                    cargo = "Diretor";
                    aumento = salario * 0.0;
                    salario += aumento;
                    break;

                default:
                    cargo = "Inválido";
                    aumento = 0;
                    break;
            }

            Console.WriteLine("Cargo: " + cargo);
            Console.WriteLine($"Aumento: R$ " + aumento);
            Console.WriteLine("Novo salário: R$ " + salario);

            Console.ReadKey();
        }
    }
}
