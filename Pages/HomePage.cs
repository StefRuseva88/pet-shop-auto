using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopAuto.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {

        }
        public static string Url => BaseUrl + "/";

        public IWebElement MyProfile => driver.FindElement(By.CssSelector("#menu-item-7319 > a > span"));

        public IWebElement LogoutBtn => driver.FindElement(By.CssSelector("#menu-item-11808 > a > span"));

        public IWebElement LogoutLink => driver.FindElement(By.CssSelector("#post-176 > div > div > div > div > div > a"));

        public IWebElement Footer => driver.FindElement(By.CssSelector(".below-footer font"));

        public IWebElement Logo => driver.FindElement(By.CssSelector("#menu-item-11808 > a > span"));

        public IWebElement SeeHere => driver.FindElement(By.CssSelector("#thunk-2col-slider > div > div.thunk-slider-content > div > div.owl-stage-outer > div > div:nth-child(3) > div > div > h2 > a"));

        public IWebElement Promotions => driver.FindElement(By.CssSelector("#thunk-2col-slider > div > div.thunk-add-content > div > div:nth-child(1) > a > img"));

        public IWebElement NaturalDelicious => driver.FindElement(By.CssSelector("#thunk-2col-slider > div > div.thunk-add-content > div > div:nth-child(2) > a > img"));

        public IWebElement Shipping => driver.FindElement(By.CssSelector("#custom_html-23 > div > i:nth-child(2)"));

        public IWebElement Discounts => driver.FindElement(By.CssSelector("#primary > div > section.thunk-product-highlight-section > div > div > div:nth-child(3) > div > div.content > h6"));

        public IWebElement BestSellers => driver.FindElement(By.CssSelector("#primary > div > section.thunk-product-highlight-section > div > div > div:nth-child(4) > div > div.content > h6"));

    }
}
