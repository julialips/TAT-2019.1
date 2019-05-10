using System;
using System.Linq;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace Task2
{  
    /// <summary>
    /// class have one method for getting user name
    /// </summary>
    class NewUserNameInMail
    {
        IWebDriver Driver { get; }
        IWebElement Panel { get; set; }
        IWebElement PersonalData { get; set; }
        IWebElement NewNickName { get; set; }
        IWebElement SaveButton { get; set; } 
        WebDriverWait Wait { get; }
        Locators.ChangingUserNameLocator Locator { get; }

        /// <summary>
        /// Constructor our class
        /// </summary>
        /// <param name="driver"></param>
        public NewUserNameInMail(IWebDriver driver)
        {
            this.Driver = driver;
            this.Locator = new Locators.ChangingUserNameLocator();
            this.Wait = new WebDriverWait(Driver, TimeSpan.FromMinutes(2));
        }

        /// <summary>
        /// method,where webdriver comes to settings, and paste got before user name 
        /// </summary>
        /// <param name="newName"></param>
        public void SettingsNickName(string newName)
        {
            Wait.Until(t => Driver.FindElements(By.XPath(Locator.SettingsSelectionPanelLocator)).Any());
            Panel = Driver.FindElement(By.XPath(Locator.SettingsSelectionPanelLocator));
            Panel.Click();

            Wait.Until(t => Driver.FindElements(By.XPath(Locator.PersonalDataButtonLocator)).Any());
            PersonalData = Driver.FindElement(By.XPath(Locator.SettingsSelectionPanelLocator));
            PersonalData.Click();

            Wait.Until(t => Driver.FindElements(By.XPath(Locator.NickNameLocator)).Any());
            NewNickName = Driver.FindElement(By.XPath(Locator.NickNameLocator));
            NewNickName.SendKeys(newName);

            Wait.Until(t => Driver.FindElements(By.XPath(Locator.SaveButtonLocator)).Any());
            SaveButton = Driver.FindElement(By.XPath(Locator.SaveButtonLocator));
            SaveButton.Click();
        }
    }
}

