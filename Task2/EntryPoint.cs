using System;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Task2.GmailPage;

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
        static void Main(string[] args)
        {
            IWebDriver webDriver = new ChromeDriver();
            StartingMailPage startpage = new StartingMailPage(webDriver);
            startpage.StartPage();
            startpage.EnterInMail("alekseeva.katya98", "itisapassword");

            Message message = new Message(webDriver);
            message.WriteMessage("lipskaya.julia.98@gmail.com", "katya");

            CheckUnreadMailInGmail reader = new CheckUnreadMailInGmail(webDriver);
            reader.CheckUnreadMail();

            ReaderMessageInGmail gmail = new ReaderMessageInGmail(webDriver);
            gmail.ReadingMessage();
        }
    }
}
