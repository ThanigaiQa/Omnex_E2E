using OMNEX.AUTOMATION.Helpers;
using OMNEX.AUTOMATION.PageObjects.WEB;
using AventStack.ExtentReports.Gherkin.Model;
using TechTalk.SpecFlow;
using System.Diagnostics.Metrics;
using System.Reflection.Emit;
using OpenQA.Selenium;

namespace OMNEX.AUTOMATION.Specflow.Steps
{
    [Binding]
    public class SupplierOnboarding : ExtentReport
    {
        #region Declaration
        private DriverContext driverContext;
        private LoginPage loginPage;
        public ScenarioContext scenarioContext;
        public FeatureContext featureContext;
        private Dashboard dashboard;
        private Supplier supplier;

        #endregion

        #region Constructor
        public SupplierOnboarding(DriverContext driverContext, ScenarioContext scenariocontext, FeatureContext featurecontext)
        {
            this.driverContext = driverContext;
            scenarioContext = scenariocontext;
            featureContext = featurecontext;
            loginPage = new LoginPage(driverContext.WebDriver);
            dashboard = new Dashboard(driverContext.WebDriver);
            supplier = new Supplier(driverContext.WebDriver, scenariocontext);
        }
        #endregion

        #region stepDefinitions

        // ************** Start of TC 01****************** //

        [Given(@"Navigate to SupplierManagement Platform")]
        public void GivenNavigateToPlatform()
        {

            dashboard.selectSupplierPlatform();
            
        }

        [Given(@"I Navigate to innermenu '([^']*)' and '([^']*)' and '([^']*)'")]
        public void GivenINavigateToInnerMenu(string sideMenu, string subMenu, string InnerMenu)
        {
            supplier.GoToDesiredMenu(sideMenu, subMenu, InnerMenu);
        }

        [Then(@"I Navigate to innermenu '([^']*)' and '([^']*)' and '([^']*)'")]
        public void ThenINavigateToInnermenuAndAnd(string sideMenu, string subMenu, string InnerMenu)
        {
            dashboard.GoToDesiredMenu(sideMenu, subMenu, InnerMenu);
        }


        [Given(@"Create a New Supplier")]
        public void WhenCreateANewSupplier()
        {
            supplier.ClickAddSupplierButton();
            
            string SupplierName = supplier.EnterMandatoryFieldsforSupplier();
            Utilities.setGlobalValue("SupplierName", SupplierName);
            //Console.WriteLine("Printing the suppliername from context  --->"+scenarioContext["SupplierName"]);
        }

        // ************** End of TC 1 ****************** //


        // ************** Start of TC 02, 0****************** //
        [When(@"Navigate to SupplierSetup")]
        public void WhenNavigateToSupplierSetup()
        {
            //Click on Menubar if Sidemenu not available
            supplier.navigateToSupplierSetup();
        }

        [Then(@"Set Supplier Evaluation BusinessRule as Yes")]
        public void ThenSetSupplierEvaluationBusinessRule()
        {
            supplier.setSupplierEvaluationBusinessRule();
        }

        [Then(@"Fill supplier Evaluation without Route")]
        public void ThenFillSupplierEvaluationWithRoute()
        {
            supplier.ClickAddSupplierButton();
            supplier.fillEvaluationRequestWitoutRoute();
        }

        // ************** End of TC 2 ****************** //

        [Then(@"Search for Supplier and open it")]
        public void ThenSearchForSupplierAndOpenIt()
        {
            String supplierName = Utilities.getGlobalValue("SupplierName");
           //Console.WriteLine("Searching the suppliername from context  --->" + scenarioContext["SupplierName"]);
            supplier.searchBySupplierName(supplierName);          
           
            
        }

        [When(@"Add Part for the Supplier")]
        public void WhenAddPartForTheSupplier()
        {
            supplier.addParts();
        }

        [Then(@"Add Location for the Part")]
        public void ThenAddLocationForThePart()
        {
           // scenarioContext["SupplierName"] = "Supplier PS-49";
            supplier.addLocationDetails(Utilities.getGlobalValue("SupplierName"));
        }

        [Then(@"uncheck SAM and SEM for Part")]
        public void ThenUncheckSAMAndSEMForPart()
        {
            supplier.uncheckSAMandSEM();
        }

        [Then(@"create a new Project for Supplier")]
        public void ThenCreateANewProjectForSupplier()
        {
            supplier.addNewProject(Utilities.getGlobalValue("SupplierName")); 
            
        }

        [Then(@"Add Task deatils for the Project")]
        public void ThenAddTaskDeatilsForTheProject()
        {
            supplier.addTaskDetails();
        }

        [Then(@"Add Input Documents for FirstTask")]
        public void ThenAddInputDocumentsForFirstTask()
        {
            supplier.addInputdoc();
        }

        [Then(@"Add Input Documents for Second Task")]
        public void ThenAddInputDocumentsForSecondTask()
        {
            supplier.addInputdocFortask2();
        }

        [Then(@"Publish the Project")]
        public void ThenPublishTheProject()
        {
            supplier.publishProjectToDocpro();

            //dashboard.LogoutApplication();
           // loginPage.LoginToApp(scenarioContext["PrimaryEmail"].ToString(), "pass1");
        }

        [Given(@"Login to the application as Primary Supplier user")]
        public void GivenLoginToTheApplicationAsSupplierUser()
        {
           // scenarioContext["PrimaryEmail"] = "primary@PS-103.com";
           // scenarioContext["ProjectName"] = "Supplier PS-103-06112024121758";
            loginPage.NavigateToURL(ConfigHelper.GetURL());
            loginPage.LoginToApp(Utilities.getGlobalValue("SupplierPrimaryEmail"), "pass1");
        }

        [Given(@"Login to the application as Secondary Supplier user")]
        public void GivenLoginToTheApplicationAsSecondarySupplierUser()
        {
            //scenarioContext["SecondaryEmail"] = "secondary@PS-103.com";
            //scenarioContext["ProjectName"] = "Supplier PS-103-06112024121758";
            loginPage.NavigateToURL(ConfigHelper.GetURL());
            loginPage.LoginToApp(Utilities.getGlobalValue("SupplierSecondaryEmail"), "pass1");
        }


        [Given(@"Select the ProjectName and open the task for '([^']*)'")]
        public void GivenSelectTheProjectNameAndOpenTheTaskFor(string UserType)
        {
            supplier.openProjectandTask(UserType);
            
        }

        [Given(@"Attach Output document for the task")]
        public void GivenAttachOutputDocumentForTheTask()
        {
            supplier.attachOutputDocument();
        }

        [Given(@"Attach Output document for the Secondary user")]
        public void GivenAttachOutputDocumentForTheSecondaryUser()
        {
            supplier.attachOutputDocument2();
        }

        [Given(@"Update the task Completion Percentage as (.*)")]
        public void GivenUpdateTheTaskCompletionPercentageAs(String percent)
        {
            supplier.updateTaskPercentage(percent);
            
        }

        [Given(@"Update the task Completion for secondary user")]
        public void GivenUpdateTheTaskCompletionForSecondaryUser()
        {
            supplier.updateTaskPercentage2();
        }

        [Given(@"Logout")]
        public void GivenLogout()
        {
            dashboard.LogoutApplication();
        }
        [Then(@"Logout")]
        public void ThenLogout()
        {
            dashboard.LogoutApplication();
        }


        [Given(@"Navigate to Deliverable info Page")]
        public void GivenNavigateToDeliverableInfoPage()
        {
            supplier.selectDeliverableInfoForSecondaryUser();
        }


        [Then(@"Update the Status of the Project as Completed\.")]
        public void ThenUpdateTheStatusOfTheProjectAsCompleted_()
        {
            
            supplier.updateStatusOfProject();
        }

        [Given(@"Write into Json")]
        public void GivenWriteIntoJson()
        {
            Utilities.setGlobalValue("SupplierCode", "Avon-PS-123");
            Utilities.getGlobalValue("SupplierCode");

            Utilities.setGlobalValue("SupplierName", "Avon Corp");
            Utilities.getGlobalValue("SupplierName");
        }


        #endregion
    }
}