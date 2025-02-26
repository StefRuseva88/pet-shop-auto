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
        public void Verify_Login_With_Valid_Credentials()
        {
           
        }

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
            //#post-10 > div > div > div.woocommerce-notices-wrapper > ul > li
        }
    }
}
