using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTicTacToe
{
    public partial class PlayForm : Form
    {
        public PlayForm()
        {
            InitializeComponent();
            RegisterClick();
            Rounds.Text = Databank.numbersOfRound.ToString();
        }
        string VictoryOfCrosses = "The crosses won!";
        string VictoryOfZeros = "The zeroes won!";
        private void Square_Click(object sender, EventArgs e)
        {
            Button clickedSquare = sender as Button;
            if (clickedSquare != null && clickedSquare.Text == "N")
            {
                clickedSquare.Text = Databank.initialMove;
                clickedSquare.ForeColor = Databank.initialMove == "X" ? Color.Red : Color.Green;
                Databank.initialMove = Databank.initialMove == "X" ? "O" : "X";
                CheackForVictory();
            }
            else
            {
                MessageBox.Show("It's busy here!");
            }
        }
        private void RegisterClick()
        {
            Square1.Click += Square_Click;
            Square2.Click += Square_Click;
            Square3.Click += Square_Click;
            Square4.Click += Square_Click;
            Square5.Click += Square_Click;
            Square6.Click += Square_Click;
            Square7.Click += Square_Click;
            Square8.Click += Square_Click;
            Square9.Click += Square_Click;
        }
        void CheackForVictory()
        {
            string[,] board = new string[3, 3]
            {
                 { Square1.Text, Square2.Text, Square3.Text },
                 { Square4.Text, Square5.Text, Square6.Text },
                 { Square7.Text, Square8.Text, Square9.Text }
            };
            string winner = null;
            // Проверка строк и столбцов
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] != "N" && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                    winner = board[i, 0];
                if (board[0, i] != "N" && board[0, i] == board[1, i] && board[1, i] == board[2, i])
                    winner = board[0, i];
            }
            // Проверка диагоналей
            if (board[0, 0] != "N" && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                winner = board[0, 0];
            if (board[0, 2] != "N" && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                winner = board[0, 2];

            if (winner != null)
            {
                if (winner == "X")
                {
                    VictoryCross();
                }
                else
                {
                    VictoryZeros();
                }
            }
            else if (board.Cast<string>().All(s => s != "N"))
            {
                MessageBox.Show("Draw!", "Game over");
                NewRound();
            }
        }
        void VictoryCross()
        {
            MessageBox.Show(VictoryOfCrosses, "Game over");
            Databank.pointCross++;
            CrossPoints.Text = Databank.pointCross.ToString();
            NewRound();
        }
        void VictoryZeros()
        {
            MessageBox.Show(VictoryOfZeros, "Game over");
            Databank.pointZeros++;
            ZerosPoints.Text = Databank.pointZeros.ToString();
            NewRound();
        }
        private void StartAgain_Click(object sender, EventArgs e)
        {
            DialogResult starnAgain = MessageBox.Show("Are you sure you want to start over? The account will be reset.", "Start again", MessageBoxButtons.YesNo);
            if (starnAgain == DialogResult.Yes)
            {
                Databank.pointZeros = 0;
                Databank.pointCross = 0;
                Databank.numbersOfRound = 0;
                CrossPoints.Text = Databank.pointCross.ToString();
                ZerosPoints.Text = Databank.pointZeros.ToString();
                NewRound();
            }
        }
        void NewRound()
        {
            Databank.numbersOfRound++;
            Rounds.Text = Databank.numbersOfRound.ToString();
            foreach (Control c in this.Controls)
            {
                if (c is Button && c.Name.StartsWith("Square"))
                {
                    c.Text = "N";
                    c.ForeColor = Color.White;
                }
            }
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult programClose = MessageBox.Show("Are you sure you want to go out?", "Closing the program", MessageBoxButtons.YesNo);
            if (programClose == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
