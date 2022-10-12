using static ChessSharp.Game.Helper;

namespace ChessSharp.Game;

public static class BoardConverter
{
    public static Tile[][] FenToBoard(string fen)
    {
        var board = new Tile[8][];
        string[] fenSplitted = fen.Split('/');
        for(int i = 0; i < fenSplitted.Length; i++)
        {
            var currentLine = new Tile[8];
            char[] charArray = fenSplitted[i].ToCharArray();
            int index = 0;
            for(int j = 0; j < charArray.Length; j++)
            {
                if (char.IsDigit(charArray[j]))
                {
                    int value = (int)char.GetNumericValue(charArray[j]);
                    for(int k = 1; k <= value; k++)
                    {
                        currentLine[index] = new Tile(IntToColumn[i], IntToLine[index]);
                        index++;
                    }
                }
                else
                {
                    PlayerType playerType = char.IsUpper(charArray[j]) ? PlayerType.WHITE : PlayerType.BLACK;
                    currentLine[index] = new Tile(IntToColumn[i], IntToLine[index], playerType, CharToPieceType[char.ToLower(charArray[j])]);
                    index++;
                }
            }
            board[i] = currentLine;
        }

        return board;
    }
}
