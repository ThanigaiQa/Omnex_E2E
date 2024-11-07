using System.Reflection;
using OMNEX.AUTOMATION.Data.WEB;
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
        private LoginPage loginPage;
        #endregion



        #region Constructor
        public Supplier(IWebDriver driver, ScenarioContext scenariocontext)
        {
            _driver = driver;
            seleniumActions = new SeleniumActions(_driver);
            loginPage = new LoginPage(_driver);
            utility = new Utilities();
            scenarioContext = scenariocontext;
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
        By inboxSM => By.XPath("//div[@class='ibox-content']//div[contains(text(),'Supplier Management')]");
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

        #region Gantt page
        By deliverableFirstRow => By.XPath("//*[@id='gantt_container_Table']//tr//div[3]//parent::td");
        By newDeliverableInRightClick => By.XPath("//div[@id='context-menu-layer']//following::ul/li[2]//span[contains(text(),'New Deliverable')]");
        By finishdateinSeconRow => By.XPath(" //table[@class='ui-selectable ui-grid-body-table']//tr[2]/td[2]");
        By resourcesInSecondRow => By.XPath("//table[@class='ui-selectable ui-grid-body-table']//tr[2]/td[8]");
        By saveGanttPage => By.XPath(" //div[@id='MenuContent']//i[@title='Save' and @onclick='save();']");
        By deliverableInfo => By.XPath("//li/i[@onclick='openDeliverableInfoWindow();']");
        By serialNoinFirstRow => By.XPath("//table[@class='ui-frozen-body-table ui-selectable ui-grid-body-table']//tr[1]/td[2]");
        By serialNoinSecondRow => By.XPath("//table[@class='ui-frozen-body-table ui-selectable ui-grid-body-table']//tr[2]/td[2]");
        By btnAttachInputDoc => By.XPath("//button[@id='btnAttachIP']");
        By btnAttachLocal => By.XPath("//label[@for='fileIP']");
        By inputLocalFile => By.XPath("//form[@id='ajaxUploadForm']//label[@class='custom-file-upload'])[1]//following::input[1]");
        By btnAddInput => By.XPath("//button[@id='btnAddInput']");
        By inputDocName => By.XPath("//input[@id='txtDocName']");
        By clsDeliveryInfo => By.XPath("//div[@aria-describedby='openDeliverableInfoWindow']//button[@class='ui-dialog-titlebar-close bg-transparent border-0 p-0']");
        By publishToDocpro => By.XPath("//li/i[@id='btnPublish']");
        By publishComments => By.XPath("//textarea[@id='txtPlanComments']");
        By lnkInputDocument => By.XPath("//table[@id='AttachmentListGrid']//td[7]/a");
        By iconOutputDocumentClip => By.XPath("//table[@id='AttachmentListGrid']//*[local-name()='svg' and @data-icon='paperclip']");
        By lblPercentageCompleteLink => By.XPath("//label[@id='lblProgressPercent']");
        By outputDocName => By.XPath("//form[@action='/Common/ProjectPlanner/DeliverableInfo/OutputAttachment']//input[@id='txtDocName']");
        By btnAddAttachment => By.XPath("//button[@id='btnAdd']");
        By lblOutputAttachment => By.XPath("//label[@for='fileOP']");
        By btnAddPeriodicUpdate => By.XPath("//button[@id='btn_add_hold']");
        By inputPercentageOfTask => By.XPath("//input[@name='Percent']");
        By inputHourstoComplete => By.XPath("//input[@name='Hours']");
        By savePeriodicdetails => By.XPath("//button[@id='btnSaveDetails_PeiodicUpdateResourceGridcontrol']");
        By iconClosePeriodicUpdatePopup => By.XPath("//div[@aria-describedby='divshowPeriodicUpdateResourcedialog']//button[@title='Close']");
        By iconCloseDeliverableInfo => By.XPath("//div[@aria-describedby='openDeliverableInfoWindow']//button[1]");
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
        static By iframeOpenDeliverable => By.XPath("//iframe[@id='ifropenDeliverableInfoWindow']");
        static By iframeContainer => By.XPath("//iframe[@id='iframeContainer']");
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
            scenarioContext["PrimaryEmail"] = primaryMail;
            scenarioContext["SecondaryEmail"] = secondaryMail;

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
            seleniumActions.Click(By.XPath("//table[@id='SuSupplierGridViewControl']//td/a[contains(text(),'" + SupplieName + "')]"));
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
            seleniumActions.SendKeys(inputGroupName, "Automation Group");
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
            seleniumActions.SendKeys(By.XPath("//textarea[@name='Street']"), text: "Supplier Street 1");
            seleniumActions.SendKeys(By.XPath("//input[@name='Zipcode']"), text: "100001");
            seleniumActions.Click(By.XPath("//button[@id='btnSaveDetails_SUAddressGridControl']"));//a[@id='alert_ok']
            seleniumActions.Click(By.XPath("//a[@id='alert_ok']"));
            // String suppliername = scenarioContext["SupplierName"].ToString();
            seleniumActions.Click(By.XPath("//div/h5[contains(text(),'" + suppliername + "')]/following-sibling::button[@title='Close']"));
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

            String projectname = supplierName + "-" + utility.CurrentTime();
            scenarioContext["ProjectName"] = projectname;
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
            seleniumActions.Wait(10);

        }

        public void addTaskDetails()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);

            //Right click on deliverable and add new task
            seleniumActions.WaitForElementToExists(deliverableFirstRow);
            seleniumActions.Wait(2);
            seleniumActions.ContextClick(deliverableFirstRow);
            seleniumActions.Click(newDeliverableInRightClick);

            //scroll to the Resources field and select the Admin-1 user for the new task
            seleniumActions.ScrollToElement(resourcesInSecondRow);
            seleniumActions.Click(resourcesInSecondRow);
            seleniumActions.Wait(2);
            seleniumActions.Click(resourcesInSecondRow);
            seleniumActions.Click(By.XPath("//table[@class='ui-selectable ui-grid-body-table']//tr[2]/td[8]//span[@class='ui-icon ui-icon-triangle-1-s']"));
            seleniumActions.Click(By.XPath("//label[contains(text(),'--Admin-1 ')]/preceding-sibling::input"));
            seleniumActions.Click(By.XPath("//div[@class='overlay']"));
            seleniumActions.Wait(2);

            //scroll to the finish date and add two days from present date for finish
            seleniumActions.ScrollToElement(finishdateinSeconRow);
            seleniumActions.Click(finishdateinSeconRow);
            seleniumActions.SendKeys(By.XPath("//table[@class='ui-selectable ui-grid-body-table']//tr[2]/td[2]/div/input"), utility.DateAfterAddingDays(2));

            //save the task
            seleniumActions.Click(saveGanttPage);
            seleniumActions.Wait(5);
            seleniumActions.SwitchToDefaultContent();
        }

        public void addInputdoc()
        {
            seleniumActions.Wait(5);
            seleniumActions.SwitchToIframes(iframe_DetailView);

            //Select thes erial no. of first task row
            seleniumActions.Click(serialNoinFirstRow);
            seleniumActions.Click(deliverableInfo);
            seleniumActions.Wait(3);
            seleniumActions.SwitchToFrame(iframeOpenDeliverable);
            seleniumActions.WaitForElementToExists(btnAttachInputDoc);
            seleniumActions.Click(btnAttachInputDoc);
            seleniumActions.Wait(3);

            seleniumActions.WaitForElementToExists(iframeContainer);
            seleniumActions.SwitchToFrame(iframeContainer);
            seleniumActions.WaitForElementToExists(btnAttachLocal);
            seleniumActions.SendKeys(inputDocName, text: "Doc for Supplier Primary User");

            var path = new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath;            
            var actualPath = path.Substring(0, path.LastIndexOf("\\bin"));            
            var projectPath = new Uri(actualPath).LocalPath;
            
            seleniumActions.Click(btnAttachLocal);
            seleniumActions.UploadFile(projectPath.ToString(), Constants.UploadFilePath_Book);
            seleniumActions.Wait(5);
            seleniumActions.Click(btnAddInput);

            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Wait(3);
            seleniumActions.Click(clsDeliveryInfo);
            seleniumActions.SwitchToDefaultContent();
        }

        public void addInputdocFortask2()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);

            //Select thes erial no. of first task row
            seleniumActions.Click(serialNoinSecondRow);
            seleniumActions.Click(deliverableInfo);
            seleniumActions.Wait(3);
            seleniumActions.SwitchToFrame(iframeOpenDeliverable);
            seleniumActions.WaitForElementToExists(btnAttachInputDoc);
            seleniumActions.Click(btnAttachInputDoc);
            seleniumActions.Wait(5);

            seleniumActions.WaitForElementToExists(iframeContainer);
            seleniumActions.SwitchToFrame(iframeContainer);
            seleniumActions.WaitForElementToExists(btnAttachLocal);
            seleniumActions.SendKeys(inputDocName, text: "Doc for Supplier Secondary User ");


            var path = new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath;           
            var actualPath = path.Substring(0, path.LastIndexOf("\\bin"));           
            var projectPath = new Uri(actualPath).LocalPath;
           
            seleniumActions.Click(btnAttachLocal);
            seleniumActions.UploadFile(projectPath.ToString(), Constants.UploadFilePath_Test);
            seleniumActions.Wait(5);
            seleniumActions.Click(btnAddInput);

            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Wait(3);
            seleniumActions.Click(clsDeliveryInfo);
            seleniumActions.SwitchToDefaultContent();
        }
        #endregion

        public void publishProjectToDocpro()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Click(publishToDocpro);
            seleniumActions.Wait(2);
            seleniumActions.SendKeys(publishComments, text: "Automation PPAP");
            seleniumActions.Click(By.XPath("//button[@title='Save']"));
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.Wait(5);
        }

        public void openProjectandTask(String userType)
        {
           
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Wait(5);
            seleniumActions.ActionsClick(By.XPath("//table[@id='PPLProjectListGrid']//td/a[contains(text(),'" + scenarioContext["ProjectName"].ToString() + "')]"));
            seleniumActions.Wait(5);
           if (userType.Equals("PrimaryUser"))
            {
               seleniumActions.Click(serialNoinFirstRow);
            }
            else
            {
               seleniumActions.Click(serialNoinSecondRow);
           }
            //seleniumActions.Click(deliverableInfo);

        }

        public void selectDeliverableInfoForSecondaryUser()
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Click(By.XPath("//table[@class='ui-selectable ui-grid-body-table']//tr[1]/td[2]"));
        }

        public void attachOutputDocument()
        {
            
            
            seleniumActions.Click(deliverableInfo);
            seleniumActions.Wait(5);
            seleniumActions.SwitchToFrame(iframeOpenDeliverable);
            seleniumActions.Click(lnkInputDocument);
            seleniumActions.Wait(3);

            seleniumActions.Click(iconOutputDocumentClip);
            seleniumActions.WaitForElementToExists(iframeContainer);
            seleniumActions.SwitchToFrame(iframeContainer);

            var path = new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath;
            var actualPath = path.Substring(0, path.LastIndexOf("\\bin"));
            var projectPath = new Uri(actualPath).LocalPath;

            seleniumActions.Click(lblOutputAttachment); 
            seleniumActions.UploadFile(projectPath.ToString(), Constants.UploadFilePath_Test);
            seleniumActions.Wait(3);
            seleniumActions.SendKeys(outputDocName, text: "Output Doc attached by " + scenarioContext["PrimaryEmail"].ToString());
            seleniumActions.Click(btnAddAttachment);
            seleniumActions.SwitchToDefaultContent();

        }
        public void attachOutputDocument2()
        {


            seleniumActions.Click(deliverableInfo);
            seleniumActions.Wait(5);
            //seleniumActions.SwitchToFrame(iframeOpenDeliverable);
            seleniumActions.WaitForElementToExists(iframeContainer);
            seleniumActions.SwitchToFrame(iframeContainer);
            seleniumActions.Click(lnkInputDocument);
            seleniumActions.Wait(3);

            seleniumActions.Click(iconOutputDocumentClip);
            
            

            var path = new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath;
            var actualPath = path.Substring(0, path.LastIndexOf("\\bin"));
            var projectPath = new Uri(actualPath).LocalPath;
            seleniumActions.SwitchToFrame(iframeContainer);
            seleniumActions.Click(lblOutputAttachment);
            seleniumActions.UploadFile(projectPath.ToString(), Constants.UploadFilePath_Test);
            seleniumActions.Wait(3);
            seleniumActions.SendKeys(outputDocName, text: "Output Doc attached by " + scenarioContext["SecondaryEmail"].ToString());
            seleniumActions.Click(btnAddAttachment);
            seleniumActions.SwitchToDefaultContent();

        }

        public void updateTaskPercentage(string taskPercent)
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);            
            seleniumActions.SwitchToFrame(iframeOpenDeliverable);
            seleniumActions.Click(lblPercentageCompleteLink);

            seleniumActions.WaitForElementToExists(iframeContainer);
            seleniumActions.SwitchToFrame(iframeContainer);
            seleniumActions.Click(btnAddPeriodicUpdate);
            seleniumActions.SendKeys(inputPercentageOfTask, text: taskPercent);
            seleniumActions.SendKeys(inputHourstoComplete, text: "8");
            seleniumActions.Click(savePeriodicdetails);           
           
            seleniumActions.SwitchToParentFrame();
            seleniumActions.Click(iconClosePeriodicUpdatePopup);
            seleniumActions.SwitchToParentFrame();
            seleniumActions.Click(iconCloseDeliverableInfo);
            //table[@class='ui-frozen-body-table ui-selectable ui-grid-body-table']//tr[1]/td[5]/div/i[@title='Deliverable completed']
            seleniumActions.SwitchToDefaultContent();
           // seleniumActions.SwitchToFrame(iframe_DetailView);

        }
        public void updateTaskPercentage2()
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.SwitchToFrame(iframeContainer);
            seleniumActions.Click(lblPercentageCompleteLink);

            seleniumActions.WaitForElementToExists(iframeContainer);
            seleniumActions.SwitchToFrame(iframeContainer);
            seleniumActions.Click(btnAddPeriodicUpdate);
            seleniumActions.SendKeys(inputPercentageOfTask, text: "100");
            //seleniumActions.SendKeys(By.XPath("//input[@name='EndDate']"), utility.DateAfterAddingDays(0));
            seleniumActions.Click(By.XPath("//input[@name='EndDate']"));
            seleniumActions.Click(By.XPath("//td[@class='today day']"));
            seleniumActions.SendKeys(inputHourstoComplete, text: "8");
            seleniumActions.Click(savePeriodicdetails);

            seleniumActions.SwitchToParentFrame();
            seleniumActions.Click(iconClosePeriodicUpdatePopup);
            seleniumActions.SwitchToParentFrame();
            seleniumActions.Click(iconCloseDeliverableInfo);
            //table[@class='ui-frozen-body-table ui-selectable ui-grid-body-table']//tr[1]/td[5]/div/i[@title='Deliverable completed']
            seleniumActions.SwitchToDefaultContent();
            // seleniumActions.SwitchToFrame(iframe_DetailView);

        }

        public void updateStatusOfProject()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            // seleniumActions.MoveToElement(By.XPath("//li[@class=' PAactive']"));
            seleniumActions.Click(By.XPath("//li[@id='3']"));
            seleniumActions.Wait(5);
            seleniumActions.ActionsClick(By.XPath("//table[@id='PPLProjectListGrid']//td/a[contains(text(),'" + scenarioContext["ProjectName"].ToString() + "')]"));
            seleniumActions.Click(By.XPath("//i[@id='BtnCharter']"));
           // seleniumActions.VerifyElementIsDisplayed(By.XPath("//div[contains(text(),'All the deliverables in the project are completed')]"));
            seleniumActions.Click(By.XPath("//select[@id='ProjectStatus']"));
            seleniumActions.SelectDropDown(By.XPath("//select[@id='ProjectStatus']"), "value", "3");
            seleniumActions.Click(By.XPath("//button[@id='btnSave']"));
            seleniumActions.SendKeys(By.XPath("//textarea[@id='txtCharterComments']"), text: "Completed Automation");
            seleniumActions.Click(By.XPath("//button[@class='btn btn-mini btn-success']"));
            seleniumActions.SwitchToDefaultContent();
        }
    }
}
