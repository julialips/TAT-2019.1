using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Autotests.GmailPage
{
    /// <summary>
    /// class,for reading messages
    /// </summary>
    class ReaderMessageInGmail
    {
        IWebDriver Driver { get; }
        IWebElement UnreadMessage { get; set; }
        WebDriverWait Wait { get; }
        Locators.EnterInUnreadMessageLocator Locator { get; }

        /// <summary>
        /// Constructor our class
        /// </summary>
        /// <param name="driver"></param>
        public ReaderMessageInGmail(IWebDriver driver)
        {
            this.Driver = driver;
            this.Locator = new Locators.EnterInUnreadMessageLocator();
            this.Wait = new WebDriverWait(Driver, TimeSpan.FromMinutes(2));
        }

        /// <summary>
        /// Method, which read message
        /// </summary>
        public void ReadingMessage()
        {
            Wait.Until(t => Driver.FindElements(By.XPath(Locator.IncomingMailLocator)).Any());
            UnreadMessage = Driver.FindElement(By.XPath(Locator.IncomingMailLocator));
            UnreadMessage.Click();
        }
    }
}
