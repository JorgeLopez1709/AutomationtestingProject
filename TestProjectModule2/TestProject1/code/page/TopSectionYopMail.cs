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
    public class TopSectionYopMail
    {
               
        public Boolean AccountNameIsDisplayed()
        {
            Label nameProject = new Label(By.XPath("//div[@class=\"bname\"]"));
            return nameProject.IsControlDisplayed();
        }

        public Boolean MailDeletedMessageIsDisplayed()
        {
            Label mailDeletedMessage = new Label(By.XPath("//div[@id=\"message\"]"));
            return mailDeletedMessage.IsControlDisplayed();
        }

    }
}
