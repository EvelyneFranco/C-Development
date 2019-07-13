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
    public class SamsungElements
    {
        IWebDriver driver;

        public SamsungElements(IWebDriver driver)
        {
            this.driver = driver;
        }

        [FindsBy(How = How.XPath, Using = "//span[@class='a-price-whole'][contains(.,'10,999.')]")]
        public IWebElement price1 { get; set; }

        [FindsBy(How = How.XPath, Using = "(//span[@class='a-price-fraction'][contains(.,'00')])[1]")]
        public IWebElement fraction { get; set; }

        [FindsBy(How = How.XPath, Using = "//img[@data-image-index='0']")]
        public IWebElement SelectFirst { get; set; }

        [FindsBy(How = How.Id, Using = "priceblock_ourprice")]
        public IWebElement productPrice { get; set; }

        [FindsBy(How = How.Id, Using = "add-to-cart-button")]
        public IWebElement addCar { get; set; }

        [FindsBy(How = How.Id, Using = "twotabsearchtextbox")]
        public IWebElement searchbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@value,'Ir')]")]
        public IWebElement ir { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'$10,999.00')]")]
        public IWebElement priceCar { get; set; }

        [FindsBy(How = How.XPath, Using = "//strong[contains(.,'1')]")]
        public IWebElement oneproduct { get; set; }

        public string firstPrice()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                wait.Until(driver => price1.Displayed);
                string price = "$" + price1.Text + "." + fraction.Text;
                return price;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public void selectSamsung()
        {

            try
            {
                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));

                wait.Until(driver => SelectFirst.Displayed);
                SelectFirst.Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public string secondPrice()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));

                wait.Until(driver => productPrice.Displayed);
                string price2 = productPrice.Text;
                return price2;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

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

        public string carPrice()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));

                wait.Until(driver => priceCar.Displayed);
                string price = priceCar.Text;
                return price;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public int oneProductInCar()
        {

            try
            {
                int can = Int32.Parse(oneproduct.Text);

                return can;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

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
