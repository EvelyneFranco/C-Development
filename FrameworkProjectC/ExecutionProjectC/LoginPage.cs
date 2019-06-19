using FrameworkProjectC;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExecutionProjectC
{
    public class LoginPage :LoginElements
    {
        IWebDriver driver;

        public LoginPage(IWebDriver driver) : base(driver)
        {

            this.driver = driver;
        }



        public void login()
        {
            LoginElements log = new LoginElements(driver);
            PageFactory.InitElements(driver, log);
            log.login();

        }
    }
}
