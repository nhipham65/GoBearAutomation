using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace AutomationUI.PageObjects
{
    class BasePage
    {
        protected readonly IWebDriver WebDriver;

        public BasePage(IWebDriver driver)
        {
            WebDriver = driver;
        }

        public void HoverOn(IWebElement webElement)
        {
            Actions action = new Actions(WebDriver);

            action.MoveToElement(webElement).Build().Perform();
        }
    }
}
