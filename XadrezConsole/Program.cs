using System;
using Tabuleiro;

namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TabuleiroXadrez tab = new TabuleiroXadrez(8,8);

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
