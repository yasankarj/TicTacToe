using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class mulPlayer : Form
    {
        public mulPlayer()
        {
            InitializeComponent();
        }

        private void txtPlayer1_TextChanged(object sender, EventArgs e)
        {
            if (txtPlayer1.Text.Length > 15)
            {
                lblMsg.Text = "Player 1 name should contain \n less than 15 characters";
                btnPlay.Enabled = false;
            }

            else if (txtPlayer1.Text.Length == 0)
            {
                lblMsg.Text = "Please enter Player 1 name";
                btnPlay.Enabled = false;
            }

            else
                btnPlay.Enabled = true;
        }

        private void txtPlayer2_TextChanged(object sender, EventArgs e)
        {
            if (txtPlayer1.Text.Length > 15)
            {
                lblMsg.Text = "Player 2 name should contain \n less than 15 characters";
                btnPlay.Enabled = false;
            }

            else if (txtPlayer1.Text.Length == 0)
            {
                lblMsg.Text = "Please enter Player 2 name";
                btnPlay.Enabled = false;
            }

            else
                btnPlay.Enabled = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
           if (txtPlayer1.Text.Length == 0)
            {
                lblMsg.Text = "Please enter Player 1 name";
            }

           else if (txtPlayer1.Text.Length == 0)
           {
               lblMsg.Text = "Please enter Player 2 name";
           }

           else
           {
               MPConsole newMP = new MPConsole(txtPlayer1.Text, txtPlayer2.Text);
               newMP.ShowDialog();
               this.Dispose();
           }

        }
    }
}
