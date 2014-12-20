namespace Mastermind_Game
{
    partial class frmPictureGame
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
            this.btnGiveUp = new System.Windows.Forms.Button();
            this.lstvOutput = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rBtnHard = new System.Windows.Forms.RadioButton();
            this.timTimer = new System.Windows.Forms.Timer(this.components);
            this.rBtnMedium = new System.Windows.Forms.RadioButton();
            this.rBtnEasy = new System.Windows.Forms.RadioButton();
            this.btnShowAnswer = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.picOne = new System.Windows.Forms.PictureBox();
            this.picSix = new System.Windows.Forms.PictureBox();
            this.picFive = new System.Windows.Forms.PictureBox();
            this.picFour = new System.Windows.Forms.PictureBox();
            this.picThree = new System.Windows.Forms.PictureBox();
            this.picTwo = new System.Windows.Forms.PictureBox();
            this.lblPic1 = new System.Windows.Forms.Label();
            this.lblPic2 = new System.Windows.Forms.Label();
            this.lblPic3 = new System.Windows.Forms.Label();
            this.lblPic4 = new System.Windows.Forms.Label();
            this.lblPic5 = new System.Windows.Forms.Label();
            this.lblPic6 = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTimer.Location = new System.Drawing.Point(929, 313);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(138, 35);
            this.lblTimer.TabIndex = 95;
            this.lblTimer.Text = "00:00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGiveUp
            // 
            this.btnGiveUp.AutoSize = true;
            this.btnGiveUp.Enabled = false;
            this.btnGiveUp.Location = new System.Drawing.Point(67, 310);
            this.btnGiveUp.Name = "btnGiveUp";
            this.btnGiveUp.Size = new System.Drawing.Size(113, 35);
            this.btnGiveUp.TabIndex = 94;
            this.btnGiveUp.Text = "Give Up";
            this.btnGiveUp.UseVisualStyleBackColor = true;
            this.btnGiveUp.Click += new System.EventHandler(this.btnGiveUp_Click);
            // 
            // lstvOutput
            // 
            this.lstvOutput.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstvOutput.GridLines = true;
            this.lstvOutput.Location = new System.Drawing.Point(67, 351);
            this.lstvOutput.Name = "lstvOutput";
            this.lstvOutput.Size = new System.Drawing.Size(1000, 300);
            this.lstvOutput.TabIndex = 93;
            this.lstvOutput.UseCompatibleStateImageBehavior = false;
            this.lstvOutput.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No.";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "No. of Correct Pictures";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 460;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "No. of Correctly Placed Pictures";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 460;
            // 
            // rBtnHard
            // 
            this.rBtnHard.AutoSize = true;
            this.rBtnHard.Location = new System.Drawing.Point(621, 24);
            this.rBtnHard.Name = "rBtnHard";
            this.rBtnHard.Size = new System.Drawing.Size(81, 29);
            this.rBtnHard.TabIndex = 92;
            this.rBtnHard.TabStop = true;
            this.rBtnHard.Text = "Hard";
            this.rBtnHard.UseVisualStyleBackColor = true;
            // 
            // timTimer
            // 
            this.timTimer.Interval = 10000;
            // 
            // rBtnMedium
            // 
            this.rBtnMedium.AutoSize = true;
            this.rBtnMedium.Location = new System.Drawing.Point(494, 24);
            this.rBtnMedium.Name = "rBtnMedium";
            this.rBtnMedium.Size = new System.Drawing.Size(112, 29);
            this.rBtnMedium.TabIndex = 91;
            this.rBtnMedium.TabStop = true;
            this.rBtnMedium.Text = "Medium";
            this.rBtnMedium.UseVisualStyleBackColor = true;
            // 
            // rBtnEasy
            // 
            this.rBtnEasy.AutoSize = true;
            this.rBtnEasy.Location = new System.Drawing.Point(399, 24);
            this.rBtnEasy.Name = "rBtnEasy";
            this.rBtnEasy.Size = new System.Drawing.Size(80, 29);
            this.rBtnEasy.TabIndex = 90;
            this.rBtnEasy.TabStop = true;
            this.rBtnEasy.Text = "Easy";
            this.rBtnEasy.UseVisualStyleBackColor = true;
            // 
            // btnShowAnswer
            // 
            this.btnShowAnswer.AutoSize = true;
            this.btnShowAnswer.Location = new System.Drawing.Point(488, 698);
            this.btnShowAnswer.Name = "btnShowAnswer";
            this.btnShowAnswer.Size = new System.Drawing.Size(158, 35);
            this.btnShowAnswer.TabIndex = 89;
            this.btnShowAnswer.Text = "Show Answer";
            this.btnShowAnswer.UseVisualStyleBackColor = true;
            this.btnShowAnswer.Click += new System.EventHandler(this.btnShowAnswer_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.AutoSize = true;
            this.btnNewGame.Location = new System.Drawing.Point(722, 21);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(131, 35);
            this.btnNewGame.TabIndex = 88;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.AutoSize = true;
            this.btnMenu.Location = new System.Drawing.Point(942, 698);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(180, 35);
            this.btnMenu.TabIndex = 86;
            this.btnMenu.Text = "Return to Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnInstructions
            // 
            this.btnInstructions.AutoSize = true;
            this.btnInstructions.Location = new System.Drawing.Point(12, 698);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(142, 35);
            this.btnInstructions.TabIndex = 87;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.AutoSize = true;
            this.btnCheck.Enabled = false;
            this.btnCheck.Location = new System.Drawing.Point(517, 313);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(101, 35);
            this.btnCheck.TabIndex = 85;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(281, 26);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(118, 25);
            this.lblDifficulty.TabIndex = 84;
            this.lblDifficulty.Text = "Difficulty :";
            // 
            // picOne
            // 
            this.picOne.Enabled = false;
            this.picOne.Location = new System.Drawing.Point(67, 121);
            this.picOne.Name = "picOne";
            this.picOne.Size = new System.Drawing.Size(160, 120);
            this.picOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOne.TabIndex = 96;
            this.picOne.TabStop = false;
            this.picOne.Visible = false;
            this.picOne.Click += new System.EventHandler(this.picOne_Click);
            // 
            // picSix
            // 
            this.picSix.Enabled = false;
            this.picSix.Location = new System.Drawing.Point(907, 121);
            this.picSix.Name = "picSix";
            this.picSix.Size = new System.Drawing.Size(160, 120);
            this.picSix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSix.TabIndex = 97;
            this.picSix.TabStop = false;
            this.picSix.Visible = false;
            this.picSix.Click += new System.EventHandler(this.picSix_Click);
            // 
            // picFive
            // 
            this.picFive.Enabled = false;
            this.picFive.Location = new System.Drawing.Point(739, 121);
            this.picFive.Name = "picFive";
            this.picFive.Size = new System.Drawing.Size(160, 120);
            this.picFive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFive.TabIndex = 98;
            this.picFive.TabStop = false;
            this.picFive.Visible = false;
            this.picFive.Click += new System.EventHandler(this.picFive_Click);
            // 
            // picFour
            // 
            this.picFour.Enabled = false;
            this.picFour.Location = new System.Drawing.Point(571, 121);
            this.picFour.Name = "picFour";
            this.picFour.Size = new System.Drawing.Size(160, 120);
            this.picFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFour.TabIndex = 99;
            this.picFour.TabStop = false;
            this.picFour.Visible = false;
            this.picFour.Click += new System.EventHandler(this.picFour_Click);
            // 
            // picThree
            // 
            this.picThree.Enabled = false;
            this.picThree.Location = new System.Drawing.Point(403, 121);
            this.picThree.Name = "picThree";
            this.picThree.Size = new System.Drawing.Size(160, 120);
            this.picThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picThree.TabIndex = 100;
            this.picThree.TabStop = false;
            this.picThree.Visible = false;
            this.picThree.Click += new System.EventHandler(this.picThree_Click);
            // 
            // picTwo
            // 
            this.picTwo.Enabled = false;
            this.picTwo.Location = new System.Drawing.Point(235, 121);
            this.picTwo.Name = "picTwo";
            this.picTwo.Size = new System.Drawing.Size(160, 120);
            this.picTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTwo.TabIndex = 101;
            this.picTwo.TabStop = false;
            this.picTwo.Visible = false;
            this.picTwo.Click += new System.EventHandler(this.picTwo_Click);
            // 
            // lblPic1
            // 
            this.lblPic1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPic1.Location = new System.Drawing.Point(67, 244);
            this.lblPic1.Name = "lblPic1";
            this.lblPic1.Size = new System.Drawing.Size(160, 35);
            this.lblPic1.TabIndex = 102;
            this.lblPic1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPic1.Visible = false;
            // 
            // lblPic2
            // 
            this.lblPic2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPic2.Location = new System.Drawing.Point(235, 244);
            this.lblPic2.Name = "lblPic2";
            this.lblPic2.Size = new System.Drawing.Size(160, 35);
            this.lblPic2.TabIndex = 103;
            this.lblPic2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPic2.Visible = false;
            // 
            // lblPic3
            // 
            this.lblPic3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPic3.Location = new System.Drawing.Point(403, 244);
            this.lblPic3.Name = "lblPic3";
            this.lblPic3.Size = new System.Drawing.Size(160, 35);
            this.lblPic3.TabIndex = 104;
            this.lblPic3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPic3.Visible = false;
            // 
            // lblPic4
            // 
            this.lblPic4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPic4.Location = new System.Drawing.Point(571, 244);
            this.lblPic4.Name = "lblPic4";
            this.lblPic4.Size = new System.Drawing.Size(160, 35);
            this.lblPic4.TabIndex = 105;
            this.lblPic4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPic4.Visible = false;
            // 
            // lblPic5
            // 
            this.lblPic5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPic5.Location = new System.Drawing.Point(739, 244);
            this.lblPic5.Name = "lblPic5";
            this.lblPic5.Size = new System.Drawing.Size(160, 35);
            this.lblPic5.TabIndex = 106;
            this.lblPic5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPic5.Visible = false;
            // 
            // lblPic6
            // 
            this.lblPic6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPic6.Location = new System.Drawing.Point(907, 244);
            this.lblPic6.Name = "lblPic6";
            this.lblPic6.Size = new System.Drawing.Size(160, 35);
            this.lblPic6.TabIndex = 107;
            this.lblPic6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPic6.Visible = false;
            // 
            // lblAnswer
            // 
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnswer.Location = new System.Drawing.Point(460, 660);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(214, 35);
            this.lblAnswer.TabIndex = 108;
            // 
            // frmPictureGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 745);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblPic6);
            this.Controls.Add(this.lblPic5);
            this.Controls.Add(this.lblPic4);
            this.Controls.Add(this.lblPic3);
            this.Controls.Add(this.lblPic2);
            this.Controls.Add(this.lblPic1);
            this.Controls.Add(this.picTwo);
            this.Controls.Add(this.picThree);
            this.Controls.Add(this.picFour);
            this.Controls.Add(this.picFive);
            this.Controls.Add(this.picSix);
            this.Controls.Add(this.picOne);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnGiveUp);
            this.Controls.Add(this.lstvOutput);
            this.Controls.Add(this.rBtnHard);
            this.Controls.Add(this.rBtnMedium);
            this.Controls.Add(this.rBtnEasy);
            this.Controls.Add(this.btnShowAnswer);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblDifficulty);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmPictureGame";
            this.Text = "Picture Guessing Game";
            ((System.ComponentModel.ISupportInitialize)(this.picOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTwo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnGiveUp;
        private System.Windows.Forms.ListView lstvOutput;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.RadioButton rBtnHard;
        private System.Windows.Forms.Timer timTimer;
        private System.Windows.Forms.RadioButton rBtnMedium;
        private System.Windows.Forms.RadioButton rBtnEasy;
        private System.Windows.Forms.Button btnShowAnswer;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.PictureBox picOne;
        private System.Windows.Forms.PictureBox picSix;
        private System.Windows.Forms.PictureBox picFive;
        private System.Windows.Forms.PictureBox picFour;
        private System.Windows.Forms.PictureBox picThree;
        private System.Windows.Forms.PictureBox picTwo;
        private System.Windows.Forms.Label lblPic1;
        private System.Windows.Forms.Label lblPic2;
        private System.Windows.Forms.Label lblPic3;
        private System.Windows.Forms.Label lblPic4;
        private System.Windows.Forms.Label lblPic5;
        private System.Windows.Forms.Label lblPic6;
        private System.Windows.Forms.Label lblAnswer;
    }
}