using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace TicTacToe
{
    
    public partial class SinPlayerConsole : Form
    {

        private String playerName = "";
        Stopwatch time = new Stopwatch();
        int counter = 0;              //counter will differetiate the players
        int[,] grid = new int[3, 3];   /*2d array to map the game
                                         * array elements will store 0 if no clicks yet
                                         * array elements will hold 1 if player 1 clicks
                                         * array elements will hold 2 f player 2 clicks
                                         */
        /*Single Player Game Console constructor*/
        public SinPlayerConsole(String playerName)
        {
            InitializeComponent();
            this.playerName = playerName;
           
        }
        /*End of Single Player Game Console constructor*/

        /*Form Load Event*/
        private void SinPlayerConsole_Load(object sender, EventArgs e)
        {
            /*initialize the panel, initially player 1 will take the chance*/
            lblPlayer.Text = playerName;
            lblComp.Text = "Computer";
            lblPlayer.ForeColor = Color.Yellow;
            lblComp.ForeColor = Color.Gray;
            time.Start();

            /*panel has a background color, so it will look bad. so it is invisible at the begining*/
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;

            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;

            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            time.Start();
        }
        /*Form Load Event*/
        public void clickJob(Button btn)
        { 
            
        }

        public void markBySystem()
        { 
        
        }

        /*btnEnter method*/
        /*method to perform when mouse pointer enters to the button area*/
        public void btnEnter(Button btn)
        {
            btn.BackgroundImage = TicTacToe.Properties.Resources.relea;
        }
        /*btnEnter method finishes*/

        /*btnRelease method*/
        /*method to perform when mouse pointer enters to the button area*/
        public void btnRelease(Button btn)
        {
            btn.BackgroundImage = TicTacToe.Properties.Resources.click;
        }
        /*btnRelease method finishes*/

    }
}
