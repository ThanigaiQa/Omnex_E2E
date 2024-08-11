using OMNEX.AUTOMATION.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMNEX.AUTOMATION.PageObjects.WEB
{
    public class LoginPage
    {
        #region Declaration
        private IWebDriver _driver;
        private SeleniumActions seleniumActions;
        public Utilities utility;
        #endregion

        #region Constructor
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            seleniumActions = new SeleniumActions(_driver);
            utility = new Utilities();
        }
        #endregion

        #region pageLocators
        By txtEmail => By.XPath("//input[@id='txtUsername']");
        By txtPassword => By.XPath("//input[@id='txtPassword']");
        By btnLogin => By.XPath("(//button[@type='button'])[2]");
        By lblWarning => By.XPath("//div[contains(text(),'Do you wish to continue')]");
        By btnYes => By.XPath("//*[text()='Yes']");

        #endregion

        #region pageActions

        /// <summary>
        /// Access the app by utilizing the provided "URL"
        /// </summary>
        public void NavigateToURL(string url)
        {
            seleniumActions.NavigateToUrl(url);
        }

        /// <summary>
        /// Upon entering the email and password and clicking the login button, the application automatically directs the user to the default shift page
        /// </summary>
        /// <param name="Email">email store as String</param>
        /// <param name="Password">Password store as String</param>
        public void LoginToApp(String Email, String Password)
        {
            seleniumActions.SendKeys(txtEmail, Email);
            seleniumActions.SendKeys(txtPassword, Password);
            seleniumActions.Click(btnLogin);
            seleniumActions.Wait(3);

            if (seleniumActions.IsElementPresent(lblWarning))
                {
                    seleniumActions.Click(btnYes);
                }
        }

        #endregion
    }
}
