using OpenQA.Selenium;
using PetShopAuto.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;


namespace PetShopAuto.Tests
{
    class BaseTest
    {
        public IWebDriver driver;

        public LogInPage loginPage;

        public Actions actions;


        [SetUp]
        public void OneTimeSetUp()
        {
            var options = new ChromeOptions();
            options.AddUserProfilePreference("profile.password_manager_enabled", false);
            options.AddArguments("--disable-search-engine-choice-screen");
            options.AddUserProfilePreference("profile.cookie_controls_mode", 1); // Block third-party cookies

            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            actions = new Actions(driver);

            loginPage = new LogInPage(driver);

            loginPage.OpenPage();
            loginPage.PerformLogin("kraska7a_", "0897727710ksr_");
        }

        [TearDown]
        public void OneTimeTearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
