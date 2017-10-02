///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Project 5
//	File Name:         StatesForm.cs
//	Description:       The States Form
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Koi Stephanos, stephanos@goldmail.etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Tuesday, April 28, 2015
//	Copyright:         Koi Stephanos, 2015
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using CapitalGame.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapitalGame
{
    /// <summary>
    /// Provides the GUI interface for the State Capital game.
    /// </summary>
    public partial class StateGameForm : Form
    {
        private StateGame sGame = new StateGame();                               //the instance of the game for use inside the form
        private int currentTime;                                                 //the current time left
        private int currentAttempts = 0;                                         //the current amount of attempts
        private int currentCorrect = 0;                                          //the amount of attempts the user has gotten correct
        private Boolean currentGame;                                      //stores whether or not this is the current game being played

        /// <summary>
        /// Initializes a new instance of the <see cref="StateGameForm"/> class.
        /// </summary>
        public StateGameForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the GameForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void GameForm_Load(object sender, EventArgs e)
        {
            //sets this as the current game
            currentGame = true;
            
            //populates list box with state capitals
            foreach(var item in sGame.CapitalKeys)
            {
                CapitalListBox.Items.Add(item);
            }

            //initializes other fields
            currentTime = 15;
            AttemptsBox.Text = currentAttempts.ToString();
            CorrectBox.Text = currentCorrect.ToString();
            TimeLeftTxtBox.Text = currentTime.ToString();
            
            //pauses game features until user presses start
            CapitalListBox.Enabled = false;
            TimeLeftTmr.Stop();
        }

        /// <summary>
        /// Handles the Click event of the NextBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NextBtn_Click(object sender, EventArgs e)
        {
            //sets currentGame to true
            currentGame = true;
            
            //resets the time left text box, and correct/incorrect prompt
            currentTime = 15;
            TimeLeftTxtBox.Text = currentTime.ToString();
            AnswerLbl.Text = "";
            AnswerPicBox.Image = null;
           
            //gets the random state, sets the state text box
            StateTxtBox.Text = sGame.GetState();

            //reenables form properties, disables AnswerPicBox
            CapitalListBox.Enabled = true;
            TimeLeftTmr.Enabled = true;
            AnswerPicBox.Enabled = false;
        }

        /// <summary>
        /// Handles the Click event of the EndBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void EndBtn_Click(object sender, EventArgs e)
        {
            //Exit the application
            Application.Exit();
        }

        /// <summary>
        /// Handles the Tick event of the TimeLeftTmr control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TimeLeftTmr_Tick(object sender, EventArgs e)
        {
            //decrements the current time left (in seconds)
            currentTime--;
            //if current time is still above 0, updates the corresponding text box
            if (currentTime > 0)
                TimeLeftTxtBox.Text = currentTime.ToString();
            //else, time has run out
            else
            {
                //so disable the timer and the capitals list, and update currentAttempts
                CapitalListBox.Enabled = false;
                TimeLeftTmr.Enabled = false;
                currentAttempts++;
                AttemptsBox.Text = currentAttempts.ToString();
            }
            
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the CapitalListBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void CapitalListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //a selection has been made, so disable timer and list box
            CapitalListBox.Enabled = false;
            TimeLeftTmr.Enabled = false;

            //then check to see if the selection is correct
            string selection = (string)CapitalListBox.SelectedItem;
            string state = StateTxtBox.Text;
            //if it is, update number of attempts and amount correct, display correct prompt in gui
            if(sGame.StateCapitals[selection].Equals(state))
            {
                currentAttempts++;
                currentCorrect++;
                AttemptsBox.Text = currentAttempts.ToString();
                CorrectBox.Text = currentCorrect.ToString();
                AnswerLbl.Text = "Correct!!!";
                AnswerPicBox.Image = CapitalGame.Properties.Resources.checkmark;
            }
            //otherwise, the user was wrong, so only update attempts, display incorrect prompt in gui
            else
            {
                currentAttempts++;
                AttemptsBox.Text = currentAttempts.ToString();
                AnswerLbl.Text = "Incorrect!!!";
                AnswerPicBox.Image = CapitalGame.Properties.Resources.wrong;
            }

        }

        /// <summary>
        /// Handles the FormClosing event of the GameForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            decimal percentRight;

            if (currentGame)
            {
                //calculates the percent correct for the game
                if (currentAttempts > 0)
                    percentRight = (currentCorrect * 100.0M)/ currentAttempts;
                else
                    percentRight = 0.0M;
                //displays a goodbye message whenever exiting the program
                MessageBox.Show(String.Format("Thank you for using trying your luck at the State Capital Matching Game!\n\n" +
                                                "Your score was {0:0.0}% on {1} attempts", percentRight, currentAttempts), "Thank You!", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Handles the Click event of the Regions_Europe control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Regions_Europe_Click(object sender, EventArgs e)
        {
            //resets game stats and hides this window, sets currentGame to false
            this.Hide();
            currentGame = false;
            currentAttempts = 0;
            AttemptsBox.Text = currentAttempts.ToString();
            currentCorrect = 0;
            CorrectBox.Text = currentCorrect.ToString();
            currentTime = 15;
            TimeLeftTxtBox.Text = currentTime.ToString();
            AnswerPicBox.Image = CapitalGame.Properties.Resources.start;
            AnswerLbl.Text = "Click to Start";
            AnswerPicBox.Enabled = true;
            TimeLeftTmr.Stop();
            //opens the European game window
            CountryGameForm cGame = new CountryGameForm(this);
            cGame.Show();
        }

        /// <summary>
        /// Handles the Click event of the AnswerPicBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AnswerPicBox_Click(object sender, EventArgs e)
        {
            //sets currentGame to true
            currentGame = true;
            
            //gets the random state, sets the state text box
            StateTxtBox.Text = sGame.GetState();
            
            //initializes game features when user presses start
            CapitalListBox.Enabled = true;
            TimeLeftTmr.Start();
            AnswerPicBox.Enabled = false;
            AnswerLbl.Text = "Select the Capital!";
            AnswerLbl.Text = "";
            AnswerPicBox.Image = null;
        }

        /// <summary>
        /// Handles the Click event of the AnswerLbl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AnswerLbl_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the AttemptsLbl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AttemptsLbl_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the CorrectLbl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CorrectLbl_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the TimeLeftLbl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TimeLeftLbl_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the TextChanged event of the StateTxtBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void StateTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the Options_NewGame control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Options_NewGame_Click(object sender, EventArgs e)
        {
            //resets all fields for new game
            CapitalListBox.Enabled = false;
            currentAttempts = 0;
            AttemptsBox.Text = currentAttempts.ToString();
            currentCorrect = 0;
            CorrectBox.Text = currentCorrect.ToString();
            currentTime = 15;
            TimeLeftTxtBox.Text = currentTime.ToString();
            AnswerLbl.Text = "Click to Start";
            AnswerPicBox.Image = CapitalGame.Properties.Resources.start;
            AnswerPicBox.Enabled = true;
            StateTxtBox.Text = sGame.GetState();
            TimeLeftTmr.Stop();
        }
    }
}
