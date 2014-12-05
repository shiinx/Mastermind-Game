using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace MasterMind_Game
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
                + "\nHard:\t"   + HardDigits    + " digits\t" 
                + "\nInsane:\t" + InsaneDigits  + " digits\t");
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



        /* Hints click event
         * Show first digit for Easy and Medium
         * Show first and last digit for Hard and Insane
         * End...
         */
        private void btnHint_Click(object sender, EventArgs e)
        {
            String Difficulty = DifficultyChecker();
            String hint = "";
            switch (Difficulty)
            {
                case "Easy":    hint = "          First digit: \n\t" + randNumber[0];
                                break;

                case "Medium":  hint = "          First digit: \n\t" + randNumber[0];
                                break;

                case "Hard":    hint = "          First digit: \n\t" + randNumber[0] + "\n          Last digit: \n\t" + randNumber[HardDigits - 1];
                                break;

                case "Insane":  hint = "          First digit: \n\t" + randNumber[0] + "\n          Last digit: \n\t" + randNumber[InsaneDigits - 1];
                                break;

                default:        hint = "You can't be here!...\n Whelp, must be the stupid coders mistake...";
                                break;

            }

            MessageBox.Show(hint, "Hint", MessageBoxButtons.OK);
        }
        // End of hint click codes





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
            string strInputNumber = txtDigitInput.Text;
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
            string strInputNumber = txtDigitInput.Text;
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
            btnHint.Enabled = false;
            btnGiveUp.Enabled = false;
            btnNewGame.Enabled = true;
            rBtnEasy.Enabled = true;
            rBtnMedium.Enabled = true;
            rBtnHard.Enabled = true;
            rBtnInsane.Enabled = true;
            return;
        }

        private void newgameActions()
        {

            btnCheck.Enabled = true;
            btnHint.Enabled = true;
            btnGiveUp.Enabled = true;
            btnNewGame.Enabled = false;
            rBtnEasy.Enabled = false;
            rBtnMedium.Enabled = false;
            rBtnHard.Enabled = false;
            rBtnInsane.Enabled = false;
            return;
        }
        // End of fuction definitions... 
    }
}
