using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.code.factoryBrowser
{
    public class FactoryBrowser
    {

        public static IBrowser Make(string type)
        {
            IBrowser browser;

            switch (type)
            {
                case "chrome":
                    browser = new Chrome();
                    break;
                case "grid":
                    browser = new Grid();
                    break;
                default:
                    browser = new Chrome();
                    break;
            }
            return browser;
        }
    }
}
