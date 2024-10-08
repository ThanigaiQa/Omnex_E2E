
using OMNEX.AUTOMATION.Data.WEB;
using OMNEX.AUTOMATION.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Reflection.Metadata;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Reflection;
using System.Diagnostics.Metrics;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Reactive.Subjects;
using TechTalk.SpecFlow;
using System.Drawing;

namespace OMNEX.AUTOMATION.PageObjects.WEB
{
    public class Supplier
    {
        #region Declaration
        private IWebDriver _driver;
        private SeleniumActions seleniumActions;
        public Utilities utility;
        public Dashboard dashboard;
        #endregion



        #region Constructor
        public Supplier(IWebDriver driver)
        {
            _driver = driver;
            seleniumActions = new SeleniumActions(_driver);
            utility = new Utilities();
            dashboard = new Dashboard(_driver);
            
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
        By newSupplierButton => By.XPath("//*[@id = 'btnAdd' or @id='btnadd']");        
        By saveSupplier => By.XPath("//button[@id='btnSave']");
        By alertInSupplier => By.XPath("//div[@class='alert alert-warning alert-dismissible border-bottom']/a");
        By closeAlert => By.XPath("//a[@id='alert_ok']");
        #endregion
       



        #region BusinessRule page
        By supplierBusinessRule => By.XPath("//div[@title='Supplier BusinessRule']");
        By bRuleSupplierEvaluationYes => By.XPath("//input[@id='rdoIsHLYes']");
        By bRuleAuditAgainstPartsYes => By.XPath("//input[@id='rdoIsAuditYes']");

        By bRuleSupplierEvaluationNo => By.XPath("//input[@id='rdoIsHLNo']");
        By bRuleAuditAgainstPartsNo => By.XPath("//input[@id='rdoIsAuditNo']");
        By bRuleVMFNo => By.XPath("//input[@id='rdoIsVMFFormNo']");
        By bRuleParentSupplierNo => By.XPath("//input[@id='rdoIsParentEntityNo']");
        #endregion

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
            seleniumActions.Wait(2);
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.MoveToElement(newSupplierButton);
            seleniumActions.Click(newSupplierButton);
            seleniumActions.SwitchToDefaultContent();  
        }

        public void EnterMandatoryFieldsforSupplier()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            String temp = seleniumActions.GetAttributeValue(By.XPath("//input[@id='txtCode']"), "value");
            ConfigHelper.SetSupplierCode(temp);

            validateSupplierField("SupplierName");
            String primaryMail = "primary@" + temp + ".com";
            String secondaryMail = "secondary@" + temp + ".com";
           
            temp = "Supplier " + temp;

            seleniumActions.SendKeys(supplierName, text: temp);
            ConfigHelper.SetSupplierName(temp);
            //temp = temp.Replace("-", "");
            //temp = temp.Replace("\\s", "");
            
            ConfigHelper.SetSupplierEmail(primaryMail);

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
            Console.WriteLine("Supplier created " + ConfigHelper.GetSupplierName());
            Console.WriteLine("Primary email created " + primaryMail);
            Console.WriteLine("Secondary email created " + secondaryMail);

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
            ConfigHelper.SetSupplierCode(temp);

            validateSupplierField("SupplierName");
            temp = "Supplier " + temp;
            seleniumActions.SendKeys(supplierName, text: temp);
            ConfigHelper.SetSupplierName(temp);

            validateSupplierField("Supplier Name");
            seleniumActions.SendKeys(By.XPath("//input[@id='txtSupplierName']"), text: temp);

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

            seleniumActions.MoveToElement(By.XPath("//a[@id='ahref_divDocProLevelSelector']/span"));
            seleniumActions.Click(By.XPath("//a[@id='ahref_divDocProLevelSelector']/span"));

            seleniumActions.MoveToElement(By.XPath("//a[@id='btnEditParentLavel']"));
            seleniumActions.Click(By.XPath("//a[@id='btnEditParentLavel']"));
            seleniumActions.Wait(3);

        }
        #endregion



    }
}
