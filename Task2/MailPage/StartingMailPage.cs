using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Task2
{
    /// <summary>
    /// Class which have methods for start page and enter in mail
    /// </summary>
    class StartingMailPage
    {
        IWebDriver Driver { get; }
        IWebElement Login { get; set; }
        IWebElement Password { get; set; }
        IWebElement EnterButton { get; set; }
        IWebElement Writing { get; set; }

        WebDriverWait Wait { get; }
        Locators.LoginMailLocators Locator { get; }

        /// <summary>
        /// Constructor of our class 
        /// </summary>
        /// <param name="driver"></param>
        public StartingMailPage(IWebDriver driver)
        {
            this.Driver = driver;
            this.Locator = new Locators.LoginMailLocators();
            this.Wait = new WebDriverWait(Driver, TimeSpan.FromMinutes(2));
        }

        /// <summary>
        /// Method,which navigate to mail.ru
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
        public void EnterInMail(string login,string password)
        {
            Wait.Until(t => Driver.FindElements(By.XPath(Locator.EnterLoginLocator)).Any());
            Login = Driver.FindElement(By.XPath(Locator.EnterLoginLocator));
            Password = Driver.FindElement(By.XPath(Locator.EnterPasswordLocator));
            Login.SendKeys(login);
            Password.SendKeys(password);
            EnterButton = Driver.FindElement(By.XPath(Locator.EnterButtonLocator));
            EnterButton.Click();
        }                 
    }
}
