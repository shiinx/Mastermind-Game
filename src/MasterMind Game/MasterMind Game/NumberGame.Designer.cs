namespace MasterMind_Game
{
    partial class frmNumberGame
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
            this.btnScoreBoard = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.chkInsane = new System.Windows.Forms.CheckBox();
            this.chkHard = new System.Windows.Forms.CheckBox();
            this.chkMedium = new System.Windows.Forms.CheckBox();
            this.chkEasy = new System.Windows.Forms.CheckBox();
            this.txtDigitInput = new System.Windows.Forms.TextBox();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.lblDigits = new System.Windows.Forms.Label();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnShowAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnScoreBoard
            // 
            this.btnScoreBoard.AutoSize = true;
            this.btnScoreBoard.Location = new System.Drawing.Point(630, 506);
            this.btnScoreBoard.Name = "btnScoreBoard";
            this.btnScoreBoard.Size = new System.Drawing.Size(136, 35);
            this.btnScoreBoard.TabIndex = 45;
            this.btnScoreBoard.Text = "Scoreboard";
            this.btnScoreBoard.UseVisualStyleBackColor = true;
            this.btnScoreBoard.Click += new System.EventHandler(this.btnScoreBoard_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 25;
            this.lstOutput.Items.AddRange(new object[] {
            "Input No.\t\tNo. of correctly placed digits\t\tNo. of correct digits"});
            this.lstOutput.Location = new System.Drawing.Point(73, 192);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(836, 279);
            this.lstOutput.TabIndex = 44;
            // 
            // btnMenu
            // 
            this.btnMenu.AutoSize = true;
            this.btnMenu.Location = new System.Drawing.Point(790, 506);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(180, 35);
            this.btnMenu.TabIndex = 43;
            this.btnMenu.Text = "Return to Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnHint
            // 
            this.btnHint.AutoSize = true;
            this.btnHint.Location = new System.Drawing.Point(636, 82);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(101, 35);
            this.btnHint.TabIndex = 42;
            this.btnHint.Text = "Hint";
            this.btnHint.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            this.btnCheck.AutoSize = true;
            this.btnCheck.Location = new System.Drawing.Point(519, 82);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(101, 35);
            this.btnCheck.TabIndex = 41;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // chkInsane
            // 
            this.chkInsane.AutoSize = true;
            this.chkInsane.Location = new System.Drawing.Point(730, 140);
            this.chkInsane.Name = "chkInsane";
            this.chkInsane.Size = new System.Drawing.Size(102, 29);
            this.chkInsane.TabIndex = 40;
            this.chkInsane.Text = "Insane";
            this.chkInsane.UseVisualStyleBackColor = true;
            // 
            // chkHard
            // 
            this.chkHard.AutoSize = true;
            this.chkHard.Location = new System.Drawing.Point(592, 140);
            this.chkHard.Name = "chkHard";
            this.chkHard.Size = new System.Drawing.Size(82, 29);
            this.chkHard.TabIndex = 39;
            this.chkHard.Text = "Hard";
            this.chkHard.UseVisualStyleBackColor = true;
            // 
            // chkMedium
            // 
            this.chkMedium.AutoSize = true;
            this.chkMedium.Location = new System.Drawing.Point(423, 140);
            this.chkMedium.Name = "chkMedium";
            this.chkMedium.Size = new System.Drawing.Size(113, 29);
            this.chkMedium.TabIndex = 38;
            this.chkMedium.Text = "Medium";
            this.chkMedium.UseVisualStyleBackColor = true;
            // 
            // chkEasy
            // 
            this.chkEasy.AutoSize = true;
            this.chkEasy.Location = new System.Drawing.Point(286, 140);
            this.chkEasy.Name = "chkEasy";
            this.chkEasy.Size = new System.Drawing.Size(81, 29);
            this.chkEasy.TabIndex = 37;
            this.chkEasy.Text = "Easy";
            this.chkEasy.UseVisualStyleBackColor = true;
            // 
            // txtDigitInput
            // 
            this.txtDigitInput.Location = new System.Drawing.Point(201, 82);
            this.txtDigitInput.Name = "txtDigitInput";
            this.txtDigitInput.Size = new System.Drawing.Size(290, 32);
            this.txtDigitInput.TabIndex = 36;
            this.txtDigitInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(151, 144);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(118, 25);
            this.lblDifficulty.TabIndex = 35;
            this.lblDifficulty.Text = "Difficulty :";
            // 
            // lblDigits
            // 
            this.lblDigits.AutoSize = true;
            this.lblDigits.Location = new System.Drawing.Point(99, 85);
            this.lblDigits.Name = "lblDigits";
            this.lblDigits.Size = new System.Drawing.Size(85, 25);
            this.lblDigits.TabIndex = 34;
            this.lblDigits.Text = "Digits :";
            // 
            // btnInstructions
            // 
            this.btnInstructions.AutoSize = true;
            this.btnInstructions.Location = new System.Drawing.Point(12, 506);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(142, 35);
            this.btnInstructions.TabIndex = 46;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.AutoSize = true;
            this.btnNewGame.Location = new System.Drawing.Point(753, 82);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(131, 35);
            this.btnNewGame.TabIndex = 47;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnShowAnswer
            // 
            this.btnShowAnswer.AutoSize = true;
            this.btnShowAnswer.Location = new System.Drawing.Point(313, 506);
            this.btnShowAnswer.Name = "btnShowAnswer";
            this.btnShowAnswer.Size = new System.Drawing.Size(158, 35);
            this.btnShowAnswer.TabIndex = 48;
            this.btnShowAnswer.Text = "Show Answer";
            this.btnShowAnswer.UseVisualStyleBackColor = true;
            this.btnShowAnswer.Click += new System.EventHandler(this.btnShowAnswer_Click);
            // 
            // frmNumberGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.btnShowAnswer);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.btnScoreBoard);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.chkInsane);
            this.Controls.Add(this.chkHard);
            this.Controls.Add(this.chkMedium);
            this.Controls.Add(this.chkEasy);
            this.Controls.Add(this.txtDigitInput);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.lblDigits);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmNumberGame";
            this.Text = "Number Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScoreBoard;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.CheckBox chkInsane;
        private System.Windows.Forms.CheckBox chkHard;
        private System.Windows.Forms.CheckBox chkMedium;
        private System.Windows.Forms.CheckBox chkEasy;
        private System.Windows.Forms.TextBox txtDigitInput;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Label lblDigits;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnShowAnswer;
    }
}