using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.code.factoryBrowser;
using TestProject1.code.page;
using TestProject1.code.session;

namespace TestProject1.code.test
{
    [TestClass]
    public class ProjectTest : TestBase
    {

        MainPage mainPage = new MainPage();
        LoginPage loginSection = new LoginPage();
        LeftMenu leftMenu = new LeftMenu();
        ProjectSection projectSection = new ProjectSection();
        

        [TestMethod]
        public void VerifyCRUDProject()
        {
            mainPage.loginButton.Click();
            loginSection.Login("jorge.e.lopez.1709@gmail.com", "Password1234");
            leftMenu.addNewProjectButton.Click();
            leftMenu.projectNameTxtBox.SetText("Mojix909090");
            leftMenu.saveButton.Click();
            Console.WriteLine("hola2");
            // add verificacion
            Assert.IsTrue(leftMenu.ProjectNameIsDisplayed("Mojix909090"), "ERROR!The project was not created");

            leftMenu.ClickProjectName("Mojix909090");
            leftMenu.subMenuIcon.Click();
            leftMenu.editButton.Click();
            leftMenu.projectNameTxtBox.SetText("MojixUpdateddddd");
            leftMenu.saveButton.Click();

            // add verificacion
            Assert.IsTrue(leftMenu.ProjectNameIsDisplayed("MojixUpdateddddd"), "ERROR!The project was not updated");


            leftMenu.ClickProjectName("MojixUpdateddddd");
            projectSection.projectMenuIcon.Click();
            projectSection.deleteButton.Click();

            Thread.Sleep(2000);
            //Session.Instance().GetBrowser().SwitchTo().ActiveElement();
            projectSection.confirmDeleteButton.Click();
            Thread.Sleep(1000);
            // add verificacion
            Assert.IsFalse(leftMenu.ProjectNameIsDisplayed("MojixUpdateddddd"), "ERROR!The project was not deleted");


        }

    }
}
