using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Task2
{
    /// <summary>
    /// Class, for entering in Gmail
    /// </summary>
    class LoginGmailPage
    {
        IWebDriver Driver { get; }
        IWebElement Login { get; set; }
        IWebElement Password { get; set; }
        IWebElement EnterButton { get; set; }
        IWebElement Writing { get; set; }
        IWebElement NextAfterLogin { get; set; }
        IWebElement NextAfterPassword { get; set; }
        WebDriverWait Wait { get; }
        Locators.LoginGmailLocators Locator { get; }

        /// <summary>
        /// Constructor our class
        /// </summary>
        /// <param name="driver"></param>
        public LoginGmailPage(IWebDriver driver)
        {
            this.Driver = driver;
            this.Locator = new Locators.LoginGmailLocators();
            this.Wait = new WebDriverWait(Driver, TimeSpan.FromMinutes(2));
        }

        /// <summary>
        /// Method to start page Gmail
        /// </summary>
        public void StartPage()
        {
            Driver.Navigate().GoToUrl(Locator.PageLocator);
        }

        /// <summary>
        /// Method , to enter in account
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        public void EnterInGmail(string login, string password)
        {
            Wait.Until(t => Driver.FindElements(By.XPath(Locator.EnterLoginLocator)).Any());
            Login = Driver.FindElement(By.XPath(Locator.EnterLoginLocator));
            Login.SendKeys(login);

            Wait.Until(t => Driver.FindElements(By.XPath(Locator.ButtonNextLocator)).Any());
            NextAfterLogin = Driver.FindElement(By.XPath(Locator.ButtonNextLocator));
            NextAfterLogin.Click();

            Wait.Until(t => Driver.FindElements(By.XPath(Locator.EnterPasswordLocator)).Any());
            Password = Driver.FindElement(By.XPath(Locator.EnterPasswordLocator));
            Password.SendKeys(password);

            Wait.Until(t => Driver.FindElements(By.XPath(Locator.EnterPasswordLocator)).Any());
            NextAfterPassword = Driver.FindElement(By.XPath(Locator.EnterPasswordLocator));
            NextAfterPassword.Click();

            Wait.Until(t => Driver.FindElements(By.XPath(Locator.EnterButtonLocator)).Any());
            EnterButton = Driver.FindElement(By.XPath(Locator.EnterButtonLocator));
            EnterButton.Click();
        }
    }
}
