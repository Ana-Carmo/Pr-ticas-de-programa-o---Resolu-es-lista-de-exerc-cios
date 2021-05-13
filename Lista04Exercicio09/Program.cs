using System;

namespace Lista04Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorNum = new int[6];
            int par = 0, somaPar = 0, impar = 0, somaImpar = 0, indicePar = 0, indiceImpar = 0;

            //Recebendo os números
            for (int i = 0; i < vetorNum.Length; i++)
            {
                Console.Write("Digite um número para a posição " + i + " do vetor: ");
                vetorNum[i] = Convert.ToInt32(Console.ReadLine());

                // Contando a quantidade de números pares e ímpares
                if (vetorNum[i] % 2 == 0)
                {
                    par += 1;
                }

                else
                {
                    impar += 1;
                }
            }

            for (int i = 0; i < vetorNum.Length; i++)
            {
                Console.Write(vetorNum[i] + " ");
            }

            Console.WriteLine();
            
            //Declarando vetor com o tamanho da quantidade de números pares e impares
            int[] vetorPar = new int[par], vetorImpar = new int[impar];

            //Percorrendo o vetor principal
            for (int i = 0; i < vetorNum.Length; i++)
            {
                //Preenchendo o vetor de números pares
                if (vetorNum[i] % 2 == 0)
                {
                    somaPar += vetorNum[i];
                    vetorPar[indiceImpar] = vetorNum[i];

                    indiceImpar += 1;
                }

                //Preenchendo o vetor de números ímpares
                else
                {
                    somaImpar += vetorNum[i];
                    vetorImpar[indicePar] = vetorNum[i];

                    indicePar += 1;
                }
            }

            Console.Write("Números pares digitados: ");

            for (int i = 0; i < vetorPar.Length; i++)
            {
                Console.Write(vetorPar[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Soma dos números pares: " + somaPar);

            Console.Write("Números ímpares digitados: ");

            for (int i = 0; i < vetorImpar.Length; i++)
            {
                Console.Write(vetorImpar[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Soma dos números ímpares: " + somaImpar);

            Console.ReadKey();
        }
    }
}
