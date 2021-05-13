using System;

namespace Lista02Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a primera data (ddmmaa): ");
            int data1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe a segunda data (ddmmaa): ");
            int data2 = Convert.ToInt32(Console.ReadLine());

            if (data1 < data2)
            {
                Console.WriteLine("A segunda data é maior que a primeira data.");
            }
            else
            {
                Console.WriteLine("A primeira data é maior que a segunda data.");
            }

            Console.ReadKey();
        }
    }
}
