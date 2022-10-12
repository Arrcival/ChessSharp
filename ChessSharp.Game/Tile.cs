using static ChessSharp.Game.Helper;

namespace ChessSharp.Game;

public class Tile
{
    public PlayerType PlayerType = PlayerType.EMPTY;
    public PieceType PieceType = PieceType.EMPTY;
    public char Column { get; set; }
    public char Row { get; set; }

    public string TileName { 
        get
        {
            char[] chars = { Column, Row };
            return new string(chars); 
        } 
    }

    public Tile(char column, char row)
    {
        Column = column;
        Row = row;
    }

    public Tile(char column, char row, PlayerType playerType, PieceType pieceType) : this(column, row)
    {
        PlayerType = playerType;
        PieceType = pieceType;
    }
}
