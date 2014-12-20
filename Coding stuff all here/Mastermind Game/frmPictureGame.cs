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
        


        /* global declares
         * string randNumber, time Elapsed
         * int btnClickCount , ClickCount
         * int Difficulty settings for Number of pictures
         * new Stopwatch
         * array for pictures
         * End...
         */
        const int easyPicsNum = 4, mediumPicsNum = 5, hardPicsNum = 6;
        const int COUNT = 8;
        Int32[] globalRandomNumber = new Int32[hardPicsNum];
        string timeElapsed, error;
        int btnClickedCount = 0, ClickCount,numOfPics;
        Stopwatch stpWatch = new Stopwatch();

        Bitmap[] resourcePic = new Bitmap[COUNT]{Properties.Resources.Picture1,
            Properties.Resources.Picture2,
            Properties.Resources.Picture3,
            Properties.Resources.Picture4,
            Properties.Resources.Picture5,
            Properties.Resources.Picture6,
            Properties.Resources.Picture7,
            Properties.Resources.Picture8};

        String[] picName = new String[COUNT] 
        {
            "0.Danbooru",
            "1.JellyFish",
            "2.Shark",
            "3.Hut",
            "4.Boat",
            "5.Mountain",
            "6.Frog",
            "7.Duckies"
        };



        // To show Answer for error checking
        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            lblAnswer.Text = "";
            lblAnswer.Text = string.Join("", globalRandomNumber);        
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
                + "\nEasy:\t4 Pictures" 
                + "\nMedium:\t5 Pictures" 
                + "\nHard:\t6 Pictures");
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
            RandomNumber();
            if(error == "false")
            {
                MessageBox.Show("Please select a difficulty before pressing New Game.");
                return;
            }
            DifficultyChecker();
            VisibilityToggle();
            lstvOutput.Items.Clear();
            btnClickedCount = 0;
            stpWatch.Restart();
            lblTimer.Text = "00:00:00";
            timTimer.Start();
            NewgameActions();
        }
        // End of New Game Click button event code



        // Give up button to reset button visibility to new game settings
        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to give up?", "Confirmation", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                GiveupOrWinActions();
                stpWatch.Stop();
                timTimer.Stop();
            }
        }




        /* Button Check Click event
         * 
         * End...
         */
        private void btnCheck_Click(object sender, EventArgs e)
        {
            btnClickedCount++;
            int correctlyPlacedPictures, correctPictures;
            String winMessage = "Congratulations! You got it right!";
            string[] lblName = new string[6] { lblPic1.Text, lblPic2.Text, lblPic3.Text, lblPic4.Text, lblPic5.Text, lblPic6.Text };
            int n,i=0;

            correctlyPlacedPictures = CorrectNumDigitsPlaced(numOfPics);
            correctPictures = CorrectNumDigits(numOfPics);
            lstvOutput.Items.Add(LviOutput(btnClickedCount, correctPictures, correctlyPlacedPictures));
            for (n = 0; n < numOfPics; n++)
            {
                if (picName[globalRandomNumber[n]] == lblName[n])
                {
                    i++;
                }
            }

            if (i == n)
            {
                stpWatch.Stop();
                timTimer.Stop();
                TimeSpan ts = stpWatch.Elapsed;
                timeElapsed = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
                ClickCount = btnClickedCount;
                MessageBox.Show(winMessage + "\n Tries Used:" + ClickCount + "\n Time Taken:" + timeElapsed);
                GiveupOrWinActions();
            }
            
        }
        // End of check click event code


        
        private void timTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = stpWatch.Elapsed;
            lblTimer.Text = String.Format(String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds));
        }
        

        /* My picture change on click code
         * I'll shorten it when I have the dam time or know how
         * Tedious as heck code
         * Try using more array to shorten
         */

        int resourcePicCounter1 = 1;
        private void picOne_Click(object sender, EventArgs e)
        {
            if (resourcePicCounter1 == 8)
            {
                resourcePicCounter1 = 0;
            }

            picOne.Image = resourcePic[resourcePicCounter1];
            lblPic1.Text = picName[resourcePicCounter1];
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
            lblPic2.Text = picName[resourcePicCounter2];
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
            lblPic3.Text = picName[resourcePicCounter3];
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
            lblPic4.Text = picName[resourcePicCounter4];
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
            lblPic5.Text = picName[resourcePicCounter5];
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
            lblPic6.Text = picName[resourcePicCounter6];
            resourcePicCounter6++;
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
                numOfPics = easyPicsNum;
                return "Easy";
            }
            if (rBtnMedium.Checked == true)
            {
                numOfPics = mediumPicsNum;
                return "Medium";
            }
            if (rBtnHard.Checked == true)
            {
                numOfPics = hardPicsNum;
                return "Hard";
            }
            else
            {
                return null;
            }

        }

        private void VisibilityToggle()
        {
            switch (DifficultyChecker())
            {
                case "Easy":
                    BasicDifficultyActions();
                    picFive.Enabled = false;
                    picFive.Visible = false;
                    picSix.Enabled = false;
                    picSix.Visible = false;
                    lblPic5.Visible = false;
                    lblPic6.Visible = false;
                    break;

                case "Medium": 
                    BasicDifficultyActions();
                    picFive.Enabled = true;
                    picFive.Visible = true;
                    picSix.Enabled = false;
                    picSix.Visible = false;
                    lblPic5.Visible = true;
                    lblPic6.Visible = false;
                    break;

                case "Hard":
                    BasicDifficultyActions();
                    picFive.Enabled = true;
                    picFive.Visible = true;
                    picSix.Enabled = true;
                    picSix.Visible = true;
                    lblPic5.Visible = true;
                    lblPic6.Visible = true;
                    break;

                default:
                    break;
            }

        }

        // Returns Randomnized Number depending on difficulty
        private void RandomNumber()
        {
            string Difficulty = DifficultyChecker();
            switch (Difficulty)
            {
                case "Easy":
                case "Medium":
                case "Hard":
                    globalRandomNumber = RandNumber(numOfPics);
                    break;
                default:
                    error = "false";
                    break;
            }
            
            return ;
        }


        /* Returns string of randomned number
         * Fuction required to indiviudally randomnize digits
         * To check and prevent repeat number within the random number string
         * 
         * End...
         */
        private Int32[] RandNumber(int difficultyDigits)
        {
            Random Randomnizer = new Random();
            bool[] NumberIsUsed = new bool[8];
            for (int i = 0; i < 8; i++)
            {
                NumberIsUsed[i] = false;
            }

            int digits = 0;
            int numberToPick;
            Int32[] number = new Int32[difficultyDigits];

            for (digits = 0; digits < difficultyDigits; digits++)
            {
                numberToPick = Randomnizer.Next(0,8);
                while (NumberIsUsed[numberToPick])
                {
                    numberToPick = Randomnizer.Next(0,8);
                }
                NumberIsUsed[numberToPick] = true;
                number[digits] = numberToPick;
            }
            return number;
        }


        // Return number of correctly placed digits
        private int CorrectNumDigitsPlaced(int numOfDigits)
        {
            string[] lblName = new string[6] { lblPic1.Text, lblPic2.Text, lblPic3.Text, lblPic4.Text, lblPic5.Text, lblPic6.Text };
            int CorrectlyPlacedDigits = 0, n;
            for (n = 0; n < numOfDigits; n++)
            {
                if (lblName[n] == picName[globalRandomNumber[n]])
                    CorrectlyPlacedDigits++;
            }
            return CorrectlyPlacedDigits;
        }


        // Return number of correct digits
        private int CorrectNumDigits(int numOfDigits)
        {
            string[] lblName = new string[6] { lblPic1.Text, lblPic2.Text, lblPic3.Text, lblPic4.Text, lblPic5.Text, lblPic6.Text };
            int i, a, correctNumDigits = 0;
            for (i = 0; i < numOfDigits; i++)
            {
                for (a = 0; a < numOfDigits; a++)
                {
                    if (lblName[a] == picName[globalRandomNumber[i]])
                    {
                        correctNumDigits++;
                        break;
                    }
                }
            }
            return correctNumDigits;
        }


        // Returns listviewitems
        private ListViewItem LviOutput(int ClickCount,int CorrectDigits,int CorrectlyPlacedDigits)
        {
            string[] lblName = new string[6] { lblPic1.Text, lblPic2.Text, lblPic3.Text, lblPic4.Text, lblPic5.Text, lblPic6.Text };
            string inputPictures ="";
            ListViewItem lviOutput = new ListViewItem(ClickCount.ToString());
            inputPictures += String.Join("", lblName[0]);
            for (int a = 1; a < numOfPics; a++)
            {
                inputPictures += ", ";
                inputPictures += String.Join("",lblName[a]);
            }
            lviOutput.SubItems.Add(inputPictures);
            lviOutput.SubItems.Add(CorrectDigits.ToString());
            lviOutput.SubItems.Add(CorrectlyPlacedDigits.ToString());
            return lviOutput;
        }

        private void GiveupOrWinActions()
        {
            btnCheck.Enabled = false;
            btnGiveUp.Enabled = false;
            btnNewGame.Enabled = true;
            rBtnEasy.Enabled = true;
            rBtnMedium.Enabled = true;
            rBtnHard.Enabled = true;
            picOne.Enabled = false;
            picTwo.Enabled = false;
            picThree.Enabled = false;
            picFour.Enabled = false;
            picFive.Enabled = false;
            picSix.Enabled = false;
            return;
        }

        private void NewgameActions()
        {

            btnCheck.Enabled = true;
            btnGiveUp.Enabled = true;
            btnNewGame.Enabled = false;
            rBtnEasy.Enabled = false;
            rBtnMedium.Enabled = false;
            rBtnHard.Enabled = false;
            picOne.Image = Properties.Resources.Picture1;
            picTwo.Image = Properties.Resources.Picture1;
            picThree.Image = Properties.Resources.Picture1;
            picFour.Image = Properties.Resources.Picture1;
            picFive.Image = Properties.Resources.Picture1;
            picSix.Image = Properties.Resources.Picture1;
            lblPic1.Text = picName[0];
            lblPic2.Text = picName[0];
            lblPic3.Text = picName[0];
            lblPic4.Text = picName[0];
            lblPic5.Text = picName[0];
            lblPic6.Text = picName[0];
            resourcePicCounter1 = 1;
            resourcePicCounter2 = 1;
            resourcePicCounter3 = 1;
            resourcePicCounter4 = 1;
            resourcePicCounter5 = 1;
            resourcePicCounter6 = 1;
            return;
        }

        private void BasicDifficultyActions()
        {
            picOne.Enabled = true;
            picOne.Visible = true;
            picTwo.Enabled = true;
            picTwo.Visible = true;
            picThree.Enabled = true;
            picThree.Visible = true;
            picFour.Enabled = true;
            picFour.Visible = true;
            lblPic1.Visible = true;
            lblPic2.Visible = true;
            lblPic3.Visible = true;
            lblPic4.Visible = true;
            return;
        }

        



        // End of fuction definitions... 
    }

}
