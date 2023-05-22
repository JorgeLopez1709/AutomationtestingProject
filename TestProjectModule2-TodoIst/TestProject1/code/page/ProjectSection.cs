using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.code.control;
using static System.Net.Mime.MediaTypeNames;

namespace TestProject1.code.page
{
    public class ProjectSection
    {
       

        public Button projectMenuIcon = new Button(By.XPath("//div[@class=\"view_header__content\"]//button[last()]"));
        public Button deleteButton = new Button(By.XPath("//li[@role=\"menuitem\"][last()]//div[last()]"));
        public Button confirmDeleteButton = new Button(By.XPath("//button[@type=\"submit\"]"));
        public Boolean ProjectNameIsDisplayed(String nameValue)
        {
            Label nameProject = new Label(By.XPath("//h1[@role=\"heading\"]/span[text()='" + nameValue + "']"));
            return nameProject.IsControlDisplayed();
        }

        
    }
}
