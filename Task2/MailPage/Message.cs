using System;
using System.Linq;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace Task2
{
    class Message
    {
        IWebDriver Driver { get; }
        IWebElement Writing { get; set; }
        IWebElement To { get; set; }
        IWebElement TextOfMessage { get; set; }
        IWebElement SendButton { get; set; }
       Locators.SendingMailMessageLocators Locator { get; }
        WebDriverWait Wait { get; }

        public Message(IWebDriver driver)
        {
            this.Driver = driver;
            this.Locator = new Locators.SendingMailMessageLocators();
            this.Wait = new WebDriverWait(Driver, TimeSpan.FromMinutes(2));
        }

        public void WriteMessage(string wheresend, string text)
        {
            Wait.Until(t => Driver.FindElements(By.XPath(Locator.WritingMailButtonLocator)).Any());
            Writing = Driver.FindElement(By.XPath(Locator.WritingMailButtonLocator));
            Writing.Click();

            Wait.Until(t => Driver.FindElements(By.XPath(Locator.AdressToLocator)).Any());
            To = Driver.FindElement(By.XPath(Locator.AdressToLocator));
            To.SendKeys(wheresend);

            Wait.Until(t => Driver.FindElements(By.XPath(Locator.MessageBoxLocator)).Any());
            TextOfMessage = Driver.FindElement(By.XPath(Locator.MessageBoxLocator));
            TextOfMessage.SendKeys(text);

            Wait.Until(t => Driver.FindElements(By.XPath(Locator.SendButtonLocator)).Any());
            SendButton = Driver.FindElement(By.XPath(Locator.SendButtonLocator));
            SendButton.Click();
        }
    }
}
