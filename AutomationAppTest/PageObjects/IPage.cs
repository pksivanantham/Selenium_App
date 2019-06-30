using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationAppTest.PageObjects
{
    public interface IPage 
    {
        void InitPageObjects(IWebDriver webDriver);
   }
}
