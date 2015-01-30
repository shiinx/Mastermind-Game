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

        /* For debugging purposes REMOVE BEFORE HANDING PROJECT IN
         */
        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(randNumber);
        }

        /* Returns to menu when button or X is clicked
         */
        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void frmNumberGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        // Global Variables
        const int EASY = 4, MEDIUM = 5, HARD = 6, INSANE = 8;
        const int NUMBEROFTIPS = 8;
        const int NUMBEROFTRIESALLOWED = 25;
        const int NUMBEROFDIFFICULTIES = 4;

        string randNumber, timeElapsed;
        bool error;
        int btnClickedCount = 0, counterTips = 0, clickCount, numOfDigits;

        Stopwatch stpWatch = new Stopwatch();


        String[] tips = new String[NUMBEROFTIPS]
            {
                "Tip : Read the instructions if you're not sure how to play this game.",
                "Tip : You can press enter on your keyboard instead of clicking check.",
                "Tip : Click on hints if you're stuck, there isn't any penalty.",
                "Tip : There are no repeat digits, eg. 2222, 5111, 0180",
                "Tip : Form a strategy, use a digit you know is wrong to check placement.",
                "Tip : Just give up if you're taking way to long.",
                "Tip : Start from an easier level if it's too hard.",
                "Tick-Tock, Tick-Tock. Time is wasting away. :D",
            };


        private void btnInstructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("List below shows the number of digits per difficulty."
                + "\nEasy: "    + EASY      +   " digits\t"
                + "\nMedium: "  + MEDIUM    +   " digits\t"
                + "\nHard: "    + HARD      +   " digits\t"
                + "\nInsane: "  + INSANE    +   " digits\t"
                + "\nYou can only press check/enter once you've input the correct number of digits."
                + "\nYou only have "+ NUMBEROFTRIESALLOWED + "tries regardless of difficulty."
                + "\nThere are no repeat digits, eg 2233, 5111, 0980.");
        }



        /* New Game button Click event
         */
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            randNumber = RandomNumber();
            if (error)
            {
                MessageBox.Show("Please select a difficulty before pressing New Game.");
                return;
            }
            lstvOutput.Items.Clear();
            txtDigitInput.Text = "";
            btnClickedCount = 0;
            counterTips = 0;
            stpWatch.Restart();
            lblTimer.Text = "00:00:00";
            timTimer.Start();
            timTips.Start();
            lblTips.Text = "Good Luck! You only have "+NUMBEROFTRIESALLOWED+" tries to use.";
            NewgameActions();
            btnCheck.Enabled = false;
        }



        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to give up?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("The correct digits were: "+randNumber, "Answer", MessageBoxButtons.OK);
                GiveupORwinActions();
                stpWatch.Stop();
                timTimer.Stop();
                timTips.Stop();
                lblTips.Text = "Click New Game to start.";
            }
        }



        /* Hints click event
         * Show first digit for Easy and Medium
         * Show first and last digit for Hard and Insane
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
                    hint = "          First digit: \n\t" + randNumber[0] + "\n          Last digit: \n\t" + randNumber[HARD - 1];
                    break;

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



        // Prevents user from pressing check unless the correct number of digits are inside the text box input.
        private void txtDigitInput_TextChanged(object sender, EventArgs e)
        {
            string strInputNumber = txtDigitInput.Text;
            btnCheck.Enabled = false;
            switch (DifficultyChecker())
            {
                case "Easy":
                    if (strInputNumber.Length == EASY)
                    {
                        btnCheck.Enabled = true;
                    }
                    break;

                case "Medium":
                    if (strInputNumber.Length == MEDIUM)
                    {
                        btnCheck.Enabled = true;
                    }
                    break;

                case "Hard":
                    if (strInputNumber.Length == HARD)
                    {
                        btnCheck.Enabled = true;
                    }
                    break;

                case "Insane":
                    if (strInputNumber.Length == INSANE)
                    {
                        btnCheck.Enabled = true;
                    }
                    break;

                default:
                    MessageBox.Show("You shouldn't be able to see this! Error! \n");
                    return;

            }
        }



        /* Button Check Click event
         * try catch to make sure only numbers have been input into the textbox
         * clear textbox after button click
         * +1 to click count
         * switch focus to textbox when checkbutton is pressed to ensure continuos input
         * 
         * if Win
         * Stop time
         * Display win message
         * 
         */
        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Check for only numbers is input by user and no blanks.
            try
            {
                uint testConvert = UInt32.Parse(txtDigitInput.Text);
            }
            catch
            {
                MessageBox.Show("Please input integer numbers.");
                return;
            }

            string strInputNumber = txtDigitInput.Text, winMessage, loseMessage;
            int CorrectlyPlacedDigits, CorrectDigits;
            btnClickedCount++;
            winMessage = "Congratulations! You got it right!";
            loseMessage = "Sorry! You've ran out of tries and lost!";

            CorrectlyPlacedDigits = CorrectNumDigitsPlaced(numOfDigits);
            CorrectDigits = CorrectNumDigits(numOfDigits);
            lstvOutput.Items.Add(LviOutput(btnClickedCount, strInputNumber, CorrectDigits, CorrectlyPlacedDigits));

            lstvOutput.EnsureVisible(lstvOutput.Items.Count - 1);

            if (strInputNumber == randNumber && btnClickedCount <= NUMBEROFTRIESALLOWED)
            {
                stpWatch.Stop();
                timTimer.Stop();
                timTips.Stop();
                TimeSpan ts = stpWatch.Elapsed;
                timeElapsed = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
                clickCount = btnClickedCount;
                MessageBox.Show(winMessage + "\nTries Used: " + clickCount + "\nTime Taken: " + timeElapsed);
                lblTips.Text = "Click New Game to start";
                GiveupORwinActions();

            }

            else if (btnClickedCount == NUMBEROFTRIESALLOWED)
            {
                stpWatch.Stop();
                timTimer.Stop();
                timTips.Stop();
                TimeSpan ts = stpWatch.Elapsed;
                timeElapsed = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
                clickCount = btnClickedCount;
                MessageBox.Show(loseMessage + "\nTries Used: " + clickCount + "\nTime Taken: " + timeElapsed + "\nThe correct digits were: " + randNumber);
                lblTips.Text = "Click New Game to start";
                GiveupORwinActions();
            }

            txtDigitInput.Text = "";
            txtDigitInput.Focus();
        }
        // End of check click event code


        // tooltips to show number of digits per dificlty
        private void Common_MouseEnter(object sender, EventArgs e)
        {
            RadioButton[] rbtnDifficulty = new RadioButton[NUMBEROFDIFFICULTIES] 
            {
                rBtnEasy,
                rBtnMedium,
                rBtnHard,
                rBtnInsane
            };

            System.Windows.Forms.ToolTip tltipDifficulty = new System.Windows.Forms.ToolTip();
            int counter = 0;
            while (counter < NUMBEROFDIFFICULTIES)
            {
                if (sender == rbtnDifficulty[counter])
                {
                    switch (counter)
                    {
                        case 0:
                            tltipDifficulty.SetToolTip(this.rBtnEasy, EASY + " digits");
                            break;
                        case 1:
                            tltipDifficulty.SetToolTip(this.rBtnMedium, MEDIUM + " digits");
                            break;
                        case 2:
                            tltipDifficulty.SetToolTip(this.rBtnHard, HARD + " digits");
                            break;
                        case 3:
                            tltipDifficulty.SetToolTip(this.rBtnInsane, INSANE + " digits");
                            break;
                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                counter++;
            }
        }



        private void timTips_Tick(object sender, EventArgs e)
        {
            if (counterTips == NUMBEROFTIPS)
            {
                counterTips = 0;
            }
            lblTips.Text = tips[counterTips];
            counterTips++;
        }



        private void timTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = stpWatch.Elapsed;
            lblTimer.Text = String.Format(String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds));
        }



        /* Code bellow are all method
         * DifficultyChecker        -> Check which difficuly is checked
         * randomNumber             -> Random Number returned depending on difficulty
         * strRandNumber            -> Random Number with digits randomnized individually to prevent repeating numbers
         * correctNumDigitsPlaced   -> Return number of digits correctly placed
         * correctNumDigits         -> Return number of correct digits
         * lviOutput                -> Returns the items/subitems that is to be put into the listviewbox
         * newgameActions           -> Resets visibility for certain buttons
         * giveupORwinActions       -> Resets visibility for certain buttons
         */


        // Returns Difficulty
        private string DifficultyChecker()
        {
            if (rBtnEasy.Checked == true)
            {
                numOfDigits = EASY;
                txtDigitInput.MaxLength = EASY;
                return "Easy";
            }
            if (rBtnMedium.Checked == true)
            {
                numOfDigits = MEDIUM;
                txtDigitInput.MaxLength = MEDIUM;
                return "Medium";
            }
            if (rBtnHard.Checked == true)
            {
                numOfDigits = HARD;
                txtDigitInput.MaxLength = HARD;
                return "Hard";
            }
            if (rBtnInsane.Checked == true)
            {
                numOfDigits = INSANE;
                txtDigitInput.MaxLength = INSANE;
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
                    error = false;
                    break;
                default:
                    randomNumber = "";
                    error = true;
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

        //
        private void GiveupORwinActions()
        {
            panelGameStart.Enabled = false;
            panelNewGame.Enabled = true;
            return;
        }

        //
        private void NewgameActions()
        {
            panelGameStart.Enabled = true;
            panelNewGame.Enabled = false;
            return;
        }

        
        


        // End of methods / function definitions

    }
}
// End of code




