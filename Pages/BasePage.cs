using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using PetShopAuto.Pages;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;


namespace PetShopAuto.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;
        protected Actions actions;
        protected static string BaseUrl = "https://petzone.bg";

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public IWebElement LoginLink => driver.FindElement(By.CssSelector("#menu-item-7319 > a > span"));
        
        public IWebElement LoginHereBtn => driver.FindElement(By.XPath("#customer_login > div.u-column1.col-1 > form > p:nth-child(3) > button"));
    }
}
