using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Task2
{
    class TestBrowsers
    {
        IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("D:\\3rdparty\\chrome");
        }

        [Test]
        public void test()
        {
            driver.Url = "https://mail.google.com/mail/u/0/#inbox";
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}

