using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkProjectC
{
   public class BrowserSetUp
    {

        IWebDriver driver;
        
        public IWebDriver browser()
        {
            return driver = new FirefoxDriver();
        }

        public void browserUrl()
        {
            ConfigurationFile cf = new ConfigurationFile();
            cf.readXmlFile();
            driver.Navigate().GoToUrl(cf.getUrl());
        }
    }
}
