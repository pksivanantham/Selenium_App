using AutomationAppTest.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace AutomationAppTest
{
    [Binding]
    public class GitHubRepoTestSteps
    {

        private  readonly IWebDriver _driver;

        private GitHubPage gitHubPage;
        public GitHubRepoTestSteps(IWebDriver webDriver)
        {
            _driver = webDriver;//new ChromeDriver(Environment.CurrentDirectory);

            _driver.Manage().Window.Maximize();

            gitHubPage = Page.GetPage<GitHubPage>(_driver);
        }
        

        [Given(@"I have a github repo url")]
        public void GivenIHaveAGithubRepoUrl()
        {
            //ScenarioContext.Current.Pending();
        }
        [Given(@"I entered the '(.*)'")]
        public void GivenIEnteredThe(string url)
        {
            OpenGithubPage(url);
        }
        [Given(@"I cliked on the Repository tab")]
        public void GivenIClikedOnTheRepositoryTab()
        {
            ClickOnSearchTab();

        }

        [When(@"I Search with repo name '(.*)'")]
        public void WhenISearchWithRepoName(string repoName)
        {
            EnterValueInSearch(repoName);
        }


        [Then(@"I should able to see the repo page in github with the name '(.*)'")]
        public void ThenIShouldAbleToSeeTheRepoPageInGithub(string repoName)
        {
            VerifyRepoisPresent(repoName);
        }

        public  void OpenGithubPage(string url)
        {
          
            _driver.Navigate().GoToUrl(url);            

            Assert.IsNotNull(gitHubPage.ProfileIcon);            
        }

        public  void ClickOnSearchTab()
        {
            gitHubPage.RepositoryTab.Click();

        }

        public  void EnterValueInSearch(string repoName)
        {
            gitHubPage.SearchTextBox.SendKeys(repoName);            
        }

        public  void VerifyRepoisPresent(string repoName)
        {
            Assert.IsTrue(_driver.FindElement(By.LinkText(repoName)).Displayed);

        }

        [Then(@"I add the following data")]
        public void ThenIAddTheFollowingData(Table table)
        {
            var value = table.Rows[0]["key"];
        }


    }
}
