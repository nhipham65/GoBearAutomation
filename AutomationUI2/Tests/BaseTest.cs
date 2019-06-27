using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AutomationUI.Test
{
    class BaseTest
    {
        protected IWebDriver WebDriver;

        [SetUp]
        public void SetUp()
        {
            WebDriver = new ChromeDriver();
            WebDriver.Manage().Window.Maximize();

            WebDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);

            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

        }

        [TearDown]
        public void TearDown()
        {
           WebDriver.Close();
           WebDriver.Quit();
        }
    }
}
