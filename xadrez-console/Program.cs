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

                while (!match.Finish)
                {
                    Console.Clear();
                    Screen.PrintBoard(match.Board);
                    Console.WriteLine();

                    Console.Write("Origin: ");
                    Position origin = Screen.ReadPositionChess().ToPosition();

                    bool[,] possibleMoves = match.Board.Piece(origin).PossibleMoves();

                    Console.Clear();
                    Screen.PrintBoard(match.Board, possibleMoves);
                    Console.WriteLine();

                    Console.Write("Destination: ");
                    Position destination = Screen.ReadPositionChess().ToPosition();

                    match.ExecMovement(origin, destination);
                }               
            }

            catch(BoardException bE)
            {
                Console.WriteLine(bE.Message);
            }            
        }
    }
}
