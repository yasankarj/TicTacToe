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
    public partial class SinPlayer : Form
    {
        public SinPlayer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SinPlayerConsole newSP = new SinPlayerConsole(txtPlayer.Text);
            newSP.ShowDialog();
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtPlayer.Text.Length == 0)
            {
                btnPlay.Enabled = false;
            }

            else if (txtPlayer.Text.Length > 15)
            {
                btnPlay.Enabled = false;
                lblMsg.Text = "Player name should be shorter than 15 characters";
            }

            else
            {
                btnPlay.Enabled = true;
            }
        }
    }
}
