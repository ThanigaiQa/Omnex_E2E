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

        // *********** UA - 02 : Pending Doc Draft - Start of TC 01 ************ //

        [Then(@"I verify the color code of In Process link")]
        public void ThenIVerifyTheColorCodeOfInProcessLink()
        {
            docProModule.VerifyColorCodeOfStatusValue();
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


        #endregion

    }
}
