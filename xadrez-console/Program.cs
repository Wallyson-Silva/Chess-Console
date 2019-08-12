using System;
using xadrez_console.board;
using xadrez_console.chessGame;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MatchOfTheChess match = new MatchOfTheChess();                

                Screen.PrintBoard(match.Board);
                Console.ReadLine();
            }

            catch(BoardException bE)
            {
                Console.WriteLine(bE.Message);
            }
            
        }
    }
}
