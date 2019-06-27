using System;
using System.Linq;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace Autotests.MailPage
{
    /// <summary>
    /// Class, that have methods for reading message, and getting from message new user name
    /// </summary>
    class ReadingAndGettingMessageFromGmail
    {
        IWebDriver Driver { get; }
        IWebElement IncomingMessageButton { get; set; }
        IWebElement ConcreteMessage { get; set; }
        IWebElement TextBoxOfMessage { get; set; }
        WebDriverWait Wait { get; }
        Locators.ReadingMailMessageLocators Locator { get; }

        /// <summary>
        /// Constructor our class
        /// </summary>
        /// <param name="driver"></param>
        public ReadingAndGettingMessageFromGmail(IWebDriver driver)
        {
            this.Driver = driver;
            this.Locator = new Locators.ReadingMailMessageLocators();
            this.Wait = new WebDriverWait(Driver, TimeSpan.FromMinutes(2));
        }

        /// <summary>
        /// Method to find buttons in mail for reading message
        /// </summary>
        public void ReadingMessageFromGmail()
        {
            Wait.Until(t => Driver.FindElements(By.XPath(Locator.IncomingButtonMailLocator)).Any());
            IncomingMessageButton = Driver.FindElement(By.XPath(Locator.IncomingButtonMailLocator));
            IncomingMessageButton.Click();

            Wait.Until(t => Driver.FindElements(By.XPath(Locator.MailFromGmailButtonLocator)).Any());
            ConcreteMessage = Driver.FindElement(By.XPath(Locator.MailFromGmailButtonLocator));
            ConcreteMessage.Click();

        }

        /// <summary>
        /// Method for getting  new user name, from textbox
        /// </summary>
        /// <returns></returns>
        public string GetNewName()
        {
            Wait.Until(t => Driver.FindElements(By.XPath(Locator.MessageBoxLocator)).Any());
            TextBoxOfMessage = Driver.FindElement(By.XPath(Locator.MessageBoxLocator));
            var newName = TextBoxOfMessage.Text;
            return newName;
        }
    }
}