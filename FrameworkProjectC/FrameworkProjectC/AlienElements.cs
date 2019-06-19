using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkProjectC
{
    public class AlienElements
    {


        IWebDriver driver;

        public AlienElements(IWebDriver driver)
        {
            this.driver = driver;
        }

        [FindsBy(How = How.XPath, Using = "//img[contains(@alt,'Alienware AW3418DW Monitor Gaming Curvo 34\", LED-Lit, 3440 x 1440, 1 HDMI, 4 USB, 120 Hz')]")]
        public IWebElement selectAlien { get; set; }

        public void select()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));

                wait.Until(driver => selectAlien.Displayed);
                selectAlien.Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //----------------------------------------------------------------------

        [FindsBy(How = How.Id, Using = "add-to-cart-button")]
        public IWebElement addCar { get; set; }
        public void AddToCar()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                wait.Until(driver => addCar.Displayed);
                addCar.Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //----------------------------------------------------------------------
        [FindsBy(How = How.XPath, Using = "//strong[contains(.,'2')]")]
        public IWebElement secondProduct { get; set; }

        public int secondProductInCar()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                wait.Until(driver => secondProduct.Displayed);
                int product = Int32.Parse(secondProduct.Text);
                return product;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        [FindsBy(How = How.Id, Using = "twotabsearchtextbox")]
        public IWebElement searchbox { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[contains(@value,'Ir')]")]
        public IWebElement ir { get; set; }

        public void searchCriteria(string product)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                wait.Until(driver => searchbox.Displayed);
                searchbox.SendKeys(product);
                ir.Click();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
