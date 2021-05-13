using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista02Exercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            int angulo, voltas;

            Console.Write("Digite o angulo = ");
            angulo = Convert.ToInt32(Console.ReadLine());

            if (angulo < -360 || angulo > 360)
            {
                voltas = angulo / 360;
                angulo = angulo % 360;

                if (voltas < 0)
                {
                    voltas = voltas * -1;
                }

                Console.WriteLine($"Numero de voltas = {voltas}");

                if (angulo >= 0)
                {
                    Console.WriteLine("Sentido anti-horario");
                }
                else
                {
                    Console.WriteLine("Sentido horario");
                }
            }

            if (angulo > -360 && angulo < -270)
            {
                Console.WriteLine("1 quadrante");
            }
            else if (angulo > -270 && angulo < -180)
            {
                Console.WriteLine("2 quadrante");
            }
            else if (angulo > -180 && angulo < -90)
            {
                Console.WriteLine("3 quadrante");
            }
            else if (angulo > -90 && angulo < 0)
            {
                Console.WriteLine("4 quadrante");
            }
            else if (angulo > 0 && angulo < 90)
            {
                Console.WriteLine("1 quadrante");
            }
            else if (angulo > 90 && angulo < 180)
            {
                Console.WriteLine("2 quadrante");
            }
            else if (angulo > 180 && angulo < 270)
            {
                Console.WriteLine("3 quadrante");
            }
            else if (angulo > 270 && angulo < 360)
            {
                Console.WriteLine("4 quadrante");
            }

            Console.ReadKey();
        }
    }
}
