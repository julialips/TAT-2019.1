using System;
using System.Text;

namespace TAT_2019._1
{
    /// <summary>
    /// Class,which have methods for search and display substringsks
    /// </summary>
    class Substrings
    {
        /// <summary>
        /// Method Search different substrings
        /// Function that compares the elements , and outputs sequences of non-duplicate characters.
        /// </summary>
        /// <param name="str"></param>
        public string SearchDifferentSubstrings(string strFromCommandLine)
        {
            string strForSubstrings = null; //new empty string for future sequences
            StringBuilder substring = new StringBuilder();

            for (int i = 0; i < strFromCommandLine.Length; i++)
            {
                strForSubstrings = "";
                strForSubstrings += strFromCommandLine[i];

                for (int j = 0; j < strFromCommandLine.Length - i - 1; j++)
                {
                    if (strFromCommandLine[i + j] != strFromCommandLine[i + 1 + j])
                    {
                        strForSubstrings += strFromCommandLine[i + 1 + j];
                        substring.AppendLine(strForSubstrings);
                    }
                    else break;
                }
            }
            return substring.ToString();
        }
        /// <summary>
        /// method, witch only display received substrings
        /// </summary>
        /// <param name="strForSubstrings"></param>
        /// <returns></returns>
        public string DisplayReceivedSubstrings(string strForSubstrings)
        {
            Console.WriteLine(strForSubstrings);
            return strForSubstrings;
        }
    }
}

