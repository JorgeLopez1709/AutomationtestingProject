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
        public Button addNewProjectButton = new Button(By.XPath("//*[@id=\"left_menu_inner\"]/div[1]/div[1]/div/div[1]/button"));//mejorar XPATH
        public TextBox projectNameTxtBox = new TextBox(By.Id("edit_project_modal_field_name"));
        public Button saveButton = new Button(By.XPath("//form//button[@type=\"submit\"]"));

        public Button subMenuIcon = new Button(By.XPath("//ul[@id=\"projects_list\"]/li[last()]//button"));
        public Button editButton = new Button(By.XPath("/html/body/div[7]/div[2]/div/ul/li[4]/div[2]/div"));
        //public TextBox projectNameEditTxtBox = new TextBox(By.XPath("//td/div/input[@id='ItemEditTextbox']"));
        //public Button saveButton = new Button(By.XPath("//*[@id=\":rn:\"]/form/footer/div/button[2]"));

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
