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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Crosses_Click(object sender, EventArgs e)
        {
            Databank.initialMove = "X";
            this.Hide();
            PlayForm playform = new PlayForm();
            playform.Show();
        }

        private void zeroes_Click(object sender, EventArgs e)
        {
            Databank.initialMove = "O";
            this.Hide();
            PlayForm playform = new PlayForm();
            playform.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
