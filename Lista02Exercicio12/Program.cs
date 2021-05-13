using System;

namespace Lista02Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o valor de X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o valor de Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o valor de Z: ");
            int z = Convert.ToInt32(Console.ReadLine());

            if (x - y < z && x + y > z && y - z < x && y + z > x && x - z < y && x + z > y)
            {
                if (x == y && z == x)
                {
                    Console.WriteLine("O triângulo é equilatero.");
                }
                else if (x != y && x == z || y != z && y == x)
                {
                    Console.WriteLine("O triângulo é isósceles.");
                }
                else
                {
                    Console.WriteLine("O triângulo é escaleno.");
                }
            }
            else
            {
                Console.WriteLine("As medidas não é de um triângulo.");
            }
            Console.ReadKey();
        }
    }
}
