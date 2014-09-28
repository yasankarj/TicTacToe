using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class frmChoices : Form
    {
        public frmChoices()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            MusicPlay player = new MusicPlay();
            player.playIntroSound();

          
        }

        private void btnOne_Click(object sender, EventArgs e)
        {

            SinPlayer newSP = new SinPlayer();
            newSP.ShowDialog();
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            mulPlayer newMP = new mulPlayer();
            newMP.Show();
        }
    }
}
