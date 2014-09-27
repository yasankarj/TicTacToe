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
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        public Result(int x)
        {
            InitializeComponent();
            if (x == 1)
                lblMsg.Text = "Player 1 wins";
            if (x == 2)
                lblMsg.Text = "Player 2 wins";
        }
        private void Congrat_Load(object sender, EventArgs e)
        {

        }
    }
}
