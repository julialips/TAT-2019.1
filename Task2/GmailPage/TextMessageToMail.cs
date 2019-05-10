using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Task2
{
    /// <summary>
    /// Class, for texting message to Mail
    /// </summary>
    class TextMessageToMail
    {
        IWebDriver Driver { get; }
        IWebElement IncomingButton { get; set; }
        IWebElement TextBoxLabel { get; set; }
        IWebElement SendButton { get; set; }
        WebDriverWait Wait { get; }
        Locators.TextingMessageLocator Locator { get; }

        /// <summary>
        /// Constructor our class
        /// </summary>
        /// <param name="driver"></param>
        public TextMessageToMail(IWebDriver driver)
        {
            this.Driver = driver;
            this.Locator = new Locators.TextingMessageLocator();
            this.Wait = new WebDriverWait(Driver, TimeSpan.FromMinutes(2));
        }

        /// <summary>
        /// Method, which find needed buttons ,and send message
        /// </summary>
        /// <param name="answerpsevdonim"></param>
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

