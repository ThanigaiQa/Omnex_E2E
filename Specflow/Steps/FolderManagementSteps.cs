using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            docProModule.SelectSiteSubLevelCreationCheckbox();
        }

        // *********** FM : Levels create and delete - End of TC 21861,63,64,65,66,67,69,57 ************ //

        // *********** FM : Levels create and delete - Start of TC 22974-75-76 ************ //

        [Then(@"Validate the user can define the Document number option")]
        public void ThenValidateTheUserCanDefineTheDocumentNumberOption()
        {
            docProModule.ValidateTheUserCanDefineTheDocumentNumber();
        }

        [Then(@"Validate the user can define the revision option")]
        public void ThenValidateTheUserCanDefineTheRevisionOption()
        {
            docProModule.ValidateTheUserCanDefineTheRevisionOption();
        }

        // *********** FM : Levels create and delete - End of TC 22974-75-76 ************ //

        // *********** FM : Levels create and delete - Start of TC 22977 ************ //

        [Then(@"I Right click the New button and validate the inherit from parent option present under Revision")]
        public void ThenIRightClickTheNewButtonAndValidateTheInheritFromParentOptionPresentUnderRevision()
        {
            docProModule.ValidaterevisionOptionasInheritFromParent(scenarioContext["LevelName"].ToString());
        }

        // *********** FM : Levels create and delete - End of TC 22977 ************ //

        // *********** FM : Levels create and delete - Start of TC 22979 ************ //
        
        [Then(@"I Validate revision date option as user input date")]
        public void ThenIValidateRevisionDateOptionAsUserInputDate()
        {
            docProModule.ValidateRevisionDateOptionasUserInputDate();
        }
        
        // *********** FM : Levels create and delete - Start of TC 22979 ************ //

        // *********** FM : Revision Numbering - Start of TC 22978 ************ //

        [Then(@"I assiging value for Revision Date option")]
        public void ThenIAssigingValueForRevisionDateOption()
        {
            docProModule.AssignRevisionDateOption();
        }

        // *********** FM : Revision Numbering - End of TC 22978 ************ //

        // *********** FM : Revision Numbering - Start of TC 22983 ************ //

        [Then(@"I Click the records checkbox")]
        public void ThenIClickTheRecordsCheckbox()
        {
            docProModule.ClickRecordsCheckBox();
        }

        // *********** FM : Revision Numbering - End of TC 22983 ************ //

        // *********** FM : Revision Numbering - Start of TC 22980 ************ //

        [Then(@"I Add the level owner and validate the level owner is added")]
        public void ThenIAddTheLevelOwnerAndValidateTheLevelOwnerIsAdded()
        {
            docProModule.AddlevelOwner();
        }

        [Then(@"I remove the level owner and verify the level owner is removed")]
        public void ThenIRemoveTheLevelOwnerAndVerifyTheLevelOwnerIsRemoved()
        {
            docProModule.RemoveLevelOwner();
        }

        // *********** FM : Revision Numbering - End of TC 22980 ************ //

        // *********** FM : Revision Numbering - Start of TC 22984 ************ //

        [Then(@"I set the Document Reviewed After dropdown value to day and validate that the value is correctly set to day\.")]
        public void ThenISetTheDocumentReviewedAfterDropdownValueToDayAndValidateThatTheValueIsCorrectlySetToDay_()
        {
            docProModule.SetDocumentReviewedAfterDropdownAsDay();
        }

        [Then(@"I set the Revision value")]
        public void ThenISetTheRevisionValue()
        {
            docProModule.SetRevisionValue();
        }

        [Then(@"I validate the revision value is set correctly")]
        public void ThenIValidateTheRevisionValueIsSetCorrectly()
        {
            docProModule.ValidateRevisionValue();
        }

        // *********** FM : Revision Numbering - End of TC 22984 ************ //

        // *********** FM : Levels create and delete - Start of TC 21857,61,63-67,69 ************ //

        [Then(@"I right click on the (.*) level and select (.*) option")]
        public void ThenIRightClickOnTheLevelAndSelectNewOption(string levelName, string option)
        {
            docProModule.RightClickAndSelectNewOptionOnLevel(scenarioContext["LevelName"].ToString(),option);
        }

        [Then(@"I verify the level heading")]
        public void ThenIVerifyTheLevelHeading()
        {
            docProModule.VerifyLevelHeading();
        }

        [Then(@"I give sub level name and save the level")]
        public void ThenIGiveSubLevelNameAndSaveTheLevel()
        {
            docProModule.GiveNewSubLevelNameAndClickSave();
        }

        [Then(@"I click on the folder arrow to open the sublevel")]
        public void ThenIClickOnTheFolderArrowToOpenTheSublevel()
        {
            docProModule.ClickFolderArrowOpen();
        }

        [Then(@"I click on the sub level and verify the level header")]
        public void ThenIClickOnTheSubLevelAndVerifyTheLevelHeader()
        {
           docProModule.ClickSubLevelAndVerifyLevelHeader();
        }

        [Then(@"I right click on the sublevel and select (.*) option")]
        public void ThenIRightClickOnTheSubLevelAndSelectOption(string option)
        {
            switch(option)
            {
                case "Edit":
                   docProModule.RightClickOnSubLevelAndSelectEditOption(option);
                    break;
                case "Delete":
                    docProModule.RightClickOnSubLevelAndSelectDeleteOption(option);
                    break;
                case "Rights for sites":
                    docProModule.RightClickOnSubLevelAndSelectRightsForSiteOption(option);
                    break;
            }
        }

        [Then(@"I edit the sublevel name and save the sublevel")]
        public void ThenIEditTheSublevelNameAndSaveTheSublevel()
        {
            docProModule.GiveUpdatedSubLevelNameAndClickSave();
        }

        [Then(@"I verify the sublevel was not found in RightSite")]
        public void ThenIVerifyTheSublevelWasNotFoundInRightSite()
        {
            docProModule.ClickFolderArrowOpenAndVerifySublevelIsNotFound();
        }

        // *********** FM : Levels create and delete - End of TC 21857,61,63-67,69 ************ //

        // *********** FM : Rights for level - Start of TC 21875 ************ //

        [Then(@"I search for rightsite in document rights page")]
        public void ThenISearchForRightsiteInDocumentRightsPage()
        {
            docProModule.SearchForRightSiteInDocumentRights();
        }

        [Then(@"I click the document management link")]
        public void ThenIClickTheDocumentManagementLink()
        {
            docProModule.ClickDocumentManagementLink();
        }

        [Then(@"validate the manage site document heading")]
        public void ThenValidateTheManageSiteDocumentHeading()
        {
            docProModule.ValidateTheManageSiteDocumentHeading(scenarioContext["LevelName"].ToString());
        }

        // *********** FM : Rights for level - End of TC 21875 ************ //

        // *********** FM : Rights for level - Start of TC 21872 ************ //

        [Then(@"I validate the inherit option should not be selected by default")]
        public void ThenIValidateTheInheritOptionShouldNotBeSelectedByDefault()
        {
            docProModule.ValidateInheritOptionShouldNotBeSelectedByDefault();
        }

        // *********** FM : Rights for level - End of TC 21872 ************ //

        // *********** FM : Rights for level - Start of TC 21873 ************ //

        [Then(@"I validate the inherit option should be selected by default")]
        public void ThenIValidateTheInheritOptionShouldBeSelectedByDefault()
        {
            docProModule.ValidateInheritOptionShouldBeSelectedByDefault();
        }

        // *********** FM : Rights for level - End of TC 21873 ************ //

        // *********** FM : Route - Start of TC 21877_78 ************ //

        [Then(@"I validate the route link is (.*)")]
        public void ThenIValidateTheRouteLinkIs(string state)
        {
            switch(state)
            {
                case "present":
                    docProModule.ValidateRouteLinkIsPresent();
                    break;
                case "not present":
                    docProModule.ValidateRouteLinkIsNotPresent();
                    break;
            }
        }

        // *********** FM : Route - End of TC 21877_78 ************ //

        // *********** FM : Route - End of TC 21879_80 ************ //

        [Then(@"I click on the route link and validate the UI elements")]
        public void ThenIClickOnTheRouteLinkAndValidateTheUIElements()
        {
            docProModule.ValidateUIElementsInRoutePage();
        }

        // *********** FM : Route - End of TC 21879_80 ************ //

        // *********** FM : Rights for level - Start of TC 21876 ************ //

        [Then(@"I click plus icon and I give the full access for the document")]
        public void ThenIClickPlusIconAndIGiveTheFullAccessForTheDocument()
        {
            docProModule.ClickFullAccessCheckboxForDocument();
        }

        [Then(@"I get the attribute and validate the full access checkbox")]
        public void ThenIGetTheAttributeAndValidateTheFullAccessCheckbox()
        {
            docProModule.GetAttributeAndValidateFullAccessCheckBox();
        }

        // *********** FM : Rights for level - End of TC 21876 ************ //
        // *********** FM - 07 : Tag Creation search - Start of TC 22986 ************ //

        [Then(@"I verify the tag selection link is present")]
        public void ThenIVerifyTheTagSelectionLinkIsPresent()
        {
            docProModule.VerifyTagSelectionLinkIsPresent();
        }

        [Then(@"I click on the tag selection link")]
        public void ThenIClickOnTheTagSelectionLink()
        {
            docProModule.ClickTagSelectionLink();
        }

        [Then(@"I search and select the tagname")]
        public void ThenISearchAndSelectTheTagname()
        {
            docProModule.SearchAndSelectTagName();
        }

        // *********** FM - 07 : Tag Creation search - End of TC 22986 ************ //

        #endregion

    }
}
