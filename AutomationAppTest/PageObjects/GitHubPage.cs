using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace AutomationAppTest.PageObjects
{
    public class GitHubPage : IPage
    {
        private IWebDriver _webDriver;
        public void InitPageObjects(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public IWebElement ProfileIcon => _webDriver.WaitForElementToPresent(By.ClassName("avatar"));
        public IWebElement RepositoryTab => _webDriver.WaitForElementToPresent(By.CssSelector("a[href='/pksivanantham?tab=repositories']"));
        public IWebElement SearchTextBox => _webDriver.WaitForElementToPresent(By.Id("your-repos-filter"));



    }
}
