namespace Mastermind_Game
{
    partial class frmMenu
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
            this.lblDoneBy = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPictureGame = new System.Windows.Forms.Button();
            this.btnNumberGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDoneBy
            // 
            this.lblDoneBy.AutoSize = true;
            this.lblDoneBy.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoneBy.Location = new System.Drawing.Point(8, 284);
            this.lblDoneBy.Name = "lblDoneBy";
            this.lblDoneBy.Size = new System.Drawing.Size(292, 20);
            this.lblDoneBy.TabIndex = 10;
            this.lblDoneBy.Text = "Done by: Poh Shi Hui / 140530R";
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(540, 266);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 35);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPictureGame
            // 
            this.btnPictureGame.AutoSize = true;
            this.btnPictureGame.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPictureGame.Location = new System.Drawing.Point(328, 120);
            this.btnPictureGame.Name = "btnPictureGame";
            this.btnPictureGame.Size = new System.Drawing.Size(281, 35);
            this.btnPictureGame.TabIndex = 8;
            this.btnPictureGame.Text = "Picture Guessing Game";
            this.btnPictureGame.UseVisualStyleBackColor = true;
            this.btnPictureGame.Click += new System.EventHandler(this.btnPictureGame_Click);
            // 
            // btnNumberGame
            // 
            this.btnNumberGame.AutoSize = true;
            this.btnNumberGame.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumberGame.Location = new System.Drawing.Point(23, 120);
            this.btnNumberGame.Name = "btnNumberGame";
            this.btnNumberGame.Size = new System.Drawing.Size(290, 35);
            this.btnNumberGame.TabIndex = 7;
            this.btnNumberGame.Text = "Number Guessing Game";
            this.btnNumberGame.UseVisualStyleBackColor = true;
            this.btnNumberGame.Click += new System.EventHandler(this.btnNumberGame_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 313);
            this.Controls.Add(this.lblDoneBy);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPictureGame);
            this.Controls.Add(this.btnNumberGame);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMenu";
            this.Text = "Mastermind Game Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDoneBy;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPictureGame;
        private System.Windows.Forms.Button btnNumberGame;
    }
}

