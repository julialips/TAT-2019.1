using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace valuta
{   
    // <summary>
    /// class,which find elements by their Xpath
    /// </summary>
    class DownloaingKurs
    {
        private IWebDriver driver;
        WebDriverWait WebDriverWait { get; }

        public IWebElement BuyUSD => this.driver.FindElement(By.XPath("//*[@class='BlockCurrencyExchangeRates__rate - item_buy - rate'[1]"));
        public IWebElement SellUSD => this.driver.FindElement(By.XPath("//*[@class=['BlockCurrencyExchangeRates__rate - item_sell - rate'][1]"));
        public IWebElement BuyEUR => this.driver.FindElement(By.XPath("//table[@class='b-currency-table__best'][2]/tbody/tr/td[2]/p[1]/b"));
        public IWebElement SellEUR => this.driver.FindElement(By.XPath("//table[@class='b-currency-table__best'][2]/tbody/tr/td[3]/p[1]/b"));
        public IWebElement BuyRus => this.driver.FindElement(By.XPath("//table[@class='b-currency-table__best'][3]/tbody/tr/td[2]/p[1]/b"));
        public IWebElement SellRus => this.driver.FindElement(By.XPath("//table[@class='b-currency-table__best'][3]/tbody/tr/td[3]/p[1]/b"));

        public DownloaingKurs(IWebDriver driver)
        {
            this.driver = driver;
            this.WebDriverWait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
        }

        public void LoadValues(List<Currency> currency)
        {
            new WebDriverWait(this.driver, TimeSpan.FromSeconds(10)).Until(x => this.BuyUSD.Enabled);
            string BuyUSD = this.BuyUSD.Text;
            currency.Add(new Currency("BuyUSD", BuyUSD));

            new WebDriverWait(this.driver, TimeSpan.FromSeconds(10)).Until(x => this.SellUSD.Enabled);
            string SellUSD = this.BuyUSD.Text;
            currency.Add(new Currency("SellUSD", SellUSD));
        }
    }
}