namespace xadrez_console.board
{
    class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; } // the protected faz com que ele só possa ser alterada por sua class e subclass
        public Board Board {get; protected set; }
        public int QuantityMoves { get; protected set; }

        public Piece(Position position, Color color, Board board, int quantityMoves)
        {
            Position = position;
            Color = color;
            Board = board;
            QuantityMoves = quantityMoves;
        }
    }
}
