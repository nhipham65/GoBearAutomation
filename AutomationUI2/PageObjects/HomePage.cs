using AutomationUI.Constants;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace AutomationUI.PageObjects
{
    class HomePage : BasePage
    {
        //Select element for Insurance link
        public IWebElement spanInsurance => WebDriver.FindElement(By.XPath("//li[@class='dp-navbar__item']//span[contains(text(),'Insurance')]"));

        //Select element for Travel Insurance link 
        public IWebElement aTravelInsurance => WebDriver.FindElement(By.XPath("//div[span[text()='Compare insurance']]//a[@href='/ph/travel-insurance']"));

        public HomePage(IWebDriver driver) : base(driver) { }

        //Go to Home page
        public void GotoHome()
        {
            WebDriver.Navigate().GoToUrl(GoBearConstants.URL);

            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        //Click Travel Insurance under Insurance link 
        public void GotoTravelInsurance()
        {
            HoverOn(spanInsurance);

            aTravelInsurance.Click();

            Thread.Sleep(TimeSpan.FromSeconds(2));
        }
    }
}
