using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace Mastermind_Game
{
    public partial class frmNumberGame : Form
    {
        public frmNumberGame()
        {
            InitializeComponent();
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void frmNumberGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        const int EASY = 4, MEDIUM = 5, HARD = 6, INSANE = 8;

        string randNumber, timeElapsed;
        int btnClickedCount = 0, ClickCount, numOfDigits;


        Stopwatch stpWatch = new Stopwatch();



        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(randNumber);
        }



        private void btnInstructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click New Game to generate a new number.\nList below shows the number of digits per difficulty."
                + "\nEasy: "    + EASY      +   " digits\t"
                + "\nMedium: "  + MEDIUM    +   " digits\t"
                + "\nHard: "    + HARD      +   " digits\t"
                + "\nInsane: "  + INSANE    +   " digits\t");
        }



        /* New Game button Click event
         */
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            randNumber = RandomNumber();
            if (randNumber == "false")
            {
                MessageBox.Show("Please select a difficulty before pressing New Game.");
                return;
            }
            lstvOutput.Items.Clear();
            txtDigitInput.Text = "";
            btnClickedCount = 0;
            stpWatch.Restart();
            lblTimer.Text = "00:00:00";
            timTimer.Start();
            NewgameActions();
        }



        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to give up?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show(randNumber,"Answer",MessageBoxButtons.OK)
                GiveupORwinActions();
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
                case "Easy": 
                case "Medium": 
                    hint = "          First digit: \n\t" + randNumber[0];
                    break;

                case "Hard": 
                case "Insane": 
                    hint = "          First digit: \n\t" + randNumber[0] + "\n          Last digit: \n\t" + randNumber[INSANE - 1];
                    break;

                default: 
                    hint = "You can't be here!...\n Whelp, must be the stupid coders mistake...";
                    break;

            }

            MessageBox.Show(hint, "Hint", MessageBoxButtons.OK);
        }



        /* When textbox has focus/is being used, and enter button on keyboard is pressed, btnCheck will be clicked.
         * Suppresskeypress seems to eliminate the ding sound that occurs when enter is pressed.
         */
        private void txtDigitInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCheck.PerformClick();
                e.SuppressKeyPress = true;
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
            // Check for only numbers is input by user and no blanks.
            try
            {
                int intInputNumber = Convert.ToInt32(txtDigitInput.Text);
            }
            catch
            {
                MessageBox.Show("Please input numbers.");
                return;
            }

            string strInputNumber = txtDigitInput.Text, winMessage;
            int CorrectlyPlacedDigits, CorrectDigits;
            btnClickedCount++;
            winMessage = String.Format("Congratulations! You got it right!\n{0}", randNumber);

            switch (DifficultyChecker())
            {
                case "Easy":
                    if (strInputNumber.Length != EASY)
                    {
                        MessageBox.Show("Please Enter " + EASY + " Digits.");
                        btnClickedCount--;
                        txtDigitInput.Focus();
                        return;
                    }
                    break;

                case "Medium":
                    if (strInputNumber.Length != MEDIUM)
                    {
                        MessageBox.Show("Please Enter " + MEDIUM + " Digits.");
                        btnClickedCount--;
                        txtDigitInput.Focus();
                        return;
                    }
                    break;

                case "Hard":
                    if (strInputNumber.Length != HARD)
                    {
                        MessageBox.Show("Please Enter " + HARD + " Digits.");
                        btnClickedCount--;
                        txtDigitInput.Focus();
                        return;
                    }
                    break;

                case "Insane":
                    if (strInputNumber.Length != INSANE)
                    {
                        MessageBox.Show("Please Enter " + INSANE + " Digits.");
                        btnClickedCount--;
                        txtDigitInput.Focus();
                        return;
                    }
                    break;

                default:
                    MessageBox.Show("You shouldn't be able to see this!...\nMust be the some stupid logic error again...")
                    break;

            }

            CorrectlyPlacedDigits = CorrectNumDigitsPlaced(numOfDigits);
            CorrectDigits = CorrectNumDigits(numOfDigits);
            lstvOutput.Items.Add(LviOutput(btnClickedCount, strInputNumber, CorrectDigits, CorrectlyPlacedDigits));

            if (strInputNumber == randNumber)
            {
                stpWatch.Stop();
                timTimer.Stop();
                TimeSpan ts = stpWatch.Elapsed;
                timeElapsed = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
                ClickCount = btnClickedCount;
                MessageBox.Show(winMessage + "\n Tries Used: " + ClickCount + "\n Time Taken: " + timeElapsed);
                GiveupORwinActions();

            }

            lstvOutput.EnsureVisible(lstvOutput.Items.Count - 1);
            txtDigitInput.Text = "";
            txtDigitInput.Focus();
        }
        // End of check click event code




        private void timTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = stpWatch.Elapsed;
            lblTimer.Text = String.Format(String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds));
        }






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
                numOfDigits = EASY;
                return "Easy";
            }
            if (rBtnMedium.Checked == true)
            {
                numOfDigits = MEDIUM;
                return "Medium";
            }
            if (rBtnHard.Checked == true)
            {
                numOfDigits = HARD;
                return "Hard";
            }
            if (rBtnInsane.Checked == true)
            {
                numOfDigits = INSANE;
                return "Insane";
            }
            else
            {
                return null;
            }

        }


        // Returns Randomnized Number depending on difficulty
        private string RandomNumber()
        {
            string randomNumber;
            string Difficulty = DifficultyChecker();
            switch (Difficulty)
            {
                case "Easy":
                case "Medium":
                case "Hard": 
                case "Insane": 
                    randomNumber = RandNumber(numOfDigits);
                    break;
                default: randomNumber = "false";
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
        private string RandNumber(int difficultyDigits)
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
        private int CorrectNumDigitsPlaced(int numOfDigits)
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
        private int CorrectNumDigits(int numOfDigits)
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
        private ListViewItem LviOutput(int ClickCount, string InputNumber, int CorrectDigits, int CorrectlyPlacedDigits)
        {
            ListViewItem lviOutput = new ListViewItem(ClickCount.ToString());
            lviOutput.SubItems.Add(InputNumber);
            lviOutput.SubItems.Add(CorrectDigits.ToString());
            lviOutput.SubItems.Add(CorrectlyPlacedDigits.ToString());
            return lviOutput;
        }

        private void GiveupORwinActions()
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

        private void NewgameActions()
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
// End of code




