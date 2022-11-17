﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;

namespace Xadrez_Console.Xadrez
{
    class Cavalo : Peca
    {
    public Cavalo(Tabuleiro_ tab, Cor cor) : base(tab, cor)
    {

    }

    public override string ToString()
    {
        return "C";
    }
    private bool podeMover(Posicao pos)
    {
        Peca p = tab.peca(pos);
        return p == null || p.cor != cor;
    }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            
            pos.definirValores(posicao.linha - 1, posicao.coluna - 2);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.linha - 2, pos.coluna + 1);
            }

            
            pos.definirValores(posicao.linha - 1, posicao.coluna + 2);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.linha + 1, pos.coluna + 1);
            }

            
            pos.definirValores(posicao.linha + 2, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.linha + 1, pos.coluna - 2);
            }
            return mat;

        }    
    }
}
