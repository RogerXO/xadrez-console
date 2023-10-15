﻿using tabuleiro;
using xadrez;
using xadrez_console;

try
{
    PartidaDeXadrez partida = new();

    while (!partida.Terminada)
    {
        Console.Clear();
        Tela.ImprimirTabuleiro(partida.Tab);

        Console.WriteLine();
        Console.Write("Origem: ");
        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
        Console.Write("Destino: ");
        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

        partida.ExecutarMovimento(origem, destino);
    }
}
catch (TabuleiroException e)
{
    Console.Write(e.Message);
}
Console.ReadLine();