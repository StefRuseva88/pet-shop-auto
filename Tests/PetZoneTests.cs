using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopAuto.Tests
{
    class PetZoneTests : BaseTest
    {
        [Test]
        public void Verify_Error_Message_for_Login_With_Empty_UserName()
        {
            loginPage.PerformLogin("", "password");

            Assert.That(loginPage.UserNameErrorMsg.Text, Is.EqualTo("Грешка:"));
        }

        [Test]
        public void Verify_Error_Message_for_Login_With_Empty_Password()
        {
            loginPage.PerformLogin("username", "");
            Assert.That(loginPage.PasswordErrorMsg.Text, Is.EqualTo("Грешка: Липсва парола."));
        }

        [Test]
        public void Verify_Error_Message_for_Login_With_Invalid_Credentials()
        {
            loginPage.PerformLogin("invalid", "invalid");
            Assert.That(loginPage.UnouthorizedErrorMsg.Text, Is.EqualTo("Грешка: Потребителското име invalid не е разпознато за сайта. Ако не сте сигурни, можете да позлвате имейл адреса."));
        }

        [Test]
        public void Verify_Logout_Button_Readirects_Successfully()
        {
            loginPage.PerformLogin("kraska7a_", "0897727710ksr_");

            homePage.LogoutBtn.Click();
            homePage.LogoutLink.Click();
            Assert.That(loginPage.UserNameField.Displayed, Is.True);
        }

        [Test]
        public void Verify_Footer_With_All_Rights_Reserved()
        {
            loginPage.PerformLogin("kraska7a_", "0897727710ksr_");
            actions.MoveToElement(homePage.Footer).Perform();
            Assert.That(homePage.Footer.Text, Is.EqualTo("© 2023 Petzone.bg. Всички права запазени."));
        }
    }
}
