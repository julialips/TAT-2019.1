﻿using System;
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
        public IWebElement BuyEUR => this.driver.FindElement(By.XPath("//*[@class='BlockCurrencyExchangeRates__rate - item_buy - rate'[2]"));
        public IWebElement SellEUR => this.driver.FindElement(By.XPath("//*[@class=['BlockCurrencyExchangeRates__rate - item_sell - rate'][2]"));
        public IWebElement BuyRub => this.driver.FindElement(By.XPath("//*[@class='BlockCurrencyExchangeRates__rate - item_buy - rate'[3]"));
        public IWebElement SellRub => this.driver.FindElement(By.XPath("//*[@class=['BlockCurrencyExchangeRates__rate - item_sell - rate'][3]"));

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
            string SellUSD = this.SellUSD.Text;
            currency.Add(new Currency("SellUSD", SellUSD));

            new WebDriverWait(this.driver, TimeSpan.FromSeconds(10)).Until(x => this.BuyUSD.Enabled);
            string BuyEUR = this.BuyEUR.Text;
            currency.Add(new Currency("BuyEUR", BuyEUR));

            new WebDriverWait(this.driver, TimeSpan.FromSeconds(10)).Until(x => this.SellUSD.Enabled);
            string SellEUR = this.SellEUR.Text;
            currency.Add(new Currency("SellEUR", SellEUR));

            new WebDriverWait(this.driver, TimeSpan.FromSeconds(10)).Until(x => this.BuyUSD.Enabled);
            string BuyRub = this.BuyRub.Text;
            currency.Add(new Currency("BuyRub", BuyRub));

            new WebDriverWait(this.driver, TimeSpan.FromSeconds(10)).Until(x => this.SellUSD.Enabled);
            string SellRub = this.SellRub.Text;
            currency.Add(new Currency("SellRub", SellRub));
        }
    }
}