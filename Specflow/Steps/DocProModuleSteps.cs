﻿using OMNEX.AUTOMATION.Helpers;
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

        

        #endregion

    }
}