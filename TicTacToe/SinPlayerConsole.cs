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

        public int gameCounter = 0;
        private String playerName = "";
        int[,] grid = new int[3, 3];   /*2d array to map the game
                                         * array elements will store 0 if no clicks yet
                                         * array elements will hold 1 if player 1 clicks
                                         * array elements will hold 2 f player 2 clicks
                                         */
        /*Single Player Game Console constructor*/

        GamePlay game;      //GamePlay Object
        public SinPlayerConsole(String playerName)
        {
            InitializeComponent();
            this.playerName = playerName;
            game = new GamePlay(playerName);    //game is constructed for a single game paly
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

            game.StartGame();       //game is started
        }
        /*Form Load Event*/

        /*click events for all buttons*/
        public void clickJob(Button btn, Panel pnl , int val)
        {
            /*clicked button is disposed and relevant panel is markde as X*/
            btn.Dispose();
            pnl.Visible = true;
            pnl.BackgroundImage = TicTacToe.Properties.Resources.X;

            game.PlaySingle(val);

            updatePanel(game.RemovableBtn);     /*update panel will update relavant panel with 0 and dispose relevant button
                                                 according to the picked choice by the computer, Encapsulated*/
            disablePanel(game.TerminateState);  /*if the game is finished, rest of the buttons should not be clickable, Encapsulated*/
            

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

        /*this methos will disable the panel*/
        public void disablePanel(bool state)
        {
            if (state)
                panelGrid.Enabled = false;
        }

        /*this method will remove buttons and update the panel according to the grid index chosen by the computer*/
        public void updatePanel(int Pos)
        {
            switch (Pos)
            { 
                case 1:
                    {
                        btn1.Dispose();
                        panel1.Visible = true;
                        panel1.BackgroundImage = TicTacToe.Properties.Resources.O;
                    }
                    break;

                case 2:
                    {
                        
                        btn2.Dispose();
                        panel2.Visible = true;
                        panel2.BackgroundImage = TicTacToe.Properties.Resources.O;
                    }
                    break;

                case 3:
                    {
                        btn3.Dispose();

                        panel3.Visible = true;
                        panel3.BackgroundImage = TicTacToe.Properties.Resources.O;
                    }
                    break;

                case 4:
                    {
                        btn4.Dispose();

                        panel4.Visible = true;
                        panel4.BackgroundImage = TicTacToe.Properties.Resources.O;
                    }
                    break;

                case 5:
                    {
                        btn5.Dispose();

                        panel5.Visible = true;
                        panel5.BackgroundImage = TicTacToe.Properties.Resources.O;
                    }
                    break;

                case 6:
                    {
                        btn6.Dispose();

                        panel6.Visible = true;
                        panel6.BackgroundImage = TicTacToe.Properties.Resources.O;
                    }
                    break;

                case 7:
                    {
                        btn7.Dispose();

                        panel7.Visible = true;
                        panel7.BackgroundImage = TicTacToe.Properties.Resources.O;
                    }
                    break;

                case 8:
                    {
                        btn8.Dispose();

                        panel8.Visible = true;
                        panel8.BackgroundImage = TicTacToe.Properties.Resources.O;
                    }
                    break;

                case 9:
                    {
                        btn9.Dispose();

                        panel9.Visible = true;
                        panel9.BackgroundImage = TicTacToe.Properties.Resources.O;
                    }
                    break;

                default:
                    break;

            }
        }

        /*click events for buttons*/
        private void btn1_Click(object sender, EventArgs e)
        {
            clickJob(btn1, panel1,1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            clickJob(btn2, panel2, 2);
        }


        private void btn3_Click(object sender, EventArgs e)
        {
            clickJob(btn3, panel3, 3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            clickJob(btn4, panel4, 4);
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            clickJob(btn5, panel5, 5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            clickJob(btn6, panel6, 6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            clickJob(btn7, panel7, 7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            clickJob(btn8, panel8, 8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            clickJob(btn9, panel9, 9);

        }
        /*click events for buttons FINISHED*/

        /*mouse enter and mouse release events for buttons*/
        private void btn1_MouseEnter(object sender, EventArgs e)
        {
            btnEnter(btn1);
        }

        private void btn1_MouseLeave(object sender, EventArgs e)
        {
            btnRelease(btn1);
        }

        private void btn2_MouseEnter(object sender, EventArgs e)
        {
            btnEnter(btn2);
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

        private void btn6_MouseEnter(object sender, EventArgs e)
        {
            btnEnter(btn6);
        }

        private void btn4_MouseLeave(object sender, EventArgs e)
        {
            btnRelease(btn4);
        }

        private void btn5_MouseEnter(object sender, EventArgs e)
        {
            btnEnter(btn5);
        }

        private void btn5_MouseLeave(object sender, EventArgs e)
        {
            btnRelease(btn5);
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

        
    }
}
