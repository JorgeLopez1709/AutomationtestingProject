using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.code.page;

namespace TestProject1.code.test
{
    [TestClass]
    public class LoginTest : TestBase
    {
        MainPage mainPage = new MainPage();
        LoginPage loginPage = new LoginPage();
        UserPage userPage = new UserPage();

        [TestMethod]
        public void VerifyTheLoginIsSuccessfully()
        {
            mainPage.loginButton.Click();
            loginPage.Login("jorge.e.lopez.1709@gmail.com", "Password1234");
            Assert.IsTrue(userPage.menuButton.IsControlDisplayed(),
                "ERROR !! the login was not successfully, review credentials please");


        }


    }
}
