using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.POM
{
    public class BasePageObject
    {
        protected IWebDriver webDriver;

        public BasePageObject(IWebDriver driver)
        {
            webDriver = driver;
        }
    }
}