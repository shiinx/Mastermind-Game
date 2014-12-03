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
    public partial class frmAskForName : Form
    {
        int storageCounter = 0;
        public frmAskForName()
        {
            InitializeComponent();
        }

        frmLeaderBoard LeaderBoard = new frmLeaderBoard();
        private void btnUpload_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
