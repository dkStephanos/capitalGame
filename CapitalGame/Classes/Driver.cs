///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Project 5
//	File Name:         Driver.cs
//	Description:       The Driver
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Koi Stephanos, stephanos@goldmail.etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Tuesday, April 28, 2015
//	Copyright:         Koi Stephanos, 2015
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using CapitalGame.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapitalGame
{
    /// <summary>
    /// Creates and runs the game.
    /// </summary>
    static class Driver
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());
            Application.Run(new StateGameForm());
        }
    }
}
