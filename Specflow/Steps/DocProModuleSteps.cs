﻿using Microsoft.VisualStudio.TestPlatform.ObjectModel;
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
    public class DocProModuleSteps : ExtentReport
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
        public DocProModuleSteps(DriverContext driverContext, ScenarioContext scenariocontext, FeatureContext featurecontext)
        {
            this.driverContext = driverContext;
            scenarioContext = scenariocontext;
            featureContext = featurecontext;
            loginPage = new LoginPage(driverContext.WebDriver);
            dashboard = new Dashboard(driverContext.WebDriver);
            docProModule = new DocProModule(driverContext.WebDriver);
        }

        #endregion

        #region stepDefinitions

        [Then(@"I validate pending requests menu")]
        public void ThenIValidatePendingRequestsMenu()
        {
            docProModule.ValidateUIElementsOfPendingRequestsMenu();
        }

        // ********************************************* User Actions - 01 Pending Requests ************************************************ //

        // *********** UA - 01 : Pending Request - Start of TC 06 ************ //

        [Then(@"I choose existing level and upload new document with DCN option in doc request page")]
        public void ThenIChooseExistingLevelAndUploadNewDocumentWithDCNOptionInDocRequestPage()
        {
            docProModule.ChooseExistingLevel(scenarioContext["LevelName"].ToString());
            scenarioContext["DocName"] = docProModule.UploadNewDocumentWithEnabledDCN();
        }

        [Then(@"I terminate the DCN enabled document")]
        public void ThenITerminateTheDCNEnabledDocument()
        {
            docProModule.TerminateDocumentWithDCN();
        }

        // *********** UA - 01 : Pending Request - End of TC 06 ************ //

        [Then(@"I verify the document is not present in pending request menu")]
        public void ThenIVerifyTheDocumentIsNotPresentInPendingRequestMenu()
        {
            docProModule.VerifyPendingReqDocIsNotIsPresent(scenarioContext["DocName"].ToString());
        }

        // *********** UA - 01 : Pending Request - Start of TC 07 ************ //

        [Then(@"I validate Requests Needing Approval menu")]
        public void ThenIValidateRequestsNeedingApprovalMenu()
        {
            docProModule.VerifyRequestsNeedingApprovalMenu();
            docProModule.ValidateUIElementsOfRequestsNeedingApprovalMenu();
        }

        [Then(@"I reject the document by providing Second Password")]
        public void ThenIRejectTheDocumentByProvidingSecondPassword()
        {
            docProModule.RejectDocument();
        }

        // *********** UA - 01 : Pending Request - Start of TC 07 ************ //

        // ********************************************* User Actions - 02 Pending Document Draft ************************************************ //

        // *********** UA - 02 : Pending Doc Draft - Start of TC 01 ************ //

        [Then(@"I verify the color code of In Process link")]
        public void ThenIVerifyTheColorCodeOfInProcessLink()
        {
            docProModule.VerifyColorCodeOfStatusValue();
        }

        [When(@"I click the status value link")]
        public void WhenIClickTheStatusValueLink()
        {
            docProModule.ClickStatusValueLink();
        }

        [Then(@"I add comment in the draft")]
        public void ThenIAddCommentInTheDraft()
        {
            docProModule.AddCommentForDraftInDraftReqNeedingMenu();
        }

        [Then(@"I add and verify the user can be added from the draft viewer")]
        public void ThenIAddAndVerifyTheUserCanBeAddedFromTheDraftViewer()
        {
            docProModule.VerifyUserCanBeAddedFromDraftViewer();
        }

        [Then(@"I verify the user can be removed from the draft viewer")]
        public void ThenIVerifyTheUserCanBeRemovedFromTheDraftViewer()
        {
            docProModule.VerifyUserCanBeRemovedFromDraftViewer();
        }

        // *********** UA - 02 : Pending Doc Draft - End of TC 01 ************ //

        // *********** UA - 02 : Pending Doc Draft - Start of TC 05 ************ //

        [Then(@"I validate assign author menu")]
        public void ThenIValidateAssignAuthorMenu()
        {
            docProModule.VerifyAssignAuthorMenu();
        }

        [Then(@"Assign the author for the created document")]
        public void ThenAssignTheAuthorForTheCreatedDocument()
        { 
            docProModule.AssignAuthor();
        }

        [Then(@"I validate the Documents needing revision menu")]
        public void ThenIValidateTheDocumentsNeedingRevisionMenu()
        {
            docProModule.VerifyDocumentsNeedingRevisionMenu();
        }
        [Then(@"I Attach the document")]
        public void ThenIAttachTheDocument()
        {
            docProModule.AttachDocument();
        }
        [Then(@"I give full access from Request Right for the document")]
        public void ThenIGiveFullAccessFromRequestRightForTheDocument()
        {
            docProModule.FullAccessForDocumentFromRequestRight();
        }

        // *********** UA - 02 : Pending Doc Draft - End of TC 05 ************ //

        // *********** UA - 02 : Pending Doc Draft - Start of TC 06 ************ //

        [Then(@"I verify the user who already commented on the draft is not present in draft viewer")]
        public void ThenIVerifyTheUserWhoAlreadyCommentedOnTheDraftIsNotPresentInDraftViewer()
        {
            docProModule.VerifyUserCannotRemovedFromTheDraft();
        }

        // *********** UA - 02 : Pending Doc Draft - End of TC 06 ************ //

        // *********** UA - 02 : Pending Doc Draft - Start of TC 07 ************ //

        [Then(@"I Validate the status column placed at the right most end")]
        public void ThenIValidateTheStatusColumnPlacedAtTheRightMostEnd()
        {
            docProModule.ValidateStatusColumnInRightMostEnd();
        }

        // *********** UA - 02 : Pending Doc Draft - End of TC 07 ************ //

        // *********** UA - 02 : Pending Doc Draft - Start of TC 05 ************ //

        [Then(@"I click on change request button in pending doc draft menu")]
        public void ThenIClickOnChangeRequestButtonInPendingDocDraftMenu()
        {
            docProModule.ClickChangeRequestOnPendingDocDraft();
        }

        [Then(@"I choose the date and enter the reason for change , description in change request screen")]
        public void ThenIChooseTheDateAndEnterTheReasonForChangeDescriptionInChangeRequestScreen()
        {
            docProModule.ChooseDateAndReasonDescriptionInChangeReqScreen();
        }

        [Then(@"I select (.*) in change request screen")]
        public void ThenISelectInChangeRequestScreen(string documentType)
        {
            switch (documentType)
            {
                case "online document":
                    docProModule.SelectOnlineDocumentInChangeReqScreen();
                    break;
                case "Attach Draft":
                    docProModule.SelectAttachDraftInChangeReqScreen();
                    break;

            }
        }

        // *********** UA - 02 : Pending Doc Draft - End of TC 05 ************ //

        // ********************************************* User Actions - 03 Draft Request Needing Viewing ************************************************ //

        // *********** UA - 03 : Draft Request Viewing - Start of TC 02 ************ //

        [Then(@"I validate the Accept and Reject radio button is not present")]
        public void ThenIValidateTheAcceptAndRejectRadioButtonIsNotPresent()
        {
         docProModule.ValidateAcceptAndRejectRadioIsNotPresent();
        }
        [Then(@"I validate the latest comment is present in the draft details page")]
        public void ThenIValidateTheLatestCommentIsPresentInTheDraftDetailsPage()
        {
            docProModule.ValidateLatestCommentIsPresent();
        }

        // *********** UA - 03 : Draft Request Viewing - End of TC 02 ************ //

        // *********** UA - 03 : Draft Req Needing Viewing - Start of TC 01 ************ //

        [Then(@"I add and verify the user can be added from the draft viewer in draft req needing viewing")]
        public void ThenIAddAndVerifyTheUserCanBeAddedFromTheDraftViewerInDraftReqNeedingViewing()
        {
            docProModule.VerifyUserCanBeAddedFromDraftViewerInDraftReqNeedingViewing();
        }

        [Then(@"I reject the draft request in Draft Request Needing Viewing menu")]
        public void ThenIRejectTheDraftRequestInDraftRequestNeedingViewingMenu()
        {
            docProModule.ClickOnRejectRadioButtonInDraftReqNeedingViewingPage();
        }

        // *********** UA - 03 : Draft Req Needing Viewing - End of TC 01 ************ //

        // *********** UA - 02 : Pending Doc Draft - Start of TC 02 ************ //

        [Then(@"I add old comment in the draft")]
        public void ThenIAddOldCommentInTheDraft()
        {
            docProModule.AddOldCommentForDraftInDraftReqNeedingMenu();
        }

        [Then(@"I Click on Reply button to add new comment")]
        public void ThenIClickOnReplyButtonToAddNewComment()
        {
            docProModule.AddNewestCommentDraftRequestsNeedingViewing();
        }

        [Then(@"I Click on In Process button to Validate newest comment")]
        public void ThenIClickOnInProcessButtonToValidateNewestComment()
        {
            docProModule.ValidateNewestCommentfromPendingDocumentDrafts();
        }

        [Then(@"I Click on Reply button to add old comment")]
        public void ThenIClickOnReplyButtonToAddOldComment()
        {
            docProModule.AddOldCommentDraftRequestsNeedingViewing();
        }

        [Then(@"I Click on In Process button to Validate oldest comment")]
        public void ThenIClickOnInProcessButtonToValidateOldestComment()
        {
            docProModule.ValidateOldestCommentFromPendingDocumentDrafts();
        }

        [Then(@"I Click on Reply button to add upvote to the comment")]
        public void ThenIClickOnReplyButtonToAddUpvoteToTheComment()
        {
            docProModule.AddPopularCommentDraftRequestsNeedingViewing();
        }

        [Then(@"I Click on In Process button to Validate upvote comment")]
        public void ThenIClickOnInProcessButtonToValidateUpvoteComment()
        {
            docProModule.ValidatePopularCommentPendingDocumentDrafts();
        }
        
        [Then(@"I Validate the Change Request screen")]
        public void ThenIValidateTheChangeRequestScreen()
        {
            docProModule.SelectAttachDraftWithoutClickingContinue();
        }

        // *********** UA - 02 : Pending Doc Draft - End of TC 02 ************ //

        // *********** UA - 03 : Draft Req Needing Viewing - Start of TC 03 ************ //

        [When(@"I click the Accept radio button")]
        public void WhenIClickTheAcceptRadioButton()
        {
            docProModule.ClickOnAcceptRadioButtonInDraftReqNeedingViewingPage();
        }

        [Then(@"I Validate the Accept and Reject radio is disabled or not")]
        public void ThenIValidateTheAcceptAndRejectRadioIsDisabledOrNot()
        {
            docProModule.ValidateAcceptAndRejectRadioButtonIsDisabled();
        }

        [Then(@"I Validate the background color of Accepted badge")]
        public void ThenIValidateTheBackgroundColorOfAcceptedBadge()
        {
            docProModule.ValidateAcceptedBadgeColor();
        }

        [Then(@"I Validate the background color of Rejected badge")]
        public void ThenIValidateTheBackgroundColorOfRejectedBadge()
        {
            docProModule.ValidateRejectedBadgeColor();
        }

        // *********** UA - 03 : Draft Req Needing Viewing - End of TC 03 ************ //

        // *********** Smoke Cases - Start of TC 04 ************ //

        [Then(@"I edit dropdown values for the level in folder management page")]
        public void ThenIEditDropdownValuesForTheLevelInFolderManagementPage()
        {
            docProModule.EditDropdownsInFolderManagement();
        }

        // *********** Smoke Cases - End of TC 04 ************ //

        #endregion

    }
}
