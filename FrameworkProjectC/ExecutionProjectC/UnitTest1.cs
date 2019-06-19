using FrameworkProjectC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace ExecutionProjectC
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;
        Samsung sa;
        string priceSearchResult;
        string carprice;

        [TestInitialize]
        public void setUrl() {
            
            BrowserSetUp br = new BrowserSetUp();
            driver = br.browser();
            br.browserUrl();

            LoginPage lp = new LoginPage(driver);
            lp.login();

        }
        [TestMethod]
        public void ValidatePrice1Samsung()
        {
            sa = new Samsung(driver);
            sa.searchItem();
            priceSearchResult = sa.getPrice1();
            sa.samsungFlow1();
            string productPrice = sa.productPrice();

            Assert.AreEqual(priceSearchResult,productPrice);

        }

        [TestMethod]
        public void ValidatePrice2SamsungInCar()
        {
            sa = new Samsung(driver);


            sa.searchItem();
            priceSearchResult = sa.getPrice1();
            sa.samsungFlow1();
            sa.addCar();
            carprice = sa.carPrice();

            Assert.AreEqual(priceSearchResult, carprice);

            Clean c = new Clean(driver);
            c.cleanCar();
            c.eliminaSamsung();
        }
        [TestMethod]
        public void ValidateOneProductInCar()
        {
            samsung();
          
            Assert.AreEqual(1, sa.oneProduct());
            Clean c = new Clean(driver);
            c.cleanCar();
            c.eliminaSamsung();
        }

        [TestMethod]
        public void VaidateAlienInCar()
        {
            samsung();
            Alien al = new Alien(driver);

            al.searchAlien();
            al.selectAlien();
            al.addToCar();

            Assert.AreEqual(al.secondProduct(), 2);

            Clean c = new Clean(driver);
            c.cleanCar();
            c.eliminar();
        }

        [TestCleanup]
        public void cleanup() {
          driver.Close();
        }

        public void samsung() {
            sa = new Samsung(driver);


            sa.searchItem();
            priceSearchResult = sa.getPrice1();
            sa.samsungFlow1();
            sa.addCar();
            carprice = sa.carPrice();
        }
    }
}
