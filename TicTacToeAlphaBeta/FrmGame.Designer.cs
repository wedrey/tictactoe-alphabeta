namespace TicTacToe
{
    partial class FrmTicTacToe
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSair = new System.Windows.Forms.Button();
            this.btn00 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(257, 515);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(219, 89);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btn00
            // 
            this.btn00.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn00.Location = new System.Drawing.Point(32, 40);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(144, 144);
            this.btn00.TabIndex = 1;
            this.btn00.UseVisualStyleBackColor = false;
            this.btn00.Click += new System.EventHandler(this.btn00_Click_1);
            // 
            // btn01
            // 
            this.btn01.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn01.Location = new System.Drawing.Point(182, 40);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(144, 144);
            this.btn01.TabIndex = 2;
            this.btn01.Click += new System.EventHandler(this.btn01_Click_1);
            // 
            // btn02
            // 
            this.btn02.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn02.Location = new System.Drawing.Point(332, 40);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(144, 144);
            this.btn02.TabIndex = 3;
            this.btn02.Click += new System.EventHandler(this.btn02_Click_1);
            // 
            // btn10
            // 
            this.btn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10.Location = new System.Drawing.Point(32, 190);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(144, 144);
            this.btn10.TabIndex = 4;
            this.btn10.Click += new System.EventHandler(this.btn10_Click_1);
            // 
            // btn11
            // 
            this.btn11.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn11.Location = new System.Drawing.Point(182, 190);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(144, 144);
            this.btn11.TabIndex = 5;
            this.btn11.Click += new System.EventHandler(this.btn11_Click_1);
            // 
            // btn12
            // 
            this.btn12.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn12.Location = new System.Drawing.Point(332, 190);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(144, 144);
            this.btn12.TabIndex = 6;
            this.btn12.Click += new System.EventHandler(this.btn12_Click_1);
            // 
            // btn20
            // 
            this.btn20.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn20.Location = new System.Drawing.Point(32, 340);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(144, 144);
            this.btn20.TabIndex = 7;
            this.btn20.Click += new System.EventHandler(this.btn20_Click_1);
            // 
            // btn21
            // 
            this.btn21.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn21.Location = new System.Drawing.Point(182, 340);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(144, 144);
            this.btn21.TabIndex = 8;
            this.btn21.Click += new System.EventHandler(this.btn21_Click_1);
            // 
            // btn22
            // 
            this.btn22.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn22.Location = new System.Drawing.Point(332, 340);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(144, 144);
            this.btn22.TabIndex = 9;
            this.btn22.Click += new System.EventHandler(this.btn22_Click_1);
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.BackColor = System.Drawing.Color.LightGreen;
            this.btnRestartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestartGame.Location = new System.Drawing.Point(32, 515);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(219, 89);
            this.btnRestartGame.TabIndex = 10;
            this.btnRestartGame.Text = "&Reiniciar Jogo";
            this.btnRestartGame.UseVisualStyleBackColor = false;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // FrmTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 676);
            this.ControlBox = false;
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn02);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.btn01);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn00);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmTicTacToe";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btnRestartGame;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

