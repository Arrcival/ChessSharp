using ChessSharp.Game;
using static ChessSharp.Game.Helper;

namespace ChessSharp.Tests
{
    public static class TestHelper
    {
        public static bool IsLinePieceType(Tile[] line, int[] pieceType)
        {
            for(int i = 0; i < line.Length; i++)
            {
                if (line[i] == null) return false;
                if ((int)line[i].PieceType != pieceType[i]) return false;
            }
            return true;
        }

        public static bool IsLinePlayerType(Tile[] line, int[] pieceType)
        {
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == null) return false;
                if ((int)line[i].PlayerType != pieceType[i]) return false;
            }
            return true;
        }

    }
}
