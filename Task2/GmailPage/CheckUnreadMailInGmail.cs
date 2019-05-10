using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Task2
{
    class CheckUnreadMailInGmail
    {
        IWebDriver Driver { get; }
        IWebElement IncomingButton { get; set; }
        IWebElement SelectionUnreadButton { get; set; }

        IWebElement UnreadButton { get; set; }
        IWebElement EnterButton { get; set; }
        IWebElement UnreadMessage { get; set; }

        WebDriverWait Wait { get; }
        Locators.ReaderGmailLocators Locator { get; }

        public CheckUnreadMailInGmail(IWebDriver driver)
        {
            this.Driver = driver;
            this.Locator = new Locators.ReaderGmailLocators();
            this.Wait = new WebDriverWait(Driver, TimeSpan.FromMinutes(2));
        }

        public void CheckUnreadMail()
        {
            Wait.Until(t => Driver.FindElements(By.XPath(Locator.IncomingButtonLocator)).Any());
            IncomingButton = Driver.FindElement(By.XPath(Locator.IncomingButtonLocator));
            IncomingButton.Click();

            Wait.Until(t => Driver.FindElements(By.XPath(Locator.MoreopportunityButtonLocator)).Any());
            SelectionUnreadButton = Driver.FindElement(By.XPath(Locator.MoreopportunityButtonLocator));
            SelectionUnreadButton.Click();


            Wait.Until(t => Driver.FindElements(By.XPath(Locator.UnreadButtonLocator)).Any());//зашли в непрочитанные сообщения
            UnreadButton = Driver.FindElement(By.XPath(Locator.UnreadButtonLocator));
            UnreadButton.Click();
 
        }     
    }
}
