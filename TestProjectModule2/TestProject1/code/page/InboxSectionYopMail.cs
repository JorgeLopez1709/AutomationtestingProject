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
    public class InboxSectionYopMail
    {
        public Button newMailButton = new Button(By.Id("newmail"));
        
        public void ClickRefreshInbox()
        {
            Button refreshButton = new Button(By.Id("refresh"));
            refreshButton.Click();
        }

        public void ClickMail(String subject)
        {
            Button mailItem = new Button(By.XPath(String.Format("//button[div[text()=\"{0}\"]]", subject)));
            mailItem.Click();
        }
        public void ChangeToInboxMailIframe()
        {
            Session.Instance().GetBrowser().SwitchTo().ParentFrame();
            Session.Instance().GetBrowser().SwitchTo().Frame("ifinbox");
        }
    }
}
