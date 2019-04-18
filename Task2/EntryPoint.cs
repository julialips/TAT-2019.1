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
                if (args.Length == 0)
                {
                    throw new FormatException();
                }

                for (int i = 0; i < args.Length; i++)
                {
                    Console.Write(args[i]);
                    Console.Write(" >>> ");
                }

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
