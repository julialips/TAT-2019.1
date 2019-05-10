using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Task2
{
     class StartingMailPage
    {
        IWebDriver Driver { get; }
        IWebElement Login { get; set; }
        IWebElement Password { get; set; }
        IWebElement EnterButton { get; set; }
        IWebElement Writing { get; set; }

        WebDriverWait Wait { get; }
        Locators.LoginMailLocators Locator { get; }

        public StartingMailPage(IWebDriver driver)
        {
            this.Driver = driver;
            this.Locator = new Locators.LoginMailLocators();
            this.Wait = new WebDriverWait(Driver, TimeSpan.FromMinutes(2));
        }

        public void StartPage()
        {
            Driver.Navigate().GoToUrl(Locator.PageLocator);
           
        }
       
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
