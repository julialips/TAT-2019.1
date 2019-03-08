using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAT_2019._1
{
    class DifferentSimbols
    {
        /// <summary>
        /// Method SearchDifferentSimbols
        /// Function that compares the elements , and outputs sequences of non-duplicate characters.
        /// </summary>
        /// <param name="str"></param>
        public void SearchDifferentSimbols(string str)
        {
            string strfordiffsimb = null; //new empty string for future sequences

            for (int i = 0; i < str.Length; i++)
            {
                strfordiffsimb = "";
                strfordiffsimb = strfordiffsimb + str[i];

                for (int j = 0; j < str.Length - i - 1; j++)
                {
                    if (str[i + j] != str[i + 1 + j])
                    {
                        strfordiffsimb += str[i + 1 + j];
                        Console.WriteLine(strfordiffsimb);
                    }

                    else break;
                }
            }
        }
    }
}