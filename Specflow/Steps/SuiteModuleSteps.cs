using OMNEX.AUTOMATION.Helpers;
using OMNEX.AUTOMATION.PageObjects.WEB;
using AventStack.ExtentReports.Gherkin.Model;
using TechTalk.SpecFlow;
using System.Diagnostics.Metrics;

namespace OMNEX.AUTOMATION.Specflow.Steps
{
    [Binding]
    public class SuiteModuleSteps : ExtentReport
    {
        #region Declaration
        private DriverContext driverContext;
        private LoginPage loginPage;
        public ScenarioContext scenarioContext;
        public FeatureContext featureContext;
        private Dashboard dashboard;

        #endregion

        #region Constructor
        public SuiteModuleSteps(DriverContext driverContext, ScenarioContext scenariocontext, FeatureContext featurecontext)
        {
            this.driverContext = driverContext;
            scenarioContext = scenariocontext;
            featureContext = featurecontext;
            loginPage = new LoginPage(driverContext.WebDriver);
            dashboard = new Dashboard(driverContext.WebDriver);
        }
        #endregion

        #region stepDefinitions

        // ************** Start of TC 02 ****************** //

        [Then(@"I click on the add button and Create new tag")]
        public void ThenIClickOnTheAddButtonAndCreateNewTag()
        {
            dashboard.ClickAddButtonAndCreateNewTag();
        }

        [Then(@"I click the newly created tag and rename the tagname")]
        public void ThenIClickTheNewlyCreatedTagAndRenameTheTagname()
        {
            dashboard.RenameTagName();
        }

        [Then(@"I click on the newly created tag and delete the tag")]
        public void ThenIClickOnTheNewlyCreatedTagAndDeleteTheTag()
        {
            dashboard.DeleteTag();
        }

        // ************** End of TC 02 ****************** //

        // ************** Start of TC 09 ****************** //

        [Then(@"I create the team")]
        public void ThenICreateTheTeam()
        {
           dashboard.CreateTeam();
        }

        [Then(@"I verify the team is created")]
        public void ThenIVerifyTheTeamIsCreated()
        {
            dashboard.VerifyTeamIsCreated();
        }

        [Then(@"I delete the team and verify the alert message")]
        public void ThenIDeleteTheTeamAndVerifyTheAlertMessage()
        {
            dashboard.VerifyTeamIsDeleted();
        }

        // ************** End of TC 09 ****************** //

        // ************** Start of TC 03 **************** //

        [Then(@"I create state and verify the state is created")]
        public void ThenICreateStateAndVerifyTheStateIsCreated(string Country, string State)
        {
            dashboard.ClickAddButtonAndCreateNewState(Country, State);
        }

        [Then(@"I Select ""([^""]*)"" and add the ""([^""]*)""")]
        public void ThenISelectAndAddThe(string country, string state)
        {
            dashboard.ClickAddButtonAndCreateNewState(country, state);
        }

        

        [Then(@"I Validate the newely created ""([^""]*)"" and ""([^""]*)""")]
        public void ThenIValidateTheNewelyCreatedAnd(string country, string state)
        {
            dashboard.ValidateStateCreation(country, state);
        }



        [Then(@"I delete the state")]
        public void ThenIDeleteTheState()
        {
            dashboard.DeleteState();
        }

        // ************** End of TC 03 ****************** //

        // ************** Start Of TC 04 ***************** //

        [When(@"I Navigate to (.*) page")]
        public void WhenINavigateToShiftPage(String subHead)
        {
            dashboard.NavigateToSystemPage(subHead);
        }

        [Then(@"I Create shift and I verify the shift is created")]
        public void ThenICreateShiftAndIVerifyTheShiftIsCreated()
        {
            dashboard.CreateNewShift();  
        }

        [Then(@"I Delete the shift")]
        public void ThenIDeleteTheShift()
        {
            dashboard.DeleteShift();
        }

        // ************** End of TC 04 ****************** //

        // ************** Start Of TC 13 ***************** //

        [Then(@"I Create country and I verify the country is created")]
        public void ThenICreateCountryAndIVerifyTheCountryIsCreated()
        {
            dashboard.CreateNewCountry();
        }

        [Then(@"I Delete the country")]
        public void ThenIDeleteTheCountry()
        {
            dashboard.DeleteCountry();   
        }

        // ************** End of TC 13 ****************** //

        #endregion
    }
}