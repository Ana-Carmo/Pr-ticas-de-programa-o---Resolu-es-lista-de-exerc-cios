using System;

namespace Lista04Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorA = new int[5], vetorB = new int[5], vetorR = new int[10];
            
            //Preencher vetor A
            for (int posicaoA = 0; posicaoA < 5; posicaoA++)
            {
                Console.Write("Digite o número da posição " + posicaoA + " do vetor A: ");
                vetorA[posicaoA] = Convert.ToInt32(Console.ReadLine());
            }

            //mostrar vetor A
            for (int posicaoA = 0; posicaoA < 5; posicaoA++)
            {
                Console.Write(vetorA[posicaoA] + " ");
            }

            Console.WriteLine();

            //Preencher vetor B
            for (int posicaoB = 0; posicaoB < 5; posicaoB++)
            {
                Console.Write("Digite o número da posição " + posicaoB + " do vetor 2: ");
                vetorB[posicaoB] = Convert.ToInt32(Console.ReadLine());
            }

            //mostrar vetor B
            for (int posicaoB = 0; posicaoB < 5; posicaoB++)
            {
                Console.Write(vetorB[posicaoB] + " ");
            }

            Console.WriteLine();

            //Preencher vetor resultante
            for (int posicaoVs = 0; posicaoVs < 5; posicaoVs++)
            {
                vetorR[posicaoVs * 2] = vetorA[posicaoVs];
                vetorR[(posicaoVs * 2) + 1] = vetorB[posicaoVs];
            }

            //mostrar vetor Resultante
            for (int posicaoR = 0; posicaoR < 10; posicaoR++)
            {
                Console.Write(vetorR[posicaoR] + " ");
            }

            Console.ReadKey();
        }

    }
}

