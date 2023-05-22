using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.code.control;

namespace TestProject1.code.page
{
    internal class LoginPage
    {
        public TextBox emailTxtBox = new TextBox(By.Id("element-0"));
        public TextBox pwdTxtBox = new TextBox(By.Id("element-3"));
        public Button loginButton = new Button(By.XPath("//form/button"));
        public void Login(String user, String pwd)
        {
            emailTxtBox.SetText(user);
            pwdTxtBox.SetText(pwd);
            loginButton.Click();
        }
    }
}
