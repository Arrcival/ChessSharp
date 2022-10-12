using ChessSharp.Game;
using static ChessSharp.Game.Helper;

namespace ChessSharp.Tests.BoardConverterTests;

public class FenConverterTests
{
    [Fact]
    public void FenToBoard_WhenBoardEmpty()
    {
        Tile[][] board = BoardConverter.FenToBoard("8/8/8/8/8/8/8/8");

        var emptyLine = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };

        for(int i = 0; i < 8; i++)
        {
            Assert.True(TestHelper.IsLinePieceType(board[i], emptyLine));
            Assert.True(TestHelper.IsLinePlayerType(board[i], emptyLine));
        }
    }

    // 1 king, 2 queen, 3 rook, 4 kNight, 5 bishop, 6 pawn
    [Fact]
    public void FenToBoard_WhenBoardStart()
    {
        Tile[][] board = BoardConverter.FenToBoard("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR");

        var emptyLine = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0};
        var pawnLine = new int[8] { 6, 6, 6, 6, 6, 6, 6, 6 };

        Assert.True(TestHelper.IsLinePieceType(board[0], new int[8] { 3, 4, 5, 2, 1, 5, 4, 3 }));
        Assert.True(TestHelper.IsLinePieceType(board[7], new int[8] { 3, 4, 5, 2, 1, 5, 4, 3 }));
        Assert.True(TestHelper.IsLinePieceType(board[1], pawnLine));
        Assert.True(TestHelper.IsLinePieceType(board[6], pawnLine));

        for (int i = 2; i < 6; i++)
        {
            Assert.True(TestHelper.IsLinePieceType(board[i], emptyLine));
            Assert.True(TestHelper.IsLinePlayerType(board[i], emptyLine));
        }

        Assert.True(TestHelper.IsLinePlayerType(board[0], new int[8] { 2, 2, 2, 2, 2, 2, 2, 2 }));
        Assert.True(TestHelper.IsLinePlayerType(board[1], new int[8] { 2, 2, 2, 2, 2, 2, 2, 2 }));
        Assert.True(TestHelper.IsLinePlayerType(board[6], new int[8] { 1, 1, 1, 1, 1, 1, 1, 1 }));
        Assert.True(TestHelper.IsLinePlayerType(board[7], new int[8] { 1, 1, 1, 1, 1, 1, 1, 1 }));
    }

    [Fact]
    public void FenToBoard_WhenBoarMidGame()
    {
        Tile[][] board = BoardConverter.FenToBoard("r3r1k1/pp3nPp/1b1p1B2/1q1P1N2/8/P4Q2/1P3PK1/R6R");

        Assert.True(TestHelper.IsLinePieceType(board[0], new int[8] { 3, 0, 0, 0, 3, 0, 1, 0 }));
        Assert.True(TestHelper.IsLinePieceType(board[1], new int[8] { 6, 6, 0, 0, 0, 4, 6, 6 }));
        Assert.True(TestHelper.IsLinePieceType(board[2], new int[8] { 0, 5, 0, 6, 0, 5, 0, 0 }));
        Assert.True(TestHelper.IsLinePieceType(board[3], new int[8] { 0, 2, 0, 6, 0, 4, 0, 0 }));
        Assert.True(TestHelper.IsLinePieceType(board[4], new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 }));
        Assert.True(TestHelper.IsLinePieceType(board[5], new int[8] { 6, 0, 0, 0, 0, 2, 0, 0 }));
        Assert.True(TestHelper.IsLinePieceType(board[6], new int[8] { 0, 6, 0, 0, 0, 6, 1, 0 }));
        Assert.True(TestHelper.IsLinePieceType(board[7], new int[8] { 3, 0, 0, 0, 0, 0, 0, 3 }));

        Assert.True(TestHelper.IsLinePlayerType(board[0], new int[8] { 2, 0, 0, 0, 2, 0, 2, 0 }));
        Assert.True(TestHelper.IsLinePlayerType(board[1], new int[8] { 2, 2, 0, 0, 0, 2, 1, 2 }));
        Assert.True(TestHelper.IsLinePlayerType(board[2], new int[8] { 0, 2, 0, 2, 0, 1, 0, 0 }));
        Assert.True(TestHelper.IsLinePlayerType(board[3], new int[8] { 0, 2, 0, 1, 0, 1, 0, 0 }));
        Assert.True(TestHelper.IsLinePlayerType(board[4], new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 }));
        Assert.True(TestHelper.IsLinePlayerType(board[5], new int[8] { 1, 0, 0, 0, 0, 1, 0, 0 }));
        Assert.True(TestHelper.IsLinePlayerType(board[6], new int[8] { 0, 1, 0, 0, 0, 1, 1, 0 }));
        Assert.True(TestHelper.IsLinePlayerType(board[7], new int[8] { 1, 0, 0, 0, 0, 0, 0, 1 }));
    }
}
