using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace executeAutomation
{
    public class NunitTests
    {
        IWebDriver driver;

        [SetUp]
        public void setup()
        {
            driver = new FirefoxDriver();
        }

        // Enter all the values and save
        // Title
        //Initial
        //FirstName
        // MiddleName
        //Gender
        //LanguageKnown
        //The user form should be saved successfully

        [Test]
        public void testAllValues()
        {
            string abc = "abc";
             
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html");

            IndexPage indexPage = new IndexPage(driver);

            //Select Title
//            new SelectElement(driver.FindElement(By.Id("TitleId"))).SelectByText("Mr.");
            indexPage.setTitle("Mr.");

            //Enter Initial
            indexPage.setInitial("Abc");
            //Enter FirstName
            driver.FindElement(By.Id("FirstName")).SendKeys("FirstName");

            //Enter MiddleName
            driver.FindElement(By.Id("MiddleName")).SendKeys("MiddleName");

            //Enter Gender
            driver.FindElement(By.CssSelector("input[name = 'Male']")).Click();

            //Enter language known
            driver.FindElement(By.CssSelector("input[name = 'english']")).Click();

            //Click Save
            driver.FindElement(By.Name("Save")).Click();

            //check login is successful
            string text = driver.FindElement(By.Id("messageSuccess")).Text;
            Assert.AreEqual("Successfully created", text);
        }


        // Enter all the values and save
        // Title
        //FirstName
        //The user form should be saved successfully
        [Test]
        public void testCheckNonMandatoryValues()
        {
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html");

            //Select Title
            new SelectElement(driver.FindElement(By.Id("TitleId"))).SelectByText("Mr.");

            //Enter FirstName
            driver.FindElement(By.Id("FirstName")).SendKeys("FirstName");

            //Click Save
            driver.FindElement(By.Name("Save")).Click();

            //check login is successful
        }

        // Enter all the values and save
        // Title
        //The user form should thrown an error
        [Test]
        public void testCheckMissingMandatoryValues()
        {
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html");

            //Select Title
            new SelectElement(driver.FindElement(By.Id("TitleId"))).SelectByText("Mr.");

            //Click Save
            driver.FindElement(By.Name("Save")).Click();

            // Error should thrown on the screen
            string errorText = driver.FindElement(By.Id("errorMsg")).Text;
            Assert.AreEqual("Error Occured", errorText);
        }

        [TearDown]
        public void teardown()
        {

        }
    }
}
