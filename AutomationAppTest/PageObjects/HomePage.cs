using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationAppTest.PageObjects
{
    public class HomePage : IPage
    {
        private IWebDriver _webDriver;

        [FindsBy(How = How.Name, Using = "q")]
        public IWebElement SearchBox => _webDriver.FindElement(By.Name("q"));

        public void InitPageObjects(IWebDriver webDriver)
        {
            _webDriver = webDriver;

        }
    }
}
