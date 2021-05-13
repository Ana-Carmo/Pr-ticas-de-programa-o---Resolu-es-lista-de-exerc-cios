using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01Exercicio25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a hora: ");
            int hora = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe os minutos: ");
            int minutos = Convert.ToInt32(Console.ReadLine());

            int minutosHoras = hora * 60;
            Console.WriteLine($"As {hora} hora(s) equivale(m) a {minutosHoras} minutos");

            int minutosTotal = minutos + minutosHoras;
            Console.WriteLine($"Total de minutos: {minutosTotal} minutos");

            int segundos = minutosTotal * 60;
            Console.WriteLine($"Segundos totais: {segundos} minutos");

            Console.ReadKey();
        }
    }
}
