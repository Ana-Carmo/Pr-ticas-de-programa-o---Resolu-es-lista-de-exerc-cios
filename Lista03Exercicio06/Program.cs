using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media, mediaClasse = 0;

            int i = 0, qntidadeA = 0, qntidadeE = 0, qntidadeR = 0;

            while (i < 6)
            {
                i += 1;
                Console.Write("Informe a nota 01 do aluno " + i + ": ");
                nota1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Informe a nota 02 do aluno " + i + ": ");
                nota2 = Convert.ToDouble(Console.ReadLine());

                media = (nota1 + nota2) / 2;

                mediaClasse += media;

                if (media <= 3)
                {
                    Console.WriteLine("A média do aluno " + i + " é: " + media.ToString("F2"));
                    Console.WriteLine("O aluno está REPROVADO.\n");
                    qntidadeR += 1;
                }
                if (media > 3 && media < 7)
                {
                    Console.WriteLine("A média do aluno " + i + " é: " + media.ToString("F2"));
                    Console.WriteLine("O aluno pegou EXAME ESPECIAL.\n");
                    qntidadeE += 1;
                }
                if (media >= 7)
                {
                    Console.WriteLine("A média do aluno " + i + " é: " + media.ToString("F2"));
                    Console.WriteLine("O aluno está APROVADO.\n");
                    qntidadeA += 1;
                }

            }
            Console.WriteLine("Alunos APROVADOS: " + qntidadeA);
            Console.WriteLine("Alunos em EXAME ESPECIAL: " + qntidadeE);
            Console.WriteLine("Alunos REPROVADOS: " + qntidadeR);

            mediaClasse /= i;
            Console.WriteLine("Média da classe: " + mediaClasse.ToString("F2"));

            Console.ReadKey();
        }
    }
}
