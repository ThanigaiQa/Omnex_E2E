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

        // *********** FM : Levels create and delete - Start of TC 21858 ************ //
        [Then(@"I Validate the Delete should be Disabled")]
        public void ThenIValidateTheDeleteShouldBeDisabled()
        {
            docProModule.ValidateDeleteshouldbedisable(scenarioContext["LevelName"].ToString());
        }
        // *********** FM : Levels create and delete - End of TC 21858 ************ //

        // *********** FM : Levels create and delete - Start of TC 21859 ************ //
        [Then(@"I Validate the New Option should be Disabled")]
        public void ThenIValidateTheNewOptionShouldBeDisabled()
        {
            docProModule.ValidateNewOptionshouldbedisable(scenarioContext["LevelName"].ToString());
        }
        // *********** FM : Levels create and delete - End of TC 21859 ************ //

        // *********** FM : Levels create and delete - Start of TC 21860 ************ //
        [Then(@"I Edit the level by suite administrator")]
        public void ThenIEditTheLevelBySuiteAdministrator()
        {
            docProModule.ValidateEditTheLevel(scenarioContext["LevelName"].ToString());
        }
        // *********** FM : Levels create and delete - End of TC 21860 ************ //

        // *********** FM : Levels create and delete - Start of TC 21855 ************ //

        [Then(@"I validate the document pro heading in document management page")]
        public void ThenIValidateTheDocumentProHeadingInDocumentManagementPage()
        {
            docProModule.ValidateDocumentProHeading();
        }

        // *********** FM : Levels create and delete - End of TC 21855 ************ //


        // *********** FM : Levels create and delete - Start of TC 21870 ************ //

        [Then(@"Validate module levels are not displayed under suite setup")]
        public void ThenValidateModuleLevelsAreNotDisplayedUnderSuiteSetup()
        {
            docProModule.ValidateModuleLevelsAreNotDisplayed();
        }

        // *********** FM : Levels create and delete - End of TC 21870 ************ //

        // *********** FM : Levels create and delete - Start of TC 21861,63,64,65,66,67,69,57 ************ //

        [Then(@"I give sublevel access for the level")]
        public void ThenIGiveSublevelAccessForTheLevel()
        {
            
        }

        // *********** FM : Levels create and delete - End of TC 21861,63,64,65,66,67,69,57 ************ //


        #endregion

    }
}
