namespace TicTacToe
{
    partial class frmChoices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoices));
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.PaleGreen;
            this.btnOne.BackgroundImage = global::TicTacToe.Properties.Resources.btnSingle;
            resources.ApplyResources(this.btnOne, "btnOne");
            this.btnOne.ForeColor = System.Drawing.Color.Crimson;
            this.btnOne.Name = "btnOne";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.PaleGreen;
            this.btnTwo.BackgroundImage = global::TicTacToe.Properties.Resources.multi;
            resources.ApplyResources(this.btnTwo, "btnTwo");
            this.btnTwo.ForeColor = System.Drawing.Color.Crimson;
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // frmChoices
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicTacToe.Properties.Resources.mainBG;
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmChoices";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
    }
}

