using BoDi;
//using GoogleSearchResultTest;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Hooks
{
    [Binding]
    public sealed class Hooks
    {

        private IWebDriver webDriver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            webDriver.Quit();
        }
    }
}
