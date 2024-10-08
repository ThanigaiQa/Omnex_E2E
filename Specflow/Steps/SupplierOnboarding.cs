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
            dashboard.GoToDesiredMenu(sideMenu, subMenu, InnerMenu);
        }

        [Then(@"I Navigate to innermenu '([^']*)' and '([^']*)' and '([^']*)'")]
        public void ThenINavigateToInnermenuAndAnd(string sideMenu, string subMenu, string InnerMenu)
        {
            dashboard.GoToDesiredMenu(sideMenu, subMenu, InnerMenu);
        }


        [When(@"Create a New Supplier")]
        public void WhenCreateANewSupplier()
        {
            supplier.ClickAddSupplierButton();
            supplier.EnterMandatoryFieldsforSupplier();
        }

        // ************** End of TC 1 ****************** //


        // ************** Start of TC 02, 0****************** //
        [When(@"Navigate to SupplierSetup")]
        public void WhenNavigateToSupplierSetup()
        {
            //Click on Menubar if Sidemenu not available
            supplier.navigateToSupplierSetup();
        }

        [Then(@"Set Supplier Evaluation BusinessRule")]
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
        #endregion
    }
}