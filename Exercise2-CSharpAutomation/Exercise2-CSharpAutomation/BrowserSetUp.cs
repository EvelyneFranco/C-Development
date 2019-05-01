using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;


namespace Exercise2_CSharpAutomation
{
    class BrowserSetUp
    {
        IWebDriver driver;
        private string title;

        private string myname="Evelyne", mylast="Franco", myMobile="4773505140", birthdayday="31",birthdaymount="Jul", birthdayyear="1991";

        public IWebDriver browser() {
            
            driver = new ChromeDriver();
            
            return driver;
        }

        public void urlGoTo() {
            driver.Navigate().GoToUrl("https://www.facebook.com/");
        }

        public void name() {
          WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));

            IWebElement nameElement = driver.FindElement(By.Id("u_0_c"));
            wait.Until(driver => nameElement.Displayed);
            nameElement.SendKeys(myname);
        }

        public void last() {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));

            IWebElement lastElement = driver.FindElement(By.Id("u_0_e"));
            wait.Until(driver => lastElement.Displayed);
            lastElement.SendKeys(mylast);
        }

        public void mobile() {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));

            IWebElement mobileElement = driver.FindElement(By.Id("u_0_h"));
            wait.Until(driver => mobileElement.Displayed);
            mobileElement.SendKeys(myMobile);
        }

        public void password() {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));

            IWebElement passElement = driver.FindElement(By.Id("u_0_o"));
            wait.Until(driver => passElement.Displayed);
            passElement.SendKeys("7657897");
        }

        public void birthday() {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));

            IWebElement day = driver.FindElement(By.Id("day"));
            wait.Until(driver => day.Displayed);

            IWebElement month = driver.FindElement(By.Id("month"));
            wait.Until(driver => month.Displayed);

            IWebElement year = driver.FindElement(By.Id("year"));
            wait.Until(driver => year.Displayed);

            SelectElement dayselect = new SelectElement(day);
            dayselect.SelectByText(birthdayday);

            SelectElement monthselect = new SelectElement(month);
            monthselect.SelectByText(birthdaymount);

            SelectElement yearselect = new SelectElement(year);
            yearselect.SelectByText(birthdayyear);
           
        }

        public void female() {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));

            IWebElement fem = driver.FindElement(By.Id("u_0_9"));
            wait.Until(driver => fem.Enabled);
            fem.Click();
        }

        public string textPresent() {

            IWebElement text = driver.FindElement(By.XPath("//h2[@class='inlineBlock _3ma _6n _6s _6v'][contains(.,'Connect with friends and theworld around you on Facebook.')]"));
            string textvalue = text.Text;
            return textvalue;
        }

        public string getTittle() {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            title = driver.Title;
            
            return title;

        }

        public string lastText() {
            return mylast;

        }
        public string nameText() {
            
            return myname;
        }

        public string mobileText() {
            return myMobile;

        }

        public string birthdayText() {
            

            return birthdayday +" " +birthdaymount +" "+ birthdayyear;
        }

        public string femaleText() {
            IWebElement female = driver.FindElement(By.XPath("//label[@class='_58mt'][contains(.,'Female')]"));
            return  female.Text;
        }









    }

}
