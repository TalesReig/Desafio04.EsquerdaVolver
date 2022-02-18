using System;

namespace Desafio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int teste;
            do
            {
                Console.WriteLine("Digite o número de ordens dadas pelo Sgt: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                char referenciaatual = 'N';

                char[] comandos = new char[numero];
                for (int i = 0; i < numero; i++)
                {
                    do
                    {
                        Console.Write("Digite o comando " + i + " :");
                        comandos[i] = Convert.ToChar(Console.ReadLine().ToUpper());
                        if (comandos[i] != 'D' && comandos[i] != 'E')
                        {
                            Console.WriteLine("Digite Apenas comandos validos!!!");
                        }
                    } while (comandos[i] != 'D' && comandos[i] != 'E');
                }

                for (int i = 0; i < comandos.Length; i++)
                {
                    char charcomandos = comandos[i];
                    switch (charcomandos)
                    {
                        case 'D':
                            switch (referenciaatual)
                            {
                                case 'N':
                                    referenciaatual = 'L';
                                    break;
                                case 'S':
                                    referenciaatual = 'O';
                                    break;
                                case 'L':
                                    referenciaatual = 'S';
                                    break;
                                case 'O':
                                    referenciaatual = 'S';
                                    break;
                            }
                            break;
                        case 'E':
                            switch (referenciaatual)
                            {
                                case 'N':
                                    referenciaatual = 'O';
                                    break;
                                case 'S':
                                    referenciaatual = 'L';
                                    break;
                                case 'L':
                                    referenciaatual = 'N';
                                    break;
                                case 'O':
                                    referenciaatual = 'S';
                                    break;
                            }
                            break;
                    }

                }
                Console.WriteLine(referenciaatual);
                do {
                    Console.WriteLine("Digite 1 para continuar e 0 para sair: ");
                    teste = Convert.ToInt32(Console.ReadLine());
                    if (teste != 0 && teste != 1)
                    {
                        Console.WriteLine("Digite Apenas comandos validos!!!");
                    }
                } while (teste != 0 && teste != 1);
            } while (teste != 0);
        }
    }
}