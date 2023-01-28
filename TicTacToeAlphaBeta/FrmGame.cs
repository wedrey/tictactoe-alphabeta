using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Lib;

namespace TicTacToe
{
    public partial class FrmTicTacToe : Form
    {
        private char[,] board = {
                   { '-', '-', '-' },
                   { '-', '-', '-' },
                   { '-', '-', '-' }};
        
        private char ai = 'X';
        private char opponent = 'O';
        //+1 win
        //-1 lose
        // 0 tie
        
        public FrmTicTacToe()
        {
            InitializeComponent();

            SetStartRandom();
            
        }

        private void SetStartRandom()
        {
            Random rnd = new Random();
            int r = rnd.Next(0, 2);
            int c = rnd.Next(0, 2);

            board[r, c] = ai;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    this.Controls.Find("btn" + i + "" + j, true).FirstOrDefault().BackColor = SystemColors.Control;
                    this.Controls.Find("btn" + i + "" + j, true).FirstOrDefault().Enabled = true;
                    this.Controls.Find("btn" + i + "" + j, true).FirstOrDefault().Text = board[i, j].ToString();
                }
                    
            }

            this.Controls.Find("btn" + r + "" + c, true).FirstOrDefault().Enabled = false;
            this.Controls.Find("btn" + r + "" + c, true).FirstOrDefault().BackColor = Color.DarkCyan;
                
        }
        private void EndProgram()
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        private void SairDoSistema()
        {
            DialogResult dialogResult = MessageBox.Show("Confirma Sair do Jogo?", "Sair do Jogo", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.No)
                EndProgram();

        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    board[i, j] = '-';

            SetStartRandom();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            SairDoSistema();
        }

        private void SetMarkPlayedToForm()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    char v = char.Parse(this.Controls.Find("btn" + i + "" + j, true).FirstOrDefault().Text);
                    if (v == 'O')
                        this.Controls.Find("btn" + i + "" + j, true).FirstOrDefault().BackColor = Color.DarkSeaGreen;
                    else if (v == 'X')
                        this.Controls.Find("btn" + i + "" + j, true).FirstOrDefault().BackColor = Color.DarkCyan;

                    board[i, j] = v;
                }
            }
        }

        private void MarkAI(Move bestMove)
        {
            if (bestMove.row >= 0 && bestMove.col >= 0)
            {
                Controls.Find("btn" + bestMove.row + "" + bestMove.col, true).FirstOrDefault().Text = ai.ToString();
                Controls.Find("btn" + bestMove.row + "" + bestMove.col, true).FirstOrDefault().Enabled = false;
            }

            SetMarkPlayedToForm();

            int r = TTTGame.Utility(board);
        
            if (r != 0)
            {
                string msg = "";
                if (r == 1)
                    msg = "Você Perdeu!";
                else if (r == -1)
                    msg = "Você Ganhou!";
                
                MessageBox.Show(msg, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else if (!TTTGame.IsMovesLeft(board))
                MessageBox.Show("Não houve ganhador!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);


        }

        private void MarkMarkOpponentAI(string iBtn)
        {
            Controls.Find("btn"+ iBtn, true).FirstOrDefault().Text = opponent.ToString();
            Controls.Find("btn" + iBtn, true).FirstOrDefault().Enabled = false;
        }

        private void btn00_Click_1(object sender, EventArgs e)
        {
            MarkMarkOpponentAI("00");
            SetMarkPlayedToForm();
            Move bestMove = TTTGame.FindTheBestMove(board);
            MarkAI(bestMove);
        }

        private void btn01_Click_1(object sender, EventArgs e)
        {
            MarkMarkOpponentAI("01");
            SetMarkPlayedToForm();
            Move bestMove = TTTGame.FindTheBestMove(board);
            MarkAI(bestMove);
        }

        private void btn02_Click_1(object sender, EventArgs e)
        {
            MarkMarkOpponentAI("02");
            SetMarkPlayedToForm();
            Move bestMove = TTTGame.FindTheBestMove(board);
            MarkAI(bestMove);
        }

        private void btn10_Click_1(object sender, EventArgs e)
        {
            MarkMarkOpponentAI("10");
            SetMarkPlayedToForm();
            Move bestMove = TTTGame.FindTheBestMove(board);
            MarkAI(bestMove);
        }

        private void btn11_Click_1(object sender, EventArgs e)
        {
            MarkMarkOpponentAI("11");
            SetMarkPlayedToForm();
            Move bestMove = TTTGame.FindTheBestMove(board);
            MarkAI(bestMove);
        }

        private void btn12_Click_1(object sender, EventArgs e)
        {
            MarkMarkOpponentAI("12");
            SetMarkPlayedToForm();
            Move bestMove = TTTGame.FindTheBestMove(board);
            MarkAI(bestMove);
        }

        private void btn20_Click_1(object sender, EventArgs e)
        {
            MarkMarkOpponentAI("20");
            SetMarkPlayedToForm();
            Move bestMove = TTTGame.FindTheBestMove(board);
            MarkAI(bestMove);
        }

        private void btn21_Click_1(object sender, EventArgs e)
        {
            MarkMarkOpponentAI("21");
            SetMarkPlayedToForm();
            Move bestMove = TTTGame.FindTheBestMove(board);
            MarkAI(bestMove);
        }

        private void btn22_Click_1(object sender, EventArgs e)
        {
            MarkMarkOpponentAI("22");
            SetMarkPlayedToForm();
            Move bestMove = TTTGame.FindTheBestMove(board);
            MarkAI(bestMove);
        }

    }
}
