using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista04Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[5];
            int menor, novoMenor;

            //Preenchendo o vetor
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite um número para a posição " + i + " do vetor: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Mostrar o vetor original
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + " ");
            }

            Console.WriteLine();

            //Ordenando
            for (int i = 0; i < vetor.Length; i++)
            {
                menor = vetor[i];

                for (int posicao = 0; posicao < vetor.Length; posicao++)
                {
                    if (vetor[posicao] > menor)
                    {
                        novoMenor = vetor[posicao];
                        vetor[posicao] = menor;
                        vetor[i] = novoMenor;
                        menor = novoMenor;
                    }
                }
            }

            //Mostrar o vetor crescente
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
