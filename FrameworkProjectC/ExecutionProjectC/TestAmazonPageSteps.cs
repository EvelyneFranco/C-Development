using FrameworkProjectC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace ExecutionProjectC
{
    [Binding]
    public class TestAmazonPageSteps
    {

        IWebDriver driver;
        Samsung sa;
        string priceSearchResult;
        string carprice;
        int oneproductincar;
        Alien al;
        string productPrice;

        [Given(@"the login in amazon page")]
        public void GivenTheLoginInAmazonPage()
        {
            BrowserSetUp br = new BrowserSetUp();
            driver = br.browser();
            br.browserUrl();

            LoginPage lp = new LoginPage(driver);
            lp.login();
        }
        
        [Given(@"user search and select samsung")]
        public void GivenUserSearchAndSelectSamsung()
        {

            sa = new Samsung(driver);
            sa.searchItem();
            priceSearchResult = sa.getPrice1();
            sa.samsungFlow1();
             productPrice = sa.productPrice();

        }

        [Given(@"samsung in car")]
        public void GivenSamsungInCar()
        {
        
            sa.addCar();
            carprice = sa.carPrice();
            oneproductincar = sa.oneProduct();
        }
        
        [Given(@"user search fo Alien")]
        public void GivenUserSearchFoAlien()
        {
             al = new Alien(driver);

            al.searchAlien();
        }
        
        [Given(@"select the product and add the alien to the car")]
        public void GivenSelectTheProductAndAddTheAlienToTheCar()
        {
            al.selectAlien();
            al.addToCar();


        }

        [Then(@"price result should match with selected samsung")]
        public void ThenPriceResultShouldMatchWithSelectedSamsung()
        {
            Assert.AreEqual(priceSearchResult, productPrice);
        }
        
        [Then(@"price should march with first price and car price")]
        public void ThenPriceShouldMarchWithFirstPriceAndCarPrice()
        {
            Assert.AreEqual(priceSearchResult, carprice);
        }
        
        [Then(@"items in car should be one")]
        public void ThenItemsInCarShouldBeOne()
        {
            Assert.AreEqual(1, oneproductincar);
        }
        
        [Then(@"car number should contains two items")]
        public void ThenCarNumberShouldContainsTwoItems()
        {
            Assert.AreEqual(al.secondProduct(), 2);
        }
    }
}
