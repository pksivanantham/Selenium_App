using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace AutomationAppTest.Hooks
{   [Binding]
    public class DriverSetup
    {
        private IObjectContainer _objectContainer;

        public IWebDriver webDriver;
        public DriverSetup(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }
        [BeforeScenario]
        public void BeforeScenarioHook()
        {
            webDriver = new ChromeDriver(Environment.CurrentDirectory);

            _objectContainer.RegisterInstanceAs(webDriver);
        }

    }
}
