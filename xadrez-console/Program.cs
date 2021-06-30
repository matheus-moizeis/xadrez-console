using System;
using tabuleiro;
using xadrez;


namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 1));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 2));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(3, 3));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(4, 4));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(5, 5));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(6, 6));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(7, 7));

            Tela.imprimirTabuleiro(tab);
            Console.ReadLine();
        }
    }
}
