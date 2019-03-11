using System;

namespace TAT_2019._1
{
    /// <summary>
    /// the main class Program,entry point to the application.
    ///From here we get the string and check its length.
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                if (args[0].Length < 2 && args.Length < 2)
                {
                    throw new FormatException();
                }
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
            }
            catch (FormatException)
            {
                Console.WriteLine("String must be longer than 1 simbol");
            }

            catch (Exception)
            {
                Console.WriteLine("Oops,something went wrong,try again!");
            }

            Console.Read();
        }
    }
}