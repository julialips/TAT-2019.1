using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAT_2019._1
{
    /// <summary>
    /// the main class Program,entry point to the application.
    ///From here we get the string and check its length.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        { 
            if (args.Length != 0) // Checking the condition for the argument
            {
                string strfromcommandline = null;
                foreach (string element in args)
                {
                    strfromcommandline += element; // rewrite items from command line to variable
                }

                DifferentSimbols obj = new DifferentSimbols();
                obj.SearchDifferentSimbols(strfromcommandline);
            }

            else
            {
                Console.WriteLine("String must be longer than 1 simbol");
            }

            Console.Read();
        }
    }  
}
