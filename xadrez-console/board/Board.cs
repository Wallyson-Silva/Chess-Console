﻿namespace xadrez_console.board
{
    class Board
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        private Piece[,] Pieces;

        public Board(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;
            Pieces = new Piece[Lines, Columns];
        }

        public Piece Piece(int line, int column)
        {
            return Pieces[line, column];
        }

        public Piece Piece(Position pos)
        {
            return Pieces[pos.Line, pos.Column];
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
            Pieces[pos.Line, pos.Column] = p;
            p.Position = pos;

        }

        public bool PositionValid(Position pos)
        {
            if (pos.Line<0 || pos.Line>=Lines || pos.Column<0 || pos.Column >= Columns)
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
