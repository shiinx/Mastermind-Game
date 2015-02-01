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
            this.btnShowAnswer = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.timTimer = new System.Windows.Forms.Timer(this.components);
            this.panelNewGame = new System.Windows.Forms.Panel();
            this.rBtnHard = new System.Windows.Forms.RadioButton();
            this.rBtnInsane = new System.Windows.Forms.RadioButton();
            this.rBtnMedium = new System.Windows.Forms.RadioButton();
            this.rBtnEasy = new System.Windows.Forms.RadioButton();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.panelGameStart = new System.Windows.Forms.Panel();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.txtDigitInput = new System.Windows.Forms.TextBox();
            this.lblDigits = new System.Windows.Forms.Label();
            this.btnGiveUp = new System.Windows.Forms.Button();
            this.lblTips = new System.Windows.Forms.Label();
            this.timTips = new System.Windows.Forms.Timer(this.components);
            this.btnRecordBoard = new System.Windows.Forms.Button();
            this.lblLegend = new System.Windows.Forms.Label();
            this.panelNewGame.SuspendLayout();
            this.panelGameStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTimer.Location = new System.Drawing.Point(1221, 133);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(100, 35);
            this.lblTimer.TabIndex = 71;
            this.lblTimer.Text = "00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstvOutput
            // 
            this.lstvOutput.Location = new System.Drawing.Point(52, 172);
            this.lstvOutput.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lstvOutput.Name = "lstvOutput";
            this.lstvOutput.Size = new System.Drawing.Size(1269, 453);
            this.lstvOutput.TabIndex = 69;
            this.lstvOutput.UseCompatibleStateImageBehavior = false;
            this.lstvOutput.View = System.Windows.Forms.View.Details;
            // 
            // btnShowAnswer
            // 
            this.btnShowAnswer.AutoSize = true;
            this.btnShowAnswer.Location = new System.Drawing.Point(1101, 81);
            this.btnShowAnswer.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
            this.btnInstructions.Location = new System.Drawing.Point(12, 705);
            this.btnInstructions.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(142, 35);
            this.btnInstructions.TabIndex = 62;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.AutoSize = true;
            this.btnMenu.Location = new System.Drawing.Point(1179, 705);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(180, 35);
            this.btnMenu.TabIndex = 61;
            this.btnMenu.Text = "Return to Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // timTimer
            // 
            this.timTimer.Tick += new System.EventHandler(this.timTimer_Tick);
            // 
            // panelNewGame
            // 
            this.panelNewGame.Controls.Add(this.rBtnHard);
            this.panelNewGame.Controls.Add(this.rBtnInsane);
            this.panelNewGame.Controls.Add(this.rBtnMedium);
            this.panelNewGame.Controls.Add(this.rBtnEasy);
            this.panelNewGame.Controls.Add(this.btnNewGame);
            this.panelNewGame.Controls.Add(this.lblDifficulty);
            this.panelNewGame.Location = new System.Drawing.Point(349, 49);
            this.panelNewGame.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelNewGame.Name = "panelNewGame";
            this.panelNewGame.Size = new System.Drawing.Size(696, 45);
            this.panelNewGame.TabIndex = 72;
            // 
            // rBtnHard
            // 
            this.rBtnHard.AutoSize = true;
            this.rBtnHard.Location = new System.Drawing.Point(347, 8);
            this.rBtnHard.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rBtnHard.Name = "rBtnHard";
            this.rBtnHard.Size = new System.Drawing.Size(81, 29);
            this.rBtnHard.TabIndex = 73;
            this.rBtnHard.TabStop = true;
            this.rBtnHard.Text = "Hard";
            this.rBtnHard.UseVisualStyleBackColor = true;
            this.rBtnHard.MouseEnter += new System.EventHandler(this.Common_MouseEnter);
            // 
            // rBtnInsane
            // 
            this.rBtnInsane.AutoSize = true;
            this.rBtnInsane.Location = new System.Drawing.Point(444, 8);
            this.rBtnInsane.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rBtnInsane.Name = "rBtnInsane";
            this.rBtnInsane.Size = new System.Drawing.Size(101, 29);
            this.rBtnInsane.TabIndex = 74;
            this.rBtnInsane.TabStop = true;
            this.rBtnInsane.Text = "Insane";
            this.rBtnInsane.UseVisualStyleBackColor = true;
            this.rBtnInsane.MouseEnter += new System.EventHandler(this.Common_MouseEnter);
            // 
            // rBtnMedium
            // 
            this.rBtnMedium.AutoSize = true;
            this.rBtnMedium.Location = new System.Drawing.Point(221, 8);
            this.rBtnMedium.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rBtnMedium.Name = "rBtnMedium";
            this.rBtnMedium.Size = new System.Drawing.Size(112, 29);
            this.rBtnMedium.TabIndex = 72;
            this.rBtnMedium.TabStop = true;
            this.rBtnMedium.Text = "Medium";
            this.rBtnMedium.UseVisualStyleBackColor = true;
            this.rBtnMedium.MouseEnter += new System.EventHandler(this.Common_MouseEnter);
            // 
            // rBtnEasy
            // 
            this.rBtnEasy.AutoSize = true;
            this.rBtnEasy.Location = new System.Drawing.Point(126, 8);
            this.rBtnEasy.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rBtnEasy.Name = "rBtnEasy";
            this.rBtnEasy.Size = new System.Drawing.Size(80, 29);
            this.rBtnEasy.TabIndex = 71;
            this.rBtnEasy.TabStop = true;
            this.rBtnEasy.Text = "Easy";
            this.rBtnEasy.UseVisualStyleBackColor = true;
            this.rBtnEasy.MouseEnter += new System.EventHandler(this.Common_MouseEnter);
            // 
            // btnNewGame
            // 
            this.btnNewGame.AutoSize = true;
            this.btnNewGame.Location = new System.Drawing.Point(558, 5);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(131, 35);
            this.btnNewGame.TabIndex = 70;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(8, 10);
            this.lblDifficulty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(118, 25);
            this.lblDifficulty.TabIndex = 69;
            this.lblDifficulty.Text = "Difficulty :";
            // 
            // panelGameStart
            // 
            this.panelGameStart.Controls.Add(this.btnCheck);
            this.panelGameStart.Controls.Add(this.btnHint);
            this.panelGameStart.Controls.Add(this.txtDigitInput);
            this.panelGameStart.Controls.Add(this.lblDigits);
            this.panelGameStart.Controls.Add(this.btnGiveUp);
            this.panelGameStart.Enabled = false;
            this.panelGameStart.Location = new System.Drawing.Point(44, 98);
            this.panelGameStart.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelGameStart.Name = "panelGameStart";
            this.panelGameStart.Size = new System.Drawing.Size(1014, 81);
            this.panelGameStart.TabIndex = 73;
            // 
            // btnCheck
            // 
            this.btnCheck.AutoSize = true;
            this.btnCheck.Location = new System.Drawing.Point(763, 7);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(100, 35);
            this.btnCheck.TabIndex = 79;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnHint
            // 
            this.btnHint.AutoSize = true;
            this.btnHint.Location = new System.Drawing.Point(887, 6);
            this.btnHint.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(100, 35);
            this.btnHint.TabIndex = 80;
            this.btnHint.Text = "Hint";
            this.btnHint.UseVisualStyleBackColor = true;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // txtDigitInput
            // 
            this.txtDigitInput.Location = new System.Drawing.Point(448, 9);
            this.txtDigitInput.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDigitInput.Name = "txtDigitInput";
            this.txtDigitInput.Size = new System.Drawing.Size(290, 32);
            this.txtDigitInput.TabIndex = 78;
            this.txtDigitInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDigitInput.TextChanged += new System.EventHandler(this.txtDigitInput_TextChanged);
            this.txtDigitInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDigitInput_KeyDown);
            // 
            // lblDigits
            // 
            this.lblDigits.AutoSize = true;
            this.lblDigits.Location = new System.Drawing.Point(346, 13);
            this.lblDigits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDigits.Name = "lblDigits";
            this.lblDigits.Size = new System.Drawing.Size(85, 25);
            this.lblDigits.TabIndex = 77;
            this.lblDigits.Text = "Digits :";
            // 
            // btnGiveUp
            // 
            this.btnGiveUp.AutoSize = true;
            this.btnGiveUp.Location = new System.Drawing.Point(8, 35);
            this.btnGiveUp.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnGiveUp.Name = "btnGiveUp";
            this.btnGiveUp.Size = new System.Drawing.Size(113, 35);
            this.btnGiveUp.TabIndex = 76;
            this.btnGiveUp.Text = "Give Up";
            this.btnGiveUp.UseVisualStyleBackColor = true;
            this.btnGiveUp.Click += new System.EventHandler(this.btnGiveUp_Click);
            // 
            // lblTips
            // 
            this.lblTips.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTips.Location = new System.Drawing.Point(257, 627);
            this.lblTips.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTips.Name = "lblTips";
            this.lblTips.Size = new System.Drawing.Size(859, 34);
            this.lblTips.TabIndex = 125;
            this.lblTips.Text = "Click New Game to start.";
            this.lblTips.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timTips
            // 
            this.timTips.Interval = 20000;
            this.timTips.Tick += new System.EventHandler(this.timTips_Tick);
            // 
            // btnRecordBoard
            // 
            this.btnRecordBoard.AutoSize = true;
            this.btnRecordBoard.Location = new System.Drawing.Point(607, 705);
            this.btnRecordBoard.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRecordBoard.Name = "btnRecordBoard";
            this.btnRecordBoard.Size = new System.Drawing.Size(158, 35);
            this.btnRecordBoard.TabIndex = 126;
            this.btnRecordBoard.Text = "RecordBoard";
            this.btnRecordBoard.UseVisualStyleBackColor = true;
            this.btnRecordBoard.Click += new System.EventHandler(this.btnRecordBoard_Click);
            // 
            // lblLegend
            // 
            this.lblLegend.Location = new System.Drawing.Point(311, 661);
            this.lblLegend.Name = "lblLegend";
            this.lblLegend.Size = new System.Drawing.Size(750, 34);
            this.lblLegend.TabIndex = 127;
            this.lblLegend.Text = "Legend : \'O\' means correct , \'X\' means wong , \'P\' means wrong position";
            this.lblLegend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLegend.Visible = false;
            // 
            // frmNumberGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 745);
            this.Controls.Add(this.lblLegend);
            this.Controls.Add(this.btnRecordBoard);
            this.Controls.Add(this.lblTips);
            this.Controls.Add(this.panelNewGame);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lstvOutput);
            this.Controls.Add(this.btnShowAnswer);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.panelGameStart);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmNumberGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number Guessing Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNumberGame_FormClosed);
            this.Load += new System.EventHandler(this.frmNumberGame_Load);
            this.panelNewGame.ResumeLayout(false);
            this.panelNewGame.PerformLayout();
            this.panelGameStart.ResumeLayout(false);
            this.panelGameStart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.ListView lstvOutput;
        private System.Windows.Forms.Button btnShowAnswer;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Timer timTimer;
        private System.Windows.Forms.Panel panelNewGame;
        private System.Windows.Forms.RadioButton rBtnHard;
        private System.Windows.Forms.RadioButton rBtnInsane;
        private System.Windows.Forms.RadioButton rBtnMedium;
        private System.Windows.Forms.RadioButton rBtnEasy;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Panel panelGameStart;
        private System.Windows.Forms.Label lblTips;
        private System.Windows.Forms.Timer timTips;
        private System.Windows.Forms.Button btnRecordBoard;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.TextBox txtDigitInput;
        private System.Windows.Forms.Label lblDigits;
        private System.Windows.Forms.Button btnGiveUp;
        private System.Windows.Forms.Label lblLegend;
    }
}