namespace HangmanProject
{
    partial class HangmanGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HangmanGame));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HangmanPost = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstBxhighScore = new System.Windows.Forms.ListBox();
            this.lstBxscoreboard = new System.Windows.Forms.ListBox();
            this.lblLives = new System.Windows.Forms.Label();
            this.lblMissed = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLetter = new System.Windows.Forms.TextBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnGuess = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnStart.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnStart.Location = new System.Drawing.Point(206, 185);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(283, 34);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Snow;
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(247, 255);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(220, 34);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Tempus Sans ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Red;
            this.lblWelcome.Location = new System.Drawing.Point(105, 52);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(520, 62);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome to Hangman ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.HangmanPost);
            this.groupBox1.Location = new System.Drawing.Point(6, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 252);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // HangmanPost
            // 
            this.HangmanPost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HangmanPost.Location = new System.Drawing.Point(3, 16);
            this.HangmanPost.Name = "HangmanPost";
            this.HangmanPost.Size = new System.Drawing.Size(215, 233);
            this.HangmanPost.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lstBxhighScore);
            this.groupBox2.Controls.Add(this.lstBxscoreboard);
            this.groupBox2.Controls.Add(this.lblLives);
            this.groupBox2.Controls.Add(this.lblMissed);
            this.groupBox2.Controls.Add(this.lblNumber);
            this.groupBox2.Controls.Add(this.lblSize);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(233, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 252);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // lstBxhighScore
            // 
            this.lstBxhighScore.FormattingEnabled = true;
            this.lstBxhighScore.Location = new System.Drawing.Point(331, 16);
            this.lstBxhighScore.Name = "lstBxhighScore";
            this.lstBxhighScore.Size = new System.Drawing.Size(101, 43);
            this.lstBxhighScore.TabIndex = 7;
            // 
            // lstBxscoreboard
            // 
            this.lstBxscoreboard.FormattingEnabled = true;
            this.lstBxscoreboard.Location = new System.Drawing.Point(202, 16);
            this.lstBxscoreboard.Name = "lstBxscoreboard";
            this.lstBxscoreboard.Size = new System.Drawing.Size(123, 69);
            this.lstBxscoreboard.TabIndex = 6;
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLives.Location = new System.Drawing.Point(330, 215);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(56, 13);
            this.lblLives.TabIndex = 3;
            this.lblLives.Text = "Lives Left:";
            // 
            // lblMissed
            // 
            this.lblMissed.AutoSize = true;
            this.lblMissed.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMissed.Location = new System.Drawing.Point(3, 215);
            this.lblMissed.Name = "lblMissed";
            this.lblMissed.Size = new System.Drawing.Size(72, 13);
            this.lblMissed.TabIndex = 2;
            this.lblMissed.Text = "Missed Word:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNumber.Location = new System.Drawing.Point(75, 20);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(0, 13);
            this.lblNumber.TabIndex = 1;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSize.Location = new System.Drawing.Point(7, 20);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(72, 13);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Word Length:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtLetter);
            this.groupBox3.Controls.Add(this.btnRestart);
            this.groupBox3.Controls.Add(this.btnGuess);
            this.groupBox3.Location = new System.Drawing.Point(12, 282);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(659, 100);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Visible = false;
            // 
            // txtLetter
            // 
            this.txtLetter.Location = new System.Drawing.Point(266, 42);
            this.txtLetter.Name = "txtLetter";
            this.txtLetter.Size = new System.Drawing.Size(113, 20);
            this.txtLetter.TabIndex = 2;
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(493, 40);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(120, 23);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(14, 40);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(120, 23);
            this.btnGuess.TabIndex = 0;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // HangmanGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(683, 394);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.MaximizeBox = false;
            this.Name = "HangmanGame";
            this.Text = "Hangman";
            this.Shown += new System.EventHandler(this.HangmanGame_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel HangmanPost;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtLetter;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Label lblMissed;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.ListBox lstBxhighScore;
        private System.Windows.Forms.ListBox lstBxscoreboard;
    }

}

