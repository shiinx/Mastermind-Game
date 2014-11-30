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
    public partial class frmNumberGame : Form
    {
        /* private declares
         * string randNumber
         * int btnClickCount
         * int Difficulty settings for Number of digits
         * 
         * End...
         */
        string randNumber;
        int btnClickedCount = 0;
        int sec = 0, min = 0, hr = 0;
        // Change number of digits per difficulty by changing numbers
        int EasyDigits = 4, MediumDigits = 5, HardDigits = 6, InsaneDigits = 8;



        public frmNumberGame()
        {
            InitializeComponent();
        }



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



        // To open scoreboard
        frmLeaderBoard frmLeaderBoard = new frmLeaderBoard();
        private void btnLeaderBoard_Click(object sender, EventArgs e)
        {
            frmLeaderBoard.ShowDialog();
        }



        // To open instructions  
        private void btnInstructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click New Game to generate a new number.\nList below shows the number of digits per difficulty."
                + "\nEasy:\t"   + EasyDigits    + " digits\t" 
                + "\nMedium:\t" + MediumDigits  + " digits\t" 
                + "\nHard:\t"   + HardDigits    + " digits\t" 
                + "\nInsane:\t" + InsaneDigits  + " digits\t" 
                + "Press upload to leaderboard to transfer your score to the leaderboards.");
        }



        /* New Game button Click event
         * To generate new random number depending on difficulty 
         * If no difficulty selected show error message
         * To clear items in listboxview
         * To clear input textbox
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
            txtDigitInput.Text = "";
            btnClickedCount = 0;
            timTimerReset();
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

            // Rest of the freakin code
            string strInputNumber = txtDigitInput.Text, winMessage, timeElapsed;
            int CorrectlyPlacedDigits, CorrectDigits, ClickCount;
            btnClickedCount++;
            winMessage = String.Format("Congratulations! You got it right!\n{0}", randNumber);
            

            switch (DifficultyChecker())
            {
                case "Easy":
                        if (strInputNumber.Length != EasyDigits)
                        {
                            MessageBox.Show("Please Enter " + EasyDigits +" Digits.");
                            btnClickedCount--;
                            txtDigitInput.Focus();
                            return;
                        }

                        CorrectlyPlacedDigits = correctNumDigitsPlaced(EasyDigits);
                        CorrectDigits = correctNumDigits(EasyDigits);

                        if (strInputNumber == randNumber)
                        {
                            timTimer.Stop();
                            timeElapsed = String.Format("{0:00}:{1:00}:{2:00}", hr, min, sec);
                            ClickCount = btnClickedCount;
                            MessageBox.Show(winMessage + "\n" + ClickCount + "\n" + timeElapsed);
                            giveupORwinActions();

                        }

                        lstvOutput.Items.Add(lviOutput(btnClickedCount, strInputNumber, CorrectDigits, CorrectlyPlacedDigits));
                        break;

                case "Medium":
                        if (strInputNumber.Length != MediumDigits)
                        {
                            MessageBox.Show("Please Enter " + MediumDigits + " Digits.");
                            btnClickedCount--;
                            txtDigitInput.Focus();
                            return;
                        }

                        CorrectlyPlacedDigits = correctNumDigitsPlaced(MediumDigits);
                        CorrectDigits = correctNumDigits(MediumDigits);

                        if (strInputNumber == randNumber)
                        {
                            timTimer.Stop();
                            timeElapsed = String.Format("{0:00}:{1:00}:{2:00}", hr, min, sec);
                            ClickCount = btnClickedCount;
                            MessageBox.Show(winMessage + "\n" + ClickCount + "\n" + timeElapsed);
                            giveupORwinActions();
                        }
                        
                        lstvOutput.Items.Add(lviOutput(btnClickedCount, strInputNumber, CorrectDigits, CorrectlyPlacedDigits));
                        break;

                case "Hard":
                        if (strInputNumber.Length != HardDigits)
                        {
                            MessageBox.Show("Please Enter " + HardDigits + " Digits.");
                            btnClickedCount--;
                            txtDigitInput.Focus();
                            return;
                        }

                        CorrectlyPlacedDigits = correctNumDigitsPlaced(HardDigits);
                        CorrectDigits = correctNumDigits(HardDigits);

                        if (strInputNumber == randNumber)
                        {
                            timTimer.Stop();
                            timeElapsed = String.Format("{0:00}:{1:00}:{2:00}", hr, min, sec);
                            ClickCount = btnClickedCount;
                            MessageBox.Show(winMessage + "\n" + ClickCount + "\n" + timeElapsed);
                            giveupORwinActions();
                        }

                        lstvOutput.Items.Add(lviOutput(btnClickedCount, strInputNumber, CorrectDigits, CorrectlyPlacedDigits));
                        break;

                case "Insane":
                        if (strInputNumber.Length != InsaneDigits)
                        {
                            MessageBox.Show("Please Enter " + InsaneDigits + " Digits.");
                            btnClickedCount--;
                            txtDigitInput.Focus();
                            return;
                        }

                        CorrectlyPlacedDigits = correctNumDigitsPlaced(InsaneDigits);
                        CorrectDigits = correctNumDigits(InsaneDigits);

                        if (strInputNumber == randNumber)
                        {
                            timTimer.Stop();
                            timeElapsed = String.Format("{0:00}:{1:00}:{2:00}", hr, min, sec);
                            ClickCount = btnClickedCount;
                            MessageBox.Show(winMessage + "\n" + ClickCount + "\n" + timeElapsed);
                            giveupORwinActions();
                        }
                         
                        lstvOutput.Items.Add(lviOutput(btnClickedCount, strInputNumber, CorrectDigits, CorrectlyPlacedDigits));
                         break;
                default :
                         MessageBox.Show("You shouldn't be able to see this!...\nMust be the some stupid logic error again...");
                         break;

            }
            lstvOutput.EnsureVisible(lstvOutput.Items.Count-1);
            txtDigitInput.Text = "";
            txtDigitInput.Focus();
            
            

        }
        // End of check click event code



        // timer/stopwatch
        private void timTimer_Tick(object sender, EventArgs e)
        {
            sec++;
            if (sec == 59)
            {
                min++;
                sec = 0;
            }
            if (min == 59)
            {
                hr++;
                min = 0;
            }
            lblTimer.Text = String.Format("{0:00}:{1:00}:{2:00}", hr, min, sec);
        }
        





        /* Code bellow are all function definition stuff...
         * DifficultyChecker        -> Check which difficuly is checked
         * randomNumber             -> Random Number returned depending on difficulty
         * strRandNumber            -> Random Number with digits randomnized individually to prevent repeating numbers
         * correctNumDigitsPlaced   -> Return number of digits correctly placed
         * correctNumDigits         -> Return number of correct digits
         * lviOutput                -> Returns the items/subitems that is to be put into the listviewbox
         * timTimerReset            -> Resets timer
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
            if (rBtnInsane.Checked == true)
            {
                return "Insane";
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
                case "Insane":  randomNumber = strRandNumber(InsaneDigits);
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

        

        // timer reset function
        private void timTimerReset()
        {
            sec = 0;
            min = 0;
            hr = 0;
            lblTimer.Text = "00:00:00";
            return;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

        }
        
        // End of fuction definitions... 




    }
}
// End of code


                

