using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using AutomationAppTest.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationAppTest
{
    public static class Helper
    {

        public static  void OpenBrowser()
        {
            //System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"C:\Users%USERNAME%\AppData\Local\Google\Chrome\Application\chrome.exe");
            using (IWebDriver driver = new ChromeDriver(Environment.CurrentDirectory))
            {
                //Notice navigation is slightly different than the Java version
                //This is because 'get' is a keyword in C#
                driver.Navigate().GoToUrl("http://www.google.com/");

                // Find the text input element by its name
                IWebElement query = driver.FindElement(By.Name("q"));

                // Enter something to search for
                query.SendKeys("Cheese");

                // Now submit the form. WebDriver will find the form for us from the element
                query.Submit();

                // Google's search is rendered dynamically with JavaScript.
                // Wait for the page to load, timeout after 10 seconds
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until(d => d.Title.StartsWith("cheese", StringComparison.OrdinalIgnoreCase));

                // Should see: "Cheese - Google Search" (for an English locale)
                Console.WriteLine("Page title is: " + driver.Title);
            }
        }
        public static void OpenBootstrapSite()
        {
            //System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"C:\Users%USERNAME%\AppData\Local\Google\Chrome\Application\chrome.exe");
            using (IWebDriver driver = new ChromeDriver(Environment.CurrentDirectory))
            {

                driver.Manage().Window.Maximize();

                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);

                //Notice navigation is slightly different than the Java version
                //This is because 'get' is a keyword in C#
                driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.3/components/dropdowns/");


                //var page = AutomationAppTest.PageObjects.Page.GetPage<HomePage>(driver);

                //page.SearchBox.SendKeys("Cheese");

                //// Find the text input element by its name
                IWebElement query = driver.FindElement(By.Id("dropdownMenuButton"));


                query.Click();


                var jsElement = ((IJavaScriptExecutor)driver).ExecuteScript("document.getElementById('search-input').value='TEST'");


                //driver.SwitchTo().Alert().Accept();

                var selectElement = driver.FindElement(By.XPath("/html/body/div/div/main/div[2]/div/div/a[1]"));

               var dropDownText = selectElement.Text;

                selectElement.Click();


               // var selectElement = new SelectElement(query);

                //selectElement.SelectByText("Action");


                //Assert.AreEqual("Action", selectElement.SelectedOption.Text);
                //// Enter something to search for
                //query.SendKeys("Cheese");

                // Now submit the form. WebDriver will find the form for us from the element
                //query.Submit();


                // Should see: "Cheese - Google Search" (for an English locale)
                Console.WriteLine("Page title is: " + driver.Title);


                driver.Quit();
            }
        }
    }
}
