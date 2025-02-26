using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using PetShopAuto.Pages;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Security.Cryptography.X509Certificates;

namespace PetShopAuto.Pages
{
    public class LogInPage : BasePage
    {
        public LogInPage(IWebDriver driver) : base(driver)
        {
           
        }

        public static string Url => BaseUrl + "/my-account-2/edit-account";
        public IWebElement UserNameField => driver.FindElement(By.CssSelector("#username"));
        public IWebElement PasswordField => driver.FindElement(By.CssSelector("#password"));
        public IWebElement LoginBtn => driver.FindElement(By.CssSelector("#customer_login > div.u-column1.col-1 > form > p:nth-child(3) > button"));

        public IWebElement UserNameErrorMsg => driver.FindElement(By.CssSelector("#post-176 > div > div > div.woocommerce-notices-wrapper > ul > li > strong"));

        public IWebElement PasswordErrorMsg => driver.FindElement(By.CssSelector("#post-176 > div > div > div.woocommerce-notices-wrapper > ul > li"));

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(Url);
        }

        public void PerformLogin(string username, string password)
        {
            UserNameField.Clear();
            UserNameField.SendKeys(username);

            PasswordField.Clear();
            PasswordField.SendKeys(password);

            LoginBtn.Click();
        }
    }
}
