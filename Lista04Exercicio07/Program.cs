using System;

namespace Lista04Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetorGabarito = new string[8], vetorResposta = new string[8];
            double[] vetorAluno = new double[10], vetorAcertos = new double[10];
            double aprovados = 0, media = 6,percAprovados;
            
            // Preenchendo vetor gabarito
            for (int i = 0; i < vetorGabarito.Length; i++)
            {
                Console.Write("Informe a resposta correta da questão " + (i + 1) + " da prova (de A a D): ");
                vetorGabarito[i] = Console.ReadLine();
            }

            Console.WriteLine();

            // Preenchendo vetor aluno (um de cada vez)
            for (int alunos = 0; alunos < vetorAluno.Length; alunos++)
            {
                Console.Write("Informe o número do aluno " + (alunos + 1) + ": ");
                vetorAluno[alunos] = Convert.ToInt32(Console.ReadLine());

                // Preenchendo o gabarito de respostas dos alunos (um aluno de cada vez)
                for (int questao = 0; questao < vetorResposta.Length; questao++)
                {
                    Console.Write("Informe a resposta da questão " + (questao + 1) + " do aluno " + vetorAluno[alunos] + ": ");
                    vetorResposta[questao] = Console.ReadLine();

                    // Verificando os acertos do aluno
                    if (vetorResposta[questao] == vetorGabarito[questao])
                    {
                        vetorAcertos[alunos] += 1;
                    }
                }
            }

            Console.WriteLine();

            //Apresentandos as informações
            for (int i = 0; i < vetorAluno.Length; i++)
            {
                Console.WriteLine("Aluno: " + vetorAluno[i]);
                Console.WriteLine("Nota: " + vetorAcertos[i]);
                Console.WriteLine();
            }

            // Verificando alunos aprovados
            for (int alunos = 0; alunos < vetorAcertos.Length; alunos++)
            {
                if (vetorAcertos[alunos] >= media)
                {
                    aprovados += 1;
                }
            }

            Console.WriteLine("Alunos aprovados: " + aprovados);
            
            percAprovados = ((aprovados / vetorAluno.Length) * 100);

            Console.Write("Percentual de alunos aprovados: " + percAprovados.ToString("F0") + "%");

            Console.ReadKey();
        }
    }
}
