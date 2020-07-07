using System;
using System.Collections.Generic;
using System.Text;
using Tabuleiro;

namespace Tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public TabuleiroXadrez Tab { get; protected set; }
    
        public Peca(Cor cor, TabuleiroXadrez tab)
        {
            Posicao = null;
            Cor = cor;
            Tab = tab;
            QteMovimentos = 0;
        }

        public void incrementarQtdMovimentos()
        {
            QteMovimentos++;
        }

        public abstract bool[,] movimentosPossiveis();
    }
}
