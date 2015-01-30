namespace Mastermind_Game
{
    partial class frmRecordBoard
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
            this.lstRecords = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.rBtnPictureRecord = new System.Windows.Forms.RadioButton();
            this.rBtnNumberRecord = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lstRecords
            // 
            this.lstRecords.FormattingEnabled = true;
            this.lstRecords.ItemHeight = 25;
            this.lstRecords.Location = new System.Drawing.Point(24, 84);
            this.lstRecords.Name = "lstRecords";
            this.lstRecords.Size = new System.Drawing.Size(506, 479);
            this.lstRecords.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(452, 575);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 36);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "OK";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rBtnPictureRecord
            // 
            this.rBtnPictureRecord.AutoSize = true;
            this.rBtnPictureRecord.Location = new System.Drawing.Point(285, 38);
            this.rBtnPictureRecord.Name = "rBtnPictureRecord";
            this.rBtnPictureRecord.Size = new System.Drawing.Size(245, 29);
            this.rBtnPictureRecord.TabIndex = 2;
            this.rBtnPictureRecord.Text = "Picture Game Record";
            this.rBtnPictureRecord.UseVisualStyleBackColor = true;
            this.rBtnPictureRecord.CheckedChanged += new System.EventHandler(this.rBtnPictureRecord_CheckedChanged);
            // 
            // rBtnNumberRecord
            // 
            this.rBtnNumberRecord.AutoSize = true;
            this.rBtnNumberRecord.Location = new System.Drawing.Point(24, 38);
            this.rBtnNumberRecord.Name = "rBtnNumberRecord";
            this.rBtnNumberRecord.Size = new System.Drawing.Size(255, 29);
            this.rBtnNumberRecord.TabIndex = 3;
            this.rBtnNumberRecord.Text = "Number Game Record";
            this.rBtnNumberRecord.UseVisualStyleBackColor = true;
            this.rBtnNumberRecord.CheckedChanged += new System.EventHandler(this.rBtnNumberRecord_CheckedChanged);
            // 
            // frmRecordBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 623);
            this.Controls.Add(this.rBtnNumberRecord);
            this.Controls.Add(this.rBtnPictureRecord);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lstRecords);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmRecordBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecordBoard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRecordBoard_FormClosing);
            this.Load += new System.EventHandler(this.frmRecordBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRecords;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rBtnPictureRecord;
        private System.Windows.Forms.RadioButton rBtnNumberRecord;
    }
}