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
            supplier = new Supplier(driverContext.WebDriver);
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
            scenarioContext["SupplierName"] = supplier.EnterMandatoryFieldsforSupplier();
            Console.WriteLine("Printing the suppliername from context  --->"+scenarioContext["SupplierName"]);
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
           //scenarioContext["SupplierName"] = "Supplier PS-49";
           Console.WriteLine("Searching the suppliername from context  --->" + scenarioContext["SupplierName"]);
            supplier.searchBySupplierName(scenarioContext["SupplierName"].ToString());          
           
            
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
            supplier.addLocationDetails(scenarioContext["SupplierName"].ToString());
        }

        [Then(@"uncheck SAM and SEM for Part")]
        public void ThenUncheckSAMAndSEMForPart()
        {
            supplier.uncheckSAMandSEM();
        }

        [Then(@"create a new Project for Supplier")]
        public void ThenCreateANewProjectForSupplier()
        {
            supplier.addNewProject(scenarioContext["SupplierName"].ToString());
        }


        #endregion
    }
}