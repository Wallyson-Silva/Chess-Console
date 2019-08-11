using System;
using xadrez_console.board;
using xadrez_console.chessGame;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8, 8);

            board.PutThePiece(new Tower(Color.Black, board), new Position(0, 3));
            board.PutThePiece(new Tower(Color.Black, board), new Position(1, 5));
            board.PutThePiece(new King(Color.Black, board), new Position(2, 4));

            Screen.PrintBoard(board);
            Console.ReadLine();
        }
    }
}
