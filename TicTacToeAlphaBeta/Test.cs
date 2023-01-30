using TicTacToe.Lib;

namespace TicTacToeAlphaBeta
{
    public static class Test
    {
        public static void TheBestMove()
        {
			char[,] board = {
				   { '-', '-', '-' },
				   { '-', '-', '-' },
				   { '-', '-', '-' }};
			Move bestMove = TTTGame.FindTheBestMove(board);
		}
    }
}
