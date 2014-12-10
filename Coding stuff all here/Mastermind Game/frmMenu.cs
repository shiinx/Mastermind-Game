﻿using System;
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

        frmNumberGame frmNumberGameVariable = new frmNumberGame();        //Number game's foorm variable creation
        frmPictureGame frmPictureGamVariable = new frmPictureGame();    //Color game's form variable creation

        // Switch to NumberGame form
        private void btnNumberGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNumberGameVariable.ShowDialog();

            if (frmNumberGameVariable.DialogResult == DialogResult.OK)
            {
                this.Show();
            }
        }


        // Switch to PictureGame form
        private void btnPictureGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPictureGamVariable.ShowDialog();

            if (frmPictureGamVariable.DialogResult == DialogResult.OK)
            {
                this.Show();
            }
        }

        // Exit button (Self explanatory)
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
