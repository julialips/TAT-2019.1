using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Task2
{
    class TextMessageToMail
    {
        IWebDriver Driver { get; }
        IWebElement IncomingButton { get; set; }
        IWebElement TextBoxLabel { get; set; }
        IWebElement SendButton { get; set; }

        WebDriverWait Wait { get; }
        Locators.TextingMessageLocator Locator { get; }

        public TextMessageToMail(IWebDriver driver)
        {
            this.Driver = driver;
            this.Locator = new Locators.TextingMessageLocator();
            this.Wait = new WebDriverWait(Driver, TimeSpan.FromMinutes(2));
        }

        public void TextingAnswerMessageToMail(string answerpsevdonim)
        {
            Wait.Until(t => Driver.FindElements(By.XPath(Locator.AnswerButtonLocator)).Any());
            IncomingButton = Driver.FindElement(By.XPath(Locator.AnswerButtonLocator));
            IncomingButton.Click();

            Wait.Until(t => Driver.FindElements(By.XPath(Locator.TextBoxLocator)).Any());
            TextBoxLabel = Driver.FindElement(By.XPath(Locator.TextBoxLocator));
            TextBoxLabel.SendKeys(answerpsevdonim);

            Wait.Until(t => Driver.FindElements(By.XPath(Locator.SendButtonLocator)).Any());
            SendButton = Driver.FindElement(By.XPath(Locator.SendButtonLocator));
            SendButton.Click();
        }
    }
}

