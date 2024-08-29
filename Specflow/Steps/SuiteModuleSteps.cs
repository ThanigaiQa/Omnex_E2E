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
        // *************** Starts of TC 01 ***************//

        [Then(@"Validate the remember me option")]
        public void ThenValidateTheRememberMeOption()
        {
            dashboard.ValidateTheRememberme();
        }


        // ************** Start of TC 08 ****************** //

        [Then(@"I create a customer")]
        public void ThenICreateACustomer()
        {
            scenarioContext["CustomerName"] = dashboard.CreateCustomer();
        }

        [Then(@"I add address,contact and verify the address and contact is added")]
        public void ThenIAddAddressContactAndVerifyTheAddressAndContactIsAdded()
        {
            dashboard.AddAddress();
            dashboard.AddContact();
        }

        [Then(@"I change the page record size")]
        public void ThenIChangeThePageRecordSize()
        {
            dashboard.ChangePageRecordSize();
        }

        [Then(@"I delete the customer")]
        public void ThenIDeleteTheCustomer()
        {
            dashboard.DeleteCustomerFromTheRecords(scenarioContext["CustomerName"].ToString());
        }

        // ************** End of TC 08 ****************** //

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

        // ************** Start of TC 07 ****************** //

        [Then(@"I create a manufacturer")]
        public void ThenICreateAManufacturer()
        {
            scenarioContext["ManufacturerName"] = dashboard.CreateManufacturer();
        }

        [Then(@"I delete the manufacturer")]
        public void ThenIDeleteTheManufacturer()
        {
            dashboard.DeleteManufacturerFromTheRecords(scenarioContext["ManufacturerName"].ToString());
        }

        // ************** End of TC 07 ****************** //

        // ************** Start Of TC 05 ***************** //

        [Then(@"I create a vendor")]
        public void ThenICreateAVendor()
        {
            scenarioContext["VendorName"] = dashboard.CreateVendor();   
        }

        [Then(@"I delete the vendor")]
        public void ThenIDeleteTheVendor()
        {
            dashboard.DeleteVendor(scenarioContext["VendorName"].ToString());
        }

        // ************** End of TC 05 ****************** //

        // ************** Starts of TC 21 ****************** //

        [Then(@"Update the Organization profile details")]
        public void ThenUpdateTheOrganizationProfileDetails()
        {
            dashboard.OrganizationDetailsUpdate();
        }

        // ************** End of TC 21 ****************** //

        // ************** Start Of TC 11 ***************** //

        private string createdPosition;
        [When(@"I create a position for site '([^']*)'")]
        public void WhenICreateAPositionForSite(string site)
        {
            createdPosition = dashboard.CreatePosition(site);
        }

        [Then(@"verify the position is created")]
        public void ThenVerifyThePositionIsCreated()
        {
           dashboard.VerifyPosition(createdPosition);
        }

        [Then(@"I Delete the position")]
        public void ThenIDeleteThePosition()
        {
            dashboard.DeletePosition();
        }

        // ************** End of TC 11 ****************** //

        // **************Starts of TC 22 **************** //


        [Then(@"Update the Admin Setting details")]
        public void ThenUpdateTheAdminSettingDetails()
        {
            dashboard.updateAndValidateAdminSetting();
        }



        // ************** Start Of TC 20 ***************** //

        [Then(@"I Select country ""([^""]*)"" and add the city ""([^""]*)""")]
        public void ThenISelectCountryAndAddTheCity(string country, string city)
        {
            dashboard.CreateCity(country,city);
        }

        [Then(@"I Validate the newely created ""([^""]*)"" and the city ""([^""]*)""")]
        public void ThenIValidateTheNewelyCreatedAndTheCity(string country, string city)
        {
            dashboard.VerifyCity(country,city);
        }

        [Then(@"I delete the city")]
        public void ThenIDeleteTheCity()
        {
           dashboard.DeleteCity();
        }

        // ************** End of TC 20 ****************** //

        // ************** Start of TC 24 ****************** //

        [Then(@"I create a Entity")]
        public void ThenICreateAEntity()
        {
           scenarioContext["EntityName"] = dashboard.CreateEntity();
        }

        [Then(@"I assign owner to the entity")]
        public void ThenIAssignOwnerToTheEntity()
        {
            dashboard.AssignOwnerToEntity(scenarioContext["EntityName"].ToString());
        }

        [Then(@"I delete the Entity")]
        public void ThenIDeleteTheEntity()
        {
            dashboard.DeleteEntity(scenarioContext["EntityName"].ToString());
        }

        // ************** End of TC 24 ****************** //

        // ************** Start of TC 23 ****************** //

        [Then(@"I create country")]
        public void ThenICreateCountry()
        {
            scenarioContext["CountryName"] = dashboard.CreateCountry();
        }

        [Then(@"I create state")]
        public void ThenICreateState()
        {
            dashboard.CreateState(scenarioContext["CountryName"].ToString());
        }

        [Then(@"I create city")]
        public void ThenICreateCity()
        {
            dashboard.CreateCity(scenarioContext["CountryName"].ToString());
        }

        [Then(@"I delete city")]
        public void ThenIDeleteCity()
        {
            dashboard.DeleteCity(scenarioContext["CountryName"].ToString());
        }

        [Then(@"I delete state")]
        public void ThenIDeleteState()
        {
            dashboard.DeleteState(scenarioContext["CountryName"].ToString());
        }

        [Then(@"I delete country")]
        public void ThenIDeleteCountry()
        {
            dashboard.DeleteCountry(scenarioContext["CountryName"].ToString());
        }

        // ************** End of TC 23 ****************** //

        #endregion
    }
}