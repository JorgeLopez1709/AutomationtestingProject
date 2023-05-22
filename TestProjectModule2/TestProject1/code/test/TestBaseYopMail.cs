using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.code.test
{
    public class TestBaseYopMail
    {
        [TestInitialize]
        public void OpenBrowser()
        {
            session.Session.Instance().GetBrowser().Navigate().GoToUrl("https://yopmail.com/");
        }

        [TestCleanup]
        public void CloseBrowser()
        {
            session.Session.Instance().CloseBrowser();
        }
    }
}
