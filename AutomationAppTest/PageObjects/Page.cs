using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationAppTest.PageObjects
{
    public static class Page
    {

        public static T GetPage<T>(IWebDriver webDriver) where T : IPage, new()
        {
            var page = new T();

            page.InitPageObjects(webDriver);

            return page;
        }

    }
}
