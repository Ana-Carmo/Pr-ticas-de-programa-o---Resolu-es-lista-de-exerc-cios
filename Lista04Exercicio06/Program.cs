using System;

namespace Lista04Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorA = new int[5], vetorB = new int[5], vetorR = new int[10];
            int menor = 0, novoMenor;

            //Preencher o vetor A
            for (int i = 0; i < vetorA.Length; i++)
            {
                Console.Write("Digite o número da posição " + i + " do vetor A: ");
                vetorA[i] = Convert.ToInt32(Console.ReadLine());
            }

            //mostrar vetor A
            for (int i = 0; i < vetorA.Length; i++)
            {
                Console.Write(vetorA[i] + " ");
            }

            Console.WriteLine();

            //Ordenando vetor A
            for (int i = 0; i < vetorA.Length; i++)
            {
                menor = vetorA[i];

                for (int posicao = 0; posicao < vetorA.Length; posicao++)
                {
                    if (vetorA[posicao] > menor)
                    {
                        novoMenor = vetorA[posicao];
                        vetorA[posicao] = menor;
                        vetorA[i] = novoMenor;
                        menor = novoMenor;
                    }
                }
            }

            //mostrar vetor A ordenado
            for (int i = 0; i < vetorA.Length; i++)
            {
                Console.Write(vetorA[i] + " ");
            }

            Console.WriteLine();

            //Preencher o vetor B
            for (int i = 0; i < vetorB.Length; i++)
            {
                Console.Write("Digite o número da posição " + i + " do vetor B: ");
                vetorB[i] = Convert.ToInt32(Console.ReadLine());
            }

            //mostrar vetor B
            for (int i = 0; i < vetorB.Length; i++)
            {
                Console.Write(vetorB[i] + " ");
            }

            Console.WriteLine();

            //Ordenando vetor B
            for (int i = 0; i < vetorB.Length; i++)
            {
                menor = vetorB[i];

                for (int posicao = 0; posicao < vetorB.Length; posicao++)
                {
                    if (vetorB[posicao] > menor)
                    {
                        novoMenor = vetorB[posicao];
                        vetorB[posicao] = menor;
                        vetorB[i] = novoMenor;
                        menor = novoMenor;
                    }
                }
            }

            //mostrar vetor B ordenado
            for (int i = 0; i < vetorB.Length; i++)
            {
                Console.Write(vetorB[i] + " ");
            }

            Console.WriteLine();

            //Preencher o vetor R
            for (int i = 9; i > -1; i--)
            {
                if (i > 4)
                {
                    vetorR[i] = vetorB[i - 5];
                }

                else if (i <= 4)
                {
                    vetorR[i] = vetorA[i];
                }
            }

            //mostrar vetor R
            for (int i = 0; i < vetorR.Length; i++)
            {
                Console.Write(vetorR[i] + " ");
            }

            Console.WriteLine();

            //Ordenando vetor R
            for (int i = 0; i < vetorR.Length; i++)
            {
                menor = vetorR[i];

                for (int posicao = 0; posicao < vetorR.Length; posicao++)
                {
                    if (vetorR[posicao] > menor)
                    {
                        novoMenor = vetorR[posicao];
                        vetorR[posicao] = menor;
                        vetorR[i] = novoMenor;
                        menor = novoMenor;
                    }
                }
            }

            //mostrar vetor R ordenado
            for (int i = 0; i < vetorR.Length; i++)
            {
                Console.Write(vetorR[i] + " ");
            }

            Console.ReadKey();
        }
    }
}

