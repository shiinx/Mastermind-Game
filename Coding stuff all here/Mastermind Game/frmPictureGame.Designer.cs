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
            this.lstvOutput = new System.Windows.Forms.ListView();
            this.timTimer = new System.Windows.Forms.Timer(this.components);
            this.btnShowAnswer = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.panelGameStart = new System.Windows.Forms.Panel();
            this.btnGiveUp = new System.Windows.Forms.Button();
            this.panelNewGame = new System.Windows.Forms.Panel();
            this.rBtnHard = new System.Windows.Forms.RadioButton();
            this.rBtnMedium = new System.Windows.Forms.RadioButton();
            this.rBtnEasy = new System.Windows.Forms.RadioButton();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.panelPicBox1to4 = new System.Windows.Forms.Panel();
            this.lblPic4 = new System.Windows.Forms.Label();
            this.lblPic3 = new System.Windows.Forms.Label();
            this.lblPic2 = new System.Windows.Forms.Label();
            this.lblPic1 = new System.Windows.Forms.Label();
            this.picTwo = new System.Windows.Forms.PictureBox();
            this.picThree = new System.Windows.Forms.PictureBox();
            this.picFour = new System.Windows.Forms.PictureBox();
            this.picOne = new System.Windows.Forms.PictureBox();
            this.lblPic5 = new System.Windows.Forms.Label();
            this.lblPic6 = new System.Windows.Forms.Label();
            this.lblTips = new System.Windows.Forms.Label();
            this.timTips = new System.Windows.Forms.Timer(this.components);
            this.picFive = new System.Windows.Forms.PictureBox();
            this.picSix = new System.Windows.Forms.PictureBox();
            this.btnRecordBoard = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblLegend = new System.Windows.Forms.Label();
            this.panelGameStart.SuspendLayout();
            this.panelNewGame.SuspendLayout();
            this.panelPicBox1to4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSix)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTimer.Location = new System.Drawing.Point(1242, 269);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(100, 34);
            this.lblTimer.TabIndex = 95;
            this.lblTimer.Text = "00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstvOutput
            // 
            this.lstvOutput.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvOutput.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstvOutput.Location = new System.Drawing.Point(30, 308);
            this.lstvOutput.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lstvOutput.Name = "lstvOutput";
            this.lstvOutput.Size = new System.Drawing.Size(1312, 347);
            this.lstvOutput.TabIndex = 93;
            this.lstvOutput.UseCompatibleStateImageBehavior = false;
            this.lstvOutput.View = System.Windows.Forms.View.Details;
            // 
            // timTimer
            // 
            this.timTimer.Tick += new System.EventHandler(this.timTimer_Tick);
            // 
            // btnShowAnswer
            // 
            this.btnShowAnswer.AutoSize = true;
            this.btnShowAnswer.Location = new System.Drawing.Point(1203, 68);
            this.btnShowAnswer.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnShowAnswer.Name = "btnShowAnswer";
            this.btnShowAnswer.Size = new System.Drawing.Size(158, 35);
            this.btnShowAnswer.TabIndex = 89;
            this.btnShowAnswer.Text = "Show Answer";
            this.btnShowAnswer.UseVisualStyleBackColor = true;
            this.btnShowAnswer.Click += new System.EventHandler(this.btnShowAnswer_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.AutoSize = true;
            this.btnMenu.Location = new System.Drawing.Point(1179, 734);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
            this.btnInstructions.Location = new System.Drawing.Point(13, 734);
            this.btnInstructions.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(142, 35);
            this.btnInstructions.TabIndex = 87;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnswer.Location = new System.Drawing.Point(1145, 29);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(214, 35);
            this.lblAnswer.TabIndex = 108;
            // 
            // panelGameStart
            // 
            this.panelGameStart.Controls.Add(this.btnHint);
            this.panelGameStart.Controls.Add(this.btnCheck);
            this.panelGameStart.Controls.Add(this.btnGiveUp);
            this.panelGameStart.Enabled = false;
            this.panelGameStart.Location = new System.Drawing.Point(13, 261);
            this.panelGameStart.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelGameStart.Name = "panelGameStart";
            this.panelGameStart.Size = new System.Drawing.Size(803, 48);
            this.panelGameStart.TabIndex = 110;
            // 
            // btnGiveUp
            // 
            this.btnGiveUp.AutoSize = true;
            this.btnGiveUp.Location = new System.Drawing.Point(17, 8);
            this.btnGiveUp.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnGiveUp.Name = "btnGiveUp";
            this.btnGiveUp.Size = new System.Drawing.Size(113, 35);
            this.btnGiveUp.TabIndex = 111;
            this.btnGiveUp.Text = "Give Up";
            this.btnGiveUp.UseVisualStyleBackColor = true;
            this.btnGiveUp.Click += new System.EventHandler(this.btnGiveUp_Click);
            // 
            // panelNewGame
            // 
            this.panelNewGame.Controls.Add(this.rBtnHard);
            this.panelNewGame.Controls.Add(this.rBtnMedium);
            this.panelNewGame.Controls.Add(this.rBtnEasy);
            this.panelNewGame.Controls.Add(this.btnNewGame);
            this.panelNewGame.Controls.Add(this.lblDifficulty);
            this.panelNewGame.Location = new System.Drawing.Point(382, 12);
            this.panelNewGame.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelNewGame.Name = "panelNewGame";
            this.panelNewGame.Size = new System.Drawing.Size(609, 52);
            this.panelNewGame.TabIndex = 112;
            // 
            // rBtnHard
            // 
            this.rBtnHard.AutoSize = true;
            this.rBtnHard.Location = new System.Drawing.Point(358, 12);
            this.rBtnHard.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rBtnHard.Name = "rBtnHard";
            this.rBtnHard.Size = new System.Drawing.Size(81, 29);
            this.rBtnHard.TabIndex = 97;
            this.rBtnHard.TabStop = true;
            this.rBtnHard.Text = "Hard";
            this.rBtnHard.UseVisualStyleBackColor = true;
            this.rBtnHard.MouseEnter += new System.EventHandler(this.Common_MouseEnter);
            // 
            // rBtnMedium
            // 
            this.rBtnMedium.AutoSize = true;
            this.rBtnMedium.Location = new System.Drawing.Point(230, 12);
            this.rBtnMedium.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rBtnMedium.Name = "rBtnMedium";
            this.rBtnMedium.Size = new System.Drawing.Size(112, 29);
            this.rBtnMedium.TabIndex = 96;
            this.rBtnMedium.TabStop = true;
            this.rBtnMedium.Text = "Medium";
            this.rBtnMedium.UseVisualStyleBackColor = true;
            this.rBtnMedium.MouseEnter += new System.EventHandler(this.Common_MouseEnter);
            // 
            // rBtnEasy
            // 
            this.rBtnEasy.AutoSize = true;
            this.rBtnEasy.Location = new System.Drawing.Point(136, 12);
            this.rBtnEasy.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rBtnEasy.Name = "rBtnEasy";
            this.rBtnEasy.Size = new System.Drawing.Size(80, 29);
            this.rBtnEasy.TabIndex = 95;
            this.rBtnEasy.TabStop = true;
            this.rBtnEasy.Text = "Easy";
            this.rBtnEasy.UseVisualStyleBackColor = true;
            this.rBtnEasy.MouseEnter += new System.EventHandler(this.Common_MouseEnter);
            // 
            // btnNewGame
            // 
            this.btnNewGame.AutoSize = true;
            this.btnNewGame.Location = new System.Drawing.Point(459, 9);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(131, 35);
            this.btnNewGame.TabIndex = 94;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(18, 14);
            this.lblDifficulty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(118, 25);
            this.lblDifficulty.TabIndex = 93;
            this.lblDifficulty.Text = "Difficulty :";
            // 
            // panelPicBox1to4
            // 
            this.panelPicBox1to4.Controls.Add(this.lblPic4);
            this.panelPicBox1to4.Controls.Add(this.lblPic3);
            this.panelPicBox1to4.Controls.Add(this.lblPic2);
            this.panelPicBox1to4.Controls.Add(this.lblPic1);
            this.panelPicBox1to4.Controls.Add(this.picTwo);
            this.panelPicBox1to4.Controls.Add(this.picThree);
            this.panelPicBox1to4.Controls.Add(this.picFour);
            this.panelPicBox1to4.Controls.Add(this.picOne);
            this.panelPicBox1to4.Enabled = false;
            this.panelPicBox1to4.Location = new System.Drawing.Point(177, 68);
            this.panelPicBox1to4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelPicBox1to4.Name = "panelPicBox1to4";
            this.panelPicBox1to4.Size = new System.Drawing.Size(684, 189);
            this.panelPicBox1to4.TabIndex = 111;
            this.panelPicBox1to4.Visible = false;
            // 
            // lblPic4
            // 
            this.lblPic4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPic4.Location = new System.Drawing.Point(522, 138);
            this.lblPic4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPic4.Name = "lblPic4";
            this.lblPic4.Size = new System.Drawing.Size(160, 35);
            this.lblPic4.TabIndex = 121;
            this.lblPic4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPic3
            // 
            this.lblPic3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPic3.Location = new System.Drawing.Point(355, 138);
            this.lblPic3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPic3.Name = "lblPic3";
            this.lblPic3.Size = new System.Drawing.Size(160, 35);
            this.lblPic3.TabIndex = 120;
            this.lblPic3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPic2
            // 
            this.lblPic2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPic2.Location = new System.Drawing.Point(186, 138);
            this.lblPic2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPic2.Name = "lblPic2";
            this.lblPic2.Size = new System.Drawing.Size(160, 35);
            this.lblPic2.TabIndex = 119;
            this.lblPic2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPic1
            // 
            this.lblPic1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPic1.Location = new System.Drawing.Point(18, 138);
            this.lblPic1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPic1.Name = "lblPic1";
            this.lblPic1.Size = new System.Drawing.Size(160, 35);
            this.lblPic1.TabIndex = 118;
            this.lblPic1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picTwo
            // 
            this.picTwo.Location = new System.Drawing.Point(186, 15);
            this.picTwo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.picTwo.Name = "picTwo";
            this.picTwo.Size = new System.Drawing.Size(160, 120);
            this.picTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTwo.TabIndex = 113;
            this.picTwo.TabStop = false;
            this.picTwo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Common_MouseDown);
            // 
            // picThree
            // 
            this.picThree.Location = new System.Drawing.Point(355, 15);
            this.picThree.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.picThree.Name = "picThree";
            this.picThree.Size = new System.Drawing.Size(160, 120);
            this.picThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picThree.TabIndex = 112;
            this.picThree.TabStop = false;
            this.picThree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Common_MouseDown);
            // 
            // picFour
            // 
            this.picFour.Location = new System.Drawing.Point(522, 15);
            this.picFour.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.picFour.Name = "picFour";
            this.picFour.Size = new System.Drawing.Size(160, 120);
            this.picFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFour.TabIndex = 111;
            this.picFour.TabStop = false;
            this.picFour.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Common_MouseDown);
            // 
            // picOne
            // 
            this.picOne.Location = new System.Drawing.Point(18, 15);
            this.picOne.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.picOne.Name = "picOne";
            this.picOne.Size = new System.Drawing.Size(160, 120);
            this.picOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOne.TabIndex = 108;
            this.picOne.TabStop = false;
            this.picOne.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Common_MouseDown);
            // 
            // lblPic5
            // 
            this.lblPic5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPic5.Location = new System.Drawing.Point(868, 206);
            this.lblPic5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPic5.Name = "lblPic5";
            this.lblPic5.Size = new System.Drawing.Size(160, 35);
            this.lblPic5.TabIndex = 122;
            this.lblPic5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPic5.Visible = false;
            // 
            // lblPic6
            // 
            this.lblPic6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPic6.Location = new System.Drawing.Point(1035, 206);
            this.lblPic6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPic6.Name = "lblPic6";
            this.lblPic6.Size = new System.Drawing.Size(160, 35);
            this.lblPic6.TabIndex = 123;
            this.lblPic6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPic6.Visible = false;
            // 
            // lblTips
            // 
            this.lblTips.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTips.Location = new System.Drawing.Point(257, 657);
            this.lblTips.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTips.Name = "lblTips";
            this.lblTips.Size = new System.Drawing.Size(859, 34);
            this.lblTips.TabIndex = 124;
            this.lblTips.Text = "Click New Game to start.";
            this.lblTips.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timTips
            // 
            this.timTips.Interval = 20000;
            this.timTips.Tick += new System.EventHandler(this.timTips_Tick);
            // 
            // picFive
            // 
            this.picFive.Enabled = false;
            this.picFive.InitialImage = null;
            this.picFive.Location = new System.Drawing.Point(868, 84);
            this.picFive.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.picFive.Name = "picFive";
            this.picFive.Size = new System.Drawing.Size(160, 120);
            this.picFive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFive.TabIndex = 121;
            this.picFive.TabStop = false;
            this.picFive.Visible = false;
            this.picFive.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Common_MouseDown);
            // 
            // picSix
            // 
            this.picSix.Enabled = false;
            this.picSix.Location = new System.Drawing.Point(1035, 84);
            this.picSix.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.picSix.Name = "picSix";
            this.picSix.Size = new System.Drawing.Size(160, 120);
            this.picSix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSix.TabIndex = 120;
            this.picSix.TabStop = false;
            this.picSix.Visible = false;
            this.picSix.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Common_MouseDown);
            // 
            // btnRecordBoard
            // 
            this.btnRecordBoard.AutoSize = true;
            this.btnRecordBoard.Location = new System.Drawing.Point(607, 734);
            this.btnRecordBoard.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRecordBoard.Name = "btnRecordBoard";
            this.btnRecordBoard.Size = new System.Drawing.Size(158, 35);
            this.btnRecordBoard.TabIndex = 127;
            this.btnRecordBoard.Text = "RecordBoard";
            this.btnRecordBoard.UseVisualStyleBackColor = true;
            this.btnRecordBoard.Click += new System.EventHandler(this.btnRecordBoard_Click);
            // 
            // btnHint
            // 
            this.btnHint.AutoSize = true;
            this.btnHint.Location = new System.Drawing.Point(693, 8);
            this.btnHint.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(100, 35);
            this.btnHint.TabIndex = 114;
            this.btnHint.Text = "Hint";
            this.btnHint.UseVisualStyleBackColor = true;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.AutoSize = true;
            this.btnCheck.Location = new System.Drawing.Point(553, 8);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(100, 35);
            this.btnCheck.TabIndex = 113;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblLegend
            // 
            this.lblLegend.Location = new System.Drawing.Point(311, 691);
            this.lblLegend.Name = "lblLegend";
            this.lblLegend.Size = new System.Drawing.Size(750, 34);
            this.lblLegend.TabIndex = 128;
            this.lblLegend.Text = "Legend : \'O\' means correct , \'X\' means wong , \'P\' means wrong position";
            this.lblLegend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLegend.Visible = false;
            // 
            // frmPictureGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 780);
            this.Controls.Add(this.lblLegend);
            this.Controls.Add(this.btnRecordBoard);
            this.Controls.Add(this.lblTips);
            this.Controls.Add(this.lblPic6);
            this.Controls.Add(this.lblPic5);
            this.Controls.Add(this.picFive);
            this.Controls.Add(this.picSix);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lstvOutput);
            this.Controls.Add(this.btnShowAnswer);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.panelGameStart);
            this.Controls.Add(this.panelNewGame);
            this.Controls.Add(this.panelPicBox1to4);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmPictureGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture Guessing Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPictureGame_FormClosed);
            this.Load += new System.EventHandler(this.frmPictureGame_Load);
            this.panelGameStart.ResumeLayout(false);
            this.panelGameStart.PerformLayout();
            this.panelNewGame.ResumeLayout(false);
            this.panelNewGame.PerformLayout();
            this.panelPicBox1to4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.ListView lstvOutput;
        private System.Windows.Forms.Timer timTimer;
        private System.Windows.Forms.Button btnShowAnswer;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Panel panelGameStart;
        private System.Windows.Forms.Button btnGiveUp;
        private System.Windows.Forms.Panel panelNewGame;
        private System.Windows.Forms.RadioButton rBtnHard;
        private System.Windows.Forms.RadioButton rBtnMedium;
        private System.Windows.Forms.RadioButton rBtnEasy;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.PictureBox picOne;
        private System.Windows.Forms.PictureBox picFour;
        private System.Windows.Forms.PictureBox picThree;
        private System.Windows.Forms.PictureBox picTwo;
        private System.Windows.Forms.Panel panelPicBox1to4;
        private System.Windows.Forms.PictureBox picSix;
        private System.Windows.Forms.PictureBox picFive;
        private System.Windows.Forms.Label lblPic5;
        private System.Windows.Forms.Label lblPic6;
        private System.Windows.Forms.Label lblTips;
        private System.Windows.Forms.Timer timTips;
        private System.Windows.Forms.Label lblPic4;
        private System.Windows.Forms.Label lblPic3;
        private System.Windows.Forms.Label lblPic2;
        private System.Windows.Forms.Label lblPic1;
        private System.Windows.Forms.Button btnRecordBoard;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblLegend;
    }
}