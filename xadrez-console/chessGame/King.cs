using xadrez_console.board;

namespace xadrez_console.chessGame
{
    class King : Piece
    {
        public King(Color color, Board board) : base(color, board)
        {
        }

        public override string ToString()
        {
            return "K";
        }

        private bool YesMove(Position pos)
        {
            Piece p = Board.Piece(pos);
            return p == null || p.Color != Color;
        }

        public override bool[,] PossibleMoves()
        {
            bool[,] mat = new bool[Board.Lines, Board.Columns];

            Position pos = new Position(0, 0);

            //above
            pos.DefineValues(Position.Line - 1, Position.Column);
            if (Board.PositionValid(pos) && YesMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }
            //
            pos.DefineValues(Position.Line - 1, Position.Column + 1);
            if (Board.PositionValid(pos) && YesMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }
            //
            pos.DefineValues(Position.Line, Position.Column + 1);
            if (Board.PositionValid(pos) && YesMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }
            //
            pos.DefineValues(Position.Line + 1, Position.Column + 1);
            if (Board.PositionValid(pos) && YesMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }
            //
            pos.DefineValues(Position.Line + 1, Position.Column);
            if (Board.PositionValid(pos) && YesMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }
            //
            pos.DefineValues(Position.Line + 1, Position.Column - 1);
            if (Board.PositionValid(pos) && YesMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }
            //
            pos.DefineValues(Position.Line, Position.Column - 1);
            if (Board.PositionValid(pos) && YesMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }
            //
            pos.DefineValues(Position.Line - 1, Position.Column - 1);
            if (Board.PositionValid(pos) && YesMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }
            return mat;
        }
    }
}
