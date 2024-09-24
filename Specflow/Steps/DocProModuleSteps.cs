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
            docProModule.VerifyPendingRequestsMenu();
            docProModule.ValidateUIElementsOfPendingRequestsMenu();
        }

        // *********** Start of TC 06 ************ //

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

        // *********** End of TC 06 ************ //

        [Then(@"I verify the document is not present in pending request menu")]
        public void ThenIVerifyTheDocumentIsNotPresentInPendingRequestMenu()
        {
            docProModule.VerifyPendingReqDocIsNotIsPresent(scenarioContext["DocName"].ToString());
        }

        // *********** Start of TC 07 ************ //

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

        // *********** Start of TC 07 ************ //

        // *********** Start of TC 05 ************ //
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

        // *********** Start of TC 05 ************ //


        #endregion

    }
}
