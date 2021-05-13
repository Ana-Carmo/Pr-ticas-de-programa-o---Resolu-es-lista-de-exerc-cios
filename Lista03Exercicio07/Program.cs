using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroA, numeroB, numeroC, numeroD;

            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine("Digite numero A = ");
                numeroA = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite numero B = ");
                numeroB = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite numero C = ");
                numeroC = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite numero D = ");
                numeroD = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"{numeroA}, {numeroB}, {numeroC} e {numeroD}");

                if (numeroA <= numeroB && numeroB <= numeroC && numeroC <= numeroD)
                {
                    Console.WriteLine($"{numeroA}, {numeroB}, {numeroC} e {numeroD}");
                    Console.WriteLine($"{numeroD}, {numeroC}, {numeroB} e {numeroA}");
                }
                else if ((numeroA <= numeroB && numeroB <= numeroD && numeroD <= numeroC))
                {
                    Console.WriteLine($"{numeroA}, {numeroB}, {numeroD} e {numeroC}");
                    Console.WriteLine($"{numeroC}, {numeroD}, {numeroB} e {numeroA}");
                }
                else if ((numeroA <= numeroC && numeroC <= numeroB && numeroB <= numeroD))
                {
                    Console.WriteLine($"{numeroA}, {numeroC}, {numeroB} e {numeroD}");
                    Console.WriteLine($"{numeroD}, {numeroB}, {numeroC} e {numeroA}");
                }
                else if ((numeroA <= numeroC && numeroC <= numeroD && numeroD <= numeroB))
                {
                    Console.WriteLine($"{numeroA}, {numeroC}, {numeroD} e {numeroB}");
                    Console.WriteLine($"{numeroB}, {numeroD}, {numeroC} e {numeroA}");
                }
                else if ((numeroA <= numeroD && numeroD <= numeroB && numeroB <= numeroC))
                {
                    Console.WriteLine($"{numeroA}, {numeroD}, {numeroB} e {numeroC}");
                    Console.WriteLine($"{numeroC}, {numeroB}, {numeroD} e {numeroA}");
                }
                else if ((numeroA <= numeroD && numeroD <= numeroC && numeroC <= numeroB))
                {
                    Console.WriteLine($"{numeroA}, {numeroD}, {numeroC} e {numeroB}");
                    Console.WriteLine($"{numeroB}, {numeroC}, {numeroD} e {numeroA}");
                }
                else if ((numeroB <= numeroA && numeroA <= numeroC && numeroC <= numeroD))
                {
                    Console.WriteLine($"{numeroB}, {numeroA}, {numeroC} e {numeroD}");
                    Console.WriteLine($"{numeroD}, {numeroC}, {numeroA} e {numeroB}");
                }
                else if ((numeroB <= numeroA && numeroA <= numeroD && numeroD <= numeroC))
                {
                    Console.WriteLine($"{numeroB}, {numeroA}, {numeroC} e {numeroD}");
                    Console.WriteLine($"{numeroD}, {numeroC}, {numeroA} e {numeroB}");
                }
                else if ((numeroB <= numeroC && numeroC <= numeroA && numeroA <= numeroD))
                {
                    Console.WriteLine($"{numeroB}, {numeroC}, {numeroA} e {numeroD}");
                    Console.WriteLine($"{numeroD}, {numeroA}, {numeroC} e {numeroB}");
                }
                else if ((numeroB <= numeroC && numeroC <= numeroD && numeroD <= numeroA))
                {
                    Console.WriteLine($"{numeroB}, {numeroC}, {numeroD} e {numeroA}");
                    Console.WriteLine($"{numeroA}, {numeroD}, {numeroC} e {numeroB}");
                }
                else if ((numeroB <= numeroD && numeroD <= numeroA && numeroA <= numeroC))
                {
                    Console.WriteLine($"{numeroB}, {numeroD}, {numeroA} e {numeroC}");
                    Console.WriteLine($"{numeroC}, {numeroA}, {numeroD} e {numeroB}");
                }
                else if ((numeroB <= numeroD && numeroD <= numeroC && numeroC <= numeroA))
                {
                    Console.WriteLine($"{numeroB}, {numeroD}, {numeroC} e {numeroA}");
                    Console.WriteLine($"{numeroA}, {numeroC}, {numeroD} e {numeroB}");
                }
                else if ((numeroC <= numeroA && numeroA <= numeroB && numeroB <= numeroD))
                {
                    Console.WriteLine($"{numeroC}, {numeroA}, {numeroB} e {numeroD}");
                    Console.WriteLine($"{numeroD}, {numeroB}, {numeroA} e {numeroC}");
                }
                else if ((numeroC <= numeroA && numeroA <= numeroD && numeroD <= numeroB))
                {
                    Console.WriteLine($"{numeroC}, {numeroA}, {numeroD} e {numeroB}");
                    Console.WriteLine($"{numeroB}, {numeroD}, {numeroA} e {numeroC}");
                }
                else if ((numeroC <= numeroB && numeroB <= numeroA && numeroA <= numeroD))
                {
                    Console.WriteLine($"{numeroC}, {numeroB}, {numeroA} e {numeroD}");
                    Console.WriteLine($"{numeroD}, {numeroA}, {numeroB} e {numeroC}");
                }
                else if ((numeroC <= numeroB && numeroB <= numeroD && numeroD <= numeroA))
                {
                    Console.WriteLine($"{numeroC}, {numeroB}, {numeroD} e {numeroA}");
                    Console.WriteLine($"{numeroA}, {numeroD}, {numeroB} e {numeroC}");
                }
                else if ((numeroC <= numeroD && numeroD <= numeroA && numeroA <= numeroB))
                {
                    Console.WriteLine($"{numeroC}, {numeroD}, {numeroA} e {numeroB}");
                    Console.WriteLine($"{numeroB}, {numeroA}, {numeroD} e {numeroC}");
                }
                else if ((numeroC <= numeroB && numeroB <= numeroD && numeroD <= numeroA))
                {
                    Console.WriteLine($"{numeroC}, {numeroD}, {numeroB} e {numeroA}");
                    Console.WriteLine($"{numeroA}, {numeroB}, {numeroD} e {numeroC}");
                }
                else if ((numeroD <= numeroA && numeroA <= numeroB && numeroB <= numeroC))
                {
                    Console.WriteLine($"{numeroD}, {numeroA}, {numeroB} e {numeroC}");
                    Console.WriteLine($"{numeroC}, {numeroB}, {numeroA} e {numeroD}");
                }
                else if ((numeroD <= numeroA && numeroA <= numeroC && numeroC <= numeroB))
                {
                    Console.WriteLine($"{numeroD}, {numeroA}, {numeroC} e {numeroB}");
                    Console.WriteLine($"{numeroB}, {numeroC}, {numeroA} e {numeroD}");
                }
                else if ((numeroD <= numeroB && numeroB <= numeroA && numeroA <= numeroC))
                {
                    Console.WriteLine($"{numeroD}, {numeroB}, {numeroA} e {numeroC}");
                    Console.WriteLine($"{numeroC}, {numeroA}, {numeroB} e {numeroD}");
                }
                else if ((numeroD <= numeroB && numeroB <= numeroC && numeroC <= numeroA))
                {
                    Console.WriteLine($"{numeroD}, {numeroB}, {numeroC} e {numeroA}");
                    Console.WriteLine($"{numeroA}, {numeroC}, {numeroB} e {numeroD}");
                }
                else if ((numeroD <= numeroC && numeroC <= numeroA && numeroA <= numeroB))
                {
                    Console.WriteLine($"{numeroD}, {numeroC}, {numeroA} e {numeroB}");
                    Console.WriteLine($"{numeroB}, {numeroA}, {numeroC} e {numeroD}");
                }
                else if ((numeroD <= numeroC && numeroC <= numeroB && numeroB <= numeroA))
                {
                    Console.WriteLine($"{numeroD}, {numeroC}, {numeroB} e {numeroA}");
                    Console.WriteLine($"{numeroA}, {numeroB}, {numeroC} e {numeroD}");
                }

            }

            Console.ReadKey();

        }
    }
}
