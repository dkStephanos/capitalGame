///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Project 5
//	File Name:         StateGame.cs
//	Description:       The State Game Class with all methods and properties that underly the GUI interface for the game.
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Koi Stephanos, stephanos@goldmail.etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Tuesday, April 28, 2015
//	Copyright:         Koi Stephanos, 2015
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapitalGame.Classes
{
    /// <summary>
    /// Obtains states and capitals from a .txt file and constructs a Sorted Dictionary
    /// from that information for use with the game.
    /// </summary>
    class StateGame
    {
        StreamReader rdr;                                                                                        //used for file input
        public SortedDictionary<string, string> StateCapitals = new SortedDictionary<string, string>();          //dictionary used for capital game
        public SortedDictionary<string, string>.KeyCollection CapitalKeys;                                       //collections of dictionary keys
        public SortedDictionary<string, string>.ValueCollection StateValues;                                    //collection of state names
        Random r= new Random();                                                                                //random number used to determine state

        /// <summary>
        /// Initializes a new instance of the StateGame class, filing the SortedDictionary property
        /// from the states.txt file in resources.
        /// </summary>
        public StateGame ()
        {
            try
            {
                rdr = new StreamReader(Application.StartupPath + @"\Resources\states.txt");
                //goes through entire .txt file line by line creating dictionary entries
                while (rdr.Peek() != -1)
                {
                    //reads the line triming of white space
                    String[] fields = rdr.ReadLine().Split(',');
                    fields[1].Trim(' ');
                    //adds state and capital from line into dictionary
                    StateCapitals[fields[0]] = fields[1];
                }
                //adds keys to CapitalKeys and closes reader
                CapitalKeys = StateCapitals.Keys;
                rdr.Close();
            }
            //if an error is encountered, catch exception and display appropriate MessageBox
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gets the state.
        /// </summary>
        /// <returns></returns>
        public string GetState ( )
        {
            //determines random state to be pulled in
            int position = r.Next(0, 49);
            //converts State Value collection to an array
            StateValues = StateCapitals.Values;
            String[] states = new String[50];
            states = StateValues.ToArray();
            //returns the state at the calcuated position from the array
            return states[position];

        }

    }
}
