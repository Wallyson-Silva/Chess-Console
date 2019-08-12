namespace xadrez_console.board
{
    class Board
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        private Piece[,] MatPieces; //Matrix of the pieces

        public Board(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;
            MatPieces = new Piece[Lines, Columns]; //the new matrix of type Piece - [Lines, Columns] - for example [8, 8]
        }

        public Piece Piece(int line, int column)
        {
            return MatPieces[line, column];
        }

        public Piece Piece(Position pos)
        {
            return MatPieces[pos.Line, pos.Column];
        }

        public bool ThereIsPiece(Position pos)
        {
            ValidatePosition(pos);
            return Piece(pos) != null;
        }

        public void PutThePiece(Piece p, Position pos)
        {
            if (ThereIsPiece(pos))
            {
                throw new BoardException("There was an attempt to include piece where one already existed.");
            }
            MatPieces[pos.Line, pos.Column] = p;
            p.Position = pos;
        }

        public Piece RemovePiece(Position pos)
        {
            if(Piece(pos) == null)
            {
                return null;
            }
            else
            {
                Piece aux = Piece(pos);
                aux.Position = null;
                MatPieces[pos.Line, pos.Column] = null;
                return aux;
            }
        }

        public bool PositionValid(Position pos)
        {
            if (pos.Line<0 || pos.Line>=Lines || pos.Column<0 || pos.Column>=Columns)
            {
                return false;
            }
            return true;
        }

        public void ValidatePosition(Position pos)
        {
            if (!PositionValid(pos))
            {
                throw new BoardException("There was an attempt to include a piece in a position invalid.");
            }
        }

    }
}