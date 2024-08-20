using OMNEX.AUTOMATION.Helpers;
using OMNEX.AUTOMATION.PageObjects.WEB;
using AventStack.ExtentReports.Gherkin.Model;
using TechTalk.SpecFlow;

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

        #endregion
    }
}