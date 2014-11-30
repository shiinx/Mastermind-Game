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
        // string randnumber and btnclickcount
        string randNumber;
        int btnClickedCount=0;
        public frmNumberGame()
        {
            InitializeComponent();
        }

        // To show answer
        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(randNumber);
        }

        // To close dialog / return to menu
        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        // To open scoreboard
        frmScoreboard frmScoreboardPopout = new frmScoreboard();
        private void btnScoreBoard_Click(object sender, EventArgs e)
        {
            frmScoreboardPopout.ShowDialog();
        }

        // To open instructions  
        private void btnInstructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click New Game to change number and clear list.\nEasy:\t4 digits\t20 tries\nMedium:\t6 digits\t15 tries\nHard:\t8 digits\t10 tries\nInsane:\t8 digits\t 5 tries\n");
        }

        /* New Game button Click event
         * To generate new random number depending on difficulty 
         * To reset Click Count number
         * To reset items in listbox
         * D:.......
         */
        public void btnNewGame_Click(object sender, EventArgs e)
        {
            Boolean checkedboxeq1;
            checkedboxeq1 = checkboxCounterEqOne();
            if (checkedboxeq1 == true)
            {
                randNumber = Convert.ToString(randomNumber());
                lstOutput.Items.Clear();
                lstOutput.Items.Add("Input No.\t\tNo. of correctly placed digits\t\tNo. of correct digits");
                txtDigitInput.Text = "";
                btnClickedCount = 0;
            }
            else
                MessageBox.Show("Please select one difficulty before pressing New Game.");
        }


        /* Button Click event
         * try catch to make sure only numbers have been input into the textbox
         * switch case for different difficulty settings
         * clear textbox after button clik
         * +1 to click count
         * switch focus to textbox when checkbutton is pressed to ensure continuos input
         * ToDo:
         * Enter press = btnNewGame_Click event
         * 
         * Derrrr......
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
            string strInputNumber = txtDigitInput.Text;
            int CorrectlyPlacedDigits, CorrectDigits;
            // Change number of digits by changing numbers
            int EasyDigits = 4, MediumDigits = 5, HardDigits = 6, InsaneDigits = 8;

            switch (DifficultyChecker())
            {
                case "Easy":
                    if (strInputNumber.Length != EasyDigits)
                    {
                        MessageBox.Show("Please Enter " + EasyDigits +" Digits.");
                        break;
                    }
                    if (strInputNumber == randNumber)
                        MessageBox.Show("Congratulations! You got it right!\n" + strInputNumber + "\t\t" + randNumber);
                    else
                    {
                        if (btnClickedCount >= 20)
                            MessageBox.Show("Sorry you lose!");
                        else
                        {
                            CorrectlyPlacedDigits = correctNumDigitsPlaced(EasyDigits);
                            CorrectDigits = correctNumDigits(EasyDigits);
                            lstOutput.Items.Add(strInputNumber + "\t\t\t" + CorrectlyPlacedDigits + "\t\t\t\t" + CorrectDigits);
                        }
                    }
                    break;
                case "Medium":
                    if (strInputNumber.Length != MediumDigits)
                    {
                        MessageBox.Show("Please Enter " + MediumDigits + " Digits.");
                        break;
                    }
                    if (strInputNumber == randNumber)
                        MessageBox.Show("Congratulations! You got it right!\n\t\t" + strInputNumber + "\t\t" + randNumber);
                    else
                    {
                        if (btnClickedCount >= 15)
                            MessageBox.Show("Sorry you lose!");
                        else
                        {
                        CorrectlyPlacedDigits = correctNumDigitsPlaced(MediumDigits);
                        CorrectDigits = correctNumDigits(MediumDigits);
                        lstOutput.Items.Add(strInputNumber + "\t\t\t" + CorrectlyPlacedDigits + "\t\t\t\t" + CorrectDigits);
                        }
                    }
                    break;
                case "Hard":
                        if (strInputNumber.Length != HardDigits)
                    {
                        MessageBox.Show("Please Enter " + HardDigits + " Digits.");
                        break;
                    }
                    if (strInputNumber == randNumber)
                        MessageBox.Show("Congratulations! You got it right!\n\t\t" + strInputNumber + "\t\t" + randNumber);
                    else
                    {
                        if(btnClickedCount >=10)
                            MessageBox.Show("Sorry you lose!");
                        else
                        {
                        CorrectlyPlacedDigits = correctNumDigitsPlaced(HardDigits);
                        CorrectDigits = correctNumDigits(HardDigits);
                        lstOutput.Items.Add(strInputNumber + "\t\t\t" + CorrectlyPlacedDigits + "\t\t\t\t" + CorrectDigits );
                        }
                    }
                    break;
                case "Insane":
                        if (strInputNumber.Length != InsaneDigits)
                    {
                        MessageBox.Show("Please Enter " + InsaneDigits +" Digits.");
                        break;
                    }
                        if (strInputNumber == randNumber)
                            MessageBox.Show("Congratulations! You got it right!\n\t\t" + strInputNumber + "\t\t" + randNumber);
                        else
                        {
                            if(btnClickedCount >=5)
                                MessageBox.Show("Sorry you lose!");
                            else
                            {
                            CorrectlyPlacedDigits = correctNumDigitsPlaced(InsaneDigits);
                            CorrectDigits = correctNumDigits(InsaneDigits);
                            lstOutput.Items.Add(strInputNumber + "\t\t\t" + CorrectlyPlacedDigits + "\t\t\t\t" + CorrectDigits);
                            }
                        }
                    break;
                default:
                    break;
            }
            txtDigitInput.Text = "";
            txtDigitInput.Focus();
            btnClickedCount++;
            

        }


        /*Code bellow are all function definition
         * randomnizer              -> Random fuction
         * checkboxCounterEqOne     -> Used to check if total checkbox checked is equal to one = true
         * DifficultyChecker        -> Check which difficuly is checked
         * randomNumber             -> Random Number returned depending on difficulty
         * correctNumDigitsPlaced   -> Return number of digits correctly placed
         * correctNumDigits         -> Return number of correct digits
         * End...
         */


        // Returns Randomed Number
        public int randomnizer(int min, int max)
        {
            Random randomnizer = new Random();
            int randomNumber = randomnizer.Next(min, max);
            return randomNumber;
        }


        // Returns Number of checkbox checked
        public Boolean checkboxCounterEqOne()
        {
            int counterCheckbox = 0;
            foreach (Control a in this.Controls)
            {
                if (a is CheckBox)
                {
                    if (((CheckBox)a).Checked)
                    {
                        counterCheckbox++;
                    }
                }
            }
            if (counterCheckbox == 1)
                return true;
            else
                return false;
        }


        //Returns Difficult
        public string DifficultyChecker()
        {
            if (chkEasy.Checked == true && checkboxCounterEqOne())
            {
                return "Easy";
            }
            if (chkMedium.Checked == true && checkboxCounterEqOne())
            {
                return "Medium";
            }
            if (chkHard.Checked == true && checkboxCounterEqOne())
            {
                return "Hard";
            }
            if (chkInsane.Checked == true && checkboxCounterEqOne())
            {
                return "Insane";
            }
            else
            {
                return null;
            }

        }

        // Returns Randomnized Number depending on difficulty
        public int randomNumber()
        {
            int randomNumber;
            string Difficulty = DifficultyChecker();
            switch (Difficulty)
            {
                case "Easy": randomNumber = randomnizer(1000, 10000);
                    break;
                case "Medium": randomNumber = randomnizer(100000, 1000000);
                    break;
                case "Hard": randomNumber = randomnizer(10000000, 100000000);
                    break;
                case "Insane": randomNumber = randomnizer(10000000, 100000000);
                    break;
                default: randomNumber = 0;
                    break;
            }
            return randomNumber;
        }


        // Return number of correctly placed digits
        public int correctNumDigitsPlaced(int numOfDigits)
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
        public int correctNumDigits(int numOfDigits)
        {
            string strInputNumber = txtDigitInput.Text;
            int i, a, n = 0;
            for (i = 0; i < numOfDigits; i++)
            {
                for (a = 0; a < numOfDigits; a++)
                {
                    if (strInputNumber[i] == randNumber[a])
                        n++;
                }
            }
            return n;
        }









        
    }
}


                

