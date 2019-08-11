namespace xadrez_console.board
{
    class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; } // the protected faz com que ele só possa ser alterada por sua class e subclass
        public Board Board {get; protected set; }
        public int QuantityMoves { get; protected set; }

        public Piece(Color color, Board board)
        {
            Position = null;
            Color = color;
            Board = board;
            QuantityMoves = 0;
        }
    }
}
