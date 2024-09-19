using Microsoft.VisualStudio.TestTools.UnitTesting;
using OMNEX.AUTOMATION.Data.WEB;
using OMNEX.AUTOMATION.Helpers;
using OpenQA.Selenium;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OMNEX.AUTOMATION.PageObjects.WEB
{
    public class DocProModule
    {
        #region Declaration
        private IWebDriver _driver;
        private SeleniumActions seleniumActions;
        public Utilities utility;

        #endregion

        #region Constructor
        public DocProModule(IWebDriver driver)
        {
            _driver = driver;
            seleniumActions = new SeleniumActions(_driver);
            utility = new Utilities();
        }

        #endregion

        #region pageLocators

        By lblHeader => By.XPath("//h2");
        By sideMenuContainer => By.XPath("//ul[@id='sidemenu']");
        By lblSetup => By.XPath("//div[contains(text(),'Setup')]");
        By lblSuiteSetup => By.XPath("//div[@class='sub-menu']//span[contains(text(),'Suite Setup')]");
        By lblLevelsPage => By.XPath("(//a[@class='submenu_list_link has-arrow']//following-sibling::ul[@class='inner_submenu']//span[contains(text(),'Levels')])[2]");
        By txtSuiteLevelHeader => By.XPath("//h5[text()='Suite  Levels']");
        By inpLevelNumber => By.XPath("//input[@id='txtLevelNum']");
        By popUp_Yes => By.XPath("//button[@id='popup_ok']");
        By inp_Levelname => By.XPath("//input[@id='txtLevelName']");
        By btn_save => By.XPath("//button[@id='btnSave']");
        By btn_refreshLevel => By.XPath("//*[local-name()='svg' and @id='btnreferesh']");
        By folderManagement_Tab => By.XPath("//div[contains(text(),'Folder Management')]");
        By phd_SearchByFolder => By.XPath("//input[@placeholder='Search By Folder']");
        By btnSearch_SearchByFolder => By.XPath("//*[local-name()='svg' and @title='Search']");
        By chk_InUse => By.XPath("//label[@for='chkInUse']");
        By lblDocuments => By.XPath("//div[text()='Documents']");
        By breadCrumb_NewDocRequest => By.XPath("(//li[@class='breadcrumb-item active']//a[contains(text(),'New Document Request')])[1]");
        By btn_LevelSelector => By.XPath("(//span[@id='levelselectionDiv'])[1]");
        By inp_ChooseFile => By.XPath("(//input[@name = 'MyFile'])[1]");
        By chk_OnlineDocument => By.XPath("(//label[@for='chkIsonlinedoc'])[1]");
        By txtDocNumber => By.XPath("//input[contains(@id,'txtnum')]");
        By txtDocName => By.XPath("//input[contains(@id,'txtname')]");
        By btnAdd => By.XPath("(//button[@value='Add'])[1]");
        By msg_DocUploadedSuccessfully => By.XPath("(//*[contains(text(),'Document Uploaded Successfully')])[2]");
        By tbl_LevelSelection => By.XPath("(//div[@id='dialog-popuplevel'])[1]");
        By breadCrumb_Actions => By.XPath("(//li[@class='breadcrumb-item active']//a[contains(text(),'Actions')])[1]");
        By lblActions => By.XPath("//h5[contains(text(),'Actions')]");
        By lnk_InheritFromParent => By.XPath("//*[@id = 'aEditRoute']");
        By drp_NewRoute => By.XPath("//span[contains(@id,'tddrpdownNewRoute')]");
        By btn_Close => By.XPath("//button[@title='Close']");
        By menu_PendingRequests => By.XPath("//td[@title='Pending Requests']");
        By lbl_DocNumber => By.XPath("//th[text()='Document Number']");
        By lbl_DocName => By.XPath("//th[text()='Document Name']");
        By lbl_Date => By.XPath("//th[text()='Date']");
        By lbl_Revision => By.XPath("//th[text()='Revision']");
        By lbl_Status => By.XPath("//th[text()='Status']");
        By drp_SearchFilter => By.XPath("//select[contains(@class,'datatablefilter')]");
        By ddlDocName_SearchFilter => By.XPath("//select[contains(@class,'datatablefilter')]//option[@value='name']");
        By phd_SearchFilter => By.XPath("//input[@type='search']");
        By lbl_DocNameValue  => By.XPath("(//tr[@role='row']//td//div)[2]");
        By lbl_StatusValue  => By.XPath("(//a[@id='status'])[1]");
        By lnk_DocNumberValue => By.XPath("(//a[@id='EventOverDocumentNumber'])[1]");
        By btn_Terminate => By.XPath("(//span[contains(text(),'Terminate')])[1]");
        By btnYes_Popup => By.XPath("//button[@id='popup_ok']");
        By btnNo_PopUp => By.XPath("//button[@id='popup_cancel']");
        By btnMultiSearch => By.XPath("//a[@title='Multi Search']");
        By lblSearch_MultiSearch => By.XPath("//div[@class='dtsb-title']");
        By drpColumn_MultiSearch => By.XPath("(//div[@class='dtsb-criteria']//select)[1]");
        By ddlDocName_MultiSearch => By.XPath("(//div[@class='dtsb-criteria']//select//option[contains(text(),'Document Name')])[1]");
        By drpCondition_MultiSearch => By.XPath("(//div[@class='dtsb-criteria']//select)[2]");
        By ddlContains_MultiSearch => By.XPath("//div[@class='dtsb-criteria']//select//option[@value='contains']");
        By inp_MultiSearch => By.XPath("//input[@class='dtsb-value dtsb-input']");
        By btnAdvancedSearch_MultiSearch => By.XPath("//button[@title='Advanced Search']");
        By breadCrumb_BusinessRule => By.XPath("//li[@class='breadcrumb-item']//a[text()='Business Rule']");
        By menu_DocumentsBusinessRule => By.XPath("//div[@title='Documents)' or @title='Documents']");
        By btn_DisabledDCNForm => By.XPath("(//div[@class='switch form-control-inline']//span[contains(@class,'bootstrap-switch-danger')])[25]");
        By btn_EnabledDCNForm => By.XPath("(//div[@class='switch form-control-inline']//span[contains(@class,'bootstrap-switch-success')])[25]");
        By btn_SaveBusinessRule => By.XPath("//div[contains(@class,'card-footer')]//button[contains(@class,'btn-success')]");
        By btn_DoneBusinessRule => By.XPath("//button[@title='Done']");
        By inpSearch_AssignRoute => By.XPath("//span[contains(@class,'search')]//input[@type='search']");
        By svg_DCNFormIcon => By.XPath("(//*[local-name()='svg' and @title='Document Change Notice Form'])[1]");
        By rdoMajor_DCN => By.XPath("(//input[@id='rdmajor'])[1]");
        By drpRawMaterial_DCN => By.XPath("(//span[@id='select2-drpRawmaterial-container'])[1]");
        By drpWIP_DCN => By.XPath("(//span[@id='select2-drpWIP-container'])[1]");
        By drpFinishedGoods_DCN => By.XPath("(//span[@id='select2-drpfinishedgoods-container'])[1]");
        By drpNewProdStarts_DCN => By.XPath("(//span[@id='select2-drpproductstarts-container'])[1]");
        By drpTrainingReq_DCN => By.XPath("(//span[@id='select2-drptrainingrequirement-container'])[1]");
        By ddlRework_DCN => By.XPath("(//li[@class='select2-results__option']//span)[1]");
        By ddlCategoryA_DCN => By.XPath("(//li[@class='select2-results__option']//span)[1]");
        By btnClose_DCN => By.XPath("//div[@aria-describedby='divdocchangenoticeform']//button[@title='Close']");
        By lbl_DCNInfo => By.XPath("(//label[@for='DCN_Information'])[1]");
        By lnk_ViewDCN => By.XPath("(//div[@class='form-control-inline']//a[contains(text(),'View')])[1]");
        By lbl_RawMaterial => By.XPath("//b[contains(text(),'Raw Material')]"); 
        By lbl_WIP => By.XPath("//b[contains(text(),'WIP')]"); 
        By lbl_FinishedGoods => By.XPath("//b[contains(text(),'Finished Goods')]"); 
        By lbl_ProdStarts => By.XPath("//b[contains(text(),'Product Starts')]"); 
        By lbl_TrainingReq => By.XPath("//b[contains(text(),'Training Required')]");
        By lbl_RawMaterial_Value => By.XPath("//table[@id='doctable']//td[3]");
        By lbl_WIP_Value => By.XPath("//table[@id='doctable']//td[4]");
        By lbl_FinishedGoods_Value => By.XPath("//table[@id='doctable']//td[5]");
        By lbl_ProdStarts_Value => By.XPath("//table[@id='doctable']//td[6]");
        By lbl_TrainingReq_Value => By.XPath("//table[@id='doctable']//td[7]");
        By drp_RightsForGroup => By.XPath("//div[@id='rMenu_TOCDoclvl']//span[contains(text(),'Rights for groups')]//parent::li");
        By inpSearch_RightsForGroup => By.XPath("//input[@type='search']");
        By lbl_Rights => By.XPath("//td[@class='sorting_1']");
        By img_plusIcon => By.XPath("//tr//td[contains(@class,'clsselectchkbx')]");
        By chk_DocumentCreation_Inherit => By.XPath("(//input[contains(@id,'Inherit')])[1]");
        By chk_DocumentCreation_AttachRight => By.XPath("(//table[@id='DPLevelgrid']//input[@type='checkbox' and contains(@id,'Attachright')])[1]");
        By chk_DocumentCreation_RequestRight => By.XPath("(//input[contains(@id,'Requestright')])[1]");
        By chk_DocumentAccess_ViewOnly => By.XPath("(//table[@id='DPLevelgrid']//input[@type='checkbox' and contains(@id,'viewonly')])[2]");
        By chk_DocumentAccess_Inherit => By.XPath("(//input[@id='Inherit_Doc_0' and @checked='checked'])[2]");
        By chk_DocumentAccess_RequestRight => By.XPath("//td[contains(@style,'white-space')]//input[contains(@id,'Requestright_doc')]");
        By msg_DocRequestCreatedSuccessfully => By.XPath("//*[contains(text(),'Document Request Created Successfully')]");
        By lbl_DocSatusNeedAttachment => By.XPath("//a[text()='Need Attachment']");
        By menu_RequestsNeedingApproval => By.XPath("//div[text()='Requests Needing Approval ']");
        By lbl_Keywords => By.XPath("//th[text()='Keyword(s)']");
        By lbl_Site => By.XPath("//th[text()='Site']");
        By rad_Reject => By.XPath("//input[@id='rdreject']");
        By inp_Reason => By.XPath("//body[@contenteditable='true']");
        By inp_SecondPassword => By.XPath("//input[@id='txtsecondpwd']");
        By btn_Submit => By.XPath("//button[@id='btnsubmit']");
        By lbl_DocNeedAttachment => By.XPath("//a[text()='Need Attachment']");
        #endregion

        #region IFrame
        static By iframe_DetailView => By.XPath("//iframe[@name='Detailview']");
        static By iframe_Tree => By.XPath("//iframe[@id='iframeTree']");
        static By iframe_ifrUsers => By.XPath("//iframe[@id='ifrUsers']");
        static By iframe_ifrAlbum => By.XPath("(//iframe[@id='ifrAlbum'])[1]");
        static By iframe => By.XPath("//iframe[contains(@class,'cke_reset')]");
        static By iframe_MenuData => By.XPath("//iframe[@id='MenuData']");
        static By iframe_PopupLevel => By.XPath("//iframe[@id='ifrpopuplevel']");
        static By iframe_Route => By.XPath("//iframe[@id='iframeRoute']");
        static By iframe_Routes => By.XPath("//iframe[@id='iframeRoutes']");
        static By iframe_Actions => By.XPath("//iframe[@id='iframeActions']");
        static By iframe_ResetAction => By.XPath("//iframe[contains(@class,'cke_reset')]");

        #endregion

        #region PageActions

        /// <summary>
        /// This method help us to navigate into levels page inside the Suite Setup
        /// </summary>
        public void NavigateToLevelsPage(String SubHead)
        {
            if (seleniumActions.IsElementPresent(sideMenuContainer))
            {
                seleniumActions.Wait(5);
                seleniumActions.Click(lblSetup);
                seleniumActions.Click(lblSuiteSetup);
                seleniumActions.Wait(2);
                seleniumActions.ScrollToElement(By.XPath("(//a[@class='submenu_list_link has-arrow']//following-sibling::ul[@class='inner_submenu']//span[contains(text(),'" + SubHead + "')])[2]"));
                seleniumActions.Click(By.XPath("(//a[@class='submenu_list_link has-arrow']//following-sibling::ul[@class='inner_submenu']//span[contains(text(),'" + SubHead + "')])[2]"));
            }
        }

        /// <summary>
        /// Valdating Levels page Header to make sure level page is loaded or not
        /// </summary>
        public void validateLevelsPage()
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            Assert.IsTrue(seleniumActions.VerifyElementIsDisplayed(txtSuiteLevelHeader));
            seleniumActions.SwitchToParentFrame();
        }

        /// <summary>
        /// Use this method to create a New Level based on the velue we pass
        /// </summary>
        /// <param name="levelName"></param>
        public String CreateLevel(String levelName)
        {
            if (string.Equals(levelName, "random", StringComparison.OrdinalIgnoreCase))
            {
                levelName = "Automation-" + utility.CurrentTime();
            }

            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Tree);
            seleniumActions.Click(inpLevelNumber);
            seleniumActions.Click(popUp_Yes);
            seleniumActions.SendKeys(inpLevelNumber, utility.CurrentTime());
            seleniumActions.SendKeys(inp_Levelname, levelName);
            seleniumActions.Click(btn_save);
            seleniumActions.VerifyElementIsDisplayed(By.XPath("//h5[contains(text(),'Level - " + levelName + "')]"));
            seleniumActions.SwitchToDefaultContent();
            return levelName;
        }

        /// <summary>
        /// Use this method to Edit the existing level
        /// </summary>
        /// <param name="LevelName"></param>
        /// <returns></returns>
        public String EditLevel(String LevelName)
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Click(btn_refreshLevel);
            seleniumActions.MoveToElement(By.XPath("//table[@class='Tbltitle']//ul[@id='TOCDoclvl']//a[contains(@title,'" + LevelName + "')]"));
            seleniumActions.Click(By.XPath("(//table[@class='Tbltitle']//ul[@id='TOCDoclvl']//a[contains(@title,'" + LevelName + "')]//following::*[local-name()='svg' and contains(@class,'pencil')])[1]"));
            seleniumActions.SwitchToIframes(iframe_Tree);
            seleniumActions.SendKeys(inp_Levelname, Constants.Level);
            seleniumActions.Click(btn_save);
            //seleniumActions.VerifyElementIsDisplayed(By.XPath("//h5[contains(text(),'Level - "+Constants.Level+""));
            seleniumActions.SwitchToDefaultContent();
            return Constants.Level;
            //(//table[@class='Tbltitle']//ul[@id='TOCDoclvl']//a[contains(@title,'AAA')]//following::*[local-name()='svg' and contains(@class,'pencil')])[1]
        }

        /// <summary>
        /// Deletes the level by hovering on the level
        /// </summary>
        /// <param name="LevelName"></param>
        public void DeleteLevelByHovering(String LevelName)
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Click(btn_refreshLevel);
            seleniumActions.MoveToElement(By.XPath("//table[@class='Tbltitle']//ul[@id='TOCDoclvl']//a[contains(@title,'" + LevelName + "')]"));
            seleniumActions.Click(By.XPath("(//table[@class='Tbltitle']//ul[@id='TOCDoclvl']//a[contains(@title,'" + LevelName + "')]//following::*[local-name()='svg' and contains(@class,'trash')])[1]"));
            seleniumActions.Click(popUp_Yes);
        }

        /// <summary>
        /// Clicks folder management ,  searches the level and make it in use
        /// </summary>
        /// <param name="LevelName"></param>
        public void MakeLevelInUse(string LevelName)
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Click(folderManagement_Tab);
            seleniumActions.SwitchToFrame(iframe_MenuData);
            seleniumActions.Click(phd_SearchByFolder);
            seleniumActions.SendKeys(phd_SearchByFolder, LevelName);
            seleniumActions.Click(btnSearch_SearchByFolder);
            Assert.IsTrue(seleniumActions.IsElementPresent(By.XPath("(//a[@title='" + LevelName + "']//span)[2]")),"Searched level not found");
            seleniumActions.Wait(3);    
            seleniumActions.Click(By.XPath("(//a[@title='" + LevelName + "']//span)[2]"));
            seleniumActions.SwitchToFrame(iframe_Tree);
            seleniumActions.Wait(2);
            seleniumActions.ScrollToPosition(0,1000);
            Assert.IsTrue(seleniumActions.IsElementPresent(chk_InUse), "Checkbox In Use is not present");
            seleniumActions.Click(chk_InUse);
            seleniumActions.Click(btn_save);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Assign route for the level
        /// </summary>
        public void AssignRoute(string subHead)
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.Wait(2);
            seleniumActions.ScrollToPosition(0, 1000);
            seleniumActions.Click(lnk_InheritFromParent);
            seleniumActions.Wait(4);
            seleniumActions.SwitchToIframes(iframe_Routes, iframe_Route);
            seleniumActions.Click(drp_NewRoute);
            seleniumActions.Click(inpSearch_AssignRoute);
            seleniumActions.SendKeys(inpSearch_AssignRoute,subHead);
            seleniumActions.Click(By.XPath("//li[@role='treeitem']//span[contains(text(),'" + subHead + "')]"));
            seleniumActions.Wait(2);
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.Click(btn_Close);
            seleniumActions.Click(btn_save);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// This method help us to navigate into sub pages inside the Documents menu
        /// </summary>
        public void NavigateToDocumentsPage(String SubHead)
        {
            if (seleniumActions.IsElementPresent(sideMenuContainer))
            {
                seleniumActions.Wait(5);
                seleniumActions.Click(lblDocuments);
                seleniumActions.Wait(2);
                seleniumActions.ScrollToElement(By.XPath("(//div[@class='slimScrollDiv']//a[@class='submenu_list_link']//span[contains(text(),'" + SubHead + "')])[1]"));
                seleniumActions.Click(By.XPath("(//div[@class='slimScrollDiv']//a[@class='submenu_list_link']//span[contains(text(),'" + SubHead + "')])[1]"));
            }
        }

        /// <summary>
        /// Validates the new doc req page is visible
        /// </summary>
        public void ValidateNewDocRequestPage()
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            Assert.IsTrue(seleniumActions.IsElementPresent(breadCrumb_NewDocRequest,5),"New Doc Request breadcrumb is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(btn_LevelSelector,5),"level selector button is not found");
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Choose exisitng level in new document request page
        /// </summary>
        public void ChooseExistingLevel(string levelName)
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Click(btn_LevelSelector);
            Assert.IsTrue(seleniumActions.IsElementPresent(tbl_LevelSelection, 5), "level selection popup is not found");
            seleniumActions.SwitchToFrame(iframe_PopupLevel);
            seleniumActions.ScrollToElement(By.XPath("//ul[@id='tvDocument']//li[@class='level1']//span[contains(text(),'" + levelName + "')]"));
            seleniumActions.Click(By.XPath("//ul[@id='tvDocument']//li[@class='level1']//span[contains(text(),'" + levelName + "')]"));
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Uploads a new document
        /// </summary>
        /// <returns> DocName </returns>
        public string UploadNewDocument()
        {
            var path = new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath;
            var actualPath = path.Substring(0, path.LastIndexOf("bin"));
            var projectPath = new Uri(actualPath).LocalPath;

            string docName = Constants.Name + utility.GenerateRandomText(2);
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.SendKeys(inp_ChooseFile, projectPath.ToString() + Constants.SampleFilePath_Book);
            seleniumActions.ScrollToPosition(0,300);
            seleniumActions.Wait(2);
            seleniumActions.Click(txtDocNumber);
            seleniumActions.SendKeys(txtDocNumber,"123");
            seleniumActions.Wait(2);
            seleniumActions.Click(txtDocName);
            seleniumActions.SendKeys(txtDocName , Keys.Clear);
            seleniumActions.SendKeys(txtDocName, docName);
            seleniumActions.Click(btnAdd);
            Assert.IsTrue(seleniumActions.IsElementPresent(msg_DocUploadedSuccessfully, 5), "document was not uploaded properly");
            seleniumActions.SwitchToDefaultContent();
            return docName;
        }

        /// <summary>
        /// Validates the actions page is visible
        /// </summary>
        public void ValidateActionsPage()
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            Assert.IsTrue(seleniumActions.IsElementPresent(breadCrumb_Actions, 5), "Actions breadcrumb is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(lblActions, 5), "label action is not found");
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Verifies the pending requests menu is present
        /// </summary>
        public void VerifyPendingRequestsMenu()
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            Assert.IsTrue(seleniumActions.IsElementPresent(menu_PendingRequests, 5), "Pending requests menu is not found");
            seleniumActions.Click(menu_PendingRequests);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Validates the UI elements of pending requests menu
        /// </summary>
        public void ValidateUIElementsOfPendingRequestsMenu()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView,iframe_Actions);
            // ** Validate => DOC - 2500 - 10 - 110 & 140 ** //
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_DocNumber, 5), "Doc number is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_DocName, 5), "Doc name is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_Date, 5), "date is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_Revision, 5), "revision is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_Status, 5), "status is not found");
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Searches the document in actions page
        /// </summary>
        public void SearchDocumentInActionsPage(string docName)
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            Assert.IsTrue(seleniumActions.IsElementPresent(btnMultiSearch));
            seleniumActions.Click(btnMultiSearch);
            Assert.IsTrue(seleniumActions.IsElementPresent(drpColumn_MultiSearch));
            seleniumActions.Click(drpColumn_MultiSearch);
            seleniumActions.Click(ddlDocName_MultiSearch);
            seleniumActions.Click(drpCondition_MultiSearch);
            seleniumActions.Click(ddlContains_MultiSearch);
            seleniumActions.Click(inp_MultiSearch);
            seleniumActions.SendKeys(inp_MultiSearch, docName);
            seleniumActions.Click(btnAdvancedSearch_MultiSearch);
            seleniumActions.Wait(3);
            // ** Validate => DOC - 2500 - 10 - 40, 100 : Pending requests menu
            // should be displayed with the requested documents with In process status ** //
            Assert.IsTrue(seleniumActions.GetText(lbl_DocNameValue).Equals(docName));
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Terminates the document in actions page
        /// </summary>
        public void TerminateDocumentInActionsPage()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            seleniumActions.Click(lbl_StatusValue);
            // ** Validate => DOC-2500-10-210 ** //
            Assert.IsTrue(seleniumActions.IsElementPresent(lnk_DocNumberValue, 5), "link doc number value is not found");
            seleniumActions.ScrollToElement(btn_Terminate);
            // ** Validate => DOC - 2500 - 10 - 200 ** //
            seleniumActions.Click(btn_Terminate);
            seleniumActions.Wait(3);
            seleniumActions.Click(btnNo_PopUp);
            // ** Validating => DOC-2500-10-180: Click the terminate button ** //
            seleniumActions.Click(btn_Terminate);
            seleniumActions.Wait(3);
            // ** Validating => DOC-2500-10-190: Click Yes in the terminate popup screen ** //
            seleniumActions.Click(btnYes_Popup);
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToFrame(iframe_DetailView);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblActions, 5), "label actions in action page is not found");
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Validate the browser is redirected to business rule page 
        /// </summary>
        public void ValidateBusinessRulePage()
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            Assert.IsTrue(seleniumActions.IsElementPresent(breadCrumb_BusinessRule, 5), "browser is not redirected to business rule page");
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// enables the dcn button inside document menu - business rule page 
        /// </summary>
        public void EnableDCNButton()
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Click(menu_DocumentsBusinessRule);
            seleniumActions.SwitchToFrame(iframe_MenuData);
            seleniumActions.ScrollToPosition(0,1600);
            Assert.IsTrue(seleniumActions.IsElementPresent(btn_DisabledDCNForm, 5), "unable to find DCN button");
            seleniumActions.Click(btn_DisabledDCNForm);
            seleniumActions.Wait(2);
            Assert.IsTrue(seleniumActions.IsElementPresent(btn_EnabledDCNForm, 5), "dcn button is not enabled");
            seleniumActions.ScrollToPosition(0, 2800);
            seleniumActions.ScrollToElement(btn_SaveBusinessRule);
            Assert.IsTrue(seleniumActions.IsElementPresent(btn_SaveBusinessRule, 5), "unable to find save button");
            seleniumActions.Wait(2);
            seleniumActions.Click(btn_SaveBusinessRule);
            seleniumActions.Wait(2);
            seleniumActions.Click(btn_DoneBusinessRule);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// disables the dcn button inside document menu - business rule page
        /// </summary>
        public void DisableDCNButton()
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Click(menu_DocumentsBusinessRule);
            seleniumActions.SwitchToFrame(iframe_MenuData);
            seleniumActions.ScrollToPosition(0, 1600);
            Assert.IsTrue(seleniumActions.IsElementPresent(btn_EnabledDCNForm, 5), "unable to find enabled DCN button");
            seleniumActions.Click(btn_EnabledDCNForm);
            seleniumActions.Wait(2);
            Assert.IsTrue(seleniumActions.IsElementPresent(btn_DisabledDCNForm, 5), "dcn button is not disabled");
            seleniumActions.ScrollToPosition(0, 2600);
            Assert.IsTrue(seleniumActions.IsElementPresent(btn_SaveBusinessRule, 5), "unable to find save button");
            seleniumActions.Wait(2);
            seleniumActions.Click(btn_SaveBusinessRule);
            seleniumActions.Wait(2);
            seleniumActions.Click(btn_DoneBusinessRule);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Uploads a new document with enabled DCN
        /// </summary>
        /// <returns> DocName </returns>
        public string UploadNewDocumentWithEnabledDCN()
        {
            var path = new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath;
            var actualPath = path.Substring(0, path.LastIndexOf("bin"));
            var projectPath = new Uri(actualPath).LocalPath;

            string docName = Constants.Name + utility.GenerateRandomText(2);
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.SendKeys(inp_ChooseFile, projectPath.ToString() + Constants.SampleFilePath_Book);
            seleniumActions.ScrollToPosition(0, 300);
            seleniumActions.Wait(2);
            seleniumActions.Click(txtDocNumber);
            seleniumActions.SendKeys(txtDocNumber, "123");
            seleniumActions.Wait(2);
            seleniumActions.Click(txtDocName);
            seleniumActions.SendKeys(txtDocName, Keys.Clear);
            seleniumActions.SendKeys(txtDocName, docName);

            Assert.IsTrue(seleniumActions.IsElementPresent(svg_DCNFormIcon, 5), "dcn form icon was not found");
            seleniumActions.Click(svg_DCNFormIcon);
            seleniumActions.Wait(2);
            seleniumActions.Click(rdoMajor_DCN);
            seleniumActions.Click(drpRawMaterial_DCN);
            seleniumActions.Wait(2);
            seleniumActions.Click(ddlRework_DCN);
            seleniumActions.Click(drpWIP_DCN);
            seleniumActions.Wait(2);
            seleniumActions.Click(ddlRework_DCN);
            seleniumActions.Click(drpFinishedGoods_DCN);
            seleniumActions.Wait(2);
            seleniumActions.Click(ddlRework_DCN);
            seleniumActions.Click(drpNewProdStarts_DCN);
            seleniumActions.Wait(2);
            seleniumActions.Click(ddlRework_DCN);
            seleniumActions.Click(drpTrainingReq_DCN);
            seleniumActions.Wait(2);
            seleniumActions.Click(ddlCategoryA_DCN);
            seleniumActions.Click(btnClose_DCN);

            seleniumActions.Click(btnAdd);
            Assert.IsTrue(seleniumActions.IsElementPresent(msg_DocUploadedSuccessfully, 5), "document was not uploaded properly");
            seleniumActions.SwitchToDefaultContent();
            return docName;
        }

        /// <summary>
        /// Search and terminates the document woith DCN
        /// </summary>
        public void TerminateDocumentWithDCN()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            seleniumActions.Click(lbl_StatusValue);
            Assert.IsTrue(seleniumActions.IsElementPresent(lnk_DocNumberValue, 5), "link doc number value is not found");

            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_DCNInfo, 5), "dcn info is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(lnk_ViewDCN, 5), "view dcn link is not found");
            seleniumActions.Click(lnk_ViewDCN);
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_RawMaterial, 5), "label raw material is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_RawMaterial_Value, 5), "raw material value is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_WIP, 5), "label WIP is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_WIP_Value, 5), "WIP value is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_FinishedGoods, 5), "label Finished Goods is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_FinishedGoods_Value, 5), "Finished Goods value is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_ProdStarts, 5), "label Prod Starts is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_ProdStarts_Value, 5), "Prod Starts value is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_TrainingReq, 5), "label Training Req is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_TrainingReq_Value, 5), "Training Req value is not found");
            seleniumActions.Click(btn_Close);

            seleniumActions.ScrollToElement(btn_Terminate);
            seleniumActions.Click(btn_Terminate);
            seleniumActions.Wait(3);
            
            seleniumActions.Click(btnYes_Popup);
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToFrame(iframe_DetailView);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblActions, 5), "label actions in action page is not found");
            seleniumActions.SwitchToDefaultContent();
        }


        /// <summary>
        /// Clicks the Rights for Group
        /// </summary>
        public void RightForGroups(String LevelName)
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Click(folderManagement_Tab);
            seleniumActions.SwitchToFrame(iframe_MenuData);
            seleniumActions.Click(phd_SearchByFolder);
            seleniumActions.SendKeys(phd_SearchByFolder, LevelName);
            seleniumActions.Click(btnSearch_SearchByFolder);
            Assert.IsTrue(seleniumActions.IsElementPresent(By.XPath("(//a[@title='" + LevelName + "']//span)[2]")), "Searched level not found");
            seleniumActions.Wait(3);
            seleniumActions.ContextClick(By.XPath("(//a[@title='" + LevelName + "']//span)[2]"));
            Assert.IsTrue(seleniumActions.IsElementPresent(drp_RightsForGroup), "unable to find Rights for group option");
            seleniumActions.Click(drp_RightsForGroup);
            seleniumActions.SwitchToDefaultContent();

        }
        /// <summary>
        /// Set Attach Rights for New Document Creation
        /// </summary>
        public void DocumentCreationResquestRights()
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.SwitchToFrame(iframe_MenuData);
            seleniumActions.SwitchToFrame(iframe_Tree);
            seleniumActions.Wait(2);
            seleniumActions.Click(inpSearch_RightsForGroup);
            seleniumActions.SendKeys(inpSearch_RightsForGroup, "Rights");
            seleniumActions.Wait(2);
            Assert.IsTrue(seleniumActions.GetText(lbl_Rights).Equals("Rights"));
            seleniumActions.Click(chk_DocumentCreation_Inherit);
            seleniumActions.Click(chk_DocumentCreation_RequestRight);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        ///Set View Only for New Document Access
        /// </summary>
        public void DocumentAccessRequestRights()
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.SwitchToFrame(iframe_MenuData);
            seleniumActions.SwitchToFrame(iframe_Tree);
            seleniumActions.Click(img_plusIcon);
            seleniumActions.ScrollToPosition(0,1000);
            seleniumActions.Click(chk_DocumentAccess_Inherit);
            seleniumActions.Click(chk_DocumentAccess_RequestRight);
            seleniumActions.SwitchToDefaultContent();
        }
        public string createNewDocument()
        {
            string docName = Constants.Name + utility.GenerateRandomText(2);
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Click(txtDocNumber);
            seleniumActions.SendKeys(txtDocNumber, "123");
            seleniumActions.Wait(2);
            seleniumActions.Click(txtDocName);
            seleniumActions.SendKeys(txtDocName, Keys.Clear);
            seleniumActions.SendKeys(txtDocName, docName);
            seleniumActions.Click(btnAdd);
            Assert.IsTrue(seleniumActions.IsElementPresent(msg_DocRequestCreatedSuccessfully, 5), "document was not uploaded properly");
            seleniumActions.SwitchToDefaultContent();
            return docName;
        }

        /// <summary>
        /// Verifies the document status 
        /// </summary>
        /// <param name="status"></param>
        public void ValidateDocumentStatus(string status)
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            Assert.IsTrue(seleniumActions.GetText(lbl_StatusValue).Equals(status));
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Verifies the Requests Needing Approval menu is present
        /// </summary>
        public void VerifyRequestsNeedingApprovalMenu()
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            Assert.IsTrue(seleniumActions.IsElementPresent(menu_RequestsNeedingApproval, 5), "Requests Needing Approval menu is not found");
            seleniumActions.Click(menu_RequestsNeedingApproval);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Validates the UI elements of Requests Needing Approval menu
        /// </summary>
        public void ValidateUIElementsOfRequestsNeedingApprovalMenu()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_DocNumber, 5), "Doc number is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_DocName, 5), "Doc name is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_Keywords, 5), "Keywords is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_Date, 5), "date is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_Revision, 5), "revision is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_Status, 5), "status is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_Site, 5), "site is not found");
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// This method used to reject document by providing second password
        /// </summary>
        public void RejectDocument()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            seleniumActions.Click(lbl_StatusValue);
            seleniumActions.ScrollToElement(rad_Reject);
            seleniumActions.Click(rad_Reject);
            seleniumActions.Wait(3);
            seleniumActions.SwitchToFrame(iframe_ResetAction);
            seleniumActions.Click(inp_Reason);
            seleniumActions.SendKeys(inp_Reason,"Test");
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            seleniumActions.Wait(2);
            seleniumActions.ScrollToPosition(0, 1000);
            seleniumActions.Click(inp_SecondPassword);
            seleniumActions.Wait(3);
            seleniumActions.SendKeys(inp_SecondPassword, Constants.SecondPassword);
            seleniumActions.Wait(3);
            seleniumActions.Click(btn_Submit);
            seleniumActions.SwitchToDefaultContent();
        }

        #endregion

    }
}
