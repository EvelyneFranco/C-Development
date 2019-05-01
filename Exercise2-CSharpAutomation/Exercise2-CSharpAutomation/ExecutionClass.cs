using System;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Exercise2_CSharpAutomation
{
    [TestClass]
    public class ExecutionClass
    {

        BrowserSetUp bro;
        IWebDriver driver;

        [TestInitialize]
        public void init() {
            bro = new BrowserSetUp();
            driver = bro.browser();
            driver.Manage().Window.Maximize();
            bro.urlGoTo();
        }


        [TestMethod]

        public void ValidateTittle()
        {
            String actual = bro.getTittle();
            String expected = "Facebook - Log In or Sign Up";

            Assert.AreEqual(expected, actual);

            if (expected.Equals(actual)) {
                Console.WriteLine("Test pass");
            }
           

        }

        [TestMethod]
        public void ValidateTextPresent() {
            string actual=bro.textPresent();
            string expected = "Connect with friends and the\r\nworld around you on Facebook.";
            //string text = "Connect with friends and the \n world around you on Facebook.";
            Assert.AreEqual(expected,actual);

            if (actual.Equals(expected)) {
                Console.WriteLine("Test Pass");
            }

        }
        [TestMethod]
        public void FillInfo() {
            bro.name();
            bro.last();
            bro.mobile();
            bro.password();
            bro.birthday();
            bro.female();

            string values = bro.nameText()+ " " + bro.lastText() + " " + bro.mobileText() + " " + " "+bro.birthdayText()+" "+bro.femaleText();
            Console.WriteLine(values);

        }

        [TestCleanup]
        public void EndTest() {
            driver.Close();
        }
    }
}
