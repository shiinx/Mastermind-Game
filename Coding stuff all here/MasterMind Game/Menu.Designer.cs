namespace MasterMind_Game
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPictureGame = new System.Windows.Forms.Button();
            this.btnNumberGame = new System.Windows.Forms.Button();
            this.lblDoneBy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(535, 266);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 35);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPictureGame
            // 
            this.btnPictureGame.AutoSize = true;
            this.btnPictureGame.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPictureGame.Location = new System.Drawing.Point(323, 120);
            this.btnPictureGame.Name = "btnPictureGame";
            this.btnPictureGame.Size = new System.Drawing.Size(281, 35);
            this.btnPictureGame.TabIndex = 4;
            this.btnPictureGame.Text = "Picture Guessing Game";
            this.btnPictureGame.UseVisualStyleBackColor = true;
            // 
            // btnNumberGame
            // 
            this.btnNumberGame.AutoSize = true;
            this.btnNumberGame.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumberGame.Location = new System.Drawing.Point(18, 120);
            this.btnNumberGame.Name = "btnNumberGame";
            this.btnNumberGame.Size = new System.Drawing.Size(290, 35);
            this.btnNumberGame.TabIndex = 3;
            this.btnNumberGame.Text = "Number Guessing Game";
            this.btnNumberGame.UseVisualStyleBackColor = true;
            this.btnNumberGame.Click += new System.EventHandler(this.btnNumberGame_Click);
            // 
            // lblDoneBy
            // 
            this.lblDoneBy.AutoSize = true;
            this.lblDoneBy.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoneBy.Location = new System.Drawing.Point(3, 284);
            this.lblDoneBy.Name = "lblDoneBy";
            this.lblDoneBy.Size = new System.Drawing.Size(292, 20);
            this.lblDoneBy.TabIndex = 6;
            this.lblDoneBy.Text = "Done by: Poh Shi Hui / 140530R";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 313);
            this.Controls.Add(this.lblDoneBy);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPictureGame);
            this.Controls.Add(this.btnNumberGame);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMenu";
            this.Text = "MasterMind Game Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPictureGame;
        private System.Windows.Forms.Button btnNumberGame;
        private System.Windows.Forms.Label lblDoneBy;
    }
}

