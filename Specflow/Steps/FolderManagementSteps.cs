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

        [Then(@"I gave the access for site modification site sub level creation")]
        [When(@"I gave the access for site modification site sub level creation")]
        public void ThenIGaveTheAccessForSiteModificationSiteSubLevelCreation()
        {
            docProModule.SelectSiteSubLevelCreationAndAllowSiteCheckbox();
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

        // *********** FM - 08 : Site PDF Preference - Start of TC 23015,16 ************ //

        [Then(@"I disable the Enhanced printing checkbox to verify the template is option is disabled")]
        public void ThenIDisableTheEnhancedPrintingCheckboxToVerifyTheTemplateIsOptionIsDisabled()
        {
            docProModule.DisableEnhancedPrintingCheckboxToVerifyTemplateDropdown();
        }

        [Then(@"I enable the Enhanced printing checkbox to verify the template is option is enabled")]
        public void ThenIEnableTheEnhancedPrintingCheckboxToVerifyTheTemplateIsOptionIsEnabled()
        {
            docProModule.EnableEnhancedPrintingCheckboxToVerifyTemplateDropdown();
        }

        // *********** FM - 08 : Site PDF Preference - End of TC 23015,16 ************ //


        // *********** FM - 08 : SitePDFPreference - Start of TC 23020 ************ //

        [When(@"I Click the Include Template checkbox")]
        public void WhenIClickTheIncludeTemplateCheckbox()
        {
         docProModule.ClickIncludeTemplateCheckBox();
        }

        [Then(@"I validate The Include Template checkBox is checked")]
        public void ThenIValidateTheIncludeTemplateCheckBoxIsChecked()
        {
         docProModule.ValidateIncludeTemplateCheckboxIsChecked();
        }

        // *********** FM - 08 : SitePDFPreference - End of TC 23020 ************ //

        // *********** FM - 08 : SitePDFPreference - Start of TC 23017,18 ************ //

        [When(@"I Click the Enable Restricted view checkbox")]
        public void WhenIClickTheEnableRestrictedViewCheckbox()
        {
            docProModule.ClickEnableRestrictedViewCheckBox();
        }

        [Then(@"I validate The Enable Restricted view checkBox is checked")]
        public void ThenIValidateTheEnableRestrictedViewCheckBoxIsChecked()
        {
            docProModule.ValidateEnableRestrictedViewCheckboxIsChecked();
        }

        // *********** FM - 08 : SitePDFPreference - End of TC 23017,18 ************ //

        // *********** FM - 08 : SitePDFPreference - Start of TC 23023-25 ************ //

        [Then(@"I click on the multi search button")]
        [When(@"I click on the multi search button")]
        public void ThenIClickOnTheMultiSearchButton()
        {
            docProModule.ClickMultiSearchButton();
        }

        [Then(@"I verify the UI elements of Multisearch popup window")]
        public void ThenIVerifyTheUIElementsOfMultisearchPopupWindow()
        {
            docProModule.ValidateMultiSearchWindow();
        }

        [Then(@"I search document type using multi search and verify the record size")]
        public void ThenISearchDocumentTypeUsingMultiSearchAndVerifyTheRecordSize()
        {
            docProModule.SearchWithDocTypeAndVerifyRecordSize();
        }

        [When(@"I click on the refresh button in (.*) page")]
        public void WhenIClickOnTheRefreshButtonInPage(string pageName)
        {
            switch(pageName)
            {
                case "Site PDF":
                    docProModule.ClickRefreshButtonInSitePDFPage();
                    break;
                case "level":
                    docProModule.ClickRefreshButtonInLevelsPage();
                    break;
            }
        }

        [When(@"I verify the size of the records showing in Site PDF Preference page")]
        public void WhenIVerifyTheSizeOfTheRecordsShowingInSitePDFPreferencePage()
        {
            docProModule.VerifyRecordSizeAfterRefresh();
        }

        [Then(@"I search and update the Site PDF record")]
        public void ThenISearchAndUpdateTheSitePDFRecord()
        {
            docProModule.SearchDocTypeAndUpdateTheRecord();
        }

        // *********** FM - 08 : SitePDFPreference - End of TC 23023-25 ************ //


        // *********** FM - 02 : LevelPDFPreference - Start of TC 22999 ************ //

        [Then(@"I click the Level PDF preferences link")]
        public void ThenIClickTheLevelPDFPreferencesLink()
        {
        docProModule.VerifyLevelPDFPreferencesLinkAndClickIt();
        }

        [Then(@"I validate the Level PDF Preferences page heading")]
        public void ThenIValidateTheLevelPDFPreferencesPageHeading()
        {
            docProModule.ValidateLevelPDFPreferencesPageHeading();
        }

        [Then(@"I verify all UI elements on the Level PDF Preferences page")]
        public void ThenIVerifyAllUIElementsOnTheLevelPDFPreferencesPage()
        {
            docProModule.ValidateUIElementsInLevelPDFPreferencesPage();
        }

        // *********** FM - 02 : LevelPDFPreference - End of TC 22999 ************ //

        // *********** FM - 10 : Suite levels - Start of TC 01 ************ //

        [Then(@"I validate the DocPro landing screen is showing instead of displaying level details")]
        public void ThenIValidateTheDocProLandingScreenIsShowingInsteadOfDisplayingLevelDetails()
        {
            docProModule.ValidateDocProLandingScreen();
        }

        // *********** FM - 10 : Suite levels - End of TC 01 ************ //

        // *********** FM - 10 : Suite levels - End of TC 02 ************ //

        [Then(@"I validate the level color '([^']*)' making the level in use")]
        [When(@"I validate the level color '([^']*)' making the level in use")]
        public void ThenIValidateTheLevelColorMakingTheLevelInUse(string state)
        {
            switch (state)
            {
                case "before":
                    docProModule.ValidateLevelColorBeforeInUse();
                    break;
                case "after":
                    docProModule.ValidateLevelColorAfterInUse();
                    break;
            }
        }

        // *********** FM - 10 : Suite levels - End of TC 02 ************ //

        // *********** FM - 10 : Suite levels - Start of TC 03 ************ //

        [Then(@"I validate only edit option is enabled without making the level in use")]
        public void ThenIValidateOnlyEditOptionIsEnabledWithoutMakingTheLevelInUse()
        {
            docProModule.ValidateEditOptionIsEnabledBeforeLevelInuse();
        }

        // *********** FM - 10 : Suite levels - End of TC 03 ************ //


        // *********** Satrt of EwQIMS_10814_Click on select hyperlink -************ //

        [Then(@"I navigate to levels and click edit icon")]
        public void ThenINavigateToLevelsAndClickEditIcon()
        {
            docProModule.NavigateAndClickEditIconForLevels(scenarioContext["LevelName"].ToString());
        }

        [Then(@"I verify the tag selection link is present in levels page")]
        public void ThenIVerifyTheTagSelectionLinkIsPresentInLevelsPage()
        {
            docProModule.VerifyTagSelectionLinkIsPresentInLevelsPage();
        }

        [Then(@"I click on the tag selection link in levels page")]
        public void ThenIClickOnTheTagSelectionLinkInLevelsPage()
        {
            docProModule.ClickTagSelectionLinkInLevelsPage();
        }

        [Then(@"I search and select the tagname in levels page")]
        public void ThenISearchAndSelectTheTagnameInLevelsPage()
        {
            docProModule.SearchAndSelectTagNameInLevelsPage();
        }

        // *********** End of EwQIMS_10814_Click on select hyperlink -************ //

        // *********** Satrt of EwQIMS_10820_Display selected Tags in Folder Management -************ //

        [Then(@"I set the Document Reviewed After dropdown value to Month in levels page")]
        public void ThenISetTheDocumentReviewedAfterDropdownValueToMonthInLevelsPage()
        {
            docProModule.SetDocumentReviewedAfterDropdownAsMonthInLevelsPage();
        }

        [Then(@"I verify the tag selection is present in folder Management")]
        public void ThenIVerifyTheTagSelectionIsPresentInFolderManagement()
        {
          docProModule.VerifyTagSelectionLinkIsPresentInFolderManagement();
        }

        // *********** End of EwQIMS_10820_Display selected Tags in Folder Management -************ //

        // *********** Start of EwQIMS_10809_Validate whether the selected Tag can be edited   -************ //

        [Then(@"I Click and uncheck the selected tag in levels page")]
        public void ThenIClickAndUncheckTheSelectedTagInLevelsPage()
        {
          docProModule.ClickAndUncheckTheSelectedTagInLevelsPage();
        }

        [Then(@"I search and select any other tagname in levels page")]
        public void ThenISearchAndSelectAnyOtherTagnameInLevelsPage()
        {
            docProModule.SearchAndSelectOtherTagNameInLevelsPage();
        }

        // *********** End of EwQIMS_10809_Validate whether the selected Tag can be edited   -************ //

        // *********** Start of  EwQIMS-430_Validate the user can enable allow site modification   -************ //

        [Then(@"I Verify the site modification checkbox is enabled")]
        public void ThenIVerifyTheSiteModificationCheckboxIsEnabled()
        {
            docProModule.VerifyAllowSiteModificationCheckboxIsChecked();
        }

        // *********** End of  EwQIMS-430_Validate the user can enable allow site modification   -************ //

        // *********** Start of  EwQIMS-431_Validate the user can disable allow site modification   -************ //

        [Then(@"I uncheck the site modification checkbox and verify the checkbox is Unchecked")]
        public void ThenIUncheckTheSiteModificationCheckboxAndVerifyTheCheckboxIsUnchecked()
        {
            docProModule.UncheckAllowSiteModificationCheckboxAndVerifyTheCheckboxIsUnchecked();
        }

        // ***********  End of EwQIMS-431_Validate the user can disable allow site modification   -************ //

        // *********** Start of EwQIMS-47452 Validate special characters in level name and Prefix   -************ //

        [Then(@"I enter special characters into the Prefix field and verify that it accepts them")]
        public void ThenIEnterSpecialCharactersIntoThePrefixFieldAndVerifyThatItAcceptsThem()
        {
            docProModule.TestSpecialCharacterAcceptanceInPrefixField();
        }

        // *********** End of EwQIMS-47452 Validate special characters in level name and Prefix   -************ //

        // ***********  Start of EwQIMS-47491_validate whether the system accepts the space as a character to create Level name ************ //

        [Then(@"I validate the (.*) field should not accept blank space as input")]
        public void ThenIValidateTheLevelNameFieldShouldNotAcceptBlankSpaceAsInput(string value)
        {
            switch(value)
            {
                case "level name":
                    docProModule.ValidateLevelNameCannotBeEmpty();
                    break;
                case "level number":
                    docProModule.ValidateLevelNumberCannotBeEmpty();
                    break;
            }
        }

        // ***********  End of EwQIMS-47491_validate whether the system accepts the space as a character to create Level name ************ //

        // ***********  End of EwQIMS-47494_To validate whether the system accepts the all special characters to create in the level name ************ //

        [Then(@"I validate the (.*) field should is accepting special characters as input")]
        public void ThenIValidateTheLevelNameFieldShouldIsAcceptingSpecialCharactersAsInput(string value)
        {
            switch (value)
            {
                case "level name":
                    scenarioContext["LevelNameWithSpecialCharacters"] = docProModule.ValidateLevelNameAcceptsSpecialCharacter();
                    break;
                case "prefix":
                    scenarioContext["PrefixFieldWithSpecialCharactersLevel"] = docProModule.ValidatePrefixFieldAcceptsSpecialCharacter();
                    break;
            }
        }

        [Then(@"I delete the (.*) with special characters")]
        public void ThenIDeleteTheLevelNameWithSpecialCharacters(string value)
        {
            switch (value)
            {
                case "level name":
                    docProModule.DeleteLevelByHovering(scenarioContext["LevelNameWithSpecialCharacters"].ToString());
                    break;
                case "prefix":
                    docProModule.DeleteLevelByHovering(scenarioContext["PrefixFieldWithSpecialCharactersLevel"].ToString());
                    break;
            }
        }

        // ***********  End of EwQIMS-47494_To validate whether the system accepts the all special characters to create in the level name ************ //

        // ***********  Start of EwQIMS-15739_To validate whether the system accepts the user can enter alphabet (Upper and Lower) in Level Name/Prefix field ************ //

        [Then(@"I validate the level name and prefix field should is accepting upper and lower characters characters as input")]
        public void ThenIValidateTheLevelNameAndPrefixFieldShouldIsAcceptingUpperAndLowerCharactersCharactersAsInput()
        {
            scenarioContext["LevelNameWithUpperAndLowercase"] = docProModule.ValidateLevelNameAndPrefixFieldAcceptsUpperAndLowercase();
        }

        [Then(@"I delete the level name with Upper and lower character")]
        public void ThenIDeleteTheLevelNameWithUpperAndLowerCharacter()
        {
            docProModule.DeleteLevelByHovering(scenarioContext["LevelNameWithUpperAndLowercase"].ToString());
        }

        // ***********  End of EwQIMS-15739_To validate whether the system accepts the user can enter alphabet (Upper and Lower) in Level Name/Prefix field ************ //

        // *********** Start of  EwQIMS-439_Delete validation with dependency ************ //

        [Then(@"I validate that the level is not deleted and a dependency alert message is displayed")]
        public void ThenIValidateThatTheLevelIsNotDeletedAndADependencyAlertMessageIsDisplayed()
        {
            docProModule.VerifyDependencyAlertMessageWhileDeleteLevel();
        }

        // *********** End of  EwQIMS-439_Delete validation with dependency ************ //

        // *********** Start of EwQIMS-15733: Edit Level Number ************ //

        [Then(@"I validate the level number field is disabled after clicking no in level num alert popup")]
        public void ThenIValidateTheLevelNumberFieldIsDisabledAfterClickingNoInLevelNumAlertPopup()
        {
            docProModule.ValidateLevelNumberFieldIsDisabled();
        }

        // *********** End of EwQIMS-15733: Edit Level Number ************ //

        // *********** Start of EwQIMS-32426: Parent Level Name Hierarchy ************ //

        [Then(@"I right click the (.*) level and click new option")]
        public void ThenIRightClickTheLevelAndClickNewOption(string level)
        {
            switch (level)
            {
                case "random":
                    docProModule.RightClickParentLevelAndClickNew(scenarioContext["LevelName"].ToString());
                    break;
                case "subfolder":
                    docProModule.RightClickSubFolderLevelAndClickNew(scenarioContext["SubfolderLevelName"].ToString());
                    break;
            }
        }

        [Then(@"I create a new subfolder level")]
        public void ThenICreateANewSubfolderLevel()
        {
            scenarioContext["SubfolderLevelName"] = docProModule.CreateNewSubfolderLevel();
        }

        [Then(@"I verify the subfolder is created for the parent level")]
        public void ThenIVerifyTheSubfolderIsCreatedForParentTheLevel()
        {
            docProModule.VerifySubFolderIsCreatedInsideParentLevel(scenarioContext["LevelName"].ToString(), scenarioContext["SubfolderLevelName"].ToString());
        }

        [Then(@"I create new Subchild level")]
        public void ThenICreateNewSubchildLevel()
        {
            scenarioContext["SubChildLevelName"] = docProModule.CreateNewSubChildLevel();
        }

        [Then(@"I verify the Subchild level is created for the subfolder")]
        public void ThenIVerifyTheSubchildLevelIsCreatedForTheSubfolder()
        {
            docProModule.VerifySubChildIsCreatedInsideSubFolderLevel(scenarioContext["LevelName"].ToString(), scenarioContext["SubfolderLevelName"].ToString(), scenarioContext["SubChildLevelName"].ToString());
        }

        // *********** End of EwQIMS-32426: Parent Level Name Hierarchy ************ //

        // *********** Start of EwQIMS-47529: Parent Level Name blank for creating a new parent level ************ //

        [Then(@"I validate the parent level name field is greyed out before giving input")]
        public void ThenIValidateTheParentLevelNameFieldIsGreyedOutBeforeGivingInput()
        {
            docProModule.ValidateLevelNameFieldIsGreyedOutBeforeGivingAnyInput();
        }

        // *********** End of EwQIMS-47529: Parent Level Name blank for creating a new parent level ************ //

        // *********** Start of EwQIMS-22144: DOC-Display selected template ************ //

        [Then(@"I select template from the dropdown")]
        public void ThenISelectTemplateFromTheDropdown()
        {
            docProModule.SelectTemplateFromTemplateDropdown();
        }

        [Then(@"I verify the template is selected and reset to default")]
        public void ThenIVerifyTheTemplateIsSelectedAndResetToDefault()
        {
            docProModule.VerifyTemplateIsSelectedAndResetToDefault();
        }

        // *********** End of EwQIMS-22144: DOC-Display selected template ************ //

        // *********** level PDF preference - Start of TC 22153 22154 ************ //

        [Then(@"I Validate the Refresh action")]
        public void ThenIValidateTheRefreshAction()
        {
            docProModule.ValidateRefreshsInLevelPDFPreferencesPage();
        }

        // *********** level PDF preference - end of TC 22153 22154 ************ //

        // *********** level PDF preference - Start of TC 22150 ************ //

        [Then(@"I create a new template in Pdf template page")]
        public void ThenICreateANewTemplateInPdfTemplatePage()
        {
            docProModule.CreateNewTemplateInPDfTemplatePage();
        }

        [Then(@"I verify the newly created template is visible in the template dropdown")]
        public void ThenIVerifyTheNewlyCreatedTemplateIsVisibleInTheTemplateDropdown()
        {
            docProModule.VerifyNewTemplateIsVisibleFromTemplateDropdown();
        }

        [Then(@"I delete the newly created template in Pdf template page")]
        public void ThenIDeleteTheNewlyCreatedTemplateInPdfTemplatePage()
        {
            docProModule.DeleteNewlyCreatedTemplateInPdfTemplate();
        }

        // *********** level PDF preference - end of TC 22150 ************ //

        // *********** PDF Template - start of TC 17931 ************ //

        [Then(@"I create a new template in Pdf template page without saving and verify it is not created")]
        public void ThenICreateANewTemplateInPdfTemplatePageWithoutSavingAndVerifyItIsNotCreated()
        {
            docProModule.CreateANewTemplateInPdfTemplatePageWithoutSavingAndVerifyItIsNotCreated();
        }

        // *********** PDF Template - end of TC 17931 ************ //

        // *********** PDF Template - start of TC 18034 ************ //

        [Then(@"I edit the existing template and verify template in Pdf template page")]
        public void ThenIEditTheExistingTemplateAndVerifyTemplateInPdfTemplatePage()
        {
            docProModule.EditAndVerifyExistingPDFTemplate();
        }

        // *********** PDF Template - end of TC 18034 ************ //

        // *********** PDF Template - start of TC-17938,TC-17939,TC-17941 ************ //

        [Then(@"I navigate to create PDF Template window and verify the user can set review date,next review date in data field")]
        public void ThenINavigateToCreatePDFTemplateWindowAndVerifyTheUserCanSetReviewDateNextReviewDateInDataField()
        {
            docProModule.NavigateToPDFTempCreationWindowAndVerifyDataFields();
        }

        // *********** PDF Template - end of TC-17938,TC-17939,TC-17941 ************ //

        // *********** PDF Template - start of TC-18039-18041 ************ //

        [Then(@"I verify the header , footer and include cover page details on pdf template screen")]
        public void ThenIVerifyTheHeaderFooterAndIncludeCoverPageDetailsOnPdfTemplateScreen()
        {
            docProModule.EnterValuesInHeaderFooterAndIncludeCoverPageSection();
            docProModule.VerifyValuesInHeaderFooterAndIncludeCoverPageSection();
        }

        // *********** PDF Template - end of TC-18039-18041 ************ //

        // *********** PDF Template - start of TC-18024 ************ //

        [Then(@"I validate User  can Check the checkboxes in Include Water Mark, Include header, footer, Cover page")]
        public void ThenIValidateUserCanCheckTheCheckboxesInIncludeWaterMarkIncludeHeaderFooterCoverPage()
        {
            docProModule.VerifyCheckboxesFromTemplateName();
        }
        // *********** PDF Template - end of TC-18024  ************ //

        #endregion

    }
}
