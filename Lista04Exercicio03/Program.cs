using System;

namespace Lista04Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, indice = 0; ;
            int[] vetor = new int[10];

            //Prenchendo vetor
            for (int posicaoV = 0; posicaoV < vetor.Length; posicaoV++)
            {
                Console.Write("Digite o número da posição " + posicaoV + " do vetor: ");
                vetor[posicaoV] = Convert.ToInt32(Console.ReadLine());

                if (vetor[posicaoV] > 50)
                {
                    n += 1;
                }
            }

            Console.WriteLine();

            //Verificando e pegando os valores e as posições dos números maiores que 50
            if (n > 0)
            {
                int[] vetorCinq = new int[n];
                int[] vetorPos = new int[n];

                for (int i = 0; i < 10; i++)
                {
                    if (vetor[i] > 50)
                    {
                        vetorCinq[indice] = vetor[i];
                        vetorPos[indice] = i;
                        indice += 1;
                    }

                }

                //Mostrando quantidade de números maiores que 50
                Console.WriteLine("Total de números maiores que 50: " + n);

                //Mostrando os números maiores que 50 e suas posições
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(vetorCinq[i] + " na posição " + vetorPos[i] + " do vetor.");
                }
            }

            else
            {
                Console.WriteLine("Nenhum dos números digitados é maior que 50.");

                //Mostrar o vetor
                for (int posicaoV = 0; posicaoV < vetor.Length; posicaoV++)
                {
                    Console.Write(vetor[posicaoV] + " ");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}