using xadrez_console.board;

namespace xadrez_console.chessGame
{
    class Tower : Piece
    {
        public Tower(Color color, Board board) : base(color, board)
        {
        }

        public override string ToString()
        {
            return "T";
        }
    }
}