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
        /*TIED*/
        public Result()
        {
            InitializeComponent();
            this.BackgroundImage = TicTacToe.Properties.Resources.tied;
            this.Text = ":::TIED:::";
            lblMsg.Text = "::::TIED:::";
            lblTime.Text = "";
        }
        /*TIED*/

        /*MultiPlayer result*/
        public Result(int x ,String A,String B, String Time)
        {
            InitializeComponent();
            this.BackgroundImage = TicTacToe.Properties.Resources.g9;
            if (x == 1)
                lblMsg.Text = A+" win!!!";
            else if (x == -1)
                lblMsg.Text = B + " win!!!";
            lblTime.Text = "Time Taken : "+Time;
        }

        /*Single player result*/
        public Result(int x, String A,  String Time)
        {
            InitializeComponent();
            if (x == 1)
            {
                this.BackgroundImage = TicTacToe.Properties.Resources.g9;
                lblMsg.Text ="You Wins\n \t"+A;
                lblTime.Text = "Time Taken : " + Time;
            }
                
            else
            {
                this.Text = "Sorry";
                this.BackgroundImage = TicTacToe.Properties.Resources.sad;
                lblMsg.Text = "You Lose!!! Better Luck next time ";
                lblTime.Text = "";
            }
                           
        }
        /*Single Player result*/
        

        private void Result_Load(object sender, EventArgs e)
        {

        }
    }
}
