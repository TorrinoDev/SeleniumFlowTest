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
            //Arrange
            int waitTime = 1000;
            string brugernavn = "testBruger";
            string navnInput = "Jeff";
            string emailInput = "losBezoz@amazonian.org";
            string mobilInput = "20304050";
            string employLocInput = "Coop Bank";
            string childAgeInput = "12";
            string coopMedlemNrInput = "12345678";


            //Act
            driver.Navigate().GoToUrl(URL);
            IWebElement ansøgKnap = driver.FindElement(By.Id("ansøgKnap"));
            ansøgKnap.Click();

            IWebElement opstartAnsøgning = driver.FindElement(By.Id("forståetKnap"));
            opstartAnsøgning.Click();
            Thread.Sleep(waitTime);

            IWebElement offentligGældNej = driver.FindElement(By.Id("debtNej"));
            driver.ExecuteJavaScript("arguments[0].click();", offentligGældNej);
            Thread.Sleep(waitTime);

            IWebElement mitID = driver.FindElement(By.Id("brugernavnInput"));
            mitID.SendKeys(brugernavn);

            IWebElement loginKnap = driver.FindElement(By.Id("loginButton"));
            loginKnap.Click();
            Thread.Sleep(waitTime);

            IWebElement navn = driver.FindElement(By.Id("userNameInput"));
            navn.SendKeys(navnInput);

            IWebElement email = driver.FindElement(By.Id("userEmailInput"));
            email.SendKeys(emailInput);

            IWebElement mobilnr = driver.FindElement(By.Id("userPhoneInput"));
            mobilnr.SendKeys(mobilInput);

            IWebElement nextButton = driver.FindElement(By.Id("nextButton"));
            nextButton.Click();
            Thread.Sleep(waitTime);
            
            IWebElement citiDansk = driver.FindElement(By.Id("userCitizenD"));
            citiDansk.Click();

            nextButton.Click();
            Thread.Sleep(waitTime);

            IWebElement statusButton = driver.FindElement(By.Id("giftButton"));
            statusButton.Click();

            IWebElement medAnsøger = driver.FindElement(By.Id("nejMedansøgerButton"));
            medAnsøger.Click();
            Thread.Sleep(waitTime);

            IWebElement employment = driver.FindElement(By.Id("funktionærButton"));
            employment.Click();

            IWebElement employmentLocInput = driver.FindElement(By.Id("employmentLocationInput"));
            employmentLocInput.SendKeys(employLocInput);
            Thread.Sleep(waitTime);

            IWebElement ansatMåned = driver.FindElement(By.Id("ansatMånedDropdown-trigger"));
            ansatMåned.Click();

            IWebElement ansatMånedOption = driver.FindElement(By.Id("ansatMånedDropdown-option-2"));
            ansatMånedOption.Click();
            
            IWebElement ansatÅrDropdown = driver.FindElement(By.Id("ansatÅrDropdown-trigger"));
            ansatÅrDropdown.Click();

            IWebElement ansatÅrOption = driver.FindElement(By.Id("ansatÅrDropdown-option-9"));
            ansatÅrOption.Click();

            IWebElement okButton = driver.FindElement(By.Id("okButton"));
            okButton.Click();
            Thread.Sleep(waitTime);

            IWebElement children = driver.FindElement(By.Id("userRelationYO"));
            children.Click();

            IWebElement childAge = driver.FindElement(By.Id("userRelationCA"));
            childAge.SendKeys(childAgeInput);

            IWebElement nextButton1 = driver.FindElement(By.Id("nextButton"));
            nextButton1.Click();
            Thread.Sleep(waitTime);

            IWebElement car = driver.FindElement(By.Id("carOne"));
            car.Click();

            IWebElement carDropdown = driver.FindElement(By.Id("carTypeDropdown-trigger"));
            carDropdown.Click();

            IWebElement carOption = driver.FindElement(By.Id("carTypeDropdown-option-0"));
            carOption.Click();

            IWebElement nextButton2 = driver.FindElement(By.Id("nextButton"));
            nextButton2.Click();
            Thread.Sleep(waitTime);

            IWebElement coopMedlem = driver.FindElement(By.Id("coopMedlemJa"));
            coopMedlem.Click();

            IWebElement coopMedlemNr = driver.FindElement(By.Id("coopMedlemNrInput"));
            coopMedlemNr.SendKeys(coopMedlemNrInput);

            IWebElement nextButton3 = driver.FindElement(By.Id("nextButton"));
            nextButton3.Click();
            Thread.Sleep(waitTime);
            //Assert

            Thread.Sleep(waitTime);
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
            Thread.Sleep(1000);

            IWebElement gældInput = driver.FindElement(By.Id("debtInput"));
            int insertDebt = 100000;
            gældInput.SendKeys(insertDebt.ToString());

        }
    }
}