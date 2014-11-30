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
            this.btnColorGame = new System.Windows.Forms.Button();
            this.btnNumberGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(297, 87);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 35);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnColorGame
            // 
            this.btnColorGame.AutoSize = true;
            this.btnColorGame.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColorGame.Location = new System.Drawing.Point(344, 31);
            this.btnColorGame.Name = "btnColorGame";
            this.btnColorGame.Size = new System.Drawing.Size(260, 35);
            this.btnColorGame.TabIndex = 4;
            this.btnColorGame.Text = "Color Guessing Game";
            this.btnColorGame.UseVisualStyleBackColor = true;
            this.btnColorGame.Click += new System.EventHandler(this.btnColorGame_Click);
            // 
            // btnNumberGame
            // 
            this.btnNumberGame.AutoSize = true;
            this.btnNumberGame.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumberGame.Location = new System.Drawing.Point(29, 31);
            this.btnNumberGame.Name = "btnNumberGame";
            this.btnNumberGame.Size = new System.Drawing.Size(290, 35);
            this.btnNumberGame.TabIndex = 3;
            this.btnNumberGame.Text = "Number Guessing Game";
            this.btnNumberGame.UseVisualStyleBackColor = true;
            this.btnNumberGame.Click += new System.EventHandler(this.btnNumberGame_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 153);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnColorGame);
            this.Controls.Add(this.btnNumberGame);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmMenu";
            this.Text = "MasterMind Game Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnColorGame;
        private System.Windows.Forms.Button btnNumberGame;
    }
}

