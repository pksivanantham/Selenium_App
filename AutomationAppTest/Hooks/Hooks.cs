using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace AutomationAppTest.Hooks
{
    [Binding]
    public class Hooks
    {
        private IWebDriver _webDriver;
        public Hooks(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        [AfterScenario]
        public void AfterScenario()
        {
            _webDriver.Quit();
        }
    }
}
