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
        private DocProModule docProModule;

        #endregion

        #region Constructor
        public CommonSteps(DriverContext driverContext, ScenarioContext scenariocontext, FeatureContext featurecontext)
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

        [Given(@"Login to the application with '([^']*)' user")]
        [Then(@"Login to the application with '([^']*)' user")]
        public void GivenLoginToTheApplicationWithUser(string user)
        {
            loginPage.NavigateToURL(ConfigHelper.GetURL());
            switch (user.ToLower())
            {
                case "right":
                    loginPage.LoginToApp(ConfigHelper.GetRightsUser(), ConfigHelper.GetPassword());
                    break;
                case "docpro":
                    loginPage.LoginToApp(ConfigHelper.GetDocProUser(), ConfigHelper.GetPassword());
                    break;
                case "thani":
                    loginPage.LoginToApp(ConfigHelper.GetThaniUser(), ConfigHelper.GetPassword());
                    break;
                case "admin":
                    loginPage.LoginToApp(ConfigHelper.GetAdminUser(), ConfigHelper.GetPassword());
                    break;
            }
        }

        [When(@"Navigate to (.*) in suite setup Page")]
        public void WhenNavigateToInSuiteSetupPage(string subHead)
        {
            docProModule.NavigateToLevelsPage(subHead);
        }

        [Then(@"I validate the Levels page")]
        public void ThenIValidateTheLevelsPage()
        {
            docProModule.validateLevelsPage();
        }

        [When(@"Create (.*) Level")]
        [Then(@"Create (.*) Level")]
        public void ThenCreateNewLevel(String levelname)
        {
            scenarioContext["LevelName"] = docProModule.CreateLevel(levelname);
        }

        [When(@"Edit the Level")]
        public void WhenEditTheLevel()
        {
            scenarioContext["EditedLevelName"] = docProModule.EditLevel(scenarioContext["LevelName"].ToString());
        }

        [Then(@"Delete the Level")]
        public void ThenDeleteTheLevel()
        {
            docProModule.DeleteLevelByHovering(scenarioContext["LevelName"].ToString());
        }

        [When(@"I Navigate to (.*) in system Page")]
        [Then(@"I Navigate to (.*) in system Page")]
        public void WhenINavigateToInSystemPage(String subHead)
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

        [When(@"Navigate to (.*) page")]
        public void WhenNavigateToEntityPage(string subHead)
        {
            dashboard.NavigateToEntityAndOwnerPage(subHead);
        }

        [When(@"I navigate to (.*) in users Page")]
        public void WhenINavigateToInUsersPage(string subHead)
        {
            dashboard.NavigateToUsersPage(subHead);
        }

        [Then(@"I make the (.*) level in use")]
        public void ThenIMakeTheLevelInUse(string levelName)
        {
            docProModule.MakeLevelInUse(scenarioContext["LevelName"].ToString());
        }


        #endregion
    }
}