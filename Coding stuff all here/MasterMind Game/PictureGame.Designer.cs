namespace MasterMind_Game
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
            this.rBtnMedium = new System.Windows.Forms.RadioButton();
            this.rBtnEasy = new System.Windows.Forms.RadioButton();
            this.btnShowAnswer = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.timTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTimer.Location = new System.Drawing.Point(929, 323);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(138, 35);
            this.lblTimer.TabIndex = 71;
            this.lblTimer.Text = "00:00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGiveUp
            // 
            this.btnGiveUp.AutoSize = true;
            this.btnGiveUp.Enabled = false;
            this.btnGiveUp.Location = new System.Drawing.Point(942, 273);
            this.btnGiveUp.Name = "btnGiveUp";
            this.btnGiveUp.Size = new System.Drawing.Size(113, 35);
            this.btnGiveUp.TabIndex = 70;
            this.btnGiveUp.Text = "Give Up";
            this.btnGiveUp.UseVisualStyleBackColor = true;
            // 
            // lstvOutput
            // 
            this.lstvOutput.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstvOutput.GridLines = true;
            this.lstvOutput.Location = new System.Drawing.Point(67, 361);
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
            this.rBtnHard.Location = new System.Drawing.Point(621, 34);
            this.rBtnHard.Name = "rBtnHard";
            this.rBtnHard.Size = new System.Drawing.Size(81, 29);
            this.rBtnHard.TabIndex = 67;
            this.rBtnHard.TabStop = true;
            this.rBtnHard.Text = "Hard";
            this.rBtnHard.UseVisualStyleBackColor = true;
            // 
            // rBtnMedium
            // 
            this.rBtnMedium.AutoSize = true;
            this.rBtnMedium.Location = new System.Drawing.Point(494, 34);
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
            this.rBtnEasy.Location = new System.Drawing.Point(399, 34);
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
            this.btnShowAnswer.Location = new System.Drawing.Point(488, 698);
            this.btnShowAnswer.Name = "btnShowAnswer";
            this.btnShowAnswer.Size = new System.Drawing.Size(158, 35);
            this.btnShowAnswer.TabIndex = 64;
            this.btnShowAnswer.Text = "Show Answer";
            this.btnShowAnswer.UseVisualStyleBackColor = true;
            // 
            // btnNewGame
            // 
            this.btnNewGame.AutoSize = true;
            this.btnNewGame.Location = new System.Drawing.Point(722, 31);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(131, 35);
            this.btnNewGame.TabIndex = 63;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            // 
            // btnInstructions
            // 
            this.btnInstructions.AutoSize = true;
            this.btnInstructions.Location = new System.Drawing.Point(12, 698);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(142, 35);
            this.btnInstructions.TabIndex = 62;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            this.btnMenu.AutoSize = true;
            this.btnMenu.Location = new System.Drawing.Point(942, 698);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(180, 35);
            this.btnMenu.TabIndex = 61;
            this.btnMenu.Text = "Return to Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            this.btnCheck.AutoSize = true;
            this.btnCheck.Enabled = false;
            this.btnCheck.Location = new System.Drawing.Point(942, 214);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(101, 35);
            this.btnCheck.TabIndex = 59;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(281, 36);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(118, 25);
            this.lblDifficulty.TabIndex = 57;
            this.lblDifficulty.Text = "Difficulty :";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MasterMind_Game.Properties.Resources._20130311_180758;
            this.pictureBox4.Location = new System.Drawing.Point(668, 126);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(150, 150);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 75;
            this.pictureBox4.TabStop = false;
            // 
            // frmPictureGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 745);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnGiveUp);
            this.Controls.Add(this.lstvOutput);
            this.Controls.Add(this.rBtnHard);
            this.Controls.Add(this.rBtnMedium);
            this.Controls.Add(this.rBtnEasy);
            this.Controls.Add(this.btnShowAnswer);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblDifficulty);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmPictureGame";
            this.Text = "Picture Guessing Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnGiveUp;
        private System.Windows.Forms.ListView lstvOutput;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.RadioButton rBtnHard;
        private System.Windows.Forms.RadioButton rBtnMedium;
        private System.Windows.Forms.RadioButton rBtnEasy;
        private System.Windows.Forms.Button btnShowAnswer;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer timTimer;
    }
}