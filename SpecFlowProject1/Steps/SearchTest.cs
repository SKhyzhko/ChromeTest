using OpenQA.Selenium;
using SpecFlowProject1.POM;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public sealed class SearchTest
    {

        private readonly GoogleSearchPage searchPage;
        private readonly GooglePage googlePage;

        public SearchTest(IWebDriver webDriver)
        {
            searchPage = new GoogleSearchPage(webDriver);
            googlePage = new GooglePage(webDriver);
        }

        [Given(@"Navigate ChromeTest")]
        public void GivenNavigateChromeTest()
        {
        }

        [Given(@"Open Gooogle Search page")]
        public void GivenOpenGooogleSearchPage()
        {
            searchPage.Navigate(InputData.StartUrl);
        }

        [Given(@"Enter ""(.*)"" in search field")]
        public void GivenEnterInSearchField(string p0)
        {
            searchPage.SetSearchField(InputData.ToSearch);
        }

        [When(@"Press enter button")]
        public void WhenPressEnterButton()
        {
            searchPage.PressEnter();
        }

        [Then(@"Verify that (.*) first results contains needed keyword")]
        public void ThenVerifyThatFirstResultsContainsNeededKeyword(int p0)
        {
            googlePage.AreEnoughTitles(InputData.numberOfTitles);
            googlePage.AreTitlesContainWord(InputData.ToSearch, InputData.numberOfTitles);
        }

    }
}
