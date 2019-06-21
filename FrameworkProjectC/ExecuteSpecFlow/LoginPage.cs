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
    public class LoginPage : LoginElements
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
