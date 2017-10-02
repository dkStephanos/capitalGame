///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Project 5
//	File Name:         CountryGame.cs
//	Description:       The Country Game class provides the specific properties and methods for the European capital portion
//                     of the game.
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
    /// Obtains countries and capitals from a .txt file and constructs a Sorted Dictionary
    /// from that information for use with the game.
    /// </summary>
    class CountryGame
    {
        StreamReader rdr;                                                                                        //used for file input
        public SortedDictionary<string, string> CountryCapitals = new SortedDictionary<string, string>();          //dictionary used for capital game
        public SortedDictionary<string, string>.KeyCollection CapitalKeys;                                       //collections of dictionary keys
        public SortedDictionary<string, string>.ValueCollection CountryValues;                                    //collection of state names
        Random r = new Random();                                                                                //random number used to determine state

        /// <summary>
        /// Initializes a new instance of the StateGame class, filing the SortedDictionary property
        /// from the states.txt file in resources.
        /// </summary>
        public CountryGame ()
        {
            try
            {
                rdr = new StreamReader(Application.StartupPath + @"\Resources\countries.txt");
                //goes through entire .txt file line by line creating dictionary entries
                while (rdr.Peek() != -1)
                {
                    //reads the line triming of white space
                    String[] fields = rdr.ReadLine().Split(',');
                    fields[1].Trim(' ');
                    //adds state and capital from line into dictionary
                    CountryCapitals[fields[0]] = fields[1];
                }
                //adds keys to CapitalKeys and closes reader
                CapitalKeys = CountryCapitals.Keys;
                rdr.Close();
            }
            //if an error is encountered, catch exception and display appropriate MessageBox
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gets the country.
        /// </summary>
        /// <returns></returns>
        public string GetCountry ( )
        {
            //determines random state to be pulled in
            int position = r.Next(0, 44);
            //converts State Value collection to an array
            CountryValues = CountryCapitals.Values;
            String[] states = new String[45];
            states = CountryValues.ToArray();
            //returns the state at the calcuated position from the array
            return states[position];

        }

    }
}
