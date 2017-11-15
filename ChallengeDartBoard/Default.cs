using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Darts;

namespace ChallengeDartBoard
{
    public partial class Default : Form
    {
        public Default()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Game game = new Game("Player 1: ", "Player 2: ");
            // Expect back a string result from calling "game.Play()".
            string result = game.Play();
            resultLabel.Text = result;
        }

        private void Default_Load(object sender, EventArgs e)
        {

        }
    }
}