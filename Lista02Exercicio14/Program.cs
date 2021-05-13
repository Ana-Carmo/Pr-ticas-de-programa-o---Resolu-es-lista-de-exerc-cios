using System;

namespace Lista02Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o tipo de investimento.");
            Console.WriteLine("1 - Poupança");
            Console.WriteLine("2 - Fundos de renda fixa.");

            int opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1)
            {
                Console.Write("Informe o valor do investimento na poupança: ");
                double investimento = Convert.ToDouble(Console.ReadLine());

                investimento += investimento * 0.03;

                Console.WriteLine("O valor do inestimento após um mês é de : R$" + investimento.ToString("F2"));

            } else if (opcao == 2)
            {
                Console.Write("Informe o valor do investimento na poupança: ");
                double investimento = Convert.ToDouble(Console.ReadLine());

                investimento += investimento * 0.04;

                Console.WriteLine("O valor do inestimento após um mês é de : R$" + investimento.ToString("F2"));
            } else
            {
                Console.WriteLine("Opção inválida.");
            }

            Console.ReadKey();
        }

    }
}
