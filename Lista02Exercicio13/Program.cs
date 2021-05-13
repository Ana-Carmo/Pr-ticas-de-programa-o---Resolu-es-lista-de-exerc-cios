using System;

namespace Lista02Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o salário do funcionário: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            if (salario <= 300)
            {
                salario += salario * 0.5;

                Console.Write("O novo salário do funcionário é de: R$ " + salario.ToString("F2"));
            }
            else if (salario > 300 && salario <= 500)
            {
                salario += salario * 0.4;

                Console.Write("O novo salário do funcionário é de: R$ " + salario.ToString("F2"));
            }
            else if (salario > 500 && salario <= 700)
            {
                salario += salario * 0.3;

                Console.Write("O novo salário do funcionário é de: R$ " + salario.ToString("F2"));
            }
            else if (salario > 700 && salario <= 800)
            {
                salario += salario * 0.2;

                Console.Write("O novo salário do funcionário é de: R$ " + salario.ToString("F2"));
            }
            else if (salario > 800 && salario <= 1000)
            {
                salario += salario * 0.1;

                Console.Write("O novo salário do funcionário é de: R$ " + salario.ToString("F2"));
            }
            else
            {
                salario += salario * 0.05;

                Console.Write("O novo salário do funcionário é de: R$ " + salario.ToString("F2"));
            }

            Console.ReadKey();
        }
    }
}
        
       
