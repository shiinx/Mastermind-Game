using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mastermind_Game
{
    public partial class frmRecordBoard : Form
    {
        public frmRecordBoard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void frmRecordBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        string pathToPictureGameRecordsText = @"C:\Users\Public\Documents\MastermindGame\PictureGameRecords.txt";
        string pathToNumberGameRecordsText = @"C:\Users\Public\Documents\MastermindGame\NumberGameRecords.txt";



        private void frmRecordBoard_Load(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(pathToPictureGameRecordsText))
            {
                System.IO.File.WriteAllText(pathToPictureGameRecordsText, "");
            }
            if (!System.IO.File.Exists(pathToNumberGameRecordsText))
            {
                System.IO.File.WriteAllText(pathToNumberGameRecordsText, "");
            }
        }



        private void rBtnNumberRecord_CheckedChanged(object sender, EventArgs e)
        {
            lstRecords.Items.Clear();
            if (rBtnNumberRecord.Checked)
            {
                int counter = 0;
                lstRecords.Items.Add("No.\tDifficulty\t\tTries\tTime Taken");
                string numberRecord;
                System.IO.StreamReader numberRecordsTXT = new System.IO.StreamReader(pathToNumberGameRecordsText);
                while ((numberRecord = numberRecordsTXT.ReadLine()) != null)
                {
                    lstRecords.Items.Add(numberRecord);
                    counter++;
                }
            }
        }



        private void rBtnPictureRecord_CheckedChanged(object sender, EventArgs e)
        {
            lstRecords.Items.Clear();
            if (rBtnPictureRecord.Checked)
            {
                int counter = 0;
                lstRecords.Items.Add("No.\tDifficulty\t\tTries\tTime Taken");
                string pictureRecord;
                System.IO.StreamReader pictureRecordsTXT = new System.IO.StreamReader(pathToPictureGameRecordsText);
                while ((pictureRecord = pictureRecordsTXT.ReadLine()) != null)
                {
                    lstRecords.Items.Add(pictureRecord);
                    counter++;
                }
            }
        }


    }
}
