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
        private String player1;     //player1
        private String player2;     //player 2
        int counter=0;              //counter will differetiate the players
        int [,] grid = new int [3,3];   /*2d array to map the game
                                         * array elements will store 0 if no clicks yet
                                         * array elements will hold 1 if player 1 clicks
                                         * array elements will hold 2 f player 2 clicks
                                         */
        Stopwatch time = new Stopwatch();

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
            time.Start();

        }
        /*Form Load Event*/

        /*checkGrid method*/
        /*method to track the grid if a player completed the game*/
        public void checkGrid(int x)
        {
            
            /*check for first row of the grid*/
            if (grid[0, 0] == x && grid[0, 1] == x && grid[0, 2] == x)
            {
                performWhenGrid(x);
            }
            /*check for second row of the grid*/
            else if (grid[1, 0] == x && grid[1, 1] == x && grid[1, 2] == x)
            {
                performWhenGrid(x);
            }

             /*check for third row of the grid*/
            else if (grid[2, 0] == x && grid[2, 1] == x && grid[2, 2] == x)
            {
                performWhenGrid(x);
            }

             /*check for fourth column of the grid*/
            else if (grid[0, 0] == x && grid[1, 0] == x && grid[2, 0] == x)
            {
                performWhenGrid(x);
            }

             /*check for fifth column of the grid*/
            else if (grid[0, 1] == x && grid[1, 1] == x && grid[2, 1] == x)
            {
                performWhenGrid(x);
            }

             /*check for sixth column of the grid*/
            else if (grid[0, 2] == x && grid[1, 2] == x && grid[2, 2] == x)
            {
                performWhenGrid(x);
            }

             /*check for first diagonal of the grid*/
            else if (grid[0, 0] == x && grid[1, 1] == x && grid[2, 2] == x)
            {
                performWhenGrid(x);
            }

             /*check for second diagonal of the grid*/
            else if (grid[0, 2] == x && grid[1, 1] == x && grid[2, 0] == x)
            {
                performWhenGrid(x);

            }

            else if (counter == 9)
            {
                panelGrid.Enabled = false;
                Result newConForm = new Result();
                newConForm.Show();
            }
        }
        /*checkGrid method*/

        /*perform when grid is in a winning pattern*/
        public void performWhenGrid(int x)
        {
            panelGrid.Enabled = false;
            time.Stop();
            long t = time.ElapsedMilliseconds;
            timeStamp timeC = new timeStamp(t / 1000);
            Result newConForm = new Result(x, player1, player2,timeC.show());
            newConForm.Show();
        }
        /* performWhenGrid finished*/

        /*Button click job method will follow up the click events of the grid buttons*/
        public int clickJob(Button btn, Panel pnl)
        {
            btn.Dispose();
            int retVal = 0;
          
            if (counter % 2 == 0)
            {

                lblPlayer1.ForeColor = Color.Gray;
                lblPlayer2.ForeColor = Color.Yellow;
                retVal = 1;
                pnl.Visible = true;
                pnl.BackgroundImage = TicTacToe.Properties.Resources.X;
            }

            else
            {
                lblPlayer2.ForeColor = Color.Gray;
                lblPlayer1.ForeColor = Color.Yellow;
                retVal= 2;
                pnl.Visible = true;
                pnl.BackgroundImage = TicTacToe.Properties.Resources.O;
            }
            counter++;
            return retVal;

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


       
        /*click methods for buttons in the panel*/
        private void button2_Click(object sender, EventArgs e)
        {
            grid[0, 1] = clickJob(btn2, panel2);
            checkGrid(grid[0, 1]);
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            grid[2, 0] = clickJob(btn7, panel7);
            checkGrid(grid[2, 0]);
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            grid[2,1]=clickJob(btn8,panel8);
            checkGrid(grid[2, 1]);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
           grid [0,0]=clickJob(btn1,panel1);
           checkGrid(grid[0, 0]);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            grid[0, 1] = clickJob(btn2, panel2);
            checkGrid(grid[0, 1]);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
           grid [0,2] = clickJob(btn3,panel3);
           checkGrid(grid[0, 2]);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            grid[1, 0] = clickJob(btn4, panel4);
            checkGrid(grid[1, 0]);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            grid[1, 1] = clickJob(btn5, panel5);
           checkGrid(grid[1, 1]);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            grid[1, 2] = clickJob(btn6, panel6);
            checkGrid(grid[1, 2]);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            grid[2, 2] = clickJob(btn9, panel9);
            checkGrid(grid[2, 2]);
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
        /*mouseEnter and mouseRelease methods for buttons in the panel*/

    }
}