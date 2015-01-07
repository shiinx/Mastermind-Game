﻿using System;
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
        
        /* To show Answer for error checking/debugging
         * To be removed along with buttons when project is done
         */
        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            lblAnswer.Text = "";
            lblAnswer.Text = string.Join("", globalRandomNumber);        
        }



        /* To close dialog / return to menu when btnMenu is clicked or redcross is clicked
         */
        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void frmNumberGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }



        /* Global declares
         * Constant for digit difficulties
         * Constant for number of pictures to be used
         * Constant for number of pictureboxes
         * String for timeElapsed
         * boolean for error
         * btnCLickedCount to count the number of times check button has been clicked
         * ClickCount variable for btnCLickedCount to be put into
         * numOfPics variable to put in number of pictures depending on difficulty
         */
        const int EASY = 4, MEDIUM = 5, HARD = 6;
        const int NUMBEROFPICTURES = 8;
        const int NUMBEROFPICTUREBOX = 6;

        string timeElapsed;
        bool error;
        int btnClickedCount = 0, ClickCount, numOfPics;

        Stopwatch stpWatch = new Stopwatch();



        /* Global array declares
         * globalRandomNum array to put in the random number generated
         * resourcePic array to put in the pictures from resource
         * picName to use for checking and to be put in label
         * Counter for the picture click event
         */
        Int32[] globalRandomNumber = new Int32[HARD];

        Bitmap[] resourcePic = new Bitmap[NUMBEROFPICTURES]
        {   Properties.Resources.Picture1,
            Properties.Resources.Picture2,
            Properties.Resources.Picture3,
            Properties.Resources.Picture4,
            Properties.Resources.Picture5,
            Properties.Resources.Picture6,
            Properties.Resources.Picture7,
            Properties.Resources.Picture8
        };

        String[] picName = new String[NUMBEROFPICTURES] 
        {
            "Danbooru",
            "JellyFish",
            "Shark",
            "Hut",
            "Boat",
            "Mountain",
            "Frog",
            "Duckies"
        };

        int[] resourcePicCounter = new int[]
        {
            0,      //1
            0,      //2
            0,      //3
            0,      //4
            0,      //5
            0       //6
        };



        /* To open instructions
         */
        private void btnInstructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click New Game to generate a new set of picture.\nList below shows the number of pictures per difficulty."
                +   "\n\nEasy: "      +  EASY     +   " Pictures." 
                +   "\nMedium: "    +  MEDIUM   +   " Pictures."
                +   "\nHard: "      +  HARD     +   " Pictures."
                +   "\n\nLeft click the picture for the next picture."
                +   "\nRight click the picture for the previous picture."
                +   "\nHint tells you what the first picture is.");
        }



        /* New Game button Click event
         * Check what difficulty is selected
         * To generate new set of array numbers
         * If false is returned caused by no difficulty selected display error message
         * Toggles visibilty of buttons/label/picture depending on what difficulty is selected
         * Clears list
         * Resets click count
         * Resets stopwatch and restarts it
         * Resets timer label
         * Starts timer
         * Enable/disables radio button/buttons.
         * End...
         */
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            DifficultyChecker();
            RandomNumber();
            if(error)
            {
                MessageBox.Show("Please select a difficulty before pressing New Game.");
                return;
            }
            VisibilityToggle();
            lstvOutput.Items.Clear();
            btnClickedCount = 0;
            stpWatch.Restart();
            lblTimer.Text = "00:00:00";
            timTimer.Start();
            NewgameActions();
        }



        /* Give Up button event
         * Enables/Disables radio buttons/buttons
         * Displays answer 
         */
        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to give up?", "Confirmation", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                string displayAnswer="";
                displayAnswer += String.Join("", picName[globalRandomNumber[0]]);
                for(int a= 1 ; a<numOfPics ; a++)
                {
                    displayAnswer += ", ";
                    displayAnswer += String.Join("",picName[globalRandomNumber[a]]);
                }
                MessageBox.Show(displayAnswer,"Answer",MessageBoxButtons.OK);
                GiveupOrWinActions();
                stpWatch.Stop();
                timTimer.Stop();
            }
        }



        /* Hint button event
         * Tells player what the first picture is
         */
        private void btnHint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("First picture is "+picName[globalRandomNumber[0]],"Hint",MessageBoxButtons.OK);
        }



        /* Button Check Click event
         * Increase btnClickCount by one
         * Check if picture name from piclabals match with randomly generated number
         * If match display message that player got it right and show number of tries it took and time taken
         * Add items to listview, try number, the pictures that player picked , correctly placed number of pictures and number of correct pictures
         * stop stopwatch and timer
         * get elapsed time
         * enable/disable radio buttons/buttons
         * End...
         */
        private void btnCheck_Click(object sender, EventArgs e)
        {
            btnClickedCount++;
            int correctlyPlacedPictures, correctPictures;
            String winMessage = "Congratulations! You got it right!";
            string[] lblName = new string[6] { lblPic1.Text, lblPic2.Text, lblPic3.Text, lblPic4.Text, lblPic5.Text, lblPic6.Text };
            int n,i=0;

            correctlyPlacedPictures = CorrectNumDPicturesPlaced(numOfPics);
            correctPictures = CorrectNumPictures(numOfPics);
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
                MessageBox.Show(winMessage + "\n Tries Used: " + ClickCount + "\n Time Taken: " + timeElapsed);
                GiveupOrWinActions();
            }

            lstvOutput.EnsureVisible(lstvOutput.Items.Count - 1);
            
        }



        /* Timer Event
         * Display elapsed time on label
         */
        private void timTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = stpWatch.Elapsed;
            lblTimer.Text = String.Format(String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds));
        }
        


        /* My picture change on click code
         * Used array so that I could stuff all mousedown event per picturebox into one event
         */
        private void Common_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox[] picBox = new PictureBox[NUMBEROFPICTUREBOX]{
            picOne,
            picTwo,
            picThree,   
            picFour,
            picFive,
            picSix
            };

            Label[] lblPic = new Label[NUMBEROFPICTUREBOX]{
            lblPic1,
            lblPic2,
            lblPic3,
            lblPic4,
            lblPic5,
            lblPic6
            };

            int picBoxCounter = 0;
            while (picBoxCounter < 6)
            {
                if (sender == picBox[picBoxCounter])
                {
                    if (e.Button == System.Windows.Forms.MouseButtons.Right)
                    {
                        resourcePicCounter[picBoxCounter]--;
                        if (resourcePicCounter[picBoxCounter] < 0)
                        {
                            resourcePicCounter[picBoxCounter] = 7;
                        }
                    }
                    if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    {
                        resourcePicCounter[picBoxCounter]++;
                        if (resourcePicCounter[picBoxCounter] == 8)
                        {
                            resourcePicCounter[picBoxCounter] = 0;
                        }
                   }
                   picBox[picBoxCounter].Image = resourcePic[resourcePicCounter[picBoxCounter]];
                   lblPic[picBoxCounter].Text = picName[resourcePicCounter[picBoxCounter]];
                }
                picBoxCounter++;
            }
        }

        



        /* Method definition below...
         * DifficultyChecker        
         * RandomNumber             
         * RandNumber            
         * CorrectNumDPicturesPlaced
         * CorrectNumPictures   
         * LviOutput
         * GiveupORwinActions
         * NewgameActions    
         * VisibilityToggle
         * BasicDifficultyActions
         */

        /* Returns String Difficulty
         */
        private string DifficultyChecker()
        {
            if (rBtnEasy.Checked == true)
            {
                numOfPics = EASY;
                return "Easy";
            }
            if (rBtnMedium.Checked == true)
            {
                numOfPics = MEDIUM;
                return "Medium";
            }
            if (rBtnHard.Checked == true)
            {
                numOfPics = HARD;
                return "Hard";
            }
            else
            {
                return null;
            }

        }



        /* Puts generated number into global variable globalRandomNumber
         * 
         */
        private void RandomNumber()
        {
            string Difficulty = DifficultyChecker();
            switch (Difficulty)
            {
                case "Easy":
                case "Medium":
                case "Hard":
                    globalRandomNumber = RandNumber(numOfPics);
                    error = false;
                    break;
                default:
                    error = true;
                    break;
            }
            
            return ;
        }



        /* Returns string of randomned number
         * Fuction required to indiviudally randomnize digits
         * To check and prevent repeat number within the random number string
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



        /* Returns number of correctly placed pictures
         * Uses crap variables, need better names?
         */
        private int CorrectNumDPicturesPlaced(int numOfDigits)
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



        /* Returns number of correct pictures
         * Uses crap variables too
         */
        private int CorrectNumPictures(int numOfDigits)
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



        /* Returns listviewitems
         * Gets clickcount, number of correct pictures and correctly placed pictures
         * returns the items to be added to listview 
         * : Number of tries, Pictures selected , Number of correct pictures, number of correctly placed pictures
         */
        private ListViewItem LviOutput(int ClickCount,int CorrectPicture,int CorrectlyPlacedPictures)
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
            lviOutput.SubItems.Add(CorrectPicture.ToString());
            lviOutput.SubItems.Add(CorrectlyPlacedPictures.ToString());
            return lviOutput;
        }



        /* Actions made when give up or player win event happens
         * Turned OFF:
         * Check Button
         * Give up Button
         * Hint Button
         * 
         * Turned ON:
         * New Game button
         * Difficulty selection radio buttons
         * Picture boxes 
         */
        private void GiveupOrWinActions()
        {
            btnCheck.Enabled = false;
            btnGiveUp.Enabled = false;
            btnHint.Enabled = false;
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



        /* Actions made when new game button is pressed
         * Turned ON:
         * Check Button
         * Give Up Button
         * Hint Button
         * 
         * Turned OFF:
         * New Game button
         * Difficulty selection radio button
         * 
         * Reset:
         * Picture Boxes reset back to first picture
         * Label below Picture Box reset back to first name
         * Counter for Pictures
         */
        private void NewgameActions()
        {

            btnCheck.Enabled = true;
            btnGiveUp.Enabled = true;
            btnHint.Enabled = true;
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
            resourcePicCounter[0] = 0;
            resourcePicCounter[1] = 0;
            resourcePicCounter[2] = 0;
            resourcePicCounter[3] = 0;
            resourcePicCounter[4] = 0;
            resourcePicCounter[5] = 0;
            return;
        }



        /* Toggles visibilty/enable ON/OFF depending on difficulty
         * Hardcoded so if number of pictures are changed this has to be changed manually
         * For picture boxes and labels
         */
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



        /* Default action made regardless of selected difficulty
         * Used when New Game button is selected due to VisibilityToggle method
         * Turn ON + Visibility ON:
         * 1st - 4th picture boxes
         * 1st - 4th label
         */
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



        // End of method definitions... 

    }

}
