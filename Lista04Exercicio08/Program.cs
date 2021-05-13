using System;

namespace Lista04Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetorTemperatura = new double[3];
            double maiorTemp, menorTemp, mesMaior = 0, mesMenor = 0;

            //Preenchendo o vetor temperatura
            for (int i = 0; i < vetorTemperatura.Length; i++)
            {
                Console.Write("Informe a temperatura média do mês " + (i + 1) + ": ");
                vetorTemperatura[i] = Convert.ToDouble(Console.ReadLine());

            }

            //Atribuindo valor a maior e menor temperatura
            maiorTemp = vetorTemperatura[0];
            menorTemp = vetorTemperatura[0];

            //Verificando qual a maior e a menor temperatura
            for (int i = 0; i < vetorTemperatura.Length; i++)
            {
                if (vetorTemperatura[i] > maiorTemp)
                {
                    maiorTemp = vetorTemperatura[i];
                    mesMaior = i;
                }

                else if (vetorTemperatura[i] < menorTemp)
                {
                    menorTemp = vetorTemperatura[i];
                    mesMenor = i;
                }
            }

            //Apresentando as informações
            Console.WriteLine("O mês com maior temperatura: " + (mesMaior + 1));
            Console.WriteLine("Temperatura: " + maiorTemp);

            Console.WriteLine();

            Console.WriteLine("O mês com menor temperatura: " + (mesMenor + 1));
            Console.WriteLine("Temperatura: " + menorTemp);

            Console.ReadKey();
        }
    }
}
