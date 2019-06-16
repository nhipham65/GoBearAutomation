using AutomationUI.Constants;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace AutomationUI.PageObjects
{
    class SortPage : BasePage
    {
        //Select element for Sort section
       public IWebElement radiobuttonSort(string sortName)
        {
            return WebDriver.FindElement(By.XPath($"//div[contains(@class,'sort-detail')]//div[contains(@class, 'gb-radio-group field')]//div[label[contains(., '{sortName}')]]/label"));

        }

        public SortPage(IWebDriver driver) : base(driver) { }

        //Select Sort Radio Button
        public void SelectRadioButtonSort()
        {
            string sortName = "Insurer: A to Z";
            
            radiobuttonSort(sortName).Click();
            
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }
    }
}
