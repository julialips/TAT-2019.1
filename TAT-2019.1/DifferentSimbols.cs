using System;
using System.Text;

namespace TAT_2019._1
{
    class DifferentSimbols
    {
        /// <summary>
        /// Method SearchDifferentSimbols
        /// Function that compares the elements , and outputs sequences of non-duplicate characters.
        /// </summary>
        /// <param name="str"></param>
        public string SearchDifferentSimbols(string strfromcommandline)
        {
            string strfordiffsimb = null; //new empty string for future sequences
            StringBuilder subString = new StringBuilder();

            for (int i = 0; i < strfromcommandline.Length; i++)
            {
                strfordiffsimb = "";
                strfordiffsimb = strfordiffsimb + strfromcommandline[i];

                for (int j = 0; j < strfromcommandline.Length - i - 1; j++)
                {
                    if (strfromcommandline[i + j] != strfromcommandline[i + 1 + j])
                    {
                        strfordiffsimb += strfromcommandline[i + 1 + j];
                        subString.AppendLine(strfordiffsimb);
                    }

                    else break;
                }

            }
            return subString.ToString();
        }

        public string Displaystrfordiffsimb(string strfordiffsimb)
        {
            Console.WriteLine(strfordiffsimb);
            return strfordiffsimb;
        }
    }
}

