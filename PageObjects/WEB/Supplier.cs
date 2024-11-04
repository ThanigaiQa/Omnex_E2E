using OMNEX.AUTOMATION.Helpers;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace OMNEX.AUTOMATION.PageObjects.WEB
{
    public class Supplier
    {
        #region Declaration
        private IWebDriver _driver;
        private SeleniumActions seleniumActions;
        public Utilities utility;
        public Dashboard dashboard;
        public ScenarioContext scenarioContext;
        #endregion



        #region Constructor
        public Supplier(IWebDriver driver)
        {
            _driver = driver;
            seleniumActions = new SeleniumActions(_driver);
            utility = new Utilities();
            //dashboard = new Dashboard(_driver);
           // this.scenarioContext = scenarioContext;
        }

      
        #endregion



        #region PageLocators
        By menuBars => By.XPath("//*[@data-icon='bars']");
        By supplierName => By.XPath("//*[@id = 'txtName']");
        By primaryEmail => By.XPath("//input[@id='txtEmail']");
        By secondaryEmail => By.XPath("//input[@id='txtSecEmail']");
        By supplierTypeDropdown => By.XPath("(//label[contains(text(),'Supplier Type')]//following::span[@class='selection'])[1]");        
        By supplierUserCount => By.XPath("//*[@id = 'txtUserCount']");       
        By sqeUserIcon => By.XPath("//*[@id = 'imgSelectTeamLead']");
        By sqmUserIcon => By.XPath("//*[@id = 'imgSelectTeamSQM']");
        By txtUsername => By.XPath("//div[@id='userListingGridControl_wrapper']//input[@type='search']");
        By userSearchResult => By.XPath("(//table[@id='userListingGridControl']//td[@class='sorting_1'])[1]");
        By chkBoxUserResult => By.XPath("(//table[@id='userListingGridControl']//tr[@class='odd']//input[@type='checkbox'])[1]");
        By chkTeamLeaderInactive => By.XPath("(//table[@id='userListingGridControl']//tr[@class='odd']//input[@type='checkbox'])[1]");
        By clickDoneUser => By.XPath("//button[@title='Done']");
        By newSupplierButton => By.XPath("//*[@id = 'btnAdd' or @title='New']");        
        By saveSupplier => By.XPath("//button[@id='btnSave']");
        By alertInSupplier => By.XPath("//div[@class='alert alert-warning alert-dismissible border-bottom']/a");
        By closeAlert => By.XPath("//a[@id='alert_ok']");
        By inputDocproDocName => By.XPath("//input[@id='txtSearchTree_tvDocument']");
        By btnDocproPopupSearch => By.XPath("//*[local-name()='svg' and @title='Search']");
        By btnCreateSupplierEvaluationRequest => By.XPath("//button[@id='btnadd' and @title='Create Supplier Evaluation Request']");

        By selectSupplierSearchDropdown => By.XPath("//select[@id='filtercolumn_SuSupplierGridViewControl']");
        By inputSupplierNameSearch => By.XPath("//div[@id='SuSupplierGridViewControl_filter']//input[@type='search']");
        #endregion
        By tabPartsDEtails => By.XPath("//a[@id='ahref_tbPartDetails']");
        By btnAddParts => By.XPath("//button[@id='btnNewParts']");



        #region BusinessRule page
        By supplierBusinessRule => By.XPath("//div[@title='Supplier BusinessRule']");
        By bRuleSupplierEvaluationYes => By.XPath("//input[@id='rdoIsHLYes']");
        By bRuleAuditAgainstPartsYes => By.XPath("//input[@id='rdoIsAuditYes']");

        By bRuleSupplierEvaluationNo => By.XPath("//input[@id='rdoIsHLNo']");
        By bRuleAuditAgainstPartsNo => By.XPath("//input[@id='rdoIsAuditNo']");
        By bRuleVMFNo => By.XPath("//input[@id='rdoIsVMFFormNo']");
        By bRuleParentSupplierNo => By.XPath("//input[@id='rdoIsParentEntityNo']");

        By delParentLevelSelector => By.XPath("//a[@id='btnDelParentLavel']"); 
        By editParentLevelSelector => By.XPath("//a[@id='btnEditParentLavel']");
        #endregion//button[@id='btnadd' and @title='Create Supplier Evaluation Request']

        #region SupplierEvaluation Page

        #endregion

        #region SupplierSetup Locators

        By saveButton => By.XPath("//button[@id='btnSave']"); 
        By checkRouteUser => By.XPath("//table[@id='tblApproverSelection']//tr/td/input"); 
        By removeUserButton => By.XPath("//button[@id='btnDeluser']");
        By deleteButton => By.XPath("//button[@id='btnDelete']");
        #endregion

        #region SupplierGroups
        By inboxSM =>By.XPath("//div[@class='ibox-content']//div[contains(text(),'Supplier Management')]");
        By buttonAddGroups = By.XPath("//div[@id='SuGroupsGridViewControl_wrapper']//button[@id='btn_add_hold']");
        private IWebDriver webDriver;

        By inputGroupName => By.XPath("//div[@id='AddTable']//input[@id='0_groupname']");
        By saveGroupName => By.XPath("//button[@id='btnSaveDetails_SuGroupsGridViewControl']");
        By iconAddUsersforGroup => By.XPath("//table[@id='SuGroupsGridViewControl']//td[contains(text(),'Automation Group')]/following-sibling::td/*[local-name()='svg' and @data-icon='user-plus']");       
        By checkboxAuditAdministrator => By.XPath("//input[@id='chkType_Audit Administrator']");
        By checkboxSupplierAdministrator => By.XPath("//input[@id='chkType_Supplier Administrator']");
        By buttonSaveGroups => By.XPath("//button[@title='Save']");
        By checkboxGroupName => By.XPath("//tr//td[contains(text(),'Automation Group')]//parent::tr/td/input[@type='checkbox']");
        By buttonDeleteGroup => By.XPath("//button[@id='btn_delete_hold']");
        #endregion

        #region SupplierType
        By supplierType => By.XPath("//div[@title='Supplier Type']");
        By buttonAddSupplierType => By.XPath("//button[@id='btn_add_hold']");
        By inputSupplierTypeName => By.XPath("//form[@id='Form_grdSupplierTypeMaster']//input[@name='TypeName']");
        By buttonSaveSupplierType => By.XPath("//button[@id='btnSaveDetails_grdSupplierTypeMaster']");
        By iconEditSupplierType => By.XPath("//td[contains(text(),'Automation')]//parent::tr/td/span[@class='clsbtnedit']");
        By dropdownSupplierType => By.XPath("//span[@class='select2-selection__arrow' and @role='presentation']");
        By lstSupplierTypeAutomation => By.XPath("//ul[@id='select2-cmbSupplierType-results']/li/span[contains(text(),'Automation1')]");
        By buttonAddPartType => By.XPath("//div[@id='grdSupplierTypeMaster_wrapper']//button[@onclick='AddDatatable(grdSupplierTypeMaster);']");
        By inputPartTypeName => By.XPath("//input[@name='PartType']");
        By buttonSavePartType => By.XPath("//button[@id='btnSaveDetails_grdPartTypeMaster']");
        By iconEditPartType => By.XPath("//table[@id='grdPartTypeMaster']//td[@class=' dt-body-center actioncol']/span[@class='clsbtnedit']");
        
        #endregion

        #region Iframe
        static By iframe_DetailView => By.XPath("//iframe[@name='Detailview']");
        static By iframe_Tree => By.XPath("//iframe[@id='iframeTree']");
        static By iframe_ifrUsers => By.XPath("//iframe[@id='ifrUsers']");
        static By iframe_ifrAlbum => By.XPath("(//iframe[@id='ifrAlbum'])[1]");
        static By iframe => By.XPath("//iframe[contains(@class,'cke_reset')]");
        static By iframeMenuData => By.XPath("//iframe[@id='MenuData']");
        static By iframePartType => By.XPath("//iframe[@id='frmPartType']");
        #endregion

        #region pageActions

        public void ClickAddSupplierButton()
        {
            seleniumActions.Wait(4);
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.MoveToElement(newSupplierButton);
            seleniumActions.Click(newSupplierButton);
            seleniumActions.SwitchToDefaultContent();  
        }

        /// <summary>
        /// Navigate to desired menu by passing the following parameters
        /// </summary>
        /// <param name="sideMenu"></param>
        /// <param name="subMenu"></param>
        /// <param name="innerMenu"></param> --> Optional
        public void GoToDesiredMenu(string sideMenu, string subMenu, string innerMenu)
        {

            //Click on Menubar if Sidemenu not available
            seleniumActions.Wait(5);

            if (!seleniumActions.IsElementPresent(By.XPath("//ul[@id='sidemenu']//a/div[text()='" + sideMenu + "']")))
            {
                seleniumActions.Click(menuBars);
            }
            seleniumActions.Click(By.XPath("//ul[@id='sidemenu']//a/div[text()='" + sideMenu + "']"));
            seleniumActions.Click(By.XPath("//ul[@id='submenu']/li/a/span[text()='" + subMenu + "']"));
            if (!String.Equals(innerMenu, ""))
            {

                seleniumActions.Wait(2);
                if (!seleniumActions.VerifyElementIsDisplayed(By.XPath("(//ul[@class='inner_submenu']//a[@title='" + innerMenu + "']//span[contains(text(),'" + innerMenu + "')])[2]"))) ;
                {
                    seleniumActions.Click(By.XPath("//ul[@id='sidemenu']//a/div[text()='" + sideMenu + "']"));
                    //  seleniumActions.Click(By.XPath("//ul[@id='submenu']/li/a/span[text()='" + subMenu + "']"));

                }
                seleniumActions.MoveToElement(By.XPath("(//ul[@class='inner_submenu']//a[@title='" + innerMenu + "']//span[contains(text(),'" + innerMenu + "')])[2]"));
                seleniumActions.ActionsClick(By.XPath("(//ul[@class='inner_submenu']//a[@title='" + innerMenu + "']//span[contains(text(),'" + innerMenu + "')])[2]"));

            }


        }

        public String EnterMandatoryFieldsforSupplier()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            String temp = seleniumActions.GetAttributeValue(By.XPath("//input[@id='txtCode']"), "value");
            //ConfigHelper.SetSupplierCode(temp);

            validateSupplierField("SupplierName");
            String primaryMail = "primary@" + temp + ".com";
            String secondaryMail = "secondary@" + temp + ".com";
           
            temp = "Supplier " + temp;

            seleniumActions.SendKeys(supplierName, text: temp);
           // ConfigHelper.SetSupplierName(temp);
            //temp = temp.Replace("-", "");
            //temp = temp.Replace("\\s", "");
            
            //ConfigHelper.SetSupplierEmail(primaryMail);

            validateSupplierField("Supplier Type");
            seleniumActions.Click(supplierTypeDropdown);
            seleniumActions.ScrollToElement(By.XPath("//ul[@id='select2-cmbSupplierType-results']/li/span[contains(text(),'New Vendor')]"));
            seleniumActions.Click(By.XPath("//ul[@id='select2-cmbSupplierType-results']/li/span[contains(text(),'New Vendor')]"));

            validateSupplierField("Number of Supplier Users");
            seleniumActions.SendKeys(supplierUserCount, text: "10");

            validateSupplierField("Primary Email of Supplier");
            seleniumActions.SendKeys(primaryEmail, primaryMail);

            seleniumActions.SendKeys(secondaryEmail, secondaryMail);


            validateSupplierField("SQE");
            seleniumActions.Click(sqeUserIcon);
            SelectTheUser("kaalaa");
            //dashboard.SelectTheUser("kaalaa");

            validateSupplierField("SQM");
            seleniumActions.Click(sqmUserIcon);
            SelectTheUser("kaalaa");
            //dashboard.SelectTheUser("kaalaa");

            seleniumActions.Click(saveSupplier);
            seleniumActions.Wait(2);
            seleniumActions.Click(closeAlert);
            //Console.WriteLine("Supplier created " + ConfigHelper.GetSupplierName());
            Console.WriteLine("Primary email created " + primaryMail);
            Console.WriteLine("Secondary email created " + secondaryMail);
            seleniumActions.SwitchToDefaultContent();
            return temp;

        }

        public void SelectTheUser(String userName)
        {
            seleniumActions.Wait(2);
            seleniumActions.SwitchToIframes(iframe_ifrUsers); 
            
            seleniumActions.Click(txtUsername);
            seleniumActions.SendKeys(txtUsername, text: userName);
            seleniumActions.Wait(2);

            seleniumActions.MoveToElement(chkTeamLeaderInactive);
            seleniumActions.Click(chkTeamLeaderInactive);

            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Click(clickDoneUser);             
        }

        public void SelectTheUserFromMenuData(String userName)
        {
            seleniumActions.Wait(2);
            seleniumActions.SwitchToIframes(iframe_ifrUsers);

            seleniumActions.Click(txtUsername);
            seleniumActions.SendKeys(txtUsername, text: userName);
            seleniumActions.Wait(2);

            seleniumActions.MoveToElement(chkTeamLeaderInactive);
            seleniumActions.Click(chkTeamLeaderInactive);

            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.SwitchToFrame(iframeMenuData);
            seleniumActions.MoveToElement(clickDoneUser);
            seleniumActions.ActionsClick(clickDoneUser);
        }

        public void validateSupplierField(String fieldName)
        {
            seleniumActions.Click(saveSupplier);
            if (seleniumActions.IsElementPresent(alertInSupplier))
            {
                seleniumActions.Click(closeAlert);
            }
            Console.WriteLine("Mandatory check done for " + fieldName);
        }


        public void navigateToSupplierSetup()
        {
            if (!seleniumActions.IsElementPresent(By.XPath("//ul[@id='sidemenu']//a/div[text()='Setup']")))
            {
                seleniumActions.Click(menuBars);
            }
            seleniumActions.Click(By.XPath("//ul[@id='sidemenu']//a/div[text()='Setup']"));
            seleniumActions.Click(By.XPath("//ul[@id='submenu']/li/a/span[text()='Supplier Setup']"));
        }

        public void setSupplierEvaluationBusinessRule()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.MoveToElement(supplierBusinessRule);
            seleniumActions.Click(supplierBusinessRule);
            seleniumActions.SwitchToFrame(iframeMenuData);

            seleniumActions.Click(bRuleSupplierEvaluationYes);
            seleniumActions.Click(bRuleAuditAgainstPartsYes);
            seleniumActions.Click(bRuleVMFNo);
            seleniumActions.Click(bRuleParentSupplierNo);
            seleniumActions.SwitchToDefaultContent();      

        }

        public void fillEvaluationRequestWitoutRoute()
        {
            Console.WriteLine("Inside Supplier evaluation request");
            seleniumActions.SwitchToIframes(iframe_DetailView);
            String temp = seleniumActions.GetAttributeValue(By.XPath("//input[@id='txtSupplierCode']"), "value");
            //ConfigHelper.SetSupplierCode(temp);

            validateSupplierField("SupplierName");
            temp = "Supplier " + temp;
            seleniumActions.SendKeys(supplierName, text: temp);
           // ConfigHelper.SetSupplierName(temp);

            validateSupplierField("Supplier Name");
            seleniumActions.SendKeys(By.XPath("//input[@id='txtSupplierName']"), text: temp);

        }

        public void searchBySupplierName(String SupplieName)
        {
            
            Console.WriteLine("Searching for the suppliername from context  --->" + SupplieName);
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Wait(2);
            seleniumActions.Click(selectSupplierSearchDropdown);
            seleniumActions.Click(By.XPath("//select[@id='filtercolumn_SuSupplierGridViewControl']/option[@value='Name']"));
            
            seleniumActions.SendKeys(inputSupplierNameSearch, text: SupplieName);
            seleniumActions.Wait(3);
            seleniumActions.Click(By.XPath("//table[@id='SuSupplierGridViewControl']//td/a[contains(text(),'"+ SupplieName + "')]"));
            seleniumActions.Wait(5);
            seleniumActions.SwitchToDefaultContent();
        }
        #endregion

        #region SupplierSetupPageActions

        public void createDocRoute()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.MoveToElement(By.XPath("//div/div[text()='Supplier Management']"));
            seleniumActions.Click(By.XPath("//div/div[text()='Supplier Management']"));
            seleniumActions.SwitchToIframes(iframeMenuData);
            seleniumActions.Click(By.XPath("//button[@onclick='openRouteNewScreen()']"));
            seleniumActions.Wait(2);

            seleniumActions.SendKeys(By.XPath("//input[@id='strRouteName']"), "Automation Route");
            seleniumActions.ScrollToElement(By.XPath("//button[@id='btnSave']"));
            seleniumActions.Click(By.XPath("//button[@id='btnSave']"));
            seleniumActions.Wait(5);
        }

        public void openRoute()
        {
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.MoveToElement(By.XPath("//div/div[text()='Supplier Management']"));
            seleniumActions.Click(By.XPath("//div/div[text()='Supplier Management']"));

            seleniumActions.SwitchToIframes(iframeMenuData);
            Console.WriteLine("After menudata");
            seleniumActions.ScrollToElement(By.XPath("//table[@id='routesGrid']//a[contains(text(),'Automation Route')]"));
            seleniumActions.Click(By.XPath("//table[@id='routesGrid']//a[contains(text(),'Automation Route')]"));
           

        }

        public void addApproversForRoute()
        {
            seleniumActions.ScrollToElement(By.XPath("//table[@id='tblApproverSelection']/caption/button[@id='btnAdduser']"));
            seleniumActions.Click(By.XPath("//table[@id='tblApproverSelection']/caption/button[@id='btnAdduser']"));
            SelectTheUserFromMenuData("thani");
            seleniumActions.ScrollToElement(saveButton);
            seleniumActions.Click(saveButton);
            seleniumActions.Wait(2);

        }

        public void removeApproversForRoute()
        {
            seleniumActions.Click(checkRouteUser);
            seleniumActions.Click(removeUserButton);
            seleniumActions.ScrollToElement(saveButton);
            seleniumActions.Click(saveButton);

        }

        public void deleteRoute()
        {
            seleniumActions.ScrollToElement(deleteButton);
            seleniumActions.Click(deleteButton);

        }

        public void selectSupplierManagement()
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.ScrollToElement(inboxSM);
            seleniumActions.Click(inboxSM);
            seleniumActions.Wait(2);
        }

        public void createSupplierGroup()
        {
            seleniumActions.SwitchToFrame(iframeMenuData);
            seleniumActions.ScrollToElement(buttonAddGroups);
            seleniumActions.Click(buttonAddGroups);
            seleniumActions.Wait(2);
            seleniumActions.SendKeys(inputGroupName,"Automation Group");
            seleniumActions.Click(saveGroupName);
            seleniumActions.Wait(2);
            seleniumActions.IsElementPresent(closeAlert);
            seleniumActions.Click(closeAlert);

       }

        public void selectAutomationGroup()
        {
            seleniumActions.SwitchToFrame(iframeMenuData);
            seleniumActions.ScrollToElement(iconAddUsersforGroup);
            seleniumActions.Click(iconAddUsersforGroup);
            seleniumActions.Wait(2);
        }

        public void assignUserforAutomationGroup()
        {
            seleniumActions.Wait(2);
            seleniumActions.SwitchToIframes(iframe_ifrUsers);

            seleniumActions.Click(txtUsername);
            seleniumActions.SendKeys(txtUsername, text: "thani");
            seleniumActions.Wait(2);

            seleniumActions.MoveToElement(chkTeamLeaderInactive);
            seleniumActions.Click(chkTeamLeaderInactive);

            seleniumActions.MoveToElement(checkboxAuditAdministrator);
            seleniumActions.Click(checkboxAuditAdministrator);

            seleniumActions.MoveToElement(checkboxSupplierAdministrator);
            seleniumActions.Click(checkboxSupplierAdministrator);

            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToIframes(iframe_DetailView, iframeMenuData);

            seleniumActions.Click(buttonSaveGroups);
            seleniumActions.Wait(2);
            seleniumActions.IsElementPresent(closeAlert);
            seleniumActions.Click(closeAlert);

        }

        public void removeUesrfromGroup()
        {
            seleniumActions.Wait(2);
            seleniumActions.SwitchToIframes(iframe_ifrUsers);

            seleniumActions.Click(txtUsername);
            seleniumActions.SendKeys(txtUsername, text: "thani");
            seleniumActions.Wait(2);

            seleniumActions.MoveToElement(chkTeamLeaderInactive);
            seleniumActions.Click(chkTeamLeaderInactive);

            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToIframes(iframe_DetailView, iframeMenuData);

            seleniumActions.MoveToElement(buttonSaveGroups);
            seleniumActions.Click(buttonSaveGroups);
            seleniumActions.Wait(2);
            seleniumActions.SwitchToFrame(iframe_ifrUsers);
            seleniumActions.IsElementPresent(closeAlert);
            seleniumActions.Click(closeAlert);
        }

        public void deleteGroup()
        {
            seleniumActions.SwitchToFrame(iframeMenuData); 
            seleniumActions.MoveToElement(checkboxGroupName);
            seleniumActions.Click(checkboxGroupName); 
            seleniumActions.MoveToElement(buttonDeleteGroup);
            seleniumActions.Click(buttonDeleteGroup);
            seleniumActions.Click(By.XPath("//button[@id='popup_ok']"));
            seleniumActions.Wait(2);
            seleniumActions.IsElementPresent(closeAlert);
            seleniumActions.Click(closeAlert);

        }

        public void createSupplierType()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.MoveToElement(supplierType);
            seleniumActions.Click(supplierType);
            seleniumActions.Wait(2);

            seleniumActions.SwitchToFrame(iframeMenuData);
            seleniumActions.MoveToElement(buttonAddSupplierType);
            seleniumActions.Click(buttonAddSupplierType);
            seleniumActions.SendKeys(inputSupplierTypeName, "Automation");
            seleniumActions.Click(buttonSaveSupplierType);
            seleniumActions.Wait(2);
            seleniumActions.IsElementPresent(closeAlert);
            seleniumActions.Click(closeAlert);

        }

        public void editSupplierType()
        {

            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.MoveToElement(supplierType);
            seleniumActions.Click(supplierType);
            seleniumActions.Wait(2);

            seleniumActions.SwitchToFrame(iframeMenuData);
            seleniumActions.MoveToElement(By.XPath("//td[contains(text(),'Automation')]//parent::tr/td[@class=' dt-body-center actioncol']"));
            seleniumActions.Click(iconEditSupplierType);
            seleniumActions.SendKeys(inputSupplierTypeName, "Automation1");
            seleniumActions.Click(buttonSaveSupplierType);
            seleniumActions.Wait(2);
            seleniumActions.IsElementPresent(closeAlert);
            seleniumActions.Click(closeAlert);
        }

        public void createPartType()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.MoveToElement(supplierType);
            seleniumActions.Click(supplierType);
            seleniumActions.Wait(2);

            seleniumActions.SwitchToFrame(iframeMenuData);

            seleniumActions.SwitchToFrame(iframePartType);
            seleniumActions.Click(dropdownSupplierType);

            seleniumActions.ScrollToElement(lstSupplierTypeAutomation);
            seleniumActions.Click(lstSupplierTypeAutomation);
            seleniumActions.Wait(3);

            seleniumActions.ScrollToElement(buttonAddSupplierType);
            seleniumActions.Click(buttonAddSupplierType);
            seleniumActions.SendKeys(inputPartTypeName, "Automation");
            seleniumActions.Click(buttonSavePartType);
        }

        public void editPartType()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.MoveToElement(supplierType);
            seleniumActions.Click(supplierType);
            seleniumActions.Wait(2);

            seleniumActions.SwitchToFrame(iframeMenuData);

            seleniumActions.SwitchToFrame(iframePartType);
            seleniumActions.Click(dropdownSupplierType);

            seleniumActions.ScrollToElement(lstSupplierTypeAutomation);
            seleniumActions.Click(lstSupplierTypeAutomation);
            

            seleniumActions.MoveToElement(By.XPath("//table[@id='grdPartTypeMaster']//td[@class=' dt-body-center actioncol']"));
            seleniumActions.Wait(2);
            seleniumActions.Wait(2);
            seleniumActions.Click(iconEditPartType);
            seleniumActions.SendKeys(inputPartTypeName, "Automation1");
            seleniumActions.Click(buttonSavePartType);
        }

        public void setSupplierLevel()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.MoveToElement(supplierBusinessRule);
            seleniumActions.Click(supplierBusinessRule);
            seleniumActions.SwitchToFrame(iframeMenuData);

           // string originalWindow = _driver.CurrentWindowHandle;
            seleniumActions.MoveToElement(By.XPath("//a[@id='ahref_divDocProLevelSelector']/span"));
            seleniumActions.Click(By.XPath("//a[@id='ahref_divDocProLevelSelector']/span"));

            if (seleniumActions.IsElementPresent(By.XPath("//a[@id='btnEditParentLavel' and @style='display: none;']")))
            {
               // seleniumActions.Click(delParentLevelSelector);
                Console.WriteLine("Supplier Level Already present");
               // seleniumActions.IsElementPresent(closeAlert);
               // seleniumActions.Click(closeAlert);
                //seleniumActions.Wait(2);

            }
            else
            {
               seleniumActions.MoveToElement(editParentLevelSelector);
                seleniumActions.Click(editParentLevelSelector);
                seleniumActions.Wait(2);

                string originalWindow = _driver.CurrentWindowHandle;
                //Get all window handles
                IReadOnlyCollection<string> allWindows = _driver.WindowHandles;
                // Switch to the new window
                foreach (string windowHandle in allWindows)
                {
                    if (windowHandle != originalWindow)
                    {
                        _driver.SwitchTo().Window(windowHandle);
                        Console.WriteLine("The present title name is ------->" + _driver.SwitchTo().Window(windowHandle).Title);
                        break;
                    }
                }
                Console.WriteLine("Set the Level as ------->SupplierManagement");
                seleniumActions.Wait(5);
                seleniumActions.MoveToElement(inputDocproDocName);
                seleniumActions.SendKeys(inputDocproDocName, "SupplierManagement");
                seleniumActions.Click(btnDocproPopupSearch);
                seleniumActions.Click(By.XPath("//a/span[contains(text(),'SupplierManagement')]"));

                _driver.SwitchTo().Window(originalWindow);

                seleniumActions.SwitchToDefaultContent();
                seleniumActions.SwitchToIframes(iframe_DetailView, iframeMenuData);
                seleniumActions.IsElementPresent(closeAlert);
                seleniumActions.Click(closeAlert);
            }
        }



        public void checkButtonsInSupplierInformation()
        {
            if (seleniumActions.IsElementPresent(btnCreateSupplierEvaluationRequest))
            {

                Console.WriteLine("Evaluation Request Button is enabled");
            }
            else if (seleniumActions.IsElementPresent(newSupplierButton))
            {
                Console.WriteLine("Evaluation Request Button is Disabled");

            }
        }

        public void setSupplierEvaluationBusinessRuleasNO()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.MoveToElement(supplierBusinessRule);
            seleniumActions.Click(supplierBusinessRule);
            seleniumActions.SwitchToFrame(iframeMenuData);

            seleniumActions.Click(bRuleSupplierEvaluationNo);
            //seleniumActions.Click(bRuleAuditAgainstPartsYes);
            //seleniumActions.Click(bRuleVMFNo);
            //seleniumActions.Click(bRuleParentSupplierNo);
            //seleniumActions.SwitchToDefaultContent();

        }

        public void setAuditAgainstPartBusinessRuleasYes()
        {
            seleniumActions.Wait(3);
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.MoveToElement(supplierBusinessRule);
            seleniumActions.Click(supplierBusinessRule);
            seleniumActions.SwitchToFrame(iframeMenuData);

            seleniumActions.Click(bRuleSupplierEvaluationNo);
            seleniumActions.Click(bRuleAuditAgainstPartsYes);
            //seleniumActions.Click(bRuleVMFNo);
            //seleniumActions.Click(bRuleParentSupplierNo);
            //seleniumActions.SwitchToDefaultContent();

        }

        public void verifyFieldsInSupplierDetailsPage()
        {
            seleniumActions.MoveToElement(newSupplierButton);
            seleniumActions.Click(newSupplierButton);
            seleniumActions.Wait(2);
            String suppliercode = seleniumActions.GetAttributeValue(By.XPath("//input[@id='txtCode']"), "value");
            if (suppliercode.Length > 0)            
                Console.WriteLine("Temporary supplier code is available");            
            else            
                Console.WriteLine("Temporary supplier code is not available");


            if (seleniumActions.IsElementPresent(By.XPath("//label[contains(text(),'Actions Required')]")))
                Console.WriteLine("SAM SEM PPAP checkboxes are available");
            else
                Console.WriteLine("SAM SEM PPAP checkboxes are not available");
            
        }


        public void addParts()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Click(tabPartsDEtails);
            seleniumActions.Wait(3);
            seleniumActions.Click(btnAddParts);
            seleniumActions.Wait(3);
            seleniumActions.Click(By.XPath("//span[@id='select2-cmbSite-container']"));
            seleniumActions.Click(By.XPath("//ul[@id='select2-cmbSite-results']/li/span[contains(text(),'Corporate')]"));
            seleniumActions.Click(By.XPath("//span[@id='select2-cmbType-container']"));
            seleniumActions.Click(By.XPath("//ul[@id='select2-cmbType-results']/li/span[contains(text(),'Default')]"));
            seleniumActions.Click(By.XPath("//span[@id='select2-cmbTree-container']"));
            seleniumActions.Click(By.XPath("//ul[@id=\"select2-cmbTree-results\"]/li/span[contains(text(),'Part')]"));
            seleniumActions.Wait(3);
            seleniumActions.MoveToElement(By.XPath("//input[@id=\"txtSearchTree_tvwProductionItem\"]"));
            seleniumActions.SendKeys(By.XPath("//input[@id=\"txtSearchTree_tvwProductionItem\"]"), text: "test");
            seleniumActions.Wait(3);
            seleniumActions.Click(By.XPath("//span[contains(text(),'Test')]//parent::a//parent::li//span[contains(@class,'checkbox')]"));
            seleniumActions.MoveToElement(By.XPath("//button[@id='btnPartDone']"));
            seleniumActions.Click(By.XPath("//button[@id='btnPartDone']"));
            seleniumActions.Wait(3);
            seleniumActions.SwitchToDefaultContent();

        }

        public void addLocationDetails(String suppliername)
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);

            if (seleniumActions.IsElementPresent(By.XPath("//td[contains(text(),'Test')]//parent::tr/td/img[@title='Supplier Location']")))
            {
                seleniumActions.Click(By.XPath("//td[contains(text(),'Test')]//parent::tr/td/img[@title='Supplier Location']"));
            }
            else
            {
                seleniumActions.Click(By.XPath(" //td[contains(text(),'Test')]//parent::tr/td"));
                seleniumActions.Click(By.XPath(" //td[contains(text(),'Test')]//parent::tr//parent::tbody/tr[@class='child']//*/img[@title='Supplier Location']"));
            }
           
            seleniumActions.MoveToElement(By.XPath("//button[@id='btn_add_hold']"));
            seleniumActions.Click(By.XPath("//button[@id='btn_add_hold']"));
            seleniumActions.SendKeys(By.XPath("//textarea[@name='LocationCode']"), text: utility.GenerateRandomText(5));
            seleniumActions.SendKeys(By.XPath("//textarea[@name='Street']"), text:"Supplier Street 1");
            seleniumActions.SendKeys(By.XPath("//input[@name='Zipcode']"), text: "100001");
            seleniumActions.Click(By.XPath("//button[@id='btnSaveDetails_SUAddressGridControl']"));//a[@id='alert_ok']
            seleniumActions.Click(By.XPath("//a[@id='alert_ok']"));
           // String suppliername = scenarioContext["SupplierName"].ToString();
            seleniumActions.Click(By.XPath("//div/h5[contains(text(),'"+suppliername+"')]/following-sibling::button[@title='Close']"));
            seleniumActions.SwitchToDefaultContent();

        }

        public void uncheckSAMandSEM()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            // seleniumActions.Click(tabPartsDEtails);           
            seleniumActions.Click(By.XPath("//td[contains(text(),'Test')]/parent::tr/td/input[@name='chkVAM']"));
            seleniumActions.Click(By.XPath("//td[contains(text(),'Test')]/parent::tr/td/input[@name='chkVEM']"));
            seleniumActions.SwitchToDefaultContent();

        }

        public void addNewProject(String supplierName)
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
           // seleniumActions.MoveToElement(By.XPath("//li[@class=' PAactive']"));
            seleniumActions.Click(By.XPath("//li[@id='3']"));
            seleniumActions.Wait(5);
            //seleniumActions.MoveToElement(By.XPath("//div[@id='PPLProjectListGrid_wrapper']//li/button[contains(text(),'New')]"));
            seleniumActions.ActionsClick(By.XPath("//div[@id='PPLProjectListGrid_wrapper']//li/button[contains(text(),'New')]"));

            String projectname= supplierName+"-"+utility.CurrentTime();
            seleniumActions.Wait(3);
            seleniumActions.Click(By.XPath("//span[@id='select2-SelectedPillarID-container']"));
            seleniumActions.Click(By.XPath("//li/span[contains(text(), 'Supplier PPAP')]"));
            seleniumActions.Wait(5);
            seleniumActions.SendKeys(By.XPath("//input[@id='ProjectName']"), text: projectname);
            seleniumActions.SendKeys(By.XPath("//input[@id='ProjectShortName']"), text: projectname);
            //seleniumActions.Click(By.XPath("//span[@id='select2-SelectedPillarID-container']"));
            //seleniumActions.Click(By.XPath("//li/span[contains(text(), 'Supplier PPAP')]"));
            
            seleniumActions.ScrollToElement(By.XPath("//label[contains(text(),'BOM Import')]/parent::div/div/iframe[@id='iframe']"));
            seleniumActions.ScrollToElement(By.XPath("//span[@id='divSupplierSpan']"));
            seleniumActions.SwitchToFrame(By.XPath("//label[contains(text(),'BOM Import')]/parent::div/div/iframe[@id='iframe']"));
            seleniumActions.MoveToElement(By.XPath("//button[@onclick='parent.OpenSupplierTree(); return false;']"));
            seleniumActions.Wait(3);
            seleniumActions.ActionsClick(By.XPath("//button[@onclick='parent.OpenSupplierTree(); return false;']"));
            //seleniumActions.Wait(3);
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToIframes(iframe_DetailView);            
            seleniumActions.Click(By.XPath("//ul[@id='tvSupplier']/li/span[2]"));
            seleniumActions.Wait(5);
            seleniumActions.Click(By.XPath("//div[@class='ui-dialog-buttonpane ui-widget-content ui-helper-clearfix modal-footer']/div/button[contains(text(),'Save')]"));
            
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Wait(3);
            seleniumActions.Click(By.XPath("//div[@class='row no-gutters align-items-center']/div/button[@id='btnSave']"));
            //seleniumActions.Wait(3);
            //seleniumActions.Click(By.XPath("//div[@class='row no-gutters align-items-center']/div/button[@id='btnSave']"));
            seleniumActions.SendKeys(By.XPath("//textarea[@id='txtCharterComments']"), text: projectname);
            seleniumActions.Click(By.XPath("//button[@class='btn btn-mini btn-success']"));
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.Wait(5);

        }

        public void addTaskDetails()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Click(By.XPath("//li/i[@onclick='openDeliverableInfoWindow();']"));
        }
        #endregion



    }
}
