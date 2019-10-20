using MyApp;
using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationAppTest
{
    [Binding]
    public class MySpecFlowFeatureSteps
    {
        private int result;
        private Calculator calculator = new Calculator();

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            calculator.FirstNumber = number;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            calculator.SecondNumber = number;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = calculator.Add();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }


        [Given(@"I have a website url")]
        public void GivenIHaveAWebsiteUrl()
        {
            Helper.OpenBootstrapSite();
            ScenarioContext.Current.Pending();
        }

        [When(@"I launch the browser")]
        public void WhenILaunchTheBrowser()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"It should navigate to the given url")]
        public void ThenItShouldNavigateToTheGivenUrl()
        {
            ScenarioContext.Current.Pending();
        }





    }


}
