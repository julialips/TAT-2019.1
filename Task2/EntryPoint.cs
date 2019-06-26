using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace valuta
{
    /// <summary>
    /// Main class of program.From here starts others methods.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Method which navigate to site, and downloading currencies in file
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://www.bps-sberbank.by");
            DownloaingKurs downloaing = new DownloaingKurs(webDriver);

            DownloaingKurs kurs = new DownloaingKurs(webDriver);
            List<Currency> currency = new List<Currency>();
            kurs.LoadValues(currency);

            Factory factory = new Factory();
            factory.GetCreator(args[0]);
        }
    }
}
