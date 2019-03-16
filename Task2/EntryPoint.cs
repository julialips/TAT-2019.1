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
        /// <returns 0>Good start of program</returns>
        /// <returns 1>Empty string</returns> 
        /// <returns 2>Something went wrong</returns>
        /// 
        static int Main(string[] args)
        {
            try
            {
                if(args.Length == 0)
                    throw new FormatException();

                foreach (string line in args)
                {
                    Console.Write(line);
                    Console.Write("-->");
                }
                RushianRules[] converterToPhonemes = new RushianRules[args.Length];
                for (int i = 0; i < converterToPhonemes.Length; i++)
                {
                    converterToPhonemes[i] = new RushianRules(args[i]);
                    converterToPhonemes[i].PrintPhonemes(converterToPhonemes[i].Define());
                   
                }
                Console.Read();
                return 0;
              
            }
            catch (FormatException)
            {
                Console.WriteLine("The entered string is empty, try again!");
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