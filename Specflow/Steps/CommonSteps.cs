using OMNEX.AUTOMATION.Helpers;
using OMNEX.AUTOMATION.PageObjects.WEB;
using AventStack.ExtentReports.Gherkin.Model;
using TechTalk.SpecFlow;

namespace OMNEX.AUTOMATION.Specflow.Steps
{
    [Binding]
    public class CommonSteps : ExtentReport
    {
        #region Declaration
        private DriverContext driverContext;
        private LoginPage loginPage;
        public ScenarioContext scenarioContext;
        public FeatureContext featureContext;
        private Dashboard dashboard;

        #endregion

        #region Constructor
        public CommonSteps(DriverContext driverContext, ScenarioContext scenariocontext, FeatureContext featurecontext)
        {
            this.driverContext = driverContext;
            scenarioContext = scenariocontext;
            featureContext = featurecontext;
            loginPage = new LoginPage(driverContext.WebDriver);
            dashboard = new Dashboard(driverContext.WebDriver);
        }
        #endregion

        #region stepDefinitions

        [Given(@"Login to the application with '([^']*)' user")]
        [Then(@"Login to the application with '([^']*)' user")]
        public void GivenLoginToTheApplicationWithUser(string user)
        {
            switch (user.ToLower())
            {
                case "right":
                    loginPage.NavigateToURL(ConfigHelper.GetURL());
                    loginPage.LoginToApp(ConfigHelper.GetRightsUser(), ConfigHelper.GetPassword());
                    break;
                case "docpro":
                    loginPage.NavigateToURL(ConfigHelper.GetURL());
                    loginPage.LoginToApp(ConfigHelper.GetDocProUser(), ConfigHelper.GetPassword());
                    break;
                case "thani":
                    loginPage.NavigateToURL(ConfigHelper.GetURL());
                    loginPage.LoginToApp(ConfigHelper.GetThaniUser(), ConfigHelper.GetPassword());
                    break;
                case "admin":
                    loginPage.NavigateToURL(ConfigHelper.GetURL());
                    loginPage.LoginToApp(ConfigHelper.GetAdminUser(), ConfigHelper.GetPassword());
                    break;
            }
        }

        [When(@"Navigate to (.*) Page")]
        public void WhenNavigateToLevelsPage(String subHead)
        {
            dashboard.NavigateToLevelsPage(subHead);
           // dashboard.validateLevelsPage();
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

        [When(@"I Navigate to (.*) Page")]
        public void WhenINavigateToTeamsPage(String subHead)
        {
            dashboard.NavigateToSystemPage(subHead);
        }

        [Then(@"I refresh the page")]
        public void ThenIRefreshThePage()
        {
            dashboard.Refresh();
        }


        [When(@"Logout from the application")]
        [Then(@"Logout from the application")]
        public void WhenLogoutFromTheApplication()
        {
            dashboard.LogoutApplication();
        }

        #endregion
    }
}