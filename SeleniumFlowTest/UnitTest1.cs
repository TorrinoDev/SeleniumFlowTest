using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium.Chrome;
using System.Xml.Linq;
using OpenQA.Selenium.Support.Extensions;

namespace SeleniumFlowTest

{
    [TestClass]
    public class UnitTest1
    {
        private static string DriverDirectory = "C:\\WebDriver";
        private static string URL = "http://localhost:3000/";
        private static IWebDriver driver = new ChromeDriver(DriverDirectory);

        [TestMethod]
        public void TestMethod1()
        {
            driver.Navigate().GoToUrl(URL);
            IWebElement ansøgKnap = driver.FindElement(By.Id("ansøgKnap"));
            ansøgKnap.Click();
            IWebElement opstartAnsøgning = driver.FindElement(By.Id("forståetKnap"));
            opstartAnsøgning.Click();

            //Thread.Sleep(2000);
            
            IWebElement offentligGældNej = driver.FindElement(By.Id("debtNej"));
            driver.ExecuteJavaScript("arguments[0].click();", offentligGældNej);

        }

        [TestMethod]
        public void TestMethod2()
        {
            driver.Navigate().GoToUrl(URL);
            IWebElement ansøgKnap = driver.FindElement(By.Id("ansøgKnap"));
            ansøgKnap.Click();
            IWebElement opstartAnsøgning = driver.FindElement(By.Id("forståetKnap"));
            opstartAnsøgning.Click();
            IWebElement offentligGældJa = driver.FindElement(By.Id("debtJa"));
            driver.ExecuteJavaScript("arguments[0].click();", offentligGældJa);
            IWebElement gældInput = driver.FindElement(By.Id("debtInput"));
            int insertDebt = 100000;
            gældInput.SendKeys(insertDebt.ToString());


        }
    }
}