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
    public class LeftMenu
    {
        public Button addNewProjectButton = new Button(By.XPath("//div[@id=\"left_menu_inner\"]//button[@class=\"_8313bd46 f169a390 _8b7f1a82 _8644eccb _2a3b75a1\"]"));
        public TextBox projectNameTxtBox = new TextBox(By.Id("edit_project_modal_field_name"));
        public Button saveButton = new Button(By.XPath("//form//button[@type=\"submit\"]"));

        public Button subMenuIcon = new Button(By.XPath("//ul[@id=\"projects_list\"]/li[last()]//button"));
        public Button editButton = new Button(By.XPath("//li[@role=\"menuitem\"]//div[contains(text(),'Edit')]"));
        
        public Boolean ProjectNameIsDisplayed(String nameValue)
        {
            Label nameProject = new Label(By.XPath(String.Format("//ul[@id=\"projects_list\"]/li[last()]//span[text()=\"{0}\"][last()]",nameValue)));
            return nameProject.IsControlDisplayed();
        }

        public void ClickProjectName(String nameValue)
        {
            Label nameProject = new Label(By.XPath(String.Format("//ul[@id=\"projects_list\"]/li[last()]//span[text()=\"{0}\"][last()]", nameValue)));
            nameProject.Click();
        }
    }
}
