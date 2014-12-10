using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mastermind_Game
{
    public partial class frmPictureGame : Form
    {
        public frmPictureGame()
        {
            InitializeComponent();
        }
        


         /* private declares
         * string randNumber, time Elapsed
         * int btnClickCount , ClickCount
         * int Difficulty settings for Number of digits
         * new Stopwatch
         * End...
         */
        string randNumber,timeElapsed;
        int btnClickedCount = 0 ,  ClickCount;
        // Change number of digits per difficulty by changing numbers
        int EasyDigits = 4, MediumDigits = 5, HardDigits = 6;
        Stopwatch stpWatch = new Stopwatch();


        // To show Answer for error checking
        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(randNumber);
        }



        // To close dialog / return to menu when btnMenu is clicked or redcross is clicked
        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void frmNumberGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }



        // To open instructions  
        private void btnInstructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click New Game to generate a new number.\nList below shows the number of digits per difficulty."
                + "\nEasy:\t"   + EasyDigits    + " digits\t" 
                + "\nMedium:\t" + MediumDigits  + " digits\t" 
                + "\nHard:\t"   + HardDigits    + " digits\t");
        }



        /* New Game button Click event
         * To generate new random number depending on difficulty 
         * If no difficulty selected show error message
         * To clear items in listboxview
         * To clear input textbox
         * To reset time and lbltimer
         * To reset Click Count number
         * Enable check and hint button
         * Disable difficulty buttons to prevent difficulty switching when game starts
         * 
         * End...
         */
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            randNumber = randomNumber();
            if(randNumber == "false")
            {
                MessageBox.Show("Please select a difficulty before pressing New Game.");
                return;
            }
            lstvOutput.Items.Clear();
            btnClickedCount = 0;
            stpWatch.Restart();
            lblTimer.Text = "00:00:00";
            timTimer.Start();
            newgameActions();
        }
        // End of New Game Click button event code



        // Give up button to reset button visibility to new game settings
        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to give up?", "Confirmation", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                giveupORwinActions();
                stpWatch.Stop();
                timTimer.Stop();
            }
        }




        /* Button Check Click event
         * try catch to make sure only numbers have been input into the textbox
         * switch case for different difficulty settings
         * clear textbox after button click
         * +1 to click count
         * switch focus to textbox when checkbutton is pressed to ensure continuos input
         * 
         * if Win
         * Stop time
         * Display win message
         * 
         * End...
         */
        private void btnCheck_Click(object sender, EventArgs e)
        {

        }
        // End of check click event code



        /*private void timTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = stpWatch.Elapsed;
            lblTimer.Text = String.Format(String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds));
        }
        */






        /* Code bellow are all function definition stuff...
         * DifficultyChecker        -> Check which difficuly is checked
         * randomNumber             -> Random Number returned depending on difficulty
         * strRandNumber            -> Random Number with digits randomnized individually to prevent repeating numbers
         * correctNumDigitsPlaced   -> Return number of digits correctly placed
         * correctNumDigits         -> Return number of correct digits
         * lviOutput                -> Returns the items/subitems that is to be put into the listviewbox
         * newgameActions           -> Resets visibility for certain buttons
         * giveupORwinActions       -> Resets visibility for certain buttons
         * 
         * End...
         */


        // Returns Difficulty
        private string DifficultyChecker()
        {
            if (rBtnEasy.Checked == true)
            {
                return "Easy";
            }
            if (rBtnMedium.Checked == true)
            {
                return "Medium";
            }
            if (rBtnHard.Checked == true)
            {
                return "Hard";
            }
            else
            {
                return null;
            }

        }


        // Returns Randomnized Number depending on difficulty
        private string randomNumber()
        {
            string randomNumber;
            string Difficulty = DifficultyChecker();
            switch (Difficulty)
            {
                case "Easy":    randomNumber = strRandNumber(EasyDigits);
                    break;
                case "Medium":  randomNumber = strRandNumber(MediumDigits);
                    break;
                case "Hard":    randomNumber = strRandNumber(HardDigits);
                    break;
                default:        randomNumber = "false";
                    break;
            }
            return randomNumber;
        }


        /* Returns string of randomned number
         * Fuction required to indiviudally randomnize digits
         * To check and prevent repeat number within the random number string
         * 
         * End...
         */
        private string strRandNumber(int difficultyDigits)
        {
            Random Randomnizer = new Random();
            bool[] NumberIsUsed = new bool[10];
            for (int i = 0; i < 10; i++)
            {
                NumberIsUsed[i] = false;
            }

            //randomnize first digit in string outside to prevent first digit from being 0
            int digits = 0;
            int numberToPick = Randomnizer.Next(1, 10);
            String randNumber = numberToPick.ToString();
            NumberIsUsed[numberToPick] = true;

            for (digits = 1; digits < difficultyDigits; digits++)
            {
                numberToPick = Randomnizer.Next(0, 10);
                while (NumberIsUsed[numberToPick])
                {
                    numberToPick = Randomnizer.Next(0, 10);
                }
                NumberIsUsed[numberToPick] = true;
                randNumber += numberToPick.ToString();
            }
            return randNumber;
        }


        // Return number of correctly placed digits
        private int correctNumDigitsPlaced(int numOfDigits)
        {
            string strInputNumber = "a";
            int CorrectlyPlacedDigits = 0, n;
            for (n = 0; n < numOfDigits; n++)
            {
                if (strInputNumber[n] == randNumber[n])
                    CorrectlyPlacedDigits++;
            }
            return CorrectlyPlacedDigits;
        }


        // Return number of correct digits
        private int correctNumDigits(int numOfDigits)
        {
            string strInputNumber = "a";
            int i, a, n = 0;
            for (i = 0; i < numOfDigits; i++)
            {
                for (a = 0; a < numOfDigits; a++)
                {
                    if (strInputNumber[a] == randNumber[i])
                    {
                        n++;
                        break;
                    }
                }
            }
            return n;
        }


        // Returns listviewitems
        private ListViewItem lviOutput(int ClickCount,string InputNumber,int CorrectDigits,int CorrectlyPlacedDigits)
        {
            ListViewItem lviOutput = new ListViewItem(ClickCount.ToString());
            lviOutput.SubItems.Add(InputNumber);
            lviOutput.SubItems.Add(CorrectDigits.ToString());
            lviOutput.SubItems.Add(CorrectlyPlacedDigits.ToString());
            return lviOutput;
        }

        private void giveupORwinActions()
        {
            btnCheck.Enabled = false;
            btnGiveUp.Enabled = false;
            btnNewGame.Enabled = true;
            rBtnEasy.Enabled = true;
            rBtnMedium.Enabled = true;
            rBtnHard.Enabled = true;
            return;
        }

        private void newgameActions()
        {

            btnCheck.Enabled = true;
            btnGiveUp.Enabled = true;
            btnNewGame.Enabled = false;
            rBtnEasy.Enabled = false;
            rBtnMedium.Enabled = false;
            rBtnHard.Enabled = false;
            return;
        }


        /* My picture change on click code
         * I'll shorten it when I have the dam time or know how
         * Tedious as heck code
         * Try using more array to shorten
         */
        Bitmap[] resourcePic = new Bitmap[8]{Properties.Resources.Picture1,
        Properties.Resources.Picture2,
        Properties.Resources.Picture3,
        Properties.Resources.Picture4,
        Properties.Resources.Picture5,
        Properties.Resources.Picture6,
        Properties.Resources.Picture7,
        Properties.Resources.Picture8};


        int resourcePicCounter1 = 1;
        private void picOne_Click(object sender, EventArgs e)
        {
            if (resourcePicCounter1 == 8)
            {
                resourcePicCounter1 = 0;
            }

            picOne.Image = resourcePic[resourcePicCounter1];
            resourcePicCounter1++;
        }

        int resourcePicCounter2 = 1;
        private void picTwo_Click(object sender, EventArgs e)
        {
            if (resourcePicCounter2 == 8)
            {
                resourcePicCounter2 = 0;
            }

            picTwo.Image = resourcePic[resourcePicCounter2];
            resourcePicCounter2++;
        }


        int resourcePicCounter3 = 1;
        private void picThree_Click(object sender, EventArgs e)
        {
            if (resourcePicCounter3 == 8)
            {
                resourcePicCounter3 = 0;
            }

            picThree.Image = resourcePic[resourcePicCounter3];
            resourcePicCounter3++;
        }

        int resourcePicCounter4 = 1;
        private void picFour_Click(object sender, EventArgs e)
        {
            if (resourcePicCounter4 == 8)
            {
                resourcePicCounter4 = 0;
            }

            picFour.Image = resourcePic[resourcePicCounter4];
            resourcePicCounter4++;
        }

        int resourcePicCounter5 = 1;
        private void picFive_Click(object sender, EventArgs e)
        {
            if (resourcePicCounter5 == 8)
            {
                resourcePicCounter5 = 0;
            }

            picFive.Image = resourcePic[resourcePicCounter5];
            resourcePicCounter5++;
        }

        int resourcePicCounter6 = 1;
        private void picSix_Click(object sender, EventArgs e)
        {
            if (resourcePicCounter6 == 8)
            {
                resourcePicCounter6 = 0;
            }

            picSix.Image = resourcePic[resourcePicCounter6];
            resourcePicCounter6++;
        }



        // End of fuction definitions... 
    }

}
