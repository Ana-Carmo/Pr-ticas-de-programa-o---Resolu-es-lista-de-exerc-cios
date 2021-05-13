using System;
using System.Globalization;

namespace Lista01Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o angulo em que a escada esta apoiada: ");
            double angApoio = Convert.ToDouble(Console.ReadLine());
            
            double anguloRadianos = (angApoio * Math.PI) / 180;
            Console.WriteLine("Radianos: " + anguloRadianos.ToString("F2", CultureInfo.InvariantCulture));

            Console.Write("Digite a altura da parede em centímetros: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double tamanhoEscada = altura / Math.Sin(anguloRadianos);

            Console.WriteLine("O tamanho da escada é " + tamanhoEscada.ToString("F2", CultureInfo.InvariantCulture) + " centímetros");

            Console.ReadKey();

        }
    }
}
