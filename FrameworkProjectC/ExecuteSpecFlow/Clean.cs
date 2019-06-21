using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteSpecFlow
{
    public class Clean
    {

        IWebDriver driver;
        public Clean(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void cleanCar()
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));

            IWebElement carrito = driver.FindElement(By.Id("a-autoid-0-announce"));
            wait.Until(driver => carrito.Displayed);
            carrito.Click();


        }

        public void eliminar()
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            IWebElement elimina = driver.FindElement(By.XPath("//input[contains(@aria-label,'Eliminar Monitor Curvo Gamer Alienware AW3418DW 34\" Pantalla LED - Negro')]"));
            wait.Until(driver => elimina.Displayed);
            elimina.Click();

            IWebElement eliminar = driver.FindElement(By.XPath("//input[@aria-label='Eliminar Samsung Galaxy S9 64GB Desbloqueado Negro Medianoche']"));
            wait.Until(driver => eliminar.Displayed);
            eliminar.Click();



        }
        public void eliminaSamsung()
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            IWebElement eliminar = driver.FindElement(By.XPath("//input[@aria-label='Eliminar Samsung Galaxy S9 64GB Desbloqueado Negro Medianoche']"));
            wait.Until(driver => eliminar.Displayed);
            eliminar.Click();
        }
    }
}
