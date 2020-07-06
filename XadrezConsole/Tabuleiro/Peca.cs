using System;
using System.Collections.Generic;
using System.Text;
using Tabuleiro;

namespace Tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public TabuleiroXadrez Tab { get; protected set; }
    
        public Peca(Posicao posicao, Cor cor, TabuleiroXadrez tab)
        {
            Posicao = posicao;
            Cor = cor;
            Tab = tab;
            QteMovimentos = 0;
        }
    }
}
