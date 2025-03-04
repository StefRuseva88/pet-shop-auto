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
        public void Verify_Successful_Login()
        {
            loginPage.PerformLogin("username", "password");
            Assert.That(homePage.MyProfile.Displayed, Is.True);
        }
    }
}
