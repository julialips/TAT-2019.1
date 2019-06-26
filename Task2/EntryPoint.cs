using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Task2.GmailPage;
using System;

namespace Task2
{
    /// <summary>
    /// the main class of Program,entry point to the application.
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// Main method,which starts others methods
        /// </summary>
        static void Main()
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
            catch(Exception)
            {
                Console.WriteLine("Something Error!");
            }
        }
    }
}
