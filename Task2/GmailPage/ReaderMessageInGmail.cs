using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Task2.GmailPage
{
    class ReaderMessageInGmail
    {
            IWebDriver Driver { get; }
            IWebElement UnreadMessage { get; set; }
        

            WebDriverWait Wait { get; }
            Locators.EnterInUnreadMessageLocator Locator { get; }

            public ReaderMessageInGmail(IWebDriver driver)
            {
                this.Driver = driver;
                this.Locator = new Locators.EnterInUnreadMessageLocator();
                this.Wait = new WebDriverWait(Driver, TimeSpan.FromMinutes(2));
            }

        public void ReadingMessage()
        {
            Wait.Until(t => Driver.FindElements(By.XPath(Locator.IncomingMailLocator)).Any());
            UnreadMessage = Driver.FindElement(By.XPath(Locator.IncomingMailLocator));
            UnreadMessage.Click();//заходим в само сообщение

        }

    }
}

