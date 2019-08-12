using System;
using xadrez_console.board;
using xadrez_console.chessGame;

namespace xadrez_console.chessGame
{
    class MatchOfTheChess
    {
        public Board Board { get; set; }
        private int Shift;
        private Color CurrentPlayer;

        public MatchOfTheChess()
        {
            Board = new Board(8, 8);
            Shift = 1;
            CurrentPlayer = Color.White;
            ArrangePieces();
        }

        public void ExecMovement(Position origin, Position destination)
        {
            Piece p = Board.RemovePiece(origin);
            p.IncrementQuantityMoves();
            Piece CapturedPiece = Board.RemovePiece(destination);
            Board.PutThePiece(p, destination);
        }

        public void ArrangePieces()
        {
            Board.PutThePiece(new Tower(Color.White, Board), new PositionChess('c', 1).ToPosition());
            Board.PutThePiece(new Tower(Color.White, Board), new PositionChess('c', 2).ToPosition());
            Board.PutThePiece(new King(Color.White, Board),  new PositionChess('d', 1).ToPosition());
            Board.PutThePiece(new Tower(Color.White, Board), new PositionChess('d', 2).ToPosition());
            Board.PutThePiece(new Tower(Color.White, Board), new PositionChess('e', 1).ToPosition());
            Board.PutThePiece(new Tower(Color.White, Board), new PositionChess('e', 2).ToPosition());

            Board.PutThePiece(new Tower(Color.Black, Board), new PositionChess('c', 7).ToPosition());
            Board.PutThePiece(new Tower(Color.Black, Board), new PositionChess('c', 8).ToPosition());
            Board.PutThePiece(new Tower(Color.Black, Board), new PositionChess('d', 7).ToPosition());
            Board.PutThePiece(new King(Color.Black, Board),  new PositionChess('d', 8).ToPosition());
            Board.PutThePiece(new Tower(Color.Black, Board), new PositionChess('e', 7).ToPosition());
            Board.PutThePiece(new Tower(Color.Black, Board), new PositionChess('e', 8).ToPosition());
        }

    }
}
