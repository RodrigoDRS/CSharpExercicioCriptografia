using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;



namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string DRIVE, ARQUIVO, TEXTO, LINHA, ARQUIVO1;
            int OPCAO, TAMANHO, TAMANHO2;


            //MENU
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Programa para Criptografar/Descriptografar Texto");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("OBS: O Texto dever possuir somente letras maiscúlas, espaços em branco e números; sem acento, sem cedilha e sem demais caracteres especiais");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("[1]-Criptografia");
            Console.WriteLine("[2]-Descriptografia");

            //Escolher a opção do programa
            Console.Write("Escolha a opção:");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            OPCAO = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.White;
            switch (OPCAO)
            {

                //Criptografar
                case 1:

                    Console.WriteLine("\nDigite a letra em que o pendrive está instalado:");
                    DRIVE = Console.ReadLine();
                    Console.WriteLine("\nDigite o nome do arquivo de texto que será salvo(SEM A EXTENSÃO):");
                    ARQUIVO = Console.ReadLine();

                    Console.WriteLine("\nDigite o texto a ser criptografado: \n");
                    TEXTO = Console.ReadLine();
                    Console.WriteLine("\n");

                    TAMANHO = TEXTO.Length;

                    char[] vet_saida = new char[TAMANHO];


                    for (int i = 0; i < TAMANHO; i++)
                    {

                        switch (TEXTO[i])
                        {

                            case 'A': vet_saida[i] = ' '; break;
                            case 'B': vet_saida[i] = '1'; break;
                            case 'C': vet_saida[i] = '2'; break;
                            case 'D': vet_saida[i] = '3'; break;
                            case 'E': vet_saida[i] = '4'; break;
                            case 'F': vet_saida[i] = '5'; break;
                            case 'G': vet_saida[i] = '6'; break;
                            case 'H': vet_saida[i] = '7'; break;
                            case 'I': vet_saida[i] = '8'; break;
                            case 'J': vet_saida[i] = '9'; break;
                            case 'K': vet_saida[i] = 'A'; break;
                            case 'L': vet_saida[i] = 'B'; break;
                            case 'M': vet_saida[i] = 'C'; break;
                            case 'N': vet_saida[i] = 'D'; break;
                            case 'O': vet_saida[i] = 'E'; break;
                            case 'P': vet_saida[i] = 'F'; break;
                            case 'Q': vet_saida[i] = 'G'; break;
                            case 'R': vet_saida[i] = 'H'; break;
                            case 'S': vet_saida[i] = 'I'; break;
                            case 'T': vet_saida[i] = 'J'; break;
                            case 'U': vet_saida[i] = 'K'; break;
                            case 'V': vet_saida[i] = 'L'; break;
                            case 'W': vet_saida[i] = 'M'; break;
                            case 'X': vet_saida[i] = 'N'; break;
                            case 'Y': vet_saida[i] = 'O'; break;
                            case 'Z': vet_saida[i] = 'P'; break;
                            case '0': vet_saida[i] = 'Q'; break;
                            case '1': vet_saida[i] = 'R'; break;
                            case '2': vet_saida[i] = 'S'; break;
                            case '3': vet_saida[i] = 'T'; break;
                            case '4': vet_saida[i] = 'U'; break;
                            case '5': vet_saida[i] = 'V'; break;
                            case '6': vet_saida[i] = 'W'; break;
                            case '7': vet_saida[i] = 'X'; break;
                            case '8': vet_saida[i] = 'Y'; break;
                            case '9': vet_saida[i] = 'X'; break;
                            case ' ': vet_saida[i] = '0'; break;
                            default: vet_saida[i] = '*'; break;

                        }
                    }



                    Console.WriteLine("Texto Criptografado \n");
                    for (int i = 0; i < TAMANHO; i++)
                    {

                        Console.Write("{0}", vet_saida[i]);
                    }
                    Console.ReadLine();

                    ARQUIVO = DRIVE + ":" + ARQUIVO + ".TXT";
                    using (StreamWriter arquivo = File.CreateText(ARQUIVO))
                    {
                        arquivo.WriteLine(vet_saida);
                        arquivo.Close();
                    }

                    break;


                //Descriptografar
                case 2:

                    Console.WriteLine("\nDigite a letra em que o pendrive que contem o arquivo criptografado está instalado:");
                    DRIVE = Console.ReadLine();
                    Console.WriteLine("\nDigite o nome do arquivo de texto que está salvo(SEM A EXTENSÃO):");
                    ARQUIVO = Console.ReadLine();


                    ARQUIVO1 = DRIVE + ":" + ARQUIVO + ".TXT";
                    if (File.Exists(ARQUIVO1))
                    {

                        Console.WriteLine("\n O arquivo descriptografado ficou assim: \n");


                        using (StreamReader SR = File.OpenText(ARQUIVO1))
                        {

                            while ((LINHA = SR.ReadLine()) != null)
                            {


                                TAMANHO2 = LINHA.Length;

                                char[] vet_saida2 = new char[TAMANHO2];

                                for (int i = 0; i < TAMANHO2; i++)
                                {

                                    switch (LINHA[i])
                                    {
                                        case ' ': vet_saida2[i] = 'A'; break;
                                        case '1': vet_saida2[i] = 'B'; break;
                                        case '2': vet_saida2[i] = 'C'; break;
                                        case '3': vet_saida2[i] = 'D'; break;
                                        case '4': vet_saida2[i] = 'E'; break;
                                        case '5': vet_saida2[i] = 'F'; break;
                                        case '6': vet_saida2[i] = 'G'; break;
                                        case '7': vet_saida2[i] = 'H'; break;
                                        case '8': vet_saida2[i] = 'I'; break;
                                        case '9': vet_saida2[i] = 'J'; break;
                                        case 'A': vet_saida2[i] = 'K'; break;
                                        case 'B': vet_saida2[i] = 'L'; break;
                                        case 'C': vet_saida2[i] = 'M'; break;
                                        case 'D': vet_saida2[i] = 'N'; break;
                                        case 'E': vet_saida2[i] = 'O'; break;
                                        case 'F': vet_saida2[i] = 'P'; break;
                                        case 'G': vet_saida2[i] = 'Q'; break;
                                        case 'H': vet_saida2[i] = 'R'; break;
                                        case 'I': vet_saida2[i] = 'S'; break;
                                        case 'J': vet_saida2[i] = 'T'; break;
                                        case 'K': vet_saida2[i] = 'U'; break;
                                        case 'L': vet_saida2[i] = 'V'; break;
                                        case 'M': vet_saida2[i] = 'W'; break;
                                        case 'N': vet_saida2[i] = 'X'; break;
                                        case 'O': vet_saida2[i] = 'Y'; break;
                                        case 'P': vet_saida2[i] = 'Z'; break;
                                        case 'Q': vet_saida2[i] = '0'; break;
                                        case 'R': vet_saida2[i] = '1'; break;
                                        case 'S': vet_saida2[i] = '2'; break;
                                        case 'T': vet_saida2[i] = '3'; break;
                                        case 'U': vet_saida2[i] = '4'; break;
                                        case 'V': vet_saida2[i] = '5'; break;
                                        case 'W': vet_saida2[i] = '6'; break;
                                        case 'X': vet_saida2[i] = '7'; break;
                                        case 'Y': vet_saida2[i] = '8'; break;
                                        case 'Z': vet_saida2[i] = '9'; break;
                                        case '0': vet_saida2[i] = ' '; break;
                                        default: vet_saida2[i] = '*'; break;
                                    }


                                }


                                Console.WriteLine("Texto Descriptografado: \n");
                                for (int i = 0; i < TAMANHO2; i++)
                                {

                                    Console.Write("{0}", vet_saida2[i]);
                                }
                                Console.ReadLine();


                            }

                            SR.Close();
                        }
                    }
                    else
                    {
                        Console.WriteLine("File not found");
                        Console.ReadLine();
                    }
                    break;



            }
        }
    }
}