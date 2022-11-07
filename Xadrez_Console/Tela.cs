﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;
using Xadrez;

namespace Tabuleiro
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro_ tab)
        {
            for (int i=0; i<tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
            
            
                for (int j=0; j<tab.colunas; j++)
   
                    {
                        imprimirPeca(tab.peca(i, j));
                        Console.Write(" ");
                    }
                
                Console.WriteLine();
            }
            Console.WriteLine("  A " + " B " + " C "+ " D " + " E " + " F " + " G " + " H ");
        }
        public static void imprimirTabuleiro(Tabuleiro_ tab, bool[,] posicoesPossiveis)
             
        {
            ConsoleColor  fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");


                for (int j = 0; j < tab.colunas; j++)

                {
                    if (posicoesPossiveis[i , j])
                    {
                        Console.BackgroundColor = fundoAlterado;

                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;

                    }
                    imprimirPeca(tab.peca(i, j));
                    Console.BackgroundColor = fundoOriginal;
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
            Console.WriteLine("  A " + " B " + " C " + " D " + " E " + " F " + " G " + " H ");

            Console.BackgroundColor = fundoOriginal;
        }


        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char Coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(Coluna, linha);
        }
        public static void imprimirPeca(Peca peca)
        {
            if (peca == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (peca.cor == Cor.Branca)
                {
                    Console.Write(peca);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }
    }
}
