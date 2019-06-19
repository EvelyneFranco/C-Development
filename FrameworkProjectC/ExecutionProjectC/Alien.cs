using FrameworkProjectC;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;



namespace ExecutionProjectC
{
    public class Alien : AlienElements
    {
        IWebDriver driver;
        public Alien(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public void searchAlien()
        {
            AlienElements al = new AlienElements(driver);
            PageFactory.InitElements(driver, al);
            al.searchCriteria("Alienware Aw3418DW");
        }

        public void selectAlien()
        {
            AlienElements al = new AlienElements(driver);
            PageFactory.InitElements(driver, al);
            al.select();
        }

        public void addToCar()
        {
            AlienElements al = new AlienElements(driver);
            PageFactory.InitElements(driver, al);
            al.AddToCar();
        }

        public int secondProduct()
        {
            AlienElements al = new AlienElements(driver);
            PageFactory.InitElements(driver, al);
            return al.secondProductInCar();
        }
    }
}
