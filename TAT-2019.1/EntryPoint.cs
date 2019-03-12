using System;

namespace TAT_2019._1
{
    /// <summary>
    /// the main class Program,entry point to the application.
    /// From here we get the string from command line, and check for compliance with conditions.
    /// </summary>
    ///<returns> 0,when program work successfully</returns>
    ///<returns> 1,when string, from command line, have less than 2 symbols</returns>
    ///<returns> 2,when program have unpredictable errors or warnings</returns>
    class EntryPoint
    {
        /// <summary>
        /// entrance to the application
        /// </summary>
        /// <param name="args"></param>
        static int Main(string[] args)
        {
            try
            {
                if (args[0].Length < 2 && args.Length < 2)
                {
                    throw new FormatException();
                }
                if (args.Length != 0) // Checking the condition for the argument
                {
                    var searcher = new DifferentSimbols();
                    searcher.SearchDifferentSubstrings(args[0]);
                    searcher.DisplayReceivedSubstrings(searcher.SearchDifferentSubstrings(args[0]));
                }
                return 0;
            }

            catch (FormatException)
            {
                Console.WriteLine("String must be longer than 1 simbol");
                return 1;
            }

            catch (Exception)
            {
                Console.WriteLine("Oops,something went wrong,try again!");
                return 2;
            }
        }
    }
}