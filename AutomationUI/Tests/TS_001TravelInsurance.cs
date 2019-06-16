using AutomationUI.PageObjects;
using NUnit.Framework;
using System;
using System.Threading;

namespace AutomationUI.Test
{
    [TestFixture]
    class TS_001TravelSection : BaseTest
    {
        [Test]
        public void TC_001VerifyBasicGoal()
        {
            //Go to Home page and then go to Travel Insurance page
            HomePage homePage = new HomePage(WebDriver);

            homePage.GotoHome();

            homePage.GotoTravelInsurance();

            //Click Show My Results button to go to Travel results page
            TravelInsurancePage travelInsurancePage = new TravelInsurancePage(WebDriver);

            travelInsurancePage.ClickShowMyResultButton();

           //Filter function
            FilterPage filterPage = new FilterPage(WebDriver);

            filterPage.SelectCheckboxInsurers();

            //Sort function
            SortPage sortPage = new SortPage(WebDriver);

            sortPage.SelectRadioButtonSort();

            //Details function
            DetailsPage detailsPage = new DetailsPage(WebDriver);

            //Select Details function by Pocicy Type section
            detailsPage.SelectRadioButtonPolicyTypeDetails();

            //Select Details function by Who's Going section
            detailsPage.SelectRadioButtonWhoGoing();

            //Select Details function by clicking on Destination dropdown
            detailsPage.ClickDropdownDestination();
            
            //Select Details function by selecting Destination dropdown
            detailsPage.SelectDropdownDestination();

            //Select Details function by clicking TRAVEL START DATE date picker
            detailsPage.ClickDateTimePicker();

            //Select Details function by selecting date from TRAVEL START DATE date picker
            detailsPage.SelectDateTimePicker();

        }
    }
}
