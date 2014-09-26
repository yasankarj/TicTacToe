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
    public partial class mulPlayDetails : Form
    {
        public mulPlayDetails()
        {
            InitializeComponent();
        }


        private void mulPlayDetails_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (txtPlayer1.Text.Equals(""))
                lblMsg.Text = "Please enter the name of player 1";
            else if (txtPlayer2.Text.Equals(""))
                lblMsg.Text = "Please enter the name of player 2";

            else
            {
                MPConsole newMPC = new MPConsole(txtPlayer1.Text, txtPlayer2.Text);
                newMPC.ShowDialog();
                this.Close();

            }
        }
    }
}
