///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Project 5
//	File Name:         CountryForm.cs
//	Description:       The Country Form
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
    /// Provides the GUI interface for the European region within the State Capital game.
    /// </summary>
    public partial class CountryGameForm : Form
    {
        private Form stateForm;                                                  //the state form that created this form
        private CountryGame cGame = new CountryGame();                           //the instance of the game for use inside the form
        private int currentTime = 15;                                            //the current time left
        private int currentAttempts = 0;                                         //the current amount of attempts
        private int currentCorrect = 0;                                          //the amount of attempts the user has gotten correct
        private Boolean endGame = true;                                         //holds whether or not the game is completely over

        /// <summary>
        /// Initializes a new instance of the <see cref="StateGameForm"/> class.
        /// </summary>
        public CountryGameForm(Form form)
        {
            InitializeComponent();
            stateForm = form;
            TimeLeftTmr.Stop();
        }

        /// <summary>
        /// Handles the Load event of the GameForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void GameForm_Load(object sender, EventArgs e)
        {
            //populates list box with state capitals
            foreach(var item in cGame.CapitalKeys)
            {
                CapitalListBox.Items.Add(item);
            }

            //initializes other fields
            AttemptsBox.Text = currentAttempts.ToString();
            CorrectBox.Text = currentCorrect.ToString();
            TimeLeftTxtBox.Text = currentTime.ToString();
            CapitalListBox.Enabled = false;
        }

        /// <summary>
        /// Handles the Click event of the NextBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NextBtn_Click(object sender, EventArgs e)
        {
            //resets the time left text box, and correct/incorrect prompt
            currentTime = 15;
            TimeLeftTxtBox.Text = currentTime.ToString();
            AnswerLbl.Text = "";
            AnswerPicBox.Image = null;
           
            //gets the random state, sets the state text box
            CountryTxtBox.Text = cGame.GetCountry();

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
            this.Close();
            
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
            string state = CountryTxtBox.Text;
            //if it is, update number of attempts and amount correct and display correct prompt
            if(cGame.CountryCapitals[selection].Equals(state))
            {
                currentAttempts++;
                currentCorrect++;
                AttemptsBox.Text = currentAttempts.ToString();
                CorrectBox.Text = currentCorrect.ToString();
                AnswerLbl.Text = "Correct!!!";
                AnswerPicBox.Image = CapitalGame.Properties.Resources.checkmark;
            }
            //otherwise, the user was wrong, so only update attempts and display incorrect prompt
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
            Decimal percentRight;
            
            //calculates the percent correct for the game
            if (currentAttempts > 0)
                percentRight = (currentCorrect * 100.0M) / currentAttempts;
            else
                percentRight = 0.0M;
            //displays a goodbye message whenever exiting the program
            MessageBox.Show(String.Format("Thank you for using trying your luck at the Country Capital Matching Game!\n\n" +
                                            "Your score was {0:0.0}% on {1} attempts", percentRight, currentAttempts), "Thank You!", MessageBoxButtons.OK);
            //closes the state form that spawned this one, if we are ending the game completely
            if(endGame)
                stateForm.Close();
        }

        /// <summary>
        /// Handles the Click event of the CapitalLbl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CapitalLbl_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the europeToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void europeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //sets endGame to false, since we are going back to state capitals
            endGame = false;
            //closes this window and opens the United States game window
            stateForm.Show();
            this.Hide();
            
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
        /// Handles the Click event of the AnswerPicBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AnswerPicBox_Click(object sender, EventArgs e)
        {
            //gets the random state, sets the state text box
            CountryTxtBox.Text = cGame.GetCountry();
            
            //initializes game features when user presses start
            CapitalListBox.Enabled = true;
            TimeLeftTmr.Start();
            AnswerPicBox.Enabled = false;
            AnswerLbl.Text = "Select the Capital!";
            AnswerLbl.Text = "";
            AnswerPicBox.Image = null;
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
            CountryTxtBox.Text = cGame.GetCountry();
            TimeLeftTmr.Stop();
        }
    }
}
