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
    public class LoginElements
    {

        IWebDriver driver;
        ConfigurationFile cf = new ConfigurationFile();

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Hola, Identifícate')]")]
        public IWebElement identificarse { get; set; }

        [FindsBy(How = How.Id, Using = "ap_email")]
        public IWebElement email { get; set; }

        [FindsBy(How = How.Id, Using = "ap_password")]
        public IWebElement pass { get; set; }

        [FindsBy(How = How.Id, Using = "signInSubmit")]
        public IWebElement button { get; set; }


        public LoginElements(IWebDriver driver)
        {
            this.driver = driver;
            //PageFactory.InitElements(driver, this);
        }




        public void login()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));

                wait.Until(driver => identificarse.Displayed);
                identificarse.Click();

                wait.Until(driver => email.Displayed);
                cf.readXmlFile();
                email.SendKeys(cf.getUsername());
                pass.SendKeys(cf.getPassword());
                button.Click();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
