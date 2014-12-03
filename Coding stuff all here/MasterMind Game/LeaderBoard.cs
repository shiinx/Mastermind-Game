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
    public partial class frmLeaderBoard : Form
    {
        public frmLeaderBoard()
        {
            InitializeComponent();
        }

        public int[] tryCount;
        public string[] timeTaken, name;

        private void frmLeaderBoard_Load(object sender, EventArgs e)
        {
           
            int rank = 1, storageCounter =0;

            while (rank <= 20)
            {
                ListViewItem lviOutput = new ListViewItem(rank.ToString());
                lviOutput.SubItems.Add(name[storageCounter]);
                lviOutput.SubItems.Add(tryCount[storageCounter].ToString());
                lviOutput.SubItems.Add(timeTaken[storageCounter]);
                lstvLeaderboard.Items.Add(lviOutput);
                storageCounter++;
                rank++;
            }

        }
         


    }
}
