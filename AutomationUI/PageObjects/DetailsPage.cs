using AutomationUI.Constants;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace AutomationUI.PageObjects
{
    class DetailsPage : BasePage
    {
        //Select element for Details function by Pocicy Type section
        public IWebElement radiobuttonPolicyTypeDetails(string policyTypeName)
        {
            return WebDriver.FindElement(By.XPath($"//div[contains(@class,'edit-detail')]//div[contains(@class,'field')]//div[label[contains(.,'{policyTypeName}')]]/label"));

        }
        //Select element for Details function by Who's Going section
        public IWebElement radiobuttonWhoGoing(string whogoingName)
        {
            return WebDriver.FindElement(By.XPath($"//div[contains(@class,'field-wrap')]//div[contains(@class,'gb-radio-group')]//div[label[contains(., '{whogoingName}')]]/label"));

        }
        //Select element for Details function by clicking on Destination dropdown
        public IWebElement buttonDropdownDestination => WebDriver.FindElement(By.XPath("//div[@data-gb-name='destinations']//button"));


        //Select element for Details function by selecting Destination dropdown item
        public IWebElement dropdownDestinationItem(string destinationName)
        {
            return WebDriver.FindElement(By.XPath($"//div[@data-gb-name='destinations']//div[@class='dropdown-menu open']//li[contains(.,'{destinationName}')]"));

        }
        //Select element for Details function by clicking TRAVEL START DATE date picker
        public IWebElement fieldDatePicker => WebDriver.FindElement(By.XPath("//input[@name='dates-startdate']"));

        //Select element for Details function by selecting date from TRAVEL START DATE date picker
        public IWebElement dateDatePicker(string dateSection)
        {
            return WebDriver.FindElement(By.XPath($"//td[contains(@class,'day') and text()='{dateSection}']"));

        }

        public DetailsPage(IWebDriver driver) : base(driver) { }

        // Select Details function by Pocicy Type section
        public void SelectRadioButtonPolicyTypeDetails()
        {
            string policyTypeName = "annual trip";

            radiobuttonPolicyTypeDetails(policyTypeName).Click();

            Thread.Sleep(TimeSpan.FromSeconds(2));
        }
        // Select Details function by Who's Going section
        public void SelectRadioButtonWhoGoing()
        {
            string whogoingName = "5 persons";

            radiobuttonWhoGoing(whogoingName).Click();

            Thread.Sleep(TimeSpan.FromSeconds(2));
        }
        // Select Details function by clicking on Destination dropdown
        public void ClickDropdownDestination()
        {

            buttonDropdownDestination.Click();

            Thread.Sleep(TimeSpan.FromSeconds(2));
        }
        // Select Details function by selecting Destination dropdown
        public void SelectDropdownDestination()
        {
            string destinationName = "Asia";

            dropdownDestinationItem(destinationName).Click();

            Thread.Sleep(TimeSpan.FromSeconds(2));
        }
        // Select Details function by clicking TRAVEL START DATE date picker
        public void ClickDateTimePicker()
        {

            fieldDatePicker.Click();

            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        // Select Details function by selecting date from TRAVEL START DATE date picker
        public void SelectDateTimePicker()
        {
            string dateSection = "23";

            dateDatePicker(dateSection).Click();

            Thread.Sleep(TimeSpan.FromSeconds(2));
        }
    }
}
