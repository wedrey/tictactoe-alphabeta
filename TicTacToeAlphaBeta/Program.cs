using System;
using System.Windows.Forms;
using TicTacToeAlphaBeta;

namespace TicTacToe
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //true if test algorith in console
            bool test = false;

            if (!test)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmTicTacToe());
            }
            else
            {
                Test.TheBestMove();
                Console.ReadLine();
            }
            
        }
    }
}
