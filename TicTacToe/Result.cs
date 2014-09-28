using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
        
        public Result(int x ,String A,String B)
        {
            InitializeComponent();
            if (x == 1)
                lblMsg.Text = "Player 1 win!!! Congrats "+A;
            else if (x == 2)
                lblMsg.Text = "Player 2 wins!!! Congrats "+B;
        }
        private void Congrat_Load(object sender, EventArgs e)
        {
           

        }

        private void lblMsg_Click(object sender, EventArgs e)
        {

        }
    }
}
