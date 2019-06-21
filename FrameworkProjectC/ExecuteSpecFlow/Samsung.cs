using FrameworkProjectC;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteSpecFlow
{
    public class Samsung : SamsungElements
    {

        IWebDriver driver;
        public Samsung(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public void searchItem()
        {
            SamsungElements se = new SamsungElements(driver);
            PageFactory.InitElements(driver, se);
            se.searchCriteria("Samsung Galaxy S9 64GB");

        }

        public string getPrice1()
        {
            SamsungElements se = new SamsungElements(driver);
            PageFactory.InitElements(driver, se);
            return se.firstPrice();
        }
        public void samsungFlow1()
        {
            SamsungElements se = new SamsungElements(driver);
            PageFactory.InitElements(driver, se);
            se.selectSamsung();
        }

        public string productPrice()
        {
            SamsungElements se = new SamsungElements(driver);
            PageFactory.InitElements(driver, se);
            return se.secondPrice();
        }

        public void addCar()
        {
            SamsungElements se = new SamsungElements(driver);
            PageFactory.InitElements(driver, se);
            se.AddToCar();
        }

        public string carPrice()
        {
            SamsungElements se = new SamsungElements(driver);
            PageFactory.InitElements(driver, se);
            return se.carPrice();
        }

        public int oneProduct()
        {
            SamsungElements se = new SamsungElements(driver);
            PageFactory.InitElements(driver, se);
            return se.oneProductInCar();
        }

        public void carrito()
        {
            IWebElement carro = driver.FindElement(By.XPath("//a[contains(@aria-label,'1 artículo en el carrito')]"));
            carro.Click();


        }

        public int carroCantidad()
        {

            IWebElement cantidad = driver.FindElement(By.XPath("//span[@tabindex='-1'][contains(.,'1')]"));

            int cant = Int32.Parse(cantidad.Text);
            return cant;
        }
    }
}
