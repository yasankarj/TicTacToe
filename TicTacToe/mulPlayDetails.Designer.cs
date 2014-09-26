namespace TicTacToe
{
    partial class mulPlayDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mulPlayDetails));
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.BackColor = System.Drawing.SystemColors.Info;
            this.lblPlayer1.Location = new System.Drawing.Point(34, 34);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(51, 13);
            this.lblPlayer1.TabIndex = 0;
            this.lblPlayer1.Text = "Player 1 :";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.BackColor = System.Drawing.SystemColors.Info;
            this.lblPlayer2.Location = new System.Drawing.Point(34, 72);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(51, 13);
            this.lblPlayer2.TabIndex = 1;
            this.lblPlayer2.Text = "Player 2 :";
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Location = new System.Drawing.Point(91, 27);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(243, 20);
            this.txtPlayer1.TabIndex = 3;
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Location = new System.Drawing.Point(91, 65);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(243, 20);
            this.txtPlayer2.TabIndex = 4;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.BackColor = System.Drawing.SystemColors.Info;
            this.lblMsg.Location = new System.Drawing.Point(88, 114);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(10, 13);
            this.lblMsg.TabIndex = 5;
            this.lblMsg.Text = ".";
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::TicTacToe.Properties.Resources.play;
            this.btnPlay.Location = new System.Drawing.Point(129, 132);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(134, 48);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // mulPlayDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicTacToe.Properties.Resources.players;
            this.ClientSize = new System.Drawing.Size(391, 202);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.txtPlayer2);
            this.Controls.Add(this.txtPlayer1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mulPlayDetails";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mulPlayDetails";
            this.Load += new System.EventHandler(this.mulPlayDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnPlay;
    }
}