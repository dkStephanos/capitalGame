///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Project 5
//	File Name:         SplashForm.cs
//	Description:       The form that will splash on the screen before the game window appears.
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Koi Stephanos, stephanos@goldmail.etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Tuesday, April 28, 2015
//	Copyright:         Koi Stephanos, 2015
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapitalGame.Forms
{
    /// <summary>
    /// Provides a Splash screen for the game.
    /// </summary>
    public partial class SplashForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SplashForm" /> class.
        /// </summary>
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the SplashForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SplashForm_Load(object sender, EventArgs e)
        {
            this.Version.Text = Application.ProductVersion;
        }

        /// <summary>
        /// Handles the Tick event of the SplashTmr control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SplashTmr_Tick(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
