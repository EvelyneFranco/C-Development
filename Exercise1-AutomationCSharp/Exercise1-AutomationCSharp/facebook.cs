using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace Exercise1_AutomationCSharp
{
    [TestClass]
    public class facebook

    //elements to be used
    {
        IWebDriver driver;
        IWebElement name, lastname, mobile, text;
        string actualText, expectedText;

        //-----------------------------------Test-------------------------------------
        [TestMethod]
        public void firefoxFlow()

        {
            setUp("firefox");
            waits();
            IWebElement english = driver.FindElement(By.LinkText("English (US)"));
            english.Click();

            initName();
            initLast();
            initMobile();
            initText();
            expectedText = "It’s free and always will be.";
            Assert.AreEqual(actualText, expectedText);

            driver.Close();

        }

        [TestMethod]
        public void chromeFlow()

        {
            setUp("chrome");
            waits();


            initName();
            initLast();
            initMobile();
            initText();

            expectedText = "It’s free and always will be.";
            Assert.AreEqual(actualText, expectedText);

            driver.Close();

        }
        [TestMethod]
        public void notElementExist() {
            setUp("chrome");
            waits();
            elementNotExist();
            driver.Close();

        }

        [TestMethod]
        public void edgeFlow()

        {
            setUp("edge");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
           // IWebElement english = driver.FindElement(By.LinkText("English (US)"));
            //english.Click();

            initName();
            initLast();
            initMobile();
            initText();
            expectedText = "It’s free and always will be.";
            Assert.AreEqual(actualText, expectedText);

            driver.Close();

        }




        //-----------------------------------Methods-------------------------------------

        public void setUp(string browser) {
            
            switch (browser)
            {
                case "firefox":
                      driver = new FirefoxDriver();
                    driver.Navigate().GoToUrl("https://www.facebook.com/");
   
                    break;
                case "chrome":
                     driver = new ChromeDriver();
                    driver.Navigate().GoToUrl("https://www.facebook.com/");
                    break;
                case "edge":
                    string edgeDriverLocation =@"C:\\edgeDriver";
                    

                    driver = new InternetExplorerDriver(edgeDriverLocation);
                    driver.Navigate().GoToUrl("https://www.facebook.com/");

                    break;
                default:
                    Console.WriteLine("option does not exist");
                    break;


            }
        }

       
        public void waits() {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        public void initName() {
          
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            
            name = driver.FindElement(By.Id("u_0_c"));
            wait.Until(driver => name.Enabled);
            name.SendKeys("Evelyne");
        }
        public void initLast() {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            lastname = driver.FindElement(By.Id("u_0_e"));
            wait.Until(driver => lastname.Enabled);
            lastname.SendKeys("Franco");
        }
        public void initMobile() {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            mobile = driver.FindElement(By.Id("u_0_h"));
            wait.Until(driver => mobile.Enabled);
            mobile.SendKeys("4773505140");
        }

        public void initText() {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            text = driver.FindElement(By.XPath("//div[@class='mbl _3m9 _6o _6s _mf'][contains(.,'It’s free and always will be.')]"));
            wait.Until(driver => text.Enabled);
            actualText = text.Text;
        }

        public void elementNotExist() {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            try
            {

                IWebElement notelement = driver.FindElement(By.Id("test"));
                wait.Until(driver => notelement.Enabled);
                string test= notelement.Text;
            }
            catch (Exception e) {
                Console.WriteLine("Element does not exist, verify By information set and try again.");
            }
        }
    }

}
