using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.code.control;
using TestProject1.code.session;
using static System.Net.Mime.MediaTypeNames;

namespace TestProject1.code.page
{
    public class IfMailSectionYopMail
            {
        
              
        public TextBox toTextBox = new TextBox(By.Id("msgto"));
        public TextBox subjectTextBox = new TextBox(By.Id("msgsubject"));
        public TextBox msgBody = new TextBox(By.Id("msgbody"));
        public Button sendButton = new Button(By.Id("msgsend"));
        
        public Boolean ConfirmationMessageIsDisplayed()
        {
            Label confirmationMessage = new Label(By.XPath("//div[@id=\"msgpopmsg\"]"));
            return confirmationMessage.IsControlDisplayed();
        }

        public Boolean SubjectMailIsDisplayed(string subject)
        {
            Label subjectMail = new Label(By.XPath(String.Format("//div[@class=\"fl\"]/div[text()=\"{0}\"]",subject)));
            return subjectMail.IsControlDisplayed();
        }
               
        public void ChangeToIfMailIframe()
        {
            Session.Instance().GetBrowser().SwitchTo().ParentFrame();
            Session.Instance().GetBrowser().SwitchTo().Frame("ifmail");
        }

        public void DeleteSelectedMail()
        {
            Button deleteButton = new Button(By.XPath("//header//button[@onclick=\"w.suppr_mail();\"]"));
            deleteButton.Click();
        }

    }
}
