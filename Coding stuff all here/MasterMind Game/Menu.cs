using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MasterMind_Game
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        frmNumberGame frmNumberGameVariable = new frmNumberGame();  //Number game's foorm variable creation
        frmColorGame frmColorGameVariable = new frmColorGame();     //Color game's form variable creation

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

        //Switch to ColorGame Form
        private void btnColorGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmColorGameVariable.ShowDialog();

            if (frmColorGameVariable.DialogResult == DialogResult.OK)
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
