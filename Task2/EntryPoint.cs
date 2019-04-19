using System;

namespace Task2
{
    /// <summary>
    /// the main class Program,entry point to the application.
    /// From here we get the string from command line, and check for compliance with conditions.
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// entrance to the application
        /// </summary>
        /// <param name="args"></param>
        /// <returns 0>Good start of program</returns>
        /// <returns 1>Empty string</returns> 
        /// <returns 2>Something went wrong</returns>
        static int Main(string[] args)
        {
            try
            {
                if (args[0].Length == 0)
                {
                    throw new FormatException();
                }

                Console.Write(args[0]);
                Console.Write(" >>> ");

                var converter = new Converter();
                Console.WriteLine(converter.Convert(args[0]));
                return 0;
            }
            catch (FormatException)
            {
                Console.WriteLine("The entered string is empty or not valid,please, try again!");
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
