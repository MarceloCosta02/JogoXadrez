using System;
using System.Collections.Generic;
using System.Text;
using Tabuleiro.Exceptions;

namespace Tabuleiro
{
    class TabuleiroXadrez
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        private Peca[,] Pecas;

        public TabuleiroXadrez(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[Linhas, Colunas];
        }

        public Peca peca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }

        public Peca peca(Posicao pos)
        {
            validarPosicao(pos);
            return Pecas[pos.Linha, pos.Coluna];
        }

        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        public void colocarPeca(Peca p, Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição");
            }
            Pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }

        public Peca retirarPeca(Posicao pos)
        {
            if(peca(pos) == null)
            {
                return null;
            }
            Peca aux = peca(pos);
            aux.Posicao = null;
            Pecas[pos.Linha, pos.Coluna] = null;
            return aux;
        }

        public bool posicaoValida(Posicao pos)
        {
            if(pos.Linha<0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas)
                return false;
            else
                return true;
        }

        public void validarPosicao(Posicao pos)
        {
            if (posicaoValida(pos) == false)            
                throw new TabuleiroException("Posição Inválida!");
            
        }
    }
}
