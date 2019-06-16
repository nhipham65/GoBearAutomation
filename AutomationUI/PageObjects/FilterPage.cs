using AutomationUI.Constants;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace AutomationUI.PageObjects
{
    class FilterPage : BasePage
    {
        //Select element for INSURERS section
        public IWebElement checkboxInsurer(string insurerName)
        {
            return WebDriver.FindElement(By.XPath($"//div[label[@class='title' and contains(.,'Insurers')]]//div[contains(@class,'gb-checkbox-group')]//div[label[contains(., '{insurerName}')]]/label"));
        }

        public FilterPage(IWebDriver driver) : base(driver) { }

        //Select Checkbox for INSURERS section
        public void SelectCheckboxInsurers()
        {
            string insurerName = "Pacific Cross";

            checkboxInsurer(insurerName).Click();

            Thread.Sleep(TimeSpan.FromSeconds(2));
        }
    }
}
