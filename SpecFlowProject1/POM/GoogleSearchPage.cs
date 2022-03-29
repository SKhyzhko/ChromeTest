using OpenQA.Selenium;
using SpecFlowProject1.Waiters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.POM
{
    class GoogleSearchPage : BasePageObject
    {

        private readonly By _SearchField = By.XPath("//input[@class='gLFyf gsfi']");

        public GoogleSearchPage(IWebDriver driver) : base(driver) { }

        public void Navigate(string url)
        {
            webDriver.Navigate().GoToUrl(url);
            WaitUntil.ShouldLoad(webDriver, url);
        }

        public GoogleSearchPage SetSearchField(string search)
        {
            WaitUntil.WaitElement(webDriver, _SearchField);
            webDriver.FindElement(_SearchField).SendKeys(search);
            return new GoogleSearchPage(webDriver);
        }

        public GooglePage PressEnter(bool expected = true)
        {
            webDriver.FindElement(_SearchField).SendKeys(Keys.Enter);
            return new GooglePage(webDriver);
        }
    }
}