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
            IWebElement ans�gKnap = driver.FindElement(By.Id("ans�gKnap"));
            ans�gKnap.Click();

            IWebElement opstartAns�gning = driver.FindElement(By.Id("forst�etKnap"));
            opstartAns�gning.Click();
            Thread.Sleep(waitTime);

            IWebElement offentligG�ldNej = driver.FindElement(By.Id("debtNej"));
            driver.ExecuteJavaScript("arguments[0].click();", offentligG�ldNej);
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

            IWebElement medAns�ger = driver.FindElement(By.Id("nejMedans�gerButton"));
            medAns�ger.Click();
            Thread.Sleep(waitTime);

            IWebElement employment = driver.FindElement(By.Id("funktion�rButton"));
            employment.Click();

            IWebElement employmentLocInput = driver.FindElement(By.Id("employmentLocationInput"));
            employmentLocInput.SendKeys(employLocInput);
            Thread.Sleep(waitTime);

            IWebElement ansatM�ned = driver.FindElement(By.Id("ansatM�nedDropdown-trigger"));
            ansatM�ned.Click();

            IWebElement ansatM�nedOption = driver.FindElement(By.Id("ansatM�nedDropdown-option-2"));
            ansatM�nedOption.Click();
            
            IWebElement ansat�rDropdown = driver.FindElement(By.Id("ansat�rDropdown-trigger"));
            ansat�rDropdown.Click();

            IWebElement ansat�rOption = driver.FindElement(By.Id("ansat�rDropdown-option-9"));
            ansat�rOption.Click();

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
            IWebElement ans�gKnap = driver.FindElement(By.Id("ans�gKnap"));
            ans�gKnap.Click();
            IWebElement opstartAns�gning = driver.FindElement(By.Id("forst�etKnap"));
            opstartAns�gning.Click();
            IWebElement offentligG�ldJa = driver.FindElement(By.Id("debtJa"));
            driver.ExecuteJavaScript("arguments[0].click();", offentligG�ldJa);
            Thread.Sleep(1000);

            IWebElement g�ldInput = driver.FindElement(By.Id("debtInput"));
            int insertDebt = 100000;
            g�ldInput.SendKeys(insertDebt.ToString());

        }
    }
}