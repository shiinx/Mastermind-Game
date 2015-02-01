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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }


        // Switch to NumberGame form
        public void btnNumberGame_Click(object sender, EventArgs e)
        {
            frmNumberGame numberGame = new frmNumberGame();
            if (rBtnClassic.Checked)
            {
                numberGame.classicMode = true;
                numberGame.visualMode = false;
            }
            if (rBtnVisual.Checked)
            {
                numberGame.visualMode = true;
                numberGame.classicMode = false;
            }
            this.Hide();
            numberGame.ShowDialog();

            if (numberGame.DialogResult == DialogResult.OK)
            {
                this.Show();
            }
        }


        // Switch to PictureGame form
        public void btnPictureGame_Click(object sender, EventArgs e)
        {
            frmPictureGame pictureGame = new frmPictureGame();
            if (rBtnClassic.Checked)
            {
                pictureGame.classicMode = true;
                pictureGame.visualMode = false;
            }
            if (rBtnVisual.Checked)
            {
                pictureGame.visualMode = true;
                pictureGame.classicMode = false;
            }

            this.Hide();
            pictureGame.ShowDialog();

            if (pictureGame.DialogResult == DialogResult.OK)
            {
                this.Show();
            }
        }

        // Exit button (Self explanatory)
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
