    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista02Exercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o código do produto: ");
            int cod = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o preço do produto: ");
            double preco = Convert.ToDouble(Console.ReadLine());

            if (preco <= 300)
            {
                Console.WriteLine("Produto códgio: " + cod);
                Console.WriteLine("O produto não tem desconto");
                Console.WriteLine("O valor do produto é: R$" + preco);
            }
            else if (preco > 300 && preco <= 1000)
            {
                Console.WriteLine("Produto códgio: " + cod);

                double desc = preco * 0.1;
                preco -= desc;
                Console.WriteLine("Desconto: " + desc.ToString("F2"));
                Console.WriteLine("O valor do final do produto é: R$" + preco.ToString("F2"));
            }
            else
            {
                Console.WriteLine("Produto códgio: " + cod);

                double desc = preco * 0.15;
                preco -= desc;
                Console.WriteLine("Desconto: " + desc.ToString("F2"));
                Console.WriteLine("O valor do final do produto é: R$" + preco.ToString("F2"));
            }

            Console.ReadKey();

        }
    }
}
