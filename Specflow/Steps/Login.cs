using OMNEX.AUTOMATION.Helpers;
using OMNEX.AUTOMATION.PageObjects.WEB;
using AventStack.ExtentReports.Gherkin.Model;
using TechTalk.SpecFlow;

namespace OMNEX.AUTOMATION.Specflow.Steps
{
    [Binding]
    public class Login : ExtentReport
    {
        #region Declaration
        private DriverContext driverContext;
        private LoginPage loginPage;
        public ScenarioContext scenarioContext;
        public FeatureContext featureContext;
        private Dashboard dashboard;

        #endregion

        #region Constructor
        public Login(DriverContext driverContext, ScenarioContext scenariocontext, FeatureContext featurecontext)
        {
            this.driverContext = driverContext;
            scenarioContext = scenariocontext;
            featureContext = featurecontext;
            loginPage = new LoginPage(driverContext.WebDriver);
            dashboard = new Dashboard(driverContext.WebDriver);
        }
        #endregion

        #region stepDefinitions


        [Given(@"Login to the application")]
        public void GivenLoginToTheApplication()
        {
            loginPage.NavigateToURL(ConfigHelper.GetURL());
            loginPage.LoginToApp(ConfigHelper.GetEmail(), ConfigHelper.GetPassword());
            
        }

        [When(@"Navigate to (.*) Page")]
        public void WhenNavigateToLevelsPage(String subHead)
        {
            dashboard.NavigateToLevelsPage(subHead);
            dashboard.validateLevelsPage();
        }

        [When(@"Create (.*) Level")]
        public void ThenCreateNewLevel(String levelname)
        {
            scenarioContext["LevleName"]=dashboard.CreateLevel(levelname);
        }

        [When(@"Edit the Level")]
        public void WhenEditTheLevel()
        {
            scenarioContext["EditedLevleName"] = dashboard.EditLevel(scenarioContext["LevleName"].ToString());
        }

        [Then(@"Delete the Level")]
        public void ThenDeleteTheLevel()
        {
            dashboard.DeleteLevelByHovering(scenarioContext["EditedLevleName"].ToString());
        }








        #endregion
    }
}