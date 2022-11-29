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
            IWebElement ans�gKnap = driver.FindElement(By.Id("ans�gKnap"));
            ans�gKnap.Click();
            IWebElement opstartAns�gning = driver.FindElement(By.Id("forst�etKnap"));
            opstartAns�gning.Click();

            //Thread.Sleep(2000);
            
            IWebElement offentligG�ldNej = driver.FindElement(By.Id("debtNej"));
            driver.ExecuteJavaScript("arguments[0].click();", offentligG�ldNej);

        }

        [TestMethod]
        public void TestMethod2()
        {
            driver.Navigate().GoToUrl(URL);
            IWebElement ans�gKnap = driver.FindElement(By.Id("ans�gKnap"));
            ans�gKnap.Click();
            IWebElement opstartAns�gning = driver.FindElement(By.Id("forst�etKnap"));
            opstartAns�gning.Click();
            IWebElement offentligG�ldJa = driver.FindElement(By.Id("debtJa"));
            driver.ExecuteJavaScript("arguments[0].click();", offentligG�ldJa);
            IWebElement g�ldInput = driver.FindElement(By.Id("debtInput"));
            int insertDebt = 100000;
            g�ldInput.SendKeys(insertDebt.ToString());


        }
    }
}