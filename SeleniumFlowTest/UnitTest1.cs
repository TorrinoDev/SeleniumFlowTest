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
            int waitTime = 500;
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

            NextButton(waitTime);

            IWebElement citiDansk = driver.FindElement(By.Id("userCitizenD"));
            citiDansk.Click();

            NextButton(waitTime);

            IWebElement statusButton = driver.FindElement(By.Id("giftButton"));
            statusButton.Click();

            IWebElement medAnsøger = driver.FindElement(By.Id("nejMedansøgerButton"));
            medAnsøger.Click();
            Thread.Sleep(waitTime);

            IWebElement employment = driver.FindElement(By.Id("funktionærButton"));
            employment.Click();

            IWebElement employmentLocInput = driver.FindElement(By.Id("employmentLocationInput"));
            employmentLocInput.SendKeys(employLocInput);

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

            NextButton(waitTime);

            IWebElement car = driver.FindElement(By.Id("carOne"));
            car.Click();

            IWebElement carDropdown = driver.FindElement(By.Id("carTypeDropdown-trigger"));
            carDropdown.Click();

            IWebElement carOption = driver.FindElement(By.Id("carTypeDropdown-option-0"));
            carOption.Click();

            NextButton(waitTime);

            IWebElement boligSituation = driver.FindElement(By.Id("lejeboligButton"));
            boligSituation.Click();

            IWebElement coopMedlem = driver.FindElement(By.Id("coopMedlemJa"));
            coopMedlem.Click();

            IWebElement coopMedlemNr = driver.FindElement(By.Id("coopMedlemNrInput"));
            coopMedlemNr.SendKeys(coopMedlemNrInput);

            NextButton(waitTime);

            IWebElement okToTotalButton = driver.FindElement(By.Id("okButton"));
            okToTotalButton.Click();
            Thread.Sleep(waitTime);

            //Assert
            Assert.AreEqual(brugernavn, totalSplitter("MitId"));
            Assert.AreEqual(navnInput, totalSplitter("name"));
            Assert.AreEqual(emailInput, totalSplitter("mail"));
            Assert.AreEqual(mobilInput, totalSplitter("phone"));
            Assert.AreEqual(employLocInput, totalSplitter("Employer"));
            Assert.AreEqual(childAgeInput, totalSplitter("childOne"));
            Assert.AreEqual(coopMedlemNrInput, totalSplitter("CoopMember"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int waitTime = 500;
            string brugernavn = "123!@testBrug";
            string navnInput = "JeffÆØÅ";
            string emailInput = "losBezoz@amazonian.org";
            string mobilInput = "20304050";
            string medansøgerMailInput = "partner.nu@lever.her";

            //Act
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

            NextButton(waitTime);

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

            NextButton(waitTime);

            IWebElement citiUUA = driver.FindElement(By.Id("userCitizenUUA"));
            citiUUA.Click();

            NextButton(waitTime);

            IWebElement statusButton = driver.FindElement(By.Id("samleverButton"));
            statusButton.Click();

            IWebElement medansøger = driver.FindElement(By.Id("jaMedansøgerButton"));
            medansøger.Click();

            IWebElement medansøgerMail = driver.FindElement(By.Id("medansøgerMailInput"));
            medansøgerMail.SendKeys(medansøgerMailInput);

            NextButton(waitTime);

            IWebElement employment = driver.FindElement(By.Id("ledigButton"));
            employment.Click();

            IWebElement ledigMåned = driver.FindElement(By.Id("noEmploymentMonth-trigger"));
            ledigMåned.Click();

            IWebElement ledigMånedOption = driver.FindElement(By.Id("noEmploymentMonth-option-11"));
            ledigMånedOption.Click();

            IWebElement ledigÅrDropdown = driver.FindElement(By.Id("noEmploymentYear-trigger"));
            ledigÅrDropdown.Click();

            IWebElement ledigÅrOption = driver.FindElement(By.Id("noEmploymentYear-option-1"));
            ledigÅrOption.Click();

            IWebElement okButton = driver.FindElement(By.Id("okButton1"));
            okButton.Click();
            Thread.Sleep(waitTime);

            IWebElement children = driver.FindElement(By.Id("userRelationN"));
            children.Click();
            
            IWebElement car = driver.FindElement(By.Id("carNo"));
            car.Click();

            IWebElement boligSituation = driver.FindElement(By.Id("ejerboligButton"));
            boligSituation.Click();

            IWebElement coopMedlem = driver.FindElement(By.Id("coopMedlemNej"));
            coopMedlem.Click();

            IWebElement okToTotalButton = driver.FindElement(By.Id("okButton"));
            okToTotalButton.Click();
            Thread.Sleep(waitTime);

            //Assert
            Assert.AreEqual(brugernavn, totalSplitter("MitId"));
            Assert.AreEqual(navnInput, totalSplitter("name"));
            Assert.AreEqual(emailInput, totalSplitter("mail"));
            Assert.AreEqual(mobilInput, totalSplitter("phone"));
            Assert.AreEqual(medansøgerMailInput, totalSplitter("CohabitingEmail"));
        }

        [TestMethod]
        public void TestValidation()
        {
            //Arrange
            int waitTime = 500;

            string brugernavn = "123!@testBrug";
            string wrongNavnInput = "a";
            string navnInput = "a";
            List<string> wrongEmailList = new List<string> { "a", "a!", "123", "123@er.", "123@1.dk" };
            string emailInput = "losBezoz@amazonian.org";
            List<string> wrongMobilList = new List<string> { "1234567", "123456789" };
            string mobilInput = "20304050";

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
            
            //Assert
            IWebElement navn = driver.FindElement(By.Id("userNameInput"));
            navn.SendKeys(wrongNavnInput);
            Assert.AreEqual("Skriv dit navn", driver.FindElement(By.Id("errorNameText")).Text);

            foreach (var VARIABLE in wrongEmailList)
            {
                IWebElement email = driver.FindElement(By.Id("userEmailInput"));
                email.SendKeys(VARIABLE);
                Assert.AreEqual("Email format, ex: andr12f4@zealand.dk", driver.FindElement(By.Id("errorEmailText")).Text);
            }

            foreach (var VARIABLE in wrongMobilList)
            {
                IWebElement mobilnr = driver.FindElement(By.Id("userPhoneInput"));
                mobilnr.SendKeys(VARIABLE);
                Assert.AreEqual("Telefonnummer format (går under kun dansk +45 nummer), ex: 12345678", driver.FindElement(By.Id("errorMobilText")).Text);
            }
            
            NextButton(waitTime);

            Assert.AreEqual("Fejl i indtastede oplysninger: Alle Helt røde felter skal ikke kunne ses", driver.FindElement(By.Id("errorValidationText")).Text);
            
            
            
        }

        private void NextButton(int waitTime)
        {
            IWebElement nextButton = driver.FindElement(By.Id("nextButton"));
            nextButton.Click();
            Thread.Sleep(waitTime);
        }

        private string totalSplitter(string id)
        {
            var splitter = ':';
            var textLine = driver.FindElement(By.Id(id)).Text;
            var textArray = textLine.Split(splitter);
            return textArray[textArray.GetUpperBound(0)];
        }
    }
}