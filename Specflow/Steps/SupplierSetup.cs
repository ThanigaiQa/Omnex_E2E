using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OMNEX.AUTOMATION.Helpers;
using OMNEX.AUTOMATION.PageObjects.WEB;
using AventStack.ExtentReports.Gherkin.Model;
using TechTalk.SpecFlow;

namespace OMNEX.AUTOMATION.Specflow.Steps
{
    [Binding]
    public class SupplierSetup : ExtentReport
    {

        #region Declaration

        private DriverContext driverContext;        
        public ScenarioContext scenarioContext;
        public FeatureContext featureContext;
        private Dashboard dashboard;
        private Supplier supplier;

        #endregion

        #region Constructor
        public SupplierSetup(DriverContext driverContext, ScenarioContext scenariocontext, FeatureContext featurecontext)
        {
            this.driverContext = driverContext;
            scenarioContext = scenariocontext;
            featureContext = featurecontext;
            dashboard = new Dashboard(driverContext.WebDriver);
           supplier = new Supplier(driverContext.WebDriver, scenariocontext);

        }

        #endregion

        #region stepDefinitions
        [Given(@"Create a new Document route")]
        public void GivenCreateANewDocumentRoute()
        { 
            supplier.createDocRoute();

        }

        [When(@"Open the Supplier Route")]
        public void WhenOpenTheSupplierRoute()
        {
            supplier.openRoute();
        }


        [Then(@"Assign approvers for the route")]
        public void ThenAssignApproversForTheRoute()
        {
            supplier.openRoute();
            supplier.addApproversForRoute();
        }


        [Then(@"Remove Approver from Route")]
        public void ThenRemoveApproverFromRoute()
        {
            supplier.removeApproversForRoute();
        }

        [Then(@"Delete from Route")]
        public void ThenDeleteFromRoute()
        {
            supplier.deleteRoute();
        }
        [Given(@"Select SupplierManagement Module")]
        public void GivenSelectSupplierManagementModule()
        {
            supplier.selectSupplierManagement();
        }

        [Given(@"Create a new Group")]
        public void GivenCreateANewGroup()
        {
            supplier.createSupplierGroup();
        }

        [When(@"Select the Automation Group")]
        public void WhenSelectTheAutomationGroup()
        {
            supplier.selectAutomationGroup();
        }

        [Then(@"Assign User for Automation Group")]
        public void ThenAssignUserForAutomationGroup()
        {
            supplier.assignUserforAutomationGroup();
        }

        [Then(@"Remove User from Automation Group")]
        public void ThenRemoveUserFromAutomationGroup()
        {
            supplier.removeUesrfromGroup();
        }

        [Given(@"Delete Automation Group")]
        public void GivenDeleteAutomationGroup()
        
        {
            supplier.deleteGroup();
        }

        [Then(@"Create Supplier Type")]
        public void ThenCreateSupplierType()
        {
            supplier.createSupplierType();
        }

        [Then(@"Edit Supplier Type")]
        public void ThenEditSupplierType()
        {
            supplier.editSupplierType();
        }

        [Then(@"Create a Part Type")]
        public void ThenCreateAPartType()
        {
          supplier.createPartType();
        }

        [Then(@"Edit Part Type")]
        public void ThenEditPartType()
        {
           supplier.editPartType();
        }

        [Then(@"Set Level for Supplier Management")]
        public void ThenSetLevelForSupplierManagement()
        {
            supplier.setSupplierLevel();

        }

       

        [Then(@"Check the buttons in the Supplier Listing Page")]
        public void ThenCheckTheButtonsInTheSupplierDetailsPage()
        {
            supplier.checkButtonsInSupplierInformation();
        }

        [Then(@"Set Supplier Evaluation BusinessRule as No")]
        public void ThenSetSupplierEvaluationBusinessRuleAsNo()
        {
            supplier.setSupplierEvaluationBusinessRuleasNO();
        }

        [Then(@"Set Audit against Part as Yes")]
        public void ThenSetAuditAgainstPartAsYes()
        {
            supplier.setAuditAgainstPartBusinessRuleasYes();
        }

        [Then(@"Check the fields in the Supplier Details Page")]
        public void ThenCheckTheFieldsInTheSupplierDetailsPage()
        {
           
        }



        #endregion



    }
}
