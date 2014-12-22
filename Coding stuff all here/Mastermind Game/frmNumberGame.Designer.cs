namespace Mastermind_Game
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
            this.components = new System.ComponentModel.Container();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lstvOutput = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rBtnHard = new System.Windows.Forms.RadioButton();
            this.rBtnInsane = new System.Windows.Forms.RadioButton();
            this.btnGiveUp = new System.Windows.Forms.Button();
            this.rBtnMedium = new System.Windows.Forms.RadioButton();
            this.rBtnEasy = new System.Windows.Forms.RadioButton();
            this.btnShowAnswer = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtDigitInput = new System.Windows.Forms.TextBox();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.lblDigits = new System.Windows.Forms.Label();
            this.timTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTimer.Location = new System.Drawing.Point(929, 135);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(138, 35);
            this.lblTimer.TabIndex = 71;
            this.lblTimer.Text = "00:00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstvOutput
            // 
            this.lstvOutput.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstvOutput.GridLines = true;
            this.lstvOutput.Location = new System.Drawing.Point(67, 173);
            this.lstvOutput.Name = "lstvOutput";
            this.lstvOutput.Size = new System.Drawing.Size(1000, 300);
            this.lstvOutput.TabIndex = 69;
            this.lstvOutput.UseCompatibleStateImageBehavior = false;
            this.lstvOutput.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No.";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Input Number";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 230;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "No. of Correct Digits";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 350;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "No. of Correctly Placed Digits";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 350;
            // 
            // rBtnHard
            // 
            this.rBtnHard.AutoSize = true;
            this.rBtnHard.Location = new System.Drawing.Point(567, 54);
            this.rBtnHard.Name = "rBtnHard";
            this.rBtnHard.Size = new System.Drawing.Size(81, 29);
            this.rBtnHard.TabIndex = 67;
            this.rBtnHard.TabStop = true;
            this.rBtnHard.Text = "Hard";
            this.rBtnHard.UseVisualStyleBackColor = true;
            // 
            // rBtnInsane
            // 
            this.rBtnInsane.AutoSize = true;
            this.rBtnInsane.Location = new System.Drawing.Point(663, 54);
            this.rBtnInsane.Name = "rBtnInsane";
            this.rBtnInsane.Size = new System.Drawing.Size(101, 29);
            this.rBtnInsane.TabIndex = 68;
            this.rBtnInsane.TabStop = true;
            this.rBtnInsane.Text = "Insane";
            this.rBtnInsane.UseVisualStyleBackColor = true;
            // 
            // btnGiveUp
            // 
            this.btnGiveUp.AutoSize = true;
            this.btnGiveUp.Enabled = false;
            this.btnGiveUp.Location = new System.Drawing.Point(67, 135);
            this.btnGiveUp.Name = "btnGiveUp";
            this.btnGiveUp.Size = new System.Drawing.Size(113, 35);
            this.btnGiveUp.TabIndex = 70;
            this.btnGiveUp.Text = "Give Up";
            this.btnGiveUp.UseVisualStyleBackColor = true;
            this.btnGiveUp.Click += new System.EventHandler(this.btnGiveUp_Click);
            // 
            // rBtnMedium
            // 
            this.rBtnMedium.AutoSize = true;
            this.rBtnMedium.Location = new System.Drawing.Point(440, 54);
            this.rBtnMedium.Name = "rBtnMedium";
            this.rBtnMedium.Size = new System.Drawing.Size(112, 29);
            this.rBtnMedium.TabIndex = 66;
            this.rBtnMedium.TabStop = true;
            this.rBtnMedium.Text = "Medium";
            this.rBtnMedium.UseVisualStyleBackColor = true;
            // 
            // rBtnEasy
            // 
            this.rBtnEasy.AutoSize = true;
            this.rBtnEasy.Location = new System.Drawing.Point(345, 54);
            this.rBtnEasy.Name = "rBtnEasy";
            this.rBtnEasy.Size = new System.Drawing.Size(80, 29);
            this.rBtnEasy.TabIndex = 65;
            this.rBtnEasy.TabStop = true;
            this.rBtnEasy.Text = "Easy";
            this.rBtnEasy.UseVisualStyleBackColor = true;
            // 
            // btnShowAnswer
            // 
            this.btnShowAnswer.AutoSize = true;
            this.btnShowAnswer.Location = new System.Drawing.Point(490, 554);
            this.btnShowAnswer.Name = "btnShowAnswer";
            this.btnShowAnswer.Size = new System.Drawing.Size(158, 35);
            this.btnShowAnswer.TabIndex = 64;
            this.btnShowAnswer.Text = "Show Answer";
            this.btnShowAnswer.UseVisualStyleBackColor = true;
            this.btnShowAnswer.Click += new System.EventHandler(this.btnShowAnswer_Click);
            // 
            // btnInstructions
            // 
            this.btnInstructions.AutoSize = true;
            this.btnInstructions.Location = new System.Drawing.Point(12, 554);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(142, 35);
            this.btnInstructions.TabIndex = 62;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.AutoSize = true;
            this.btnNewGame.Location = new System.Drawing.Point(777, 51);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(131, 35);
            this.btnNewGame.TabIndex = 63;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.AutoSize = true;
            this.btnMenu.Location = new System.Drawing.Point(942, 554);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(180, 35);
            this.btnMenu.TabIndex = 61;
            this.btnMenu.Text = "Return to Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnHint
            // 
            this.btnHint.AutoSize = true;
            this.btnHint.Enabled = false;
            this.btnHint.Location = new System.Drawing.Point(788, 111);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(101, 35);
            this.btnHint.TabIndex = 60;
            this.btnHint.Text = "Hint";
            this.btnHint.UseVisualStyleBackColor = true;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.AutoSize = true;
            this.btnCheck.Enabled = false;
            this.btnCheck.Location = new System.Drawing.Point(663, 111);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(101, 35);
            this.btnCheck.TabIndex = 59;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtDigitInput
            // 
            this.txtDigitInput.Location = new System.Drawing.Point(349, 114);
            this.txtDigitInput.Name = "txtDigitInput";
            this.txtDigitInput.Size = new System.Drawing.Size(290, 32);
            this.txtDigitInput.TabIndex = 58;
            this.txtDigitInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDigitInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDigitInput_KeyDown);
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(227, 56);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(118, 25);
            this.lblDifficulty.TabIndex = 57;
            this.lblDifficulty.Text = "Difficulty :";
            // 
            // lblDigits
            // 
            this.lblDigits.AutoSize = true;
            this.lblDigits.Location = new System.Drawing.Point(247, 117);
            this.lblDigits.Name = "lblDigits";
            this.lblDigits.Size = new System.Drawing.Size(85, 25);
            this.lblDigits.TabIndex = 56;
            this.lblDigits.Text = "Digits :";
            // 
            // timTimer
            // 
            this.timTimer.Tick += new System.EventHandler(this.timTimer_Tick);
            // 
            // frmNumberGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 601);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lstvOutput);
            this.Controls.Add(this.rBtnHard);
            this.Controls.Add(this.rBtnInsane);
            this.Controls.Add(this.btnGiveUp);
            this.Controls.Add(this.rBtnMedium);
            this.Controls.Add(this.rBtnEasy);
            this.Controls.Add(this.btnShowAnswer);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtDigitInput);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.lblDigits);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmNumberGame";
            this.Text = "Number Guessing Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNumberGame_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.ListView lstvOutput;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.RadioButton rBtnHard;
        private System.Windows.Forms.RadioButton rBtnInsane;
        private System.Windows.Forms.Button btnGiveUp;
        private System.Windows.Forms.RadioButton rBtnMedium;
        private System.Windows.Forms.RadioButton rBtnEasy;
        private System.Windows.Forms.Button btnShowAnswer;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtDigitInput;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Label lblDigits;
        private System.Windows.Forms.Timer timTimer;
    }
}