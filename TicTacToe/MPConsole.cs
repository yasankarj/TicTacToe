using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace TicTacToe
{
    public partial class MPConsole : Form
    {
         String player1;     //player1
         String player2;     //player 2
        int counter=0;              //counter will differetiate the players
        int [,] grid = new int [3,3];   
        
        GamePlay game;
        
        

        /*Form Constructor*/
        public MPConsole(String P1, String P2)
        {
            /*constructed with two strings which were collected from previous form*/
            InitializeComponent();
            player1 = P1;
            player2 = P2;
        }
        /*Form Constructor*/


        /*Form Load Event*/
        private void MultiPlayerConsole_Load(object sender, EventArgs e)
        {
            /*initialize the panel, initially player 1 will take the chance*/
            lblPlayer1.Text = player1;
            lblPlayer2.Text = player2;
            lblPlayer1.ForeColor = Color.Yellow;
            lblPlayer2.ForeColor = Color.Gray;

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

            game = new GamePlay(player1, player2);
            game.StartGame();

        }
        /*Form Load Event*/

        /*checkGrid method*/
        /*method to track the grid if a player completed the game*/
       

        /*Button click job method will follow up the click events of the grid buttons*/
        public void clickJob(Button btn, Panel pnl)
        {
            btn.Dispose();
          
            if (game.gameCounter % 2 ==0)
            {

                lblPlayer1.ForeColor = Color.Gray;
                lblPlayer2.ForeColor = Color.Yellow;
                pnl.Visible = true;
                pnl.BackgroundImage = TicTacToe.Properties.Resources.X;
            }

            else
            {
                lblPlayer2.ForeColor = Color.Gray;
                lblPlayer1.ForeColor = Color.Yellow;
                pnl.Visible = true;
                pnl.BackgroundImage = TicTacToe.Properties.Resources.O;
            }
            

        }
        /*clickJob method finished*/

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

        public void disablePanel(bool state)
        { 
            if (state)
                panelGrid.Enabled = false;
        }
       
        /*click methods for buttons in the panel*/
        
        private void btn1_Click(object sender, EventArgs e)
        {

            clickJob(btn1, panel1);
            game.Play(1);
            disablePanel(game.terminateState);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            
            clickJob(btn2, panel2);
            game.Play(2);

            disablePanel(game.terminateState);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            
            clickJob(btn3, panel3);
            game.Play(3);

            disablePanel(game.terminateState);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            
            clickJob(btn4, panel4);
            game.Play(4);
            disablePanel(game.terminateState);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            
            clickJob(btn5, panel5);
            game.Play(5);
            disablePanel(game.terminateState);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            
            clickJob(btn6, panel6);
            game.Play(6);
            disablePanel(game.terminateState);
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            
            clickJob(btn7, panel7);
            game.Play(7);
            disablePanel(game.terminateState);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            
            clickJob(btn8, panel8);
            game.Play(8);
            disablePanel(game.terminateState);
        }


        private void btn9_Click(object sender, EventArgs e)
        {
            
            clickJob(btn9, panel9);
            game.Play(9);

            disablePanel(game.terminateState);
        }
        /*click methods for buttons in the panel finished*/
        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        /*mouseEnter and mouseRelease methods for buttons in the panel*/
        private void btn2_MouseEnter(object sender, EventArgs e)
        {
            btnEnter(btn2);
        }

        private void btn2_MouseLeave(object sender, EventArgs e)
        {
            btnRelease(btn2);
        }

        private void btn3_MouseEnter(object sender, EventArgs e)
        {
            btnEnter(btn3);
        }

        private void btn3_MouseLeave(object sender, EventArgs e)
        {
            btnRelease(btn3);
        }

        private void btn4_MouseEnter(object sender, EventArgs e)
        {
            btnEnter(btn4);
        }

        private void btn4_MouseLeave(object sender, EventArgs e)
        {
            btnRelease(btn4);
        }

        private void btn1_MouseEnter(object sender, EventArgs e)
        {
            btnEnter(btn1);
        }

        private void btn1_MouseLeave(object sender, EventArgs e)
        {
            btnRelease(btn1);
        }

        private void btn5_MouseEnter(object sender, EventArgs e)
        {
            btnEnter(btn5);
        }

        private void btn5_MouseLeave(object sender, EventArgs e)
        {
            btnRelease(btn5);
        }

        private void btn6_MouseEnter(object sender, EventArgs e)
        {
            btnEnter(btn6);
        }

        private void btn6_MouseLeave(object sender, EventArgs e)
        {
            btnRelease(btn6);
        }

        private void btn7_MouseEnter(object sender, EventArgs e)
        {
            btnEnter(btn7);
        }

        private void btn7_MouseLeave(object sender, EventArgs e)
        {
            btnRelease(btn7);
        }

        private void btn8_MouseEnter(object sender, EventArgs e)
        {
            btnEnter(btn8);
        }

        private void btn8_MouseLeave(object sender, EventArgs e)
        {
            btnRelease(btn8);
        }

        private void btn9_MouseEnter(object sender, EventArgs e)
        {
            btnEnter(btn9);
        }

        private void btn9_MouseLeave(object sender, EventArgs e)
        {
            btnRelease(btn9);
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        
        
        /*mouseEnter and mouseRelease methods for buttons in the panel*/

    }
}