namespace ChessSharp.Game;

public static class Helper
{
    public enum PieceType
    {
        EMPTY = 0,
        KING,
        QUEEN,
        ROOK,
        KNIGHT,
        BISHOP,
        PAWN
    }
    public enum PlayerType { EMPTY = 0, WHITE, BLACK }

    public static Dictionary<int, char> IntToColumn = new Dictionary<int, char>
    {
        { 0, 'A'},
        { 1, 'B'},
        { 2, 'C'},
        { 3, 'D'},
        { 4, 'E'},
        { 5, 'F'},
        { 6, 'G'},
        { 7, 'H'}
    };
    public static Dictionary<int, char> IntToLine = new Dictionary<int, char>
    {
        { 0, '1'},
        { 1, '2'},
        { 2, '3'},
        { 3, '4'},
        { 4, '5'},
        { 5, '6'},
        { 6, '7'},
        { 7, '8'}
    };

    public static Dictionary<char, PieceType> CharToPieceType = new Dictionary<char, PieceType>
    {
        { 'r', PieceType.ROOK },
        { 'q', PieceType.QUEEN },
        { 'k', PieceType.KING },
        { 'b', PieceType.BISHOP },
        { 'n', PieceType.KNIGHT },
        { 'p', PieceType.PAWN }
    };
}