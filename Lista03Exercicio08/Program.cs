using System;

namespace Lista03Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, qntidadeIdade = 0;
            double altura, alturaGeral = 0.00, alturaMedia = 0;
            double peso, pesoGeral = 0, pesoPerc = 0, qntidadePeso = 0;
            double idadeTime1 = 0, idadeTime2 = 0, idadeTime3 = 0, idadeTime4 = 0, idadeTime5 = 0, mediaIdadeTime1 = 0, mediaIdadeTime2 = 0, mediaIdadeTime3 = 0, mediaIdadeTime4 = 0, mediaIdadeTime5 = 0;

            for (int i = 1; i <= 55; i++)
            {
                Console.Write("Idade do jogador " + i + ": ");
                idade = Convert.ToInt32(Console.ReadLine());

                Console.Write("Peso do jogador " + i + ": ");
                peso = Convert.ToDouble(Console.ReadLine());

                Console.Write("Altura do jogador " + i + ": ");
                altura = Convert.ToDouble(Console.ReadLine());
                altura = altura / 100;

                Console.WriteLine();

                alturaGeral += altura;
                pesoGeral += peso;

                if (idade < 18)
                {
                    qntidadeIdade += 1;
                }
                if (i >= 1 && i <= 11)
                {
                    idadeTime1 += idade;
                }
                else if (i >= 12 && i <= 22)
                {
                    idadeTime2 += idade;
                }
                else if (i >= 23 && i <= 33)
                {
                    idadeTime3 += idade;
                }
                else if (i >= 34 && i <= 44)
                {
                    idadeTime4 += idade;
                }
                else if (i >= 45 && i <= 55)
                {
                    idadeTime5 += idade;
                }

                if (peso > 80)
                {
                    qntidadePeso += 1;
                }

                alturaMedia = alturaGeral / i;
                pesoPerc = (qntidadePeso / i) * 100;
                
            }
            
            Console.WriteLine("Quantidade de atletas com idade inferior a 18 anos: " + qntidadeIdade);

            mediaIdadeTime1 = idadeTime1 / 11;
            mediaIdadeTime2 = idadeTime2 / 11;
            mediaIdadeTime3 = idadeTime3 / 11;
            mediaIdadeTime4 = idadeTime4 / 11;
            mediaIdadeTime5 = idadeTime5 / 11;

            Console.WriteLine("Idade média do time 1: " + mediaIdadeTime1.ToString("F0"));
            Console.WriteLine("Idade média do time 2: " + mediaIdadeTime2.ToString("F0"));
            Console.WriteLine("Idade média do time 3: " + mediaIdadeTime3.ToString("F0"));
            Console.WriteLine("Idade média do time 4: " + mediaIdadeTime4.ToString("F0"));
            Console.WriteLine("Idade média do time 5: " + mediaIdadeTime5.ToString("F0"));

            Console.WriteLine("A altura média dos atletas: " + alturaMedia.ToString("F2"));

            Console.WriteLine("Percentual de atletas com mais de 80 KG: " + pesoPerc + "%.");

            Console.ReadKey();
        }
    }
}
