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

            TTTGame.setDebug(true);
            Move bestMove = TTTGame.FindTheBestMove(board);
		}
    }
}
