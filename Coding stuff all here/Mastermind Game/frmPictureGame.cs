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

        //To close dialog / return to menu when btnMenu is clicked or redcross is clicked
        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void frmPictureGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        //Open RecordBoard
        private void btnRecordBoard_Click(object sender, EventArgs e)
        {
            frmRecordBoard recordBoard = new frmRecordBoard();
            recordBoard.ShowDialog();
        }

        // Global Declares
        const int EASY = 4, MEDIUM = 5, HARD = 6;
        const int NUMBEROFPICTURES = 8;
        const int NUMBEROFPICTUREBOXINFORM = 6;
        const int NUMBEROFTIPS = 6;
        const int NUMBEROFTRIESALLOWED = 20;
        const int NUMBEROFDIFFICULTIES = 3;

        string pathToPublicDocumentsFolder = @"C:\Users\Public\Documents\MastermindGame";
        string pathToPictureGameRecordsText = @"C:\Users\Public\Documents\MastermindGame\PictureGameRecords.txt";
        string pathToPictureGameNumberText = @"C:\Users\Public\Documents\MastermindGame\PictureGameNumber.txt";

        string timeElapsed;
        bool error; 
        public bool classicMode, visualMode;
        int btnClickedCount = 0, counterTips = 0, numOfPicsBoxUsed, gameNumber;


        Stopwatch stpWatch = new Stopwatch();


        // Global array declares
        Int32[] globalRandomNumber = new Int32[HARD];

        Image[] resourcePic = new Image[NUMBEROFPICTURES]
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

        int[] resourcePicCounter = new int[NUMBEROFPICTUREBOXINFORM]
        {
            0,      //1
            0,      //2
            0,      //3
            0,      //4
            0,      //5
            0       //6
        };

        String[] tips = new String[NUMBEROFTIPS]
        {
            "Tip : Left-Click for next picture, Right-Click for previous picture.",
            "Tip : Read the instructions if you're not sure how to play this game.",
            "Tip : There are actually only "+NUMBEROFPICTURES+" pictures in total.",
            "Tip : Click on hints if you're stuck, there isn't any penalty.",
            "Tip : Just give up if you're taking way to long.",
            "Tick-Tock, Tick-Tock. Time is wasting away. :D",
        };

        // Global Declare End

        

        /* Creates files and folders when game loads
         * Creates a folder MastermindGame
         * If an existing text file called PictureGameRecords and PictureGameNumber doesn't exist, creates one
         * Takes a value from the Picture Game Value to maintain the count of number of times game has been played and won
         */
        private void frmPictureGame_Load(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(pathToPublicDocumentsFolder);
            if (!System.IO.File.Exists(pathToPictureGameNumberText))
            {
                System.IO.File.WriteAllText(pathToPictureGameNumberText, "0");
            }
            if (!System.IO.File.Exists(pathToPictureGameRecordsText))
            {
                System.IO.File.WriteAllText(pathToPictureGameRecordsText, "");
            }
            gameNumber = Int32.Parse(System.IO.File.ReadAllText(pathToPictureGameNumberText));
            if (visualMode)
            {
                lblLegend.Visible = true;
            }
            else
            {
                lblLegend.Visible = false;
            }

        }



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
                +   "\nHint tells you what the first picture is."
                +   "\nYou only have " +NUMBEROFTRIESALLOWED+" tries allowed regardless of difficulty.");
        }



        /* To show Answer for error checking/debugging
         * To be removed along with buttons when project is done
         */
        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            lblAnswer.Text = "";
            lblAnswer.Text = string.Join("", globalRandomNumber);
        }
        


        /* New Game button Click event
         * Check what difficulty is selected and depending on it generates a set of array numbers
         * If error is true, user did not select a difficulty
         * Toggles visibilty of buttons/label/picture depending on what difficulty is selected
         * Resets click count ; stopwatch ; timer label's text
         * Enable/disables radio button/buttons.
         * Change columns according to classic or visual mode
         * End...
         */
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            DifficultyChecker();
            globalRandomNumber = RandomNumberGenerator(numOfPicsBoxUsed);
            if(error)
            {
                MessageBox.Show("Please select a difficulty before pressing New Game.");
                error = false;
                return;
            }
            VisibilityToggle();
            lstvOutput.Items.Clear();
            btnClickedCount = 0;
            counterTips = 0;
            stpWatch.Restart();
            lblTimer.Text = "00:00";
            timTimer.Start();
            timTips.Start();
            lblTips.Text = "Good Luck! You only have " + NUMBEROFTRIESALLOWED + " tries to use.";
            NewgameActions();
            if (classicMode)
            {
                lstvOutputClassicSettings();
            }
            if (visualMode)
            {
                lstvOutputVisualSettings();
            }
        }



        /* Give Up button event
         * If user says yes to confirmation on giving up, answer will be displayed and game will end
         */
        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to give up?", "Confirmation", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                string displayAnswer="";
                displayAnswer += String.Join("", picName[globalRandomNumber[0]]);
                for(int a= 1 ; a<numOfPicsBoxUsed ; a++)
                {
                    displayAnswer += ", ";
                    displayAnswer += String.Join("",picName[globalRandomNumber[a]]);
                }
                MessageBox.Show("The correct pictures were: "+displayAnswer,"Answer",MessageBoxButtons.OK);
                GiveupOrWinActions();
                stpWatch.Stop();
                timTimer.Stop();
                timTips.Stop();
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
         * if win, send gameplay details to txt file
         * End...
         */
        private void btnCheck_Click(object sender, EventArgs e)
        {
            btnClickedCount++;
            int correctlyPlacedPictures, correctPictures;
            string clickCount;
            string winMessage = "Congratulations! You got it right!";
            string loseMessage = "Sorry! You've ran out of tries and lost! ";
            String[] lblName = new string[6] { lblPic1.Text, lblPic2.Text, lblPic3.Text, lblPic4.Text, lblPic5.Text, lblPic6.Text };
            string displayAnswer = "";
            int n,i=0;

            if (classicMode)
            {
                correctlyPlacedPictures = CorrectNumDPicturesPlaced(numOfPicsBoxUsed);
                correctPictures = CorrectNumPictures(numOfPicsBoxUsed);
                LstvOutputClassic(btnClickedCount, correctPictures, correctlyPlacedPictures);
            }
            if (visualMode)
            {
                LstvOutputVisual(btnClickedCount);
            }

            lstvOutput.EnsureVisible(lstvOutput.Items.Count-1);

            for (n = 0; n < numOfPicsBoxUsed; n++)
            {
                if (picName[globalRandomNumber[n]] == lblName[n])
                {
                    i++;
                }
            }

            if (i == n && btnClickedCount <= NUMBEROFTRIESALLOWED)
            {
                stpWatch.Stop();
                timTimer.Stop();
                timTips.Stop(); 
                GiveupOrWinActions();

                TimeSpan ts = stpWatch.Elapsed;
                timeElapsed = String.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
                clickCount = btnClickedCount.ToString();
                MessageBox.Show(winMessage + "\nTries Used: " + clickCount + "\nTime Taken: " + timeElapsed);

                gameNumber++;
                string gameNumberToSave = gameNumber.ToString();
                System.IO.File.WriteAllText(pathToPictureGameNumberText,gameNumberToSave);
                using (System.IO.StreamWriter scoreToStore = new System.IO.StreamWriter(pathToPictureGameRecordsText, true))
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
                clickCount = btnClickedCount.ToString();
                displayAnswer += String.Join("", picName[globalRandomNumber[0]]);
                for (int a = 1; a < numOfPicsBoxUsed; a++)
                {
                    displayAnswer += ", ";
                    displayAnswer += String.Join("", picName[globalRandomNumber[a]]);
                }
                MessageBox.Show(loseMessage +
                    "\nTries Used: " + clickCount +
                    "\nTime Taken: " + timeElapsed +
                    "\nThe correct pictures were: " + displayAnswer);
                lblTips.Text = "Click New Game to start";
                GiveupOrWinActions();
            }
            
        }
        // End of button check Event



        /* Timer Event for the tips
         * Changes the tips every 30 secs or so
         */
        private void timTips_Tick(object sender, EventArgs e)
        {
            if (counterTips == NUMBEROFTIPS)
            {
                counterTips = 0;
            }
            lblTips.Text = tips[counterTips];
            counterTips++;
        }



        /* Timer Event
         * Display elapsed time on label
         */
        private void timTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = stpWatch.Elapsed;
            lblTimer.Text = String.Format(String.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds));

        }
        


        /* My picture change on click code
         * Used array so that I could stuff all mousedown event per picturebox into one event
         */
        private void Common_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox[] picBox = new PictureBox[NUMBEROFPICTUREBOXINFORM]{
            picOne,
            picTwo,
            picThree,   
            picFour,
            picFive,
            picSix
            };

            Label[] lblPic = new Label[NUMBEROFPICTUREBOXINFORM]{
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


        // Picture click event left click for next right click for previous 
        private void Common_MouseEnter(object sender, EventArgs e)
        {
            RadioButton[] rbtnDifficulty = new RadioButton[NUMBEROFDIFFICULTIES] 
            {
                rBtnEasy,
                rBtnMedium,
                rBtnHard
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
                            tltipDifficulty.SetToolTip(this.rBtnEasy, EASY + " picture boxes");
                            break;
                        case 1:
                            tltipDifficulty.SetToolTip(this.rBtnMedium, MEDIUM + " picture boxes");
                            break;
                        case 2:
                            tltipDifficulty.SetToolTip(this.rBtnHard, HARD + " picture boxes");
                            break;
                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                counter++;
            }
        }


        // Method definition below

        /* Returns String Difficulty user selected
         */
        private string DifficultyChecker()
        {
            if (rBtnEasy.Checked == true)
            {
                numOfPicsBoxUsed = EASY;
                return "Easy";
            }
            if (rBtnMedium.Checked == true)
            {
                numOfPicsBoxUsed = MEDIUM;
                return "Medium";
            }
            if (rBtnHard.Checked == true)
            {
                numOfPicsBoxUsed = HARD;
                return "Hard";
            }
            else
            {
                error = true;
                return null;
            }

        }



        /* Returns string of randomned number
         * Fuction required to indiviudally randomnize digits
         * To check and prevent repeat number within the random number array
         */
        private Int32[] RandomNumberGenerator(int difficultyDigits)
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
        private int CorrectNumDPicturesPlaced(int numOfPictures)
        {
            string[] lblName = new string[6] { lblPic1.Text, lblPic2.Text, lblPic3.Text, lblPic4.Text, lblPic5.Text, lblPic6.Text };
            int CorrectlyPlacedPictures = 0, n;
            for (n = 0; n < numOfPictures; n++)
            {
                if (lblName[n] == picName[globalRandomNumber[n]])
                    CorrectlyPlacedPictures++;
            }
            return CorrectlyPlacedPictures;
        }



        /* Returns number of correct pictures
         * Uses crap variables too
         */
        private int CorrectNumPictures(int numOfPictures)
        {
            string[] lblName = new string[6] { lblPic1.Text, lblPic2.Text, lblPic3.Text, lblPic4.Text, lblPic5.Text, lblPic6.Text };
            int i, a, correctNumPictures = 0;
            for (i = 0; i < numOfPictures; i++)
            {
                for (a = 0; a < numOfPictures; a++)
                {
                    if (lblName[a] == picName[globalRandomNumber[i]])
                    {
                        correctNumPictures++;
                        break;
                    }
                }
            }
            return correctNumPictures;
        }



        /* Gets clickcount, number of correct pictures and correctly placed pictures
         * returns the items to be added to listview 
         * : Number of tries, Pictures selected , Number of correct pictures, number of correctly placed pictures
         */
        private void LstvOutputClassic(int ClickCount,int CorrectPicture,int CorrectlyPlacedPictures)
        {
            string[] lblName = new string[NUMBEROFPICTUREBOXINFORM] { lblPic1.Text, lblPic2.Text, lblPic3.Text, lblPic4.Text, lblPic5.Text, lblPic6.Text };
            string inputPictures ="";
            ListViewItem lviOutput = new ListViewItem(ClickCount.ToString());
            inputPictures += String.Join("", lblName[0]);
            for (int a = 1; a < numOfPicsBoxUsed; a++)
            {
                inputPictures += ", ";
                inputPictures += String.Join("",lblName[a]);
            }
            lviOutput.SubItems.Add(inputPictures);
            lviOutput.SubItems.Add(CorrectPicture.ToString());
            lviOutput.SubItems.Add(CorrectlyPlacedPictures.ToString());
            lstvOutput.Items.Add(lviOutput);
            return;
        }


        /* Code for the basic/visual mode
         * Assigned X to all the output as a default
         * if equal to randomnumber change to O
         * using for loop, compare those that arent equal to randomnumber to look for P
         * if neither O or P X will be the output
         * usedPorO will turn into true when O or P has been assigned to prevent repeat Ps
         */
        private void LstvOutputVisual(int ClickCount)
        {
            String[] lblName = new String[NUMBEROFPICTUREBOXINFORM] { lblPic1.Text, lblPic2.Text, lblPic3.Text, lblPic4.Text, lblPic5.Text, lblPic6.Text };
            ListViewItem lviOutputName = new ListViewItem(ClickCount.ToString());
            ListViewItem lviOutputXOP = new ListViewItem();
            lviOutputXOP.UseItemStyleForSubItems = false;
            String[] outputArray = new String[numOfPicsBoxUsed];
            Boolean[] usedPorO = new Boolean[numOfPicsBoxUsed];
            for (int k = 0; k < numOfPicsBoxUsed; k++)
            {
                usedPorO[k] = false;
                outputArray[k] = "X";
            }
            for (int j = 0; j < numOfPicsBoxUsed; j++)
            {
                if (lblName[j] == picName[globalRandomNumber[j]])
                {
                    outputArray[j] = "O";
                }
            }

            for (int counterInput = 0; counterInput < numOfPicsBoxUsed; counterInput++)
            {
                if (outputArray[counterInput] != "O")
                {
                    for (int counterAns = 0; counterAns < numOfPicsBoxUsed; counterAns++)
                    {
                        if (outputArray[counterAns] != "O" && !usedPorO[counterAns] && lblName[counterInput] == picName[globalRandomNumber[counterAns]])
                        {
                            outputArray[counterInput] = "P";
                            usedPorO[counterAns] = true;
                        }
                    }
                }
            }

            for (int i = 0; i < numOfPicsBoxUsed; i++)
            {
                lviOutputName.SubItems.Add(lblName[i]);
                lviOutputXOP.SubItems.Add(outputArray[i]);
                if (outputArray[i] == "O")
                {
                    lviOutputXOP.SubItems[i + 1].ForeColor = Color.Green;
                }
                if (outputArray[i] == "X")
                {
                    lviOutputXOP.SubItems[i + 1].ForeColor = Color.Red;
                }
                if (outputArray[i] == "P")
                {
                    lviOutputXOP.SubItems[i + 1].ForeColor = Color.Yellow;
                }
            }
            lstvOutput.Items.Add(lviOutputName);
            lstvOutput.Items.Add(lviOutputXOP);
            return;
        }



        /* Actions made when give up or player win event happens
         */
        private void GiveupOrWinActions()
        {
            lblTips.Text = "Click New Game to start";
            panelGameStart.Enabled = false;
            panelNewGame.Enabled = true;
            panelPicBox1to4.Enabled = false;
            picFive.Enabled = false;
            lblPic5.Enabled = false;
            picSix.Enabled = false;
            lblPic6.Enabled = false;
            return;
        }



        /* Actions made when new game button is pressed
         * Reset:
         * Picture Boxes reset back to first picture
         * Label below Picture Box reset back to first name
         * Counter for Pictures
         */
        private void NewgameActions()
        {
            panelGameStart.Enabled = true;
            panelNewGame.Enabled = false;
            VisibilityToggle();
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
                    lblPic5.Enabled = false;
                    lblPic6.Enabled = false;
                    break;

                case "Medium":
                    BasicDifficultyActions();
                    picFive.Enabled = true;
                    picFive.Visible = true;
                    picSix.Enabled = false;
                    picSix.Visible = false;
                    lblPic5.Visible = true;
                    lblPic6.Visible = false;
                    lblPic5.Enabled = true;
                    lblPic6.Enabled = false;
                    break;

                case "Hard":
                    BasicDifficultyActions();
                    picFive.Enabled = true;
                    picFive.Visible = true;
                    picSix.Enabled = true;
                    picSix.Visible = true;
                    lblPic5.Visible = true;
                    lblPic6.Visible = true;
                    lblPic5.Enabled = true;
                    lblPic6.Enabled = true;
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
            panelPicBox1to4.Enabled = true;
            panelPicBox1to4.Visible = true;
            return;
        }


        // Columns to add when classic is selected in the menu
        private void lstvOutputClassicSettings()
        {
            lstvOutput.Columns.Clear();
            lstvOutput.Columns.Add("No.", 60, HorizontalAlignment.Center);
            lstvOutput.Columns.Add("Pictures", 675, HorizontalAlignment.Center);
            lstvOutput.Columns.Add("Correct Pictures", 230, HorizontalAlignment.Center);
            lstvOutput.Columns.Add("Correctly Placed Pictures", 320, HorizontalAlignment.Center);
            return;
        }

        // Columns to add when Visual is selected in the menu
        private void lstvOutputVisualSettings()
        {
            String[] columnName = new String[HARD]
            {
                "1st Picture",
                "2nd Picture",
                "3rd Picture",
                "4th Picture",
                "5th Picture",
                "6th Picture"
            };
            lstvOutput.Columns.Clear();
            lstvOutput.Columns.Add("No.", 60, HorizontalAlignment.Center);
            for (int i = 0; i < numOfPicsBoxUsed; i++)
            {
                lstvOutput.Columns.Add(columnName[i], 200, HorizontalAlignment.Center);
            }
            return;
        }

        // End of method definitions... 

    }

}
