using System;
using System.Linq;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace Task2
{
    class ReadingAndGettingMessageFromGmail
    {
            IWebDriver Driver { get; }
            IWebElement IncomingMessageButton { get; set; }
            IWebElement ConcreteMessage { get; set; }
            IWebElement TextBoxOfMessage { get; set; }
            WebDriverWait Wait { get; }
            Locators.ReadingMailMessageLocators Locator { get; }

            public ReadingAndGettingMessageFromGmail(IWebDriver driver)
            {
                this.Driver = driver;
                this.Locator = new Locators.ReadingMailMessageLocators();
                this.Wait = new WebDriverWait(Driver, TimeSpan.FromMinutes(2));
            }

            
            public void ReadingMessageFromGmail()
            {
                Wait.Until(t => Driver.FindElements(By.XPath(Locator.IncomingButtonMailLocator)).Any());
            IncomingMessageButton = Driver.FindElement(By.XPath(Locator.IncomingButtonMailLocator));
            IncomingMessageButton.Click();

            Wait.Until(t => Driver.FindElements(By.XPath(Locator.MailFromGmailButtonLocator)).Any());
            ConcreteMessage = Driver.FindElement(By.XPath(Locator.MailFromGmailButtonLocator));
            ConcreteMessage.Click();

            }

            public string GetNewName()
            {
                Wait.Until(t => Driver.FindElements(By.XPath(Locator.MessageBoxLocator)).Any());
                TextBoxOfMessage = Driver.FindElement(By.XPath(Locator.MessageBoxLocator));

            var newName=TextBoxOfMessage.Text;
            return newName;
            }
    }
}
