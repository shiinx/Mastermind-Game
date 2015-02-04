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

        // Returns to menu when button or X is clicked
        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void frmNumberGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        // Opens RecordBoard
        private void btnRecordBoard_Click(object sender, EventArgs e)
        {
            frmRecordBoard recordBoard = new frmRecordBoard();
            recordBoard.ShowDialog();
        }

        // Global Variables
        const int EASY = 4, MEDIUM = 5, HARD = 6, INSANE = 8;
        const int NUMBEROFTIPS = 8;
        const int NUMBEROFTRIESALLOWED = 20;
        const int NUMBEROFDIFFICULTIES = 4;

        public bool classicMode, visualMode;
        string timeElapsed;
        bool error;
        int btnClickedCount = 0, counterTips = 0, clickCount, numOfDigits, gameNumber;

        Stopwatch stpWatch = new Stopwatch();

        string pathToPublicDocumentsFolder = @"C:\Users\Public\Documents\MastermindGame";
        string pathToNumberGameRecordsText = @"C:\Users\Public\Documents\MastermindGame\NumberGameRecords.txt";
        string pathToNumberGameNumberText = @"C:\Users\Public\Documents\MastermindGame\NumberGameNumber.txt";

        Int32[] globalRandNumber = new Int32[INSANE];
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

        // Global Declare End


        /* Creates files and folders when game loads
         * Creates a folder MastermindGame
         * If an existing text file called PictureGameRecords and PictureGameNumber doesn't exist, creates one
         * Takes a value from the Number Game Value to maintain the count of number of times game has been played and won
         */
        private void frmNumberGame_Load(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(pathToPublicDocumentsFolder);
            if (!System.IO.File.Exists(pathToNumberGameNumberText))
            {
                System.IO.File.WriteAllText(pathToNumberGameNumberText, "0");
            }
            if (!System.IO.File.Exists(pathToNumberGameRecordsText))
            {
                System.IO.File.WriteAllText(pathToNumberGameRecordsText, "");
            }
            gameNumber = Int32.Parse(System.IO.File.ReadAllText(pathToNumberGameNumberText));
            if (visualMode)
            {
                lblLegend.Visible = true;
            }
            else
            {
                lblLegend.Visible = false;
            }
        }



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



        /* For debugging purposes REMOVE BEFORE HANDING PROJECT IN
         */
        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Join("", globalRandNumber));
        }


        

        /* New Game button Click event
         */
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            DifficultyChecker();
            globalRandNumber = RandomNumberGenerator(numOfDigits);
            if (error)
            {
                MessageBox.Show("Please select a difficulty before pressing New Game.");
                error = false;
                return;
            }
            lstvOutput.Items.Clear();
            txtDigitInput.Text = "";
            btnClickedCount = 0;
            counterTips = 0;
            stpWatch.Restart();
            lblTimer.Text = "00:00";
            timTimer.Start();
            timTips.Start();
            lblTips.Text = "Good Luck! You only have "+NUMBEROFTRIESALLOWED+" tries to use.";
            NewgameActions();
            btnCheck.Enabled = false;
            if (classicMode)
            {
                lstvOutputClassicSettings();
            }
            if (visualMode)
            {
                lstvOutputVisualSettings();
            }
        }



        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to give up?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("The correct digits were: " + string.Join("", globalRandNumber), "Answer", MessageBoxButtons.OK);
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
                    hint = "          First digit: \n\t" + globalRandNumber[0];
                    break;

                case "Hard":
                    hint = "          First digit: \n\t" + globalRandNumber[0] + "\n          Last digit: \n\t" + globalRandNumber[HARD - 1];
                    break;

                case "Insane": 
                    hint = "          First digit: \n\t" + globalRandNumber[0] + "\n          Last digit: \n\t" + globalRandNumber[INSANE - 1];
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
            string InputNumber = txtDigitInput.Text;
            btnCheck.Enabled = false;
            CheckLength(InputNumber);
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

            if (classicMode)
            {
                CorrectlyPlacedDigits = CorrectNumDigitsPlaced(numOfDigits);
                CorrectDigits = CorrectNumDigits(numOfDigits);
                LstvOutputClassic(btnClickedCount,strInputNumber ,CorrectDigits, CorrectlyPlacedDigits);
            }
            if (visualMode)
            {
                LstvOutputVisual(btnClickedCount, strInputNumber);
            }

            lstvOutput.EnsureVisible(lstvOutput.Items.Count - 1);

            if (strInputNumber == String.Join("",globalRandNumber) && btnClickedCount <= NUMBEROFTRIESALLOWED)
            {
                stpWatch.Stop();
                timTimer.Stop();
                timTips.Stop();
                TimeSpan ts = stpWatch.Elapsed;
                timeElapsed = String.Format("{0:00}:{1:00}",ts.Minutes, ts.Seconds);
                clickCount = btnClickedCount;
                MessageBox.Show(winMessage + "\nTries Used: " + clickCount + "\nTime Taken: " + timeElapsed);
                lblTips.Text = "Click New Game to start";
                GiveupORwinActions();
                gameNumber++;
                string gameNumberToSave = gameNumber.ToString();
                System.IO.File.WriteAllText(pathToNumberGameNumberText, gameNumberToSave);
                using (System.IO.StreamWriter scoreToStore = new System.IO.StreamWriter(pathToNumberGameRecordsText, true))
                {
                    scoreToStore.WriteLine(gameNumber.ToString() + "\t" + DifficultyChecker() + "\t\t" + clickCount + "\t" + timeElapsed);
                }

            }

            else if (btnClickedCount == NUMBEROFTRIESALLOWED)
            {
                stpWatch.Stop();
                timTimer.Stop();
                timTips.Stop();
                TimeSpan ts = stpWatch.Elapsed;
                timeElapsed = String.Format("{0:00}:{1:00}",ts.Minutes, ts.Seconds);
                clickCount = btnClickedCount;
                MessageBox.Show(loseMessage + "\nTries Used: " + clickCount + "\nTime Taken: " + timeElapsed + "\nThe correct digits were: " + globalRandNumber);
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
            lblTimer.Text = String.Format(String.Format("{0:00}:{1:00}",ts.Minutes, ts.Seconds));
        }



        
        // Method definition below

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
                error = true;
                return null;
            }

        }



        /* Returns string of randomned number
         * Fuction required to indiviudally randomnize digits
         * To check and prevent repeat number within the random number string
         * 
         * End...
         */
        private Int32[] RandomNumberGenerator(int difficultyDigits)
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
            Int32[] randNumber = new Int32[difficultyDigits];
            randNumber[0] = numberToPick;
            NumberIsUsed[numberToPick] = true;

            for (digits = 1; digits < difficultyDigits; digits++)
            {
                numberToPick = Randomnizer.Next(0, 10);
                while (NumberIsUsed[numberToPick])
                {
                    numberToPick = Randomnizer.Next(0, 10);
                }
                NumberIsUsed[numberToPick] = true;
                randNumber[digits] = numberToPick;
            }
            return randNumber;
        }


        // Return number of correctly placed digits
        private int CorrectNumDigitsPlaced(int numOfDigits)
        {
            string InputNumber = txtDigitInput.Text;
            int CorrectlyPlacedDigits = 0, n;
            for (n = 0; n < numOfDigits; n++)
            {
                if (InputNumber[n] == globalRandNumber[n])
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
                    if (strInputNumber[a] == globalRandNumber[i])
                    {
                        n++;
                        break;
                    }
                }
            }
            return n;
        }


        // Returns listviewitems
        private void LstvOutputClassic(int ClickCount, string InputNumber, int CorrectDigits, int CorrectlyPlacedDigits)
        {
            ListViewItem lviOutput = new ListViewItem(ClickCount.ToString());
            lviOutput.SubItems.Add(InputNumber);
            lviOutput.SubItems.Add(CorrectDigits.ToString());
            lviOutput.SubItems.Add(CorrectlyPlacedDigits.ToString());
            lstvOutput.Items.Add(lviOutput);
            return;
        }

        private void LstvOutputVisual(int ClickCount, string InputNumber)
        {
            ListViewItem lviOutputName = new ListViewItem(ClickCount.ToString());
            ListViewItem lviOutputXOP = new ListViewItem();
            lviOutputXOP.UseItemStyleForSubItems = false;
            String[] outputArray = new String[numOfDigits];
            Boolean[] usedPorO = new Boolean[numOfDigits];
            for (int k = 0; k < numOfDigits; k++)
            {
                usedPorO[k] = false;
                outputArray[k] = "X";
            }
            string answer = String.Join("",globalRandNumber);
            for (int j = 0; j < numOfDigits; j++)
            {
                if (InputNumber[j] == answer[j])
                {
                    outputArray[j] = "O";
                }
            }

            for (int counterInput = 0; counterInput < numOfDigits; counterInput++)
            {
                if (outputArray[counterInput] != "O")
                {
                    for (int counterAns = 0; counterAns < numOfDigits; counterAns++)
                    {
                        if (outputArray[counterAns] != "O" && !usedPorO[counterAns] && InputNumber[counterInput] == answer[counterAns])
                        {
                            outputArray[counterInput] = "P";
                            usedPorO[counterAns] = true;
                        }
                    }
                }
            }

            for (int i = 0; i < numOfDigits; i++)
            {
                lviOutputName.SubItems.Add(InputNumber[i].ToString());
                lviOutputXOP.SubItems.Add(outputArray[i]);
                if(outputArray[i] == "O")
                {
                    lviOutputXOP.SubItems[i+1].ForeColor = Color.Green;
                }
                if (outputArray[i] == "X")
                {
                    lviOutputXOP.SubItems[i+1].ForeColor = Color.Red;
                }
                if (outputArray[i] == "P")
                {
                    lviOutputXOP.SubItems[i+1].ForeColor = Color.Yellow;
                }
            }
            lstvOutput.Items.Add(lviOutputName);
            lstvOutput.Items.Add(lviOutputXOP);
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

        private void CheckLength(string InputNumber)
        {
            switch (DifficultyChecker())
            {
                case "Easy":
                    if (InputNumber.Length == EASY)
                    {
                        btnCheck.Enabled = true;
                    }
                    break;

                case "Medium":
                    if (InputNumber.Length == MEDIUM)
                    {
                        btnCheck.Enabled = true;
                    }
                    break;

                case "Hard":
                    if (InputNumber.Length == HARD)
                    {
                        btnCheck.Enabled = true;
                    }
                    break;

                case "Insane":
                    if (InputNumber.Length == INSANE)
                    {
                        btnCheck.Enabled = true;
                    }
                    break;

                default:
                    MessageBox.Show("You shouldn't be able to see this! Error! (Error Caused in txtDigitInput_TextChanged Event) \n");
                    break;

            }
        }

        // Columns to add when classic is selected in the menu
        private void lstvOutputClassicSettings()
        {
            lstvOutput.Columns.Clear();
            lstvOutput.Columns.Add("No.", 60, HorizontalAlignment.Center);
            lstvOutput.Columns.Add("InputNumber", 400, HorizontalAlignment.Center);
            lstvOutput.Columns.Add("No. of Correct Digits", 350, HorizontalAlignment.Center);
            lstvOutput.Columns.Add("No. of Correctly Placed Digits", 350, HorizontalAlignment.Center);
            return;
        }

        // Columns to add when Visual is selected in the menu
        private void lstvOutputVisualSettings()
        {
            String[] columnName = new String[INSANE]
            {
                "1st Digit",
                "2nd Digit",
                "3rd Digit",
                "4th Digit",
                "5th Digit",
                "6th Digit",
                "7th Digit",
                "8th Digit",
            };
            lstvOutput.Columns.Clear();
            lstvOutput.Columns.Add("No.", 60, HorizontalAlignment.Center);
            for (int i = 0; i < numOfDigits; i++)
            {
                lstvOutput.Columns.Add(columnName[i], 150, HorizontalAlignment.Center);
            }
            return;
        }


        
        


        // End of methods / function definitions

    }
}
// End of code




