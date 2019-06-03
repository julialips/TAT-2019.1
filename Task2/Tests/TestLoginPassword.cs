using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Task2
{
    class TestLoginPassword
    {
        IWebDriver driver;
        WebDriverWait wait;

        [SetUp]
        public void OpenBrowser()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://mail.ru/");
        }

        [Test]
        public void test()
        {
            driver.Navigate().GoToUrl("https://mail.ru/");
        }
        
        [TestCase("alekseeva.katya98", "itisapassword")]
        [TestCase("alekseeva.katya99", "itisapassword")]
        [TestCase("", "")]
        public void LoginPasswordChecking(string login, string password)
        {
            StartingMailPage mailPage = new StartingMailPage(driver);
            mailPage.EnterInMail(login, password);
            Assert.IsTrue(driver.FindElement(By.XPath("Locator.NewPage")).Displayed);
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}

