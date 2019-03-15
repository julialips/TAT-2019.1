using System;
using System.Text;

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
        static void Main(string[] args)
        {
            foreach (string line in args)
            {
                Console.WriteLine(line);
               // line += args;
            }
            //var RushianRules = new RushianRules();
            //RushianRules.ConvertToPhonemes();

            //try
            //{


            //    return 0;
            //}

            //catch (FormatException)
            //{
            //    Console.WriteLine("String must be longer than 1 simbol");
            //    return 1;
            //}

            //catch (Exception)
            //{
            //    Console.WriteLine("Oops,something went wrong,try again!");
            //    return 2;
            //}
        }

    }
}