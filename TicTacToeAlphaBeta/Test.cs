using TicTacToe.Lib;

namespace TicTacToeAlphaBeta
{
    public static class Test
    {
        public static void TheBestMove()
        {
            /*
            char[,] board = {
                   { 'X', '-', '-' },
                   { 'X', 'O', '-' },
                   { 'O', 'X', 'O' }};
            */

            //slide example
            char[,] board = {
                   { 'O', 'X', '-' },
                   { 'X', '-', '-' },
                   { 'X', 'O', 'O' }};

            TTTGame.setDebug(true);
            Move bestMove = TTTGame.FindTheBestMove(board);
		}
    }
}
