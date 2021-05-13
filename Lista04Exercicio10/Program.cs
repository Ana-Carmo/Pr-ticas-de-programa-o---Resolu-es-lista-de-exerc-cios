using System;

namespace Lista04Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] corredor = new int[24], janela = new int[24];
            int opcao, tipoPassagem, numCorredor, numJanela, confCorredor, confJanela;

            //Menu de opções
            Console.WriteLine("Escolha uma das ações: ");
            Console.WriteLine("1 - Vender passagem. \n2 - Mostrar mapa de ocupação do ônibus. \n3 - Encerrar.");
            opcao = Convert.ToInt32(Console.ReadLine());

            //Ações para opção de Vender passagem
            if (opcao == 1)
            {
                //Opções de Corredor ou Janela
                Console.WriteLine("Deseja poltrona da:\n1 - Corredor\n2 - Janela");
                tipoPassagem = Convert.ToInt32(Console.ReadLine());

                //Opção do número da poltrona do corredor
                if (tipoPassagem == 1)
                {
                    Console.WriteLine("Informe o número da poltrona do corredor desejado: ");
                    numCorredor = Convert.ToInt32(Console.ReadLine());

                    //Poltrona LIVRE
                    if (corredor[numCorredor] == 0)
                    {
                        Console.WriteLine("Poltrona LIVRE, deseja efetivar a compra?\n1 - Sim\n2 - Não");
                        confCorredor = Convert.ToInt32(Console.ReadLine());

                        //Efetivação da compra
                        if (confCorredor == 1)
                        {
                            Console.WriteLine("Venda efetiva.");
                            corredor[numCorredor] = 1;
                        }

                        //Cancelamento da compra
                        if (confCorredor == 2)
                        {
                            Console.WriteLine("Compra cancelada.");
                        }
                    }

                    //Poltrona OCUPADA
                    else if (corredor[numCorredor] == 1)
                    {
                        Console.WriteLine("Poltrona OCUPADA, deseja escolher outra?\n1 - Sim\n2 - Não");
                        confCorredor = Convert.ToInt32(Console.ReadLine());

                        //Apresentar mapa de ocupação do ônibus
                        Console.WriteLine("Mapa de ocupação do ônibus: ");

                        for (int i = 0; i < corredor.Length; i++)
                        {
                            if (corredor[i] == 0)
                            {
                                Console.WriteLine((i + 1) + "- Livre");
                            }

                            else if (corredor[i] == 1)
                            {
                                Console.WriteLine((i + 1) + "- Ocupado");
                            }
                        }

                        //Escolha de outra poltrona e confirmação da venda
                        if (confCorredor == 1)
                        {
                            Console.WriteLine("Informe o número da poltrona do corredor desejado: ");
                            numCorredor = Convert.ToInt32(Console.ReadLine());
                        }

                        corredor[numCorredor] = 1;

                        Console.WriteLine("Venda efetivada.");
                    }
                }

                if (tipoPassagem == 2)
                {
                    Console.WriteLine("Informe o número da poltrona da janela desejado: ");
                    numJanela = Convert.ToInt32(Console.ReadLine());

                    //Poltrona LIVRE
                    if (janela[numJanela] == 0)
                    {
                        Console.WriteLine("Poltrona LIVRE, deseja efetivar a compra?\n1 - Sim\n2 - Não");
                        confCorredor = Convert.ToInt32(Console.ReadLine());

                        //Efetivação da compra
                        if (confCorredor == 1)
                        {
                            Console.WriteLine("Venda efetiva.");
                            corredor[numJanela] = 1;
                        }

                        //Cancelamento da compra
                        else if (confCorredor == 2)
                        {
                            Console.WriteLine("Compra cancelada.");
                        }
                    }

                    //Poltrona OCUPADA
                    else if (janela[numJanela] == 1)
                    {
                        Console.WriteLine("Poltrona OCUPADA, deseja escolher outra?\n1 - Sim\n2 - Não");
                        confJanela = Convert.ToInt32(Console.ReadLine());

                        //Apresentar mapa de ocupação do ônibus
                        Console.WriteLine("Mapa de ocupação do ônibus: ");

                        for (int i = 0; i < janela.Length; i++)
                        {
                            if (janela[i] == 0)
                            {
                                Console.WriteLine((i + 1) + "- Livre");
                            }

                            else if (janela[i] == 1)
                            {
                                Console.WriteLine((i + 1) + "- Ocupado");
                            }
                        }

                        //Escolha de outra poltrona e confirmação da venda
                        if (confJanela == 1)
                        {
                            Console.WriteLine("Informe o número da poltrona do corredor desejado: ");
                            numJanela = Convert.ToInt32(Console.ReadLine());
                        }

                        janela[confJanela] = 1;

                        Console.WriteLine("Venda efetivada.");

                        Console.WriteLine("Para encerrar o programa, pressione Enter");
                    }
                }

            }


            if (opcao == 2)
            {
                Console.WriteLine("JANELA");
                for (int i = 0; i < janela.Length; i++)
                {
                    if (janela[i] == 0)
                    {
                        Console.WriteLine((i + 1) + "- Livre");
                    }

                    else if (janela[i] == 1)
                    {
                        Console.WriteLine((i + 1) + "- Ocupado");
                    }
                }
                Console.WriteLine();

                Console.WriteLine("CORREDOR");
                for (int i = 0; i < corredor.Length; i++)
                {
                    if (corredor[i] != 1)
                    {
                        Console.WriteLine((i + 1) + "- Livre");
                    }

                    else if (janela[i] == 1)
                    {
                        Console.WriteLine((i + 1) + "- Ocupado");
                    }
                }
            }

            if (opcao == 3)
            {
                Console.WriteLine("Para encerrar o programa, pressione Enter");
            }

            Console.ReadKey();
        }
    }
}