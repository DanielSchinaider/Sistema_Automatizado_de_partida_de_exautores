using System;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] motores = new string[2, 4];
            motores[0, 0] = "M1";
            motores[0, 1] = "M2";
            motores[0, 2] = "M3";
            motores[0, 3] = "M4";

            motores[1, 0] = "DESLIGADO";
            motores[1, 1] = "DESLIGADO";
            motores[1, 2] = "DESLIGADO";
            motores[1, 3] = "DESLIGADO";


            Console.WriteLine("Iniciar? (S/N): ");
            String choose = Console.ReadLine();

            if (choose.ToLower() == "s")
            {
                Console.WriteLine("ACIONANDO VENTILADOR " + motores[0,0]);
                motores[1, 0] = "LIGADO";
                while (true)
                {
                    Thread.Sleep(6000);

                    if (motores[1,1] == "LIGADO")
                    {

                        if (motores[1, 2] == "LIGADO")
                        {

                            if(motores[1, 3] == "LIGADO")
                            {
                                for (int i = 3; i >= 0; i--)
                                {
                                    Console.WriteLine("\nDESLIGANDO VENTILADOR DO " + motores[0, i]);
                                    
                                }
                                Thread.Sleep(30000);
                                Console.Clear();
                                Console.WriteLine("INVERTENDO SENTIDO DE GIRO DAS HÉLICES!");
                                Thread.Sleep(5000);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nACIONANDO VENTILADOR " + motores[0, 3]);
                                motores[1, 3] = "LIGADO";
                                continue;
                            }
                        } else
                        {
                            Console.WriteLine("\nACIONANDO VENTILADOR " + motores[0, 2]);
                            motores[1, 2] = "LIGADO";
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nACIONANDO VENTILADOR " +motores[0, 1]);
                        motores[1,1] = "LIGADO";
                        continue;
                    }
                }

                motores[1, 0] = "DESLIGADO";
                motores[1, 1] = "DESLIGADO";
                motores[1, 2] = "DESLIGADO";
                motores[1, 3] = "DESLIGADO";

                Console.WriteLine("\nACIONANDO VENTILADOR " + motores[0, 0]);
                motores[1, 0] = "LIGADO";
                while (true)
                {
                    Thread.Sleep(6000);

                    if (motores[1, 1] == "LIGADO")
                    {

                        if (motores[1, 2] == "LIGADO")
                        {

                            if (motores[1, 3] == "LIGADO")
                            {
                                Thread.Sleep(30000);
                                Console.Clear();
                                for(int i = 3; i >= 0; i--)
                                {
                                    Thread.Sleep(1000);
                                    Console.WriteLine("\nDESLIGANDO VENTILADOR DO " + motores[0,i]);
                                }
                                break;

                            }
                            else
                            {
                                Console.WriteLine("\nACIONANDO VENTILADOR " + motores[0, 3]);
                                motores[1, 3] = "LIGADO";
                                continue;
                            }

                        }
                        else
                        {
                            Console.WriteLine("\nACIONANDO VENTILADOR " + motores[0, 2]);
                            motores[1, 2] = "LIGADO";
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nACIONANDO VENTILADOR " + motores[0, 1]);
                        motores[1, 1] = "LIGADO";
                        continue;
                    }

                }

            }
            else
            {
                Console.WriteLine("FIM");

            }
            Console.WriteLine("FIM");
        }
    }
}
