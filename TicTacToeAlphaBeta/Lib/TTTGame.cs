using System;
using System.Collections;

namespace TicTacToe.Lib
{
    public static class TTTGame
    {
        private static char ai = 'X', opponent = 'O';
        private const int MAX_DEPTH = 6;
        
        /* X = 1
         * O = -1
         * tie = 0
         */
        private static bool IsNotMarked(char v)
        {
            return (v != 'X' && v != 'O');
        }

        //returns true if there are moves
        //returns false if there are no moves to play
        public static bool IsMovesLeft(char[,] board)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (IsNotMarked(board[i, j]))
                        return true;
            return false;
        }

        public static int Utility(char[,] b)
        {

            // Checking for Rows for X or O victory.
            for (int row = 0; row < 3; row++)
            {
                if (b[row, 0] == b[row, 1] && b[row, 1] == b[row, 2])
                {
                    if (b[row, 0] == ai)
                        return 1;
                    else if (b[row, 0] == opponent)
                        return -1;
                }
            }

            // Checking for Columns for X or O victory.
            for (int col = 0; col < 3; col++)
            {
                if (b[0, col] == b[1, col] && b[1, col] == b[2, col])
                {
                    if (b[0, col] == ai)
                        return 1;

                    else if (b[0, col] == opponent)
                        return -1;
                }
            }

            // Checking for Diagonals for X or O victory.
            if (b[0, 0] == b[1, 1] && b[1, 1] == b[2, 2])
            {
                if (b[0, 0] == ai)
                    return 1;
                else if (b[0, 0] == opponent)
                    return -1;
            }

            if (b[0, 2] == b[1, 1] && b[1, 1] == b[2, 0])
            {
                if (b[0, 2] == ai)
                    return 1;
                else if (b[0, 2] == opponent)
                    return -1;
            }

            // Else if none of them have won then return 0
            return 0;
        }


        public static int MiniMax(char[,] gameBoard, int depth, int alpha, int beta, bool isMaximizer)
        {

            // If there are no more moves and
            // no winner then it is a tie
            if (IsMovesLeft(gameBoard) == false)
                return 0;

            int score = Utility(gameBoard);

            // If Maximizer has won the game
            // return his/her evaluated score
            if (score == 1)
                return score;

            // If Minimizer has won the game
            // return his/her evaluated score
            if (score == -1)
                return score;

            if (depth == 0)
                return score;


            //if is Max move
            if (isMaximizer)
            {
                int bestScore = int.MinValue;
                //check all cells
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        //check if cell is trace (unmarked)
                        if (IsNotMarked(gameBoard[i, j]))
                        {
                            // Make the move
                            gameBoard[i, j] = ai;

                            //choose the maximum value
                            bestScore = Math.Max(bestScore, MiniMax(gameBoard, depth -1, alpha, beta, !isMaximizer));

                            alpha = Math.Max(alpha, bestScore);

                            // Undo the move
                            gameBoard[i, j] = '-';

                            if (alpha >= beta)
                                return bestScore;

                          
                        }
                    }
                }
                return bestScore;
            }
            else
            {
                //if is Min move
                int bestScore = int.MaxValue;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        //check if cell is trace (unmarked)
                        if (IsNotMarked(gameBoard[i, j]))
                        {
                            // Make the move
                            gameBoard[i, j] = opponent;

                            //choose the minimum value
                            bestScore = Math.Min(bestScore, MiniMax(gameBoard, depth - 1, alpha, beta, !isMaximizer));

                            beta = Math.Min(beta, bestScore);

                            // Undo the move
                            gameBoard[i, j] = '-';

                            if (beta <= alpha)
                                return bestScore;

                           
                        }
                    }
                }
                return bestScore;

            }
        }

        public static Move FindTheBestMove(char[,] gameBoard)
        {
            Move theBestMove = new Move();
            theBestMove.row = -1;
            theBestMove.col = -1;
            int theBestVal = int.MinValue;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    //check cell without valid value
                    if (IsNotMarked(gameBoard[i, j]))
                    {
                        // Make the move
                        gameBoard[i, j] = ai;

                        //evaluation function
                        int valTmp = MiniMax(gameBoard, MAX_DEPTH, int.MinValue, int.MaxValue, false);

                        // Undo the move
                        gameBoard[i, j] = '-';

                        if (valTmp > theBestVal)
                        {
                            theBestMove.row = i;
                            theBestMove.col = j;
                            theBestVal = valTmp;                            
                        }
                    }
                }
            }

            return theBestMove;
        }
    }
}
