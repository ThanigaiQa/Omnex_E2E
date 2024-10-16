using OMNEX.AUTOMATION.Helpers;
using OMNEX.AUTOMATION.PageObjects.WEB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace OMNEX.AUTOMATION.Specflow.Steps
{
    [Binding]
    public class FolderManagementSteps : ExtentReport
    {

        #region Declaration
        private DriverContext driverContext;
        private LoginPage loginPage;
        public ScenarioContext scenarioContext;
        public FeatureContext featureContext;
        private Dashboard dashboard;
        private DocProModule docProModule;

        #endregion

        #region Constructor
        public FolderManagementSteps(DriverContext driverContext, ScenarioContext scenariocontext, FeatureContext featurecontext)
        {
            this.driverContext = driverContext;
            scenarioContext = scenariocontext;
            featureContext = featurecontext;
            loginPage = new LoginPage(driverContext.WebDriver);
            dashboard = new Dashboard(driverContext.WebDriver);
            docProModule = new DocProModule(driverContext.WebDriver);
        }

        #endregion

        #region StepDefinitions

        [Then(@"I verify the (.*) level heading in Folder management menu")]
        public void ThenIVerifyTheLevelHeadingInFolderManagementMenu(string levelName)
        {
            docProModule.VerifyLevelHeadingInFolderManagement(scenarioContext["LevelName"].ToString());
        }

        [Then(@"I Validate the Delete should be Disabled")]
        public void ThenIValidateTheDeleteShouldBeDisabled()
        {
            docProModule.ValidateDeleteshouldbedisable(scenarioContext["LevelName"].ToString());
        }

        [Then(@"I Validate the New Option should be Disabled")]
        public void ThenIValidateTheNewOptionShouldBeDisabled()
        {
            docProModule.ValidateNewOptionshouldbedisable(scenarioContext["LevelName"].ToString());
        }

        [Then(@"I Edit the level by suite administrator")]
        public void ThenIEditTheLevelBySuiteAdministrator()
        {
            docProModule.ValidateEditTheLevel(scenarioContext["LevelName"].ToString());
        }

        // *********** FM : Levels create and delete - Start of TC 21855 ************ //

        [Then(@"I validate the document pro heading in document management page")]
        public void ThenIValidateTheDocumentProHeadingInDocumentManagementPage()
        {
            docProModule.ValidateDocumentProHeading();
        }
        // *********** FM : Levels create and delete - End of TC 21855 ************ //

        #endregion

    }
}
