using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.code.control;
using TestProject1.code.session;

namespace TestProject1.code.page
{
    public class MainPageYopMail

    {
        public TextBox EmailImputTextBox = new TextBox(By.Id("login"));
        public Button loginButton = new Button(By.XPath("//div[@id=\"refreshbut\"]/button"));

        public void ChangeToMainIframe()
        {
            Session.Instance().GetBrowser().SwitchTo().DefaultContent();
        }

               
    }

}
