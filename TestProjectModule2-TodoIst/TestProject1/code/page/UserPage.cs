using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.code.control;

namespace TestProject1.code.page
{
    public class UserPage
    {
        public Button menuButton = new Button(By.XPath("//*[@id=\":r2:\"]/div/img"));
    }
}
