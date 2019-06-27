using OpenQA.Selenium;

namespace AutomationUI.PageObjects
{
    class TravelInsurancePage : BasePage
    {
        //Select element for Show My Results
        public IWebElement buttonShowMyResult => WebDriver.FindElement(By.XPath("//div[@id='travel-form']//button[contains(text(),'Show my results')]"));

        public TravelInsurancePage(IWebDriver driver) : base(driver) { }

        //Click Show My Results button
        public void ClickShowMyResultButton()
        {
            buttonShowMyResult.Click();
        }
    }
}
