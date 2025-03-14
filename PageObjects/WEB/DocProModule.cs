﻿using AventStack.ExtentReports.Gherkin.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;
using OMNEX.AUTOMATION.Data.WEB;
using OMNEX.AUTOMATION.Helpers;
using OpenQA.Selenium;
using System;
using System.Reflection;
using System.Reflection.Emit;
using TechTalk.SpecFlow;
using System.Security.Policy;
using System.Diagnostics.Metrics;
using Amazon.DynamoDBv2.Model;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using Amazon.DynamoDBv2.DocumentModel;
using OpenQA.Selenium.DevTools.V85.Runtime;
using Newtonsoft.Json;

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
        By txtSuiteLevelHeader => By.XPath("(//h5[text()='New Level'])[1]");
        By inpLevelNumber => By.XPath("//input[@id='txtLevelNum']");
        By popUp_Yes => By.XPath("//button[@id='popup_ok']");
        By inp_Levelname => By.XPath("//input[@id='txtLevelName']");
        By btn_save => By.XPath("//button[@id='btnSave']");
        By btn_Reset => By.XPath("//button[@id='btnReset']");
        By btn_Prefix => By.XPath("//input[@id='txtPrefix']");
        By btn_DocReviewafter => By.XPath("//input[@id='txtReviewUnit']");
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
        By drp_ExistingRoute => By.XPath("//span[contains(@id,'tddrpdownExistingRoute')]");
        By btn_Close => By.XPath("//button[@title='Close']");
        By btn_Close_RoutePage => By.XPath("(//div[@aria-describedBy='iframedivs']//button[@title='Close'])[1]");
        By menu_PendingRequests => By.XPath("//td[@title='Pending Requests']");
        By lbl_DocNumber => By.XPath("//th[text()='Document Number']");
        By lbl_DocName => By.XPath("//th[text()='Document Name']");
        By lbl_Date => By.XPath("//th[text()='Date']");
        By lbl_Revision => By.XPath("//th[text()='Revision']");
        By lbl_Status => By.XPath("//th[text()='Status']");
        By drp_SearchFilter => By.XPath("//select[contains(@class,'datatablefilter')]");
        By ddlDocName_SearchFilter => By.XPath("//select[contains(@class,'datatablefilter')]//option[@value='name']");
        By phd_SearchFilter => By.XPath("//input[@type='search']");
        By lbl_DocNameValue => By.XPath("(//tr[@role='row']//td//div)[2]");
        By lnk_StatusValue => By.XPath("(//a[@id='status'])[1]");
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
        By chk_NewDocumentAccess_Inherit => By.XPath("(//input[@id='Inherit_Doc_0' and @checked='checked'])[2]");
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
        By chk_NewDocFullAccess => By.XPath("(//input[@id='Fullaccess_0'])[2]");
        By lnkClick_FullAccess => By.XPath("//table[contains(@class,'table-layout')]//a[contains(text(),'Click')]");
        By chk_DocumentAccess_Inherit => By.XPath("(//input[@id='Inherit_0' and @checked='checked'])[1]");
        By chk_DocumentAccess_FullAccess => By.XPath("(//input[@id='fullaccess_0'])[2]");
        By inp_SearchLevelsInDocumentPage => By.XPath("//input[@placeholder='Search']");
        By lnk_DocumentNumber_Toc => By.XPath("//div[@class='text-wrap']//a");
        By lbl_ChangeRequest => By.XPath("//a[@id='CChangeRequest']");
        By chk_DeleteDocument_Toc => By.XPath("//label[contains(text(),'Delete Document')]");
        By btn_Continue_Toc => By.XPath("//span[contains(text(),'Continue')]");
        By lbl_NoRecordsToDisplay => By.XPath("//td[@class='dataTables_empty']");
        By menu_AssignAuthor => By.XPath("//td[@title='Assign Author']");
        By status_Assign => By.XPath("//a[text()='Assign']");
        By svg_AddAssignAutor => By.XPath("//*[local-name()='svg' and @id='imgSearch']");
        By ddlName_MultiSearch => By.XPath("(//div[@class='dtsb-criteria']//select//option[contains(text(),'Name')])[1]");
        By chk_AssignAuthor => By.XPath("//input[contains(@id, 'Chk_')]");
        By btn_SaveAuthor => By.XPath("//button[contains(@onclick, 'Save')]");
        By menu_DocumentsNeedingRevision => By.XPath("//td[@title='Documents Needing Revision']");
        By status_AttachDocument => By.XPath("//a[text()='Attach Document']");
        By btn_Continue => By.XPath("//button[@id='btnsave']");
        By lbl_NameValue => By.XPath("(//tr[@role='row']//td)[2]");
        By hintSearch => By.XPath("(//input[@type='search'])[1]");
        By chk_FirstUser => By.XPath("(//input[@name='userListingGridControl_selectCheck'])[1]");
        By btn_UserDone => By.XPath("//button[contains(text(), 'Done')]");
        By inp_ChooseFile_ActionsFlow => By.XPath("(//input[@name = 'Browse'])[1]");
        By chk_DocumentAccess_RequestRight_FromLink => By.XPath("//td[contains(@style,'white-space')]//input[contains(@id,'req_rights')]");
        By btnLevelSelector_PendingDocDraft => By.XPath("//*[local-name()='svg' and @id='btnSelectLevel']");
        By inp_ChooseFile_PendingDocDraft => By.XPath("(//input[@id= 'fileUpload'])[1]");
        By txtDocNum_PendingDocDraft => By.XPath("//input[contains(@id,'txtDocNumberValue')]");
        By txtDocName_PendingDocDraft => By.XPath("//input[contains(@id,'txtDocNameValue')]");
        By menu_PendingDocDraft => By.XPath("//td[@title='Pending Document Drafts']");
        By menu_DraftRequestsNeedingViewing => By.XPath("//td[@title='Draft Requests Needing Viewing']");
        By lbl_LastCmntDate => By.XPath("//th[text()='Last comment date']");
        By svg_HamburgerMenu => By.XPath("//*[local-name()='svg' and contains(@class,'menu')]");
        By txtAddComment => By.XPath("//div[@data-placeholder='Add a comment']");
        By btn_Send => By.XPath("//span[contains(@class,'send')]");
        By lblWaitingForComment => By.XPath("(//div[contains(text(),'Waiting for comment')])[1]");
        By btn_ChangeRequest => By.XPath("//button[@id='btnChangeRequest']");
        By svg_DraftViewersIcon => By.XPath("//*[local-name()='svg' and @title='User Details']");
        By tbl_NewestComments => By.XPath("(//li[@data-sort-key='newest'])[1]");
        By tbl_OldestComments => By.XPath("(//li[@data-sort-key='oldest'])[1]");
        By tbl_PopularComments => By.XPath("(//li[@data-sort-key='popularity'])[1]");
        By phd_Name => By.XPath("//div[@id='userListingGridControl_wrapper']//input[@type='search']");
        By lblTeamLeader_SearchResult => By.XPath("(//table[@id='userListingGridControl']//td[@class='sorting_1'])[1]");
        By chkUsernameInactive => By.XPath("(//table[@id='userListingGridControl']//tr[@class='odd']//input[@type='checkbox'])[1]");
        By chkUsernameActive => By.XPath("(//table[@id='userListingGridControl']//tr[@class='odd selected']//input[@type='checkbox'])[1]");
        By btn_Done => By.XPath("//button[@title='Done']");
        By lblDocPro_DraftViewer => By.XPath("//div[@class='table-responsive']//div[contains(text(),'DocPro-Admin')]");
        By lblRightScenario_DraftViewer => By.XPath("//div[@class='table-responsive']//div[contains(text(),'Right-Scenario')]");
        By ddp_RightSite => By.XPath("//span[@title='RightSite']");
        By ddl_Corporate => By.XPath("//li[contains(text(),'Corporate')]");
        By ddp_Corporate => By.XPath("//span[@title='Corporate']");
        By ddl_RightSite => By.XPath("//li[contains(text(),'RightSite')]");
        By tblLastColumn_pendingRequestDraft => By.XPath("//table[@id='pendingDocumentDraftGrid']//th[last()]");
        By btn_DisabledInterfaceAgreement => By.XPath("(//div[@class='switch form-control-inline']//span[contains(@class,'bootstrap-switch-danger')])[24]");
        By btn_EnabledInterfaceAgreement => By.XPath("(//div[@class='switch form-control-inline']//span[contains(@class,'bootstrap-switch-success')])[24]");
        By txt_EffectiveDate => By.XPath("//div[@id='effdate']//input[@type='text']");
        By tblDatePicker_EffectiveDate => By.XPath("//div[contains(@class,'datepicker-dropdown')]");
        By chk_AttachDraft => By.XPath("//label[@for='chkattachdft']");
        By lblCurrentDate_DatePicker => By.XPath("//div[@class='datepicker-days']//tr//td[contains(@class,'today')]");
        By txt_ReasonForChange => By.XPath("//div[@id='divrsnchange']//div[contains(@class,'cke_editable ')]");
        By txt_ChngDescription => By.XPath("//div[@id='divchangedesc']//div[contains(@class,'cke_editable ')]");
        By icn_StyleBar_ReasonForChange => By.XPath("//div[contains(@class,'changesrequired')]");
        By lblOnlineDocTemplates => By.XPath("//caption[@id='GridCaptionOnlineDocTemplatesGrid']");
        By btnClose_OnlineDocument => By.XPath("//div[@aria-describedby='dialog-transitionlistpopup']//button[@title='Close']");
        By rdo_Accept => By.XPath("//label[@for='accept']");
        By rdo_Reject => By.XPath("//label[@for='reject']");
        By lbl_LatestComment => By.XPath("(//div[@class='wrapper']//div[@class='content'])[1]");
        By svg_DraftViewersIconDraftReqNeedingPage => By.XPath("//*[local-name()='svg' and @onclick='GetUserDetailPopUp()']");
        By btn_Upvote => By.XPath("//button[@class='likedby action upvote']");
        By txtbox_commentsBox => By.XPath("(//div[@class='content'])[1]");
        By rdo_Accept_Disabled => By.XPath("//input[@id='accept' and contains(@disabled,'disabled')]");
        By rdo_Reject_Disabled => By.XPath("//input[@id='reject' and contains(@disabled,'disabled')]");
        By badge_Accepted_Comment => By.XPath("//span[@class='badge badge-success']");
        By badge_Rejected_Comment => By.XPath("//span[@class='badge badge-danger']");
        By btn_delete => By.XPath("//div[@id='rMenu_TOCDoclvl']//span[contains(text(),'Delete')]//parent::li");
        By btn_Edit => By.XPath("//div[@id='rMenu_TOCDoclvl']//span[contains(text(),'Edit')]//parent::li");
        By lbl_FolderManagementHeading => By.XPath("//div[@class='card-header']//h5[contains(text(),'Level')]");
        By btn_New => By.XPath("//div[@id='rMenu_TOCDoclvl']//span[contains(text(),'New')]//parent::li[contains(@disabled,'disabled')]");
        By menu_DocumentManagement => By.XPath("//div[text()='Document Management']");
        By lbl_FolderManagementDocumentProHeading => By.XPath("//h1[contains(text(),'Document Pro')]");
        By lnk_ModuleSideSubMenu => By.XPath("(//a[@title='Modules'])[1]");
        By ddp_Revopt => By.XPath("//span[contains(@id,'drpRevOpt')]");
        By inp_Revopt => By.XPath("//input[@class = 'select2-search__field']");
        By inpbox_Revopt => By.XPath("//span[@id = 'select2-drpRevOpt-container']");
        By inp_docProautoincreby1 => By.XPath("//ul[@id = 'select2-drpRevOpt-results']");
        By chk_InheritFromParents => By.XPath("((//div[@id=\"trRevOpt\"])[1]//following::div[@id='spnRevByInherit'])[1]");
        By chk_SiteSubLevel => By.XPath("(//label[@id='thAllowSiteSub'])[1]");
        By chk_SiteModification => By.XPath("(//label[@id='thSiteMod'])[1]");
        By btn_NewEnable => By.XPath("//div[@id='rMenu_TOCDoclvl']//span[contains(text(),'New')]");
        By ddp_DateOpt => By.XPath("//span[@id='select2-drpDocNumOpt-container']");
        By drp_RevDateOpt => By.XPath("//span[contains(@id,'drpRevDateOpt')]");
        By inp_SearchForRevDateOpt => By.XPath("(//input[@type='search'])[2]");
        By chk_Record => By.XPath("//label[@id = 'thRecords']");
        By svg_AddLevelOwner => By.XPath("//span[@id='spnAddLevelOwner']//*[local-name()='svg']");
        By svg_RemoveLevelOwner => By.XPath("//span[@id='spnRemoveLevelOwner']//*[local-name()='svg']");
        By lbl_AddedLevelOwnerName => By.XPath("//label[@id='spnOwnerName']");
        By drp_DocumentReviewedAfter => By.XPath("//span[@id = 'select2-drpDocReviewUnitName-container']");
        By inp_RevisionValue => By.XPath("//input[@id='txtDocReviewUnit']");
        By lblNewLevel => By.XPath("(//div[@class='card']//h5[contains(text(),'New Level') and @class='card-title'])[1]");
        By txtSublevelName => By.XPath("(//input[@id='txtLevelName'])[1]");
        By folder_OpenArrow => By.XPath("(//span[@class='button level0 switch root_close'])[1]");
        By folder_CloseArrow => By.XPath("(//span[@class='button level0 switch root_open'])[1]");
        By lblSublevelName => By.XPath("//span[contains(text(),'SubLevel')]");
        By lbl_SubLevelHeader => By.XPath("//div[@class='card-header']//h5[contains(text(),'Level')]");
        By lblDeletedSuccessMessage => By.XPath("//div[contains(@class,'alert-dismissible')]");
        By drp_RightsForSites => By.XPath("//div[@id='rMenu_TOCDoclvl']//span[contains(text(),'Rights for sites')]//parent::li");
        By heading_ManageSiteDocument => By.XPath("//div[@class='card-header']//h5[@class='card-title']");
        By chk_FullAccesForDocument => By.XPath("//input[@type='checkbox' and @id='fullaccess_0']");
        By lnk_TagSelect => By.XPath("//a[@id='selecttags']");
        By lbl_TagSearchResult => By.XPath("(//table[@id='FldrTagsGrid']//td[@class='sorting_1'])[1]");
        By chk_TagNameSelection => By.XPath("//input[@name='FldrTagsGrid_selectCheck']");
        By btnDone_TagSelection => By.XPath("//button[@title='Select']");
        By ddl_TagName_MultiSearch => By.XPath("(//div[@class='dtsb-criteria']//select//option[contains(text(),'TagName')])[1]");
        By lbl_EnableEnhancedPrinting => By.XPath("//label[@for='chkEnablePrinting']//*[local-name()='svg']");
        By drp_Template => By.XPath("//select[@id='drpTemplateList']");
        By chk_EnabledEnhancedPrinting => By.XPath("//label[@for='chkEnablePrinting']//preceding::input[@id='chkEnablePrinting']");
        By ddn_Template => By.XPath("//select[@class='custom-select']");
        By chk_SelectAllModules => By.XPath("//select[@class='custom-select']");
        By lbl_ToVerifyTemplateDropDown => By.XPath("//label[contains(text(),'Template')]//following::select[@class='custom-select']");
        By lnk_LevelPdfPreference => By.XPath("//a[@id = 'aLevelPdfPrefernce']");
        By chk_IncludeTemplate => By.XPath("//label[@for='chkInclTemplate']//preceding::input[@id='chkInclTemplate']");
        By lbl_IncludeTemplate => By.XPath("//label[@for='chkInclTemplate']");
        By lbl_EnableRestrickedView => By.XPath("//label[@for='chkResrictedView']");
        By chk_EnableRestrickedView => By.XPath("//label[@for='chkResrictedView']//preceding::input[@id='chkResrictedView']");
        By lbl_SearchTitle_MultiSearch => By.XPath("//div[@class='dtsb-title']");
        By btnRefresh_MultiSearch => By.XPath("//button[@class='dtsb-clearAll dtsb-button']");
        By btnAdd_MultiSearch => By.XPath("//button[@class='dtsb-add dtsb-button']");
        By btnRemove_MultiSearch => By.XPath("(//button[@class='dtsb-delete dtsb-button'])[2]");
        By btnRefresh_PDF => By.XPath("//li[@id='refresh']");
        By btnUpdate_PDF => By.XPath("//button[@title='Update']");
        By chk_SearchResultSitePDF => By.XPath("(//td[contains(@class,'clsselectchkbx')]//input[@type='checkbox'])[1]");
        By lblSuccessMessage => By.XPath("//div[contains(@class,'alert-success')]");
        By ddl_DocType => By.XPath("(//option[contains(text(),'Document Type')])[1]");
        By tblRow => By.XPath("//tbody//tr[@role='row']");
        By lbl_LevelPdfPreferencesPageHeading => By.XPath("//div[contains(@class,'modal-header')]//h5");
        By drp_TemplateInLevelPDFPreferencesPage => By.XPath("//label[contains(text(),'Template')]//following::select[@class='custom-select']");
        By lbl_RestrictedView => By.XPath("//label[@for='chkResrictedView']");
        By btn_LevelPDFRestart => By.XPath("//li[contains(@onclick,'gridModPDFDocTypes')]");
        By btn_LevelPDFSave => By.XPath("//button[contains(@onclick,'Savepdf')]");
        By btn_LevelPDFUseSiteDefault => By.XPath("//button[@id='btnDefaultSave']");
        By btn_LevelApplyThisToAllSubLevels => By.XPath("//button[@id='btnApplyToChild']");
        By btn_LevelPDFShowSamplePDF => By.XPath("//button[@id='btnShowTemplate']");
        By btn_PDFShowSamplePDF => By.XPath("//button[@id='btnshowpdf']");
        By drp_LevelPDFSearch => By.XPath("//select[contains(@class,'datatablefilter') and contains(@id,'gridModPDFDocTypes')]");
        By pagination_LevelPDFPagination => By.XPath("//div[@id='gridModPDFDocTypes_paginate']");
        By txt_Search => By.XPath("//span[contains(@class,'search--dropdown')]//input[@type='search']");
        By ddl_Month => By.XPath("//span[contains(@class,'select2-dropdown')]//li//span[contains(text(),'Month')]");
        By inp_DocReviewedAfter => By.XPath("//input[@id='txtDocReviewUnit']");
        By lbl_RevOptValue => By.XPath("//span[@id='select2-drpRevOpt-container']//span");
        By lbl_DocNumOptValue => By.XPath("//span[@id='select2-drpDocNumOpt-container']//span");
        By lbl_RevDateOptValue => By.XPath("//span[@id='select2-drpRevDateOpt-container']//span");
        By lbl_DocumentPro => By.XPath("//h1[contains(text(),'Document Pro')]");
        By lbl_KeyFeatures => By.XPath("//h3[contains(text(),'Key Features')]");
        By lbl_LevelNameInFM => By.XPath("(//a[contains(@class,'level')]//span)[2]");
        By ddl_RightForSite_Disabled => By.XPath("//div[@id='rightsContextMenu']//li[@id='divSiterights' and contains(@cursor,'not-allowed')]");
        By ddl_RightForGroups_Disabled => By.XPath("//div[@id='rightsContextMenu']//li[@id='divGrouprights' and contains(@cursor,'not-allowed')]");
        By ddl_RightForUsers_Disabled => By.XPath("//div[@id='rightsContextMenu']//li[@id='divUserrights' and contains(@cursor,'not-allowed')]");
        By ddl_New_Disabled => By.XPath("//div[@id='rightsContextMenu']//li[@id='divNewFolder' and contains(@cursor,'not-allowed')]");
        By ddl_Delete_Disabled => By.XPath("//div[@id='rightsContextMenu']//li[@id='divDeleteFolder' and contains(@cursor,'not-allowed')]");
        By ddl_Edit_Enabled => By.XPath("//div[@id='rightsContextMenu']//li[@id='divEditFolder']");
        By ddl_New_Enabled => By.XPath("//div[@id='rightsContextMenu']//li[@id='divNewFolder']");
        By lbl_levelName => By.XPath("//span[contains(@class,'Lbl_PrimaryID')]");
        By ddl_RightForSite_Enabled => By.XPath("//div[@id='rightsContextMenu']//li[@id='divSiterights']");
        By ddl_RightForGroups_Enabled => By.XPath("//div[@id='rightsContextMenu']//li[@id='divGrouprights']");
        By ddl_RightForUsers_Enabled => By.XPath("//div[@id='rightsContextMenu']//li[@id='divUserrights']");
        By ddl_Delete_Enable => By.XPath("//div[@id='rightsContextMenu']//li[@id='divDeleteFolder']");
        By lbl_FrequencyAlert => By.XPath("//div[@class='alert alert-warning alert-dismissible border-bottom']");
        By lbl_days => By.XPath("(//span[contains(@id,'drpReviewAfter')])[1]");
        By drp_DocumentsReviewdAfterInLevelsPage => By.XPath("//span[@id = 'select2-drpReviewAfter-container']");

        By inp_SearchForDocumentsReviewdAfterInLevelsPage = By.XPath("//input[@type='search']");
        By chk_AllowSiteModificationIsChecked => By.XPath("//input[contains(@class, 'chk-col-blue') and @checked]");
        By lbl_alertLevelDependencyMessage => By.XPath("//div[contains(text(),'This level is used by site and contains documents. Please transfer documents')]");
        By lbl_Alert_LevelNameNumberCannotBeEmpty => By.XPath("//div[contains(text(),'Level name/number empty')]");
        By inp_DisabledLevelNumField => By.XPath("//input[@id='txtLevelNum' and @disabled]");
        By btnRefresh_LevelPage => By.XPath("//*[local-name()='svg' and @id='btnreferesh']");
        By inpParentLevelName_LevelPage => By.XPath("(//input[@id='tdParentLevelName' and @readonly='true'])[1]");
        By ddlTemplateName_LevelPDFPreference => By.XPath("//label[contains(text(),'Template')]//following::select[@class='custom-select']//option[@selected]");
        By ddlSuiteDefault_LevelPDFPreference => By.XPath("//label[contains(text(),'Template')]//following::select[@class='custom-select']//option[contains(text(),'Suite Default')]");
        By ddlAutomationTemp_LevelPDFPreference => By.XPath("//label[contains(text(),'Template')]//following::select[@class='custom-select']//option[contains(text(),'Automation Template')]");
        By msgPreferencesSavedSuccessfully => By.XPath("//div[contains(text(),'saved successfully')]");
        By btn_UseSiteDefault => By.XPath("//div[contains(text(),'saved successfully')]");
        By input_pdfsearch => By.XPath("//select[contains(@id,'gridModPDFDocTypes')]//following::input[1]");
        By ddlModules_MultiSearch => By.XPath("(//div[@class='dtsb-criteria']//select//option[contains(text(),'Modules')])[1]");
        By btnAdd_PdfTemplate => By.XPath("//button[@title='Add']");
        By btnDelete_PdfTemplate => By.XPath("//button[contains(@class,'danger')]");
        By ddlTempName_MultiSearch => By.XPath("(//div[@class='dtsb-criteria']//select//option[contains(text(),'Template Name')])[1]");
        By txtTemplateName => By.XPath("//input[@id='txtTemplateName']");
        By chkIncludeWatermark => By.XPath("//label[@for='chkIncludeWMark']");
        By chkIncludeHeader => By.XPath("//label[@for='chkIncludeHeader']");
        By chkIncludeFooter => By.XPath("//label[@for='chkIncludeFooter']");
        By chkIncludeCoverPage => By.XPath("//label[@for='chkIncludeCPage']");
        By ddlQATesting_LevelPDFPreference => By.XPath("//label[contains(text(),'Template')]//following::select[@class='custom-select']//option[contains(text(),'QATesting')]");
        By chk_FirstRowInActive => By.XPath("//tbody//tr[@role='row' and @class='odd']//input[@type='checkbox']");
        By drpPositionInTempDetails => By.XPath("//select[@id='drpwMarkPosition']");
        By ddlPositionTopInTempDetails => By.XPath("(//select[@id='drpwMarkPosition']/option)[1]");
        By ddlPositionBottomInTempDetails => By.XPath("(//select[@id='drpwMarkPosition']/option)[2]");
        By ddlPositionLeftInTempDetails => By.XPath("(//select[@id='drpwMarkPosition']/option)[3]");
        By ddlPositionRightInTempDetails => By.XPath("(//select[@id='drpwMarkPosition']/option)[4]");
        By ddlPositionDiagonalInTempDetails => By.XPath("(//select[@id='drpwMarkPosition']/option)[5]");
        By ddlPositionCenterInTempDetails => By.XPath("(//select[@id='drpwMarkPosition']/option)[6]");
        By inp_Opaqueness => By.XPath("//input[@id='txtOpaqueness']");
        By lblTempNameInPdfTempPage => By.XPath("(//td[@class='sorting_1']/a)[1]");
        By btn_YesApplyToAllDoc => By.XPath("//button[@title='Yes Apply to All Documents']");
        By drp_DataFields_Watermark => By.XPath("(//a[@title='DataFields'])[1]");
        By drp_DataFields_CoverPage => By.XPath("(//a[@title='DataFields'])[4]");
        By lblHeaderDetails => By.XPath("//div[@id='trHeaderHeading']/h6");
        By lblFooterDetails => By.XPath("//div[@id='trFooterHeading']/h6");
        By coverPageTab => By.XPath("//a[@id='tabpdfcpage']");
        By lblPosition => By.XPath("//div[@id='trCPageHeader']//h5");
        By txtHeaderDetails => By.XPath("(//html[@dir='ltr']//body[@contenteditable='true']/p)[1]");
        By txtCoverPageDetails => By.XPath("(//html[@dir='ltr']//body[@contenteditable='true']/p)[4]");
        By btnLoadPrevious => By.XPath("//button[@id='btnldprvtemp']");
        By lblTempName_LoadPrev => By.XPath("//tr[@class='ui-widget-header']//th");
        By lblLoadPreviousVersion => By.XPath("//h5[contains(text(),'Load Previous Version')]");
        By btnShowSamplePDF_LoadPrev => By.XPath("(//div[@id='TemplateLoadPreviousGrid_wrapper']//button[contains(@onclick,'ShowSamplePDF')])[1]");
        By tblLoadPrevGrid_LoadPrev => By.XPath("//table[@id='TemplateLoadPreviousGrid']");

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
        static By iframe_SelectTags => By.XPath("//iframe[@id='ifrselecttags']");
        static By iframe_water => By.XPath("//iframe[@id='iframewater']");
        static By iframe_ckeEditor_Watermark => By.XPath("(//iframe[contains(@class,'wysiwyg')])[1]");
        static By iframe_ckeEditor_Header => By.XPath("(//iframe[contains(@class,'wysiwyg')])[2]");
        static By iframe_ckeEditor_Footer => By.XPath("(//iframe[contains(@class,'wysiwyg')])[3]");
        static By iframe_ckeEditor_CoverPage => By.XPath("(//iframe[contains(@class,'wysiwyg')])[4]");
        static By iframe_tempLoadPrev => By.XPath("//iframe[@id='iframetemploadprv']");

        #endregion

        #region PageActions

        /// <summary>
        /// This method help us to navigate into levels page inside the Suite Setup
        /// </summary>
        public void NavigateToLevelsPage(String SubHead)
        {
            if (seleniumActions.IsElementPresent(sideMenuContainer))
            {
                seleniumActions.Wait(3);
                seleniumActions.Click(lblSetup);
                seleniumActions.Click(lblSuiteSetup);
                seleniumActions.Wait(3);
                seleniumActions.ScrollToElement(By.XPath("(//a[@class='submenu_list_link has-arrow']//following-sibling::ul[@class='inner_submenu']//span[contains(text(),'" + SubHead + "')])[2]"));
                seleniumActions.Click(By.XPath("(//a[@class='submenu_list_link has-arrow']//following-sibling::ul[@class='inner_submenu']//span[contains(text(),'" + SubHead + "')])[2]"));
            }
        }

        /// <summary>
        /// Valdating Levels page Header to make sure level page is loaded or not
        /// </summary>
        public void validateLevelsPage()
        {
            seleniumActions.Wait(3);
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Tree);
            Assert.IsTrue(seleniumActions.IsElementPresent(txtSuiteLevelHeader, 5));
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
            seleniumActions.SwitchToFrame(iframe_Tree);
            seleniumActions.Click(inpLevelNumber);
            seleniumActions.Click(popUp_Yes);
            seleniumActions.SendKeys(inpLevelNumber, utility.CurrentTime());
            seleniumActions.SendKeys(inp_Levelname, levelName);
            seleniumActions.Click(btn_save);
            seleniumActions.Wait(2);
            seleniumActions.IsElementPresent(By.XPath("//h5[contains(text(),'Level - " + levelName + "')]"));
            seleniumActions.SwitchToDefaultContent();
            return levelName;
        }

        /// <summary>
        /// Validate the Reset scenario in the level page
        /// </summary>

        public void ValidateResetScenario()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Tree);
            seleniumActions.Click(inpLevelNumber);
            seleniumActions.Click(popUp_Yes);
            seleniumActions.SendKeys(inpLevelNumber, "10000");
            string levelnum = seleniumActions.GetAttributeValue(inpLevelNumber, "value");
            seleniumActions.SendKeys(inp_Levelname, "Tester");
            string levelname = seleniumActions.GetAttributeValue(inp_Levelname, "value");
            seleniumActions.SendKeys(btn_Prefix, "QA");
            string prefixname = seleniumActions.GetAttributeValue(btn_Prefix, "value");
            seleniumActions.SendKeys(btn_DocReviewafter, "1");
            string docreviewday = seleniumActions.GetAttributeValue(btn_DocReviewafter, "value");
            seleniumActions.Click(btn_Reset);
            seleniumActions.Wait(3);
            Assert.IsFalse(seleniumActions.GetText(inpLevelNumber).Equals(levelnum));
            Assert.IsFalse(seleniumActions.GetText(inp_Levelname).Equals(levelname));
            Assert.IsFalse(seleniumActions.GetText(btn_Prefix).Equals(prefixname));
            Assert.IsFalse(seleniumActions.GetText(btn_DocReviewafter).Equals(docreviewday));
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Validate the Review Frequency must be numeric alert popup
        /// </summary>

        public void ValidateReviewFrequencyMustBeNumeric()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Tree);
            seleniumActions.Click(inpLevelNumber);
            seleniumActions.Click(popUp_Yes);
            seleniumActions.SendKeys(inpLevelNumber, "1000012");
            seleniumActions.SendKeys(inp_Levelname, "SASASH");
            seleniumActions.SendKeys(btn_DocReviewafter, "QA");
            seleniumActions.Click(btn_save);
            seleniumActions.Wait(2);
            seleniumActions.IsElementPresent(lbl_FrequencyAlert);
            Assert.IsTrue(seleniumActions.GetText(lbl_FrequencyAlert).Contains("Review Frequency must be numeric"));
            seleniumActions.Wait(3);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Validate the Review Frequency must be numeric alert popup
        /// </summary>
        public void ValidateDayDocumentReviewedFieldAcceptDigits()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Tree);
            seleniumActions.Click(inpLevelNumber);
            seleniumActions.Click(popUp_Yes);
            seleniumActions.SendKeys(inpLevelNumber, "10000");
            seleniumActions.SendKeys(inp_Levelname, "Tester");
            seleniumActions.IsElementPresent(lbl_days);
            seleniumActions.SendKeys(btn_DocReviewafter, "100001");
            seleniumActions.Click(btn_save);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// selects site sub level creation checkbox
        /// </summary>
        public void SelectSiteSubLevelCreationCheckbox()
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.SwitchToFrame(iframe_Tree);
            seleniumActions.Click(chk_SiteSubLevel);
            seleniumActions.Click(btn_save);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Click Sub level creation check box and Allow Site modification Check box in levels page
        /// </summary>
        public void SelectSiteSubLevelCreationAndAllowSiteCheckbox()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Tree);
            seleniumActions.Click(chk_SiteModification);
            seleniumActions.Click(chk_SiteSubLevel);
            seleniumActions.Click(btn_save);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Use this method to Edit the existing level
        /// </summary>
        /// <param name="LevelName"></param>
        /// <returns></returns>
        public String EditLevel(String LevelName)
        {
            string editedLevel = Constants.Level + "-" + utility.CurrentTime();
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Click(btn_refreshLevel);
            seleniumActions.MoveToElement(By.XPath("//table[@class='Tbltitle']//ul[@id='TOCDoclvl']//a[contains(@title,'" + LevelName + "')]"));
            seleniumActions.Click(By.XPath("(//table[@class='Tbltitle']//ul[@id='TOCDoclvl']//a[contains(@title,'" + LevelName + "')]//following::*[local-name()='svg' and contains(@class,'pencil')])[1]"));
            seleniumActions.SwitchToIframes(iframe_Tree);
            seleniumActions.SendKeys(inp_Levelname, editedLevel);
            seleniumActions.Click(btn_save);
            string levelHeader = "Level - " + editedLevel;
            seleniumActions.IsElementPresent(By.XPath("//h5[contains(text(),'" + levelHeader + "')]"));
            seleniumActions.SwitchToDefaultContent();
            return editedLevel;
        }

        /// <summary>
        /// Deletes the level by hovering on the level
        /// </summary>
        /// <param name="LevelName"></param>
        public void DeleteLevelByHovering(String LevelName)
        {
            //seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Click(btn_refreshLevel);
            seleniumActions.MoveToElement(By.XPath("//table[@class='Tbltitle']//ul[@id='TOCDoclvl']//a[contains(@title,'" + LevelName + "')]"));
            seleniumActions.Click(By.XPath("(//table[@class='Tbltitle']//ul[@id='TOCDoclvl']//a[contains(@title,'" + LevelName + "')]//following::*[local-name()='svg' and contains(@class,'trash')])[1]"));
            seleniumActions.Click(popUp_Yes);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblDeletedSuccessMessage), "lbl Deleted success msg is not showing");
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Clicks folder management ,  searches the level 
        /// </summary>
        /// <param name="LevelName"></param>
        public void SearchAndClickLevelInFolderManagement(string LevelName)
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Click(folderManagement_Tab);
            seleniumActions.SwitchToFrame(iframe_MenuData);
            seleniumActions.Click(phd_SearchByFolder);
            seleniumActions.SendKeys(phd_SearchByFolder, LevelName);
            seleniumActions.Click(btnSearch_SearchByFolder);
            Assert.IsTrue(seleniumActions.IsElementPresent(By.XPath("(//a[@title='" + LevelName + "']//span)[2]")), "Searched level not found");
            seleniumActions.Wait(3);
            seleniumActions.Click(By.XPath("(//a[@title='" + LevelName + "']//span)[2]"));
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Clicks folder management ,  searches the level and make it in use
        /// </summary>
        public void MakeLevelInUse()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.Wait(2);
            seleniumActions.ScrollToPosition(0, 1000);
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
            seleniumActions.SendKeys(inpSearch_AssignRoute, subHead);
            seleniumActions.Click(By.XPath("//li[@role='treeitem']//span[contains(text(),'" + subHead + "')]"));
            seleniumActions.Wait(2);
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.Click(btn_Close_RoutePage);
            Assert.IsTrue(seleniumActions.GetText(lnk_InheritFromParent).Equals(subHead));
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
            Assert.IsTrue(seleniumActions.IsElementPresent(breadCrumb_NewDocRequest, 5), "New Doc Request breadcrumb is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(btn_LevelSelector, 5), "level selector button is not found");
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
            seleniumActions.ScrollToPosition(0, 300);
            seleniumActions.Wait(2);
            seleniumActions.Click(txtDocNumber);
            seleniumActions.SendKeys(txtDocNumber, utility.RandomNumberGenerator(3));
            seleniumActions.Wait(2);
            seleniumActions.Click(txtDocName);
            seleniumActions.SendKeys(txtDocName, Keys.Clear);
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
        /// Clicks the pending requests menu if present
        /// </summary>
        public void ClickPendingRequestsMenu()
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
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
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
            seleniumActions.Wait(5);
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
            //Assert.IsTrue(seleniumActions.IsElementPresent(lblActions, 5), "label actions in action page is not found");
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
            seleniumActions.ScrollToPosition(0, 1600);
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
        /// searches for rights in document rights page
        /// </summary>
        public void SearchForRightsInDocumentRights()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.Wait(2);
            seleniumActions.Click(inpSearch_RightsForGroup);
            seleniumActions.SendKeys(inpSearch_RightsForGroup, "Rights");
            seleniumActions.Wait(2);
            Assert.IsTrue(seleniumActions.GetText(lbl_Rights).Equals("Rights"));
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Set Attach Rights for New Document Creation
        /// </summary>
        public void DocumentCreationResquestRights()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.Click(chk_DocumentCreation_Inherit);
            seleniumActions.Click(chk_DocumentCreation_RequestRight);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        ///Set View Only for New Document Access
        /// </summary>
        public void DocumentAccessRequestRights()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.Click(img_plusIcon);
            seleniumActions.ScrollToPosition(0, 1000);
            seleniumActions.Click(chk_NewDocumentAccess_Inherit);
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
            Assert.IsTrue(seleniumActions.GetText(lnk_StatusValue).Equals(status));
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
            seleniumActions.ScrollToElement(rad_Reject);
            seleniumActions.Click(rad_Reject);
            seleniumActions.Wait(3);
            seleniumActions.SwitchToFrame(iframe_ResetAction);
            seleniumActions.Click(inp_Reason);
            seleniumActions.SendKeys(inp_Reason, "Test");
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

        /// <summary>
        /// Verifies pending req doc is not showing in the actions page
        /// </summary>
        public void VerifyPendingReqDocIsNotIsPresent(string docName)
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
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_NoRecordsToDisplay), "Document is showing actions page");
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        ///  Gives full access for new doc access and doc access
        /// </summary>
        public void FullAccessForDocument()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.Click(img_plusIcon);
            seleniumActions.ScrollToPosition(0, 1000);
            seleniumActions.Click(chk_NewDocumentAccess_Inherit);
            seleniumActions.Click(chk_NewDocFullAccess);
            seleniumActions.Click(lnkClick_FullAccess);
            seleniumActions.Wait(2);
            if (seleniumActions.IsElementPresent(img_plusIcon))
            {
                seleniumActions.Click(img_plusIcon);
                seleniumActions.ScrollToPosition(0, 1000);
                seleniumActions.Click(chk_DocumentAccess_Inherit);
                seleniumActions.Click(chk_DocumentAccess_FullAccess);
            }
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// This method used to search levels is document page
        /// </summary>
        public void SearchLevelsInDocumentPage(string LevelName)
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Click(inp_SearchLevelsInDocumentPage);
            seleniumActions.SendKeys(inp_SearchLevelsInDocumentPage, LevelName);
            seleniumActions.Click(btnSearch_SearchByFolder);
            Assert.IsTrue(seleniumActions.IsElementPresent(By.XPath("(//a[@title='" + LevelName + "']//span)[2]")), "Searched level not found");
            seleniumActions.Wait(3);
            seleniumActions.Click(By.XPath("(//a[@title='" + LevelName + "']//span)[2]"));
            seleniumActions.SwitchToDefaultContent();
        }

        // <summary>
        /// This method used terminate document in toc
        /// </summary>
        public void DeleteDocumentInToc()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Tree);
            seleniumActions.ContextClick(lnk_DocumentNumber_Toc);
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_ChangeRequest), "change request option is not displaying");
            seleniumActions.Click(lbl_ChangeRequest);
            seleniumActions.ScrollToPosition(0, 1000);
            seleniumActions.Click(chk_DeleteDocument_Toc);
            seleniumActions.Click(btn_Continue_Toc);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Verifies the Assigm Author menu is present
        /// </summary>
        public void VerifyAssignAuthorMenu()
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            Assert.IsTrue(seleniumActions.IsElementPresent(menu_AssignAuthor, 5), "Assign Author menu is not found");
            seleniumActions.Click(menu_AssignAuthor);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Searches the Authors in actions page
        /// </summary>
        public void SearchAuthorsInAssignAuthorPage()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions, iframe_ifrUsers);
            Assert.IsTrue(seleniumActions.IsElementPresent(btnMultiSearch));
            seleniumActions.Click(btnMultiSearch);
            Assert.IsTrue(seleniumActions.IsElementPresent(drpColumn_MultiSearch));
            seleniumActions.Click(drpColumn_MultiSearch);
            seleniumActions.Click(ddlName_MultiSearch);
            seleniumActions.Click(drpCondition_MultiSearch);
            seleniumActions.Click(ddlContains_MultiSearch);
            seleniumActions.Click(inp_MultiSearch);
            seleniumActions.SendKeys(inp_MultiSearch, "docpro");
            seleniumActions.Click(btnAdvancedSearch_MultiSearch);
            seleniumActions.Wait(3);
            Assert.IsTrue(seleniumActions.GetText(lbl_NameValue).Equals("docpro"));
            seleniumActions.Click(chk_AssignAuthor);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// This method helps to assign author
        /// </summary>
        public void AssignAuthor()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            seleniumActions.Click(status_Assign);
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            seleniumActions.Click(svg_AddAssignAutor);
            seleniumActions.Wait(2);
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions, iframe_ifrUsers);
            seleniumActions.Wait(3);
            seleniumActions.Click(hintSearch);
            seleniumActions.SendKeys(hintSearch, "DocPro");
            seleniumActions.Wait(3);
            seleniumActions.Click(chk_FirstUser);
            seleniumActions.SwitchToParentFrame();
            seleniumActions.ScrollToPosition(0, 1000);
            seleniumActions.Click(btn_UserDone);
            seleniumActions.Wait(3);
            seleniumActions.SwitchToParentFrame();
            seleniumActions.Click(btn_DoneBusinessRule);
            seleniumActions.Click(btn_SaveAuthor);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Verifies the documents needing revision menu is present
        /// </summary>
        public void VerifyDocumentsNeedingRevisionMenu()
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            Assert.IsTrue(seleniumActions.IsElementPresent(menu_DocumentsNeedingRevision, 5), "Documents Needing Revision menu is not found");
            seleniumActions.Click(menu_DocumentsNeedingRevision);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// this method is used to attach document
        /// </summary>
        public void AttachDocument()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            Assert.IsTrue(seleniumActions.IsElementPresent(status_AttachDocument), "Attach Document link is not found");
            seleniumActions.Click(status_AttachDocument);
            var path = new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath;
            var actualPath = path.Substring(0, path.LastIndexOf("bin"));
            var projectPath = new Uri(actualPath).LocalPath;
            string docName = Constants.Name + utility.GenerateRandomText(2);
            seleniumActions.SendKeys(inp_ChooseFile_ActionsFlow, projectPath.ToString() + Constants.SampleFilePath_Book);
            seleniumActions.ScrollToPosition(0, 300);
            seleniumActions.Wait(2);
            seleniumActions.Click(btn_Continue);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        ///  Gives full access for new doc access and doc access
        /// </summary>
        public void FullAccessForDocumentFromRequestRight()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.Click(img_plusIcon);
            seleniumActions.ScrollToPosition(0, 1000);
            seleniumActions.Click(chk_DocumentAccess_RequestRight);
            seleniumActions.Click(chk_NewDocFullAccess);
            seleniumActions.Click(lnkClick_FullAccess);
            seleniumActions.Wait(2);
            if (seleniumActions.IsElementPresent(img_plusIcon))
            {
                seleniumActions.Click(img_plusIcon);
                seleniumActions.ScrollToPosition(0, 1000);
                seleniumActions.Click(chk_DocumentAccess_RequestRight_FromLink);
                seleniumActions.Click(chk_DocumentAccess_FullAccess);
            }
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Choose exisitng level in new document request page
        /// </summary>
        public void ChooseExistingLevelForPendingDocDraft(string levelName)
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Click(btnLevelSelector_PendingDocDraft);
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
        public string UploadNewDocumentForPendingDocDraft()
        {
            var path = new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath;
            var actualPath = path.Substring(0, path.LastIndexOf("bin"));
            var projectPath = new Uri(actualPath).LocalPath;

            string docName = Constants.Name + utility.GenerateRandomText(2);
            string docNumber = Constants.DocNumber + utility.RandomNumberGenerator(2);
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Click(txtDocNum_PendingDocDraft);
            seleniumActions.SendKeys(txtDocNum_PendingDocDraft, docNumber);
            seleniumActions.Click(txtDocName_PendingDocDraft);
            seleniumActions.SendKeys(txtDocName_PendingDocDraft, docName);
            seleniumActions.SendKeys(inp_ChooseFile_PendingDocDraft, projectPath.ToString() + Constants.SampleFilePath_Book);
            seleniumActions.Click(btn_Continue_Toc);
            seleniumActions.Click(popUp_Yes);
            seleniumActions.SwitchToDefaultContent();
            return docName;
        }

        /// <summary>
        /// Clicks the pending doc draft menu if present
        /// </summary>
        public void ClickPendingDocDraftMenu()
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            Assert.IsTrue(seleniumActions.IsElementPresent(menu_PendingDocDraft, 5), "Pending doc draft menu is not found");
            seleniumActions.Click(menu_PendingDocDraft);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Clicks the hamburger menu
        /// </summary>
        public void ClickHamburgerMenu()
        {
            Assert.IsTrue(seleniumActions.IsElementPresent(svg_HamburgerMenu, 5), "hamburger menu is not found");
            seleniumActions.Click(svg_HamburgerMenu);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// this method helps to click the statusValue link
        /// </summary>
        public void ClickStatusValueLink()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            seleniumActions.Click(lnk_StatusValue);
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** UA - 02 : Pending Doc Draft - Start of TC 01 ************ //

        /// <summary>
        /// Validates the UI elements of pending doc draft menu
        /// </summary>
        public void ValidateUIElementsOfPendingDocDraftMenu()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            // ** Validate => DOC - 2500 - 10 - 110 & 140 ** //
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_DocNumber, 5), "Doc number is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_DocName, 5), "Doc name is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_Date, 5), "date is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_Revision, 5), "revision is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_LastCmntDate, 5), "last cmnt date is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_Status, 5), "status is not found");
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// verifies the color code of in process status 
        /// </summary>
        public void VerifyColorCodeOfStatusValue()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            string bgColor = seleniumActions.FindElement(lnk_StatusValue).GetCssValue("color");
            Assert.IsTrue(bgColor.Equals(Constants.StatusColorCode));
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Clicks the draft req needing viewing menu if present
        /// </summary>
        public void ClickDraftReqNeedingViewingMenu()
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            Assert.IsTrue(seleniumActions.IsElementPresent(menu_DraftRequestsNeedingViewing, 5), "Draft req needing viewing menu is not found");
            seleniumActions.Click(menu_DraftRequestsNeedingViewing);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// adds a comment for the draft in draft req needing viewing menu
        /// </summary>
        public void AddCommentForDraftInDraftReqNeedingMenu()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            seleniumActions.Click(txtAddComment);
            seleniumActions.SendKeys(txtAddComment, Constants.Name);
            seleniumActions.Click(btn_Send);
            seleniumActions.SwitchToDefaultContent();
        }

        public void AddOldCommentForDraftInDraftReqNeedingMenu()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            seleniumActions.Click(lnk_StatusValue);
            seleniumActions.Click(txtAddComment);
            seleniumActions.SendKeys(txtAddComment, Constants.TestName);
            seleniumActions.Click(btn_Send);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// verifies the user can be added from draft viewer
        /// </summary>
        public void VerifyUserCanBeAddedFromDraftViewer()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            seleniumActions.Click(lnk_StatusValue);
            Assert.IsTrue(seleniumActions.IsElementPresent(btn_ChangeRequest, 5), "change req button is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(svg_DraftViewersIcon, 5), "Add draft viewers button is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(tbl_OldestComments, 5), "oldest cmnt section tab is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(tbl_NewestComments, 5), "newest cmnt section tab is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(tbl_PopularComments, 5), "popular cmnt section tab is not found");
            seleniumActions.Click(svg_DraftViewersIcon);

            seleniumActions.Wait(4);
            seleniumActions.SwitchToIframes(iframe_ifrUsers);
            seleniumActions.Click(phd_Name);
            seleniumActions.SendKeys(phd_Name, "DocPro-Admin");
            seleniumActions.Wait(3);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblTeamLeader_SearchResult));
            Assert.IsTrue(seleniumActions.GetText(lblTeamLeader_SearchResult).Contains(Constants.DocProUsername));
            seleniumActions.Click(chkUsernameInactive);
            Assert.IsTrue(seleniumActions.IsElementPresent(chkUsernameActive, 5), "username was not checked");
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            seleniumActions.Click(btn_Done);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblDocPro_DraftViewer), "added draft viewer was not visible");
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// verifies the user can be removed from draft viewer
        /// </summary>
        public void VerifyUserCanBeRemovedFromDraftViewer()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            seleniumActions.WaitForElementToExists(svg_DraftViewersIcon);
            seleniumActions.Click(svg_DraftViewersIcon);

            seleniumActions.Wait(4);
            seleniumActions.SwitchToIframes(iframe_ifrUsers);
            seleniumActions.Click(phd_Name);
            seleniumActions.SendKeys(phd_Name, "DocPro-Admin");
            seleniumActions.Wait(3);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblTeamLeader_SearchResult));
            Assert.IsTrue(seleniumActions.GetText(lblTeamLeader_SearchResult).Contains(Constants.DocProUsername));
            Assert.IsTrue(seleniumActions.IsElementPresent(chkUsernameInactive));
            seleniumActions.Click(chkUsernameInactive);
            seleniumActions.Wait(2);
            Assert.IsTrue(seleniumActions.IsElementPresent(chkUsernameInactive), "username was not removed");
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            seleniumActions.Click(btn_Done);
            Assert.IsFalse(seleniumActions.IsElementPresent(lblDocPro_DraftViewer), "added draft viewer was not visible");
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** UA - 02 : Pending Doc Draft - End of TC 01 ************ //

        // *********** UA - 02 : Pending Doc Draft - Start of TC 06 ************ //

        /// <summary>
        /// Validate the system should not allow the user to remove the 
        /// user who has already  commented on the draft
        /// </summary>
        public void VerifyUserCannotRemovedFromTheDraft()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            Assert.IsTrue(seleniumActions.IsElementPresent(btn_ChangeRequest, 5), "change req button is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(svg_DraftViewersIcon, 5), "Add draft viewers button is not found");
            seleniumActions.WaitForElementToExists(svg_DraftViewersIcon);
            seleniumActions.Click(svg_DraftViewersIcon);

            seleniumActions.Wait(4);
            seleniumActions.SwitchToIframes(iframe_ifrUsers);
            seleniumActions.Click(phd_Name);
            seleniumActions.SendKeys(phd_Name, "Right-Scenario");
            seleniumActions.Wait(3);
            seleniumActions.Wait(3);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblTeamLeader_SearchResult));
            Assert.IsTrue(seleniumActions.GetText(lblTeamLeader_SearchResult).Contains(Constants.RightUsername));
            Assert.IsTrue(seleniumActions.IsElementPresent(chkUsernameInactive));
            seleniumActions.Click(chkUsernameInactive);
            seleniumActions.Wait(2);
            Assert.IsTrue(seleniumActions.IsElementPresent(chkUsernameInactive), "username was not removed");
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            seleniumActions.Click(btn_Done);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblRightScenario_DraftViewer), "added draft viewer was not visible");
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** UA - 02 : Pending Doc Draft - End of TC 06 ************ //

        /// <summary>
        /// Changes the corporate to right site
        /// </summary>
        public void ChangeTheCorporateToRightSite()
        {
            seleniumActions.Click(ddp_Corporate);
            seleniumActions.Click(ddl_RightSite);
        }

        /// <summary>
        /// Change the site from "Right Site" to "corporate"
        /// </summary>
        public void ChangeTheRightSiteToCorporate()
        {
            seleniumActions.Click(ddp_RightSite);
            seleniumActions.Click(ddl_Corporate);
        }

        // *********** UA - 02 : Pending Doc Draft - Start of TC 07 ************ //

        /// <summary>
        /// This method is used to validate the status column in right end
        /// </summary>
        public void ValidateStatusColumnInRightMostEnd()
        {
            {
                seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
                string lastHeaderText = seleniumActions.GetText(tblLastColumn_pendingRequestDraft);
                Assert.IsTrue(lastHeaderText.Equals("Status"), "The last column is not 'Status'.");
                seleniumActions.SwitchToDefaultContent();
            }
        }

        // *********** UA - 02 : Pending Doc Draft - End of TC 07 ************ //

        // *********** UA - 02 : Pending Doc Draft - Start of TC 05 ************ //

        /// <summary>
        /// Clicks the change req button in pending doc draft
        /// </summary>
        public void ClickChangeRequestOnPendingDocDraft()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            Assert.IsTrue(seleniumActions.IsElementPresent(btn_ChangeRequest, 5), "change req button is not found");
            seleniumActions.Click(btn_ChangeRequest);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// enables the Interface Agreement button inside document menu - business rule page 
        /// </summary>
        public void EnableInterfaceAgreementButton()
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Click(menu_DocumentsBusinessRule);
            seleniumActions.SwitchToFrame(iframe_MenuData);
            seleniumActions.ScrollToPosition(0, 1600);
            Assert.IsTrue(seleniumActions.IsElementPresent(btn_DisabledInterfaceAgreement, 5), "unable to find interface agreement button");
            seleniumActions.Click(btn_DisabledInterfaceAgreement);
            seleniumActions.Wait(2);
            Assert.IsTrue(seleniumActions.IsElementPresent(btn_EnabledInterfaceAgreement, 5), "enabled interface agreement button is not enabled");
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
        /// disables the Interface Agreement button inside document menu - business rule page
        /// </summary>
        public void DisableInterfaceAgreementButton()
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Click(menu_DocumentsBusinessRule);
            seleniumActions.SwitchToFrame(iframe_MenuData);
            seleniumActions.ScrollToPosition(0, 1600);
            Assert.IsTrue(seleniumActions.IsElementPresent(btn_EnabledInterfaceAgreement, 5), "unable to find enabled interface agreement button");
            seleniumActions.Click(btn_EnabledInterfaceAgreement);
            seleniumActions.Wait(2);
            Assert.IsTrue(seleniumActions.IsElementPresent(btn_DisabledInterfaceAgreement, 5), "disabled interface agreement button is not disabled");
            seleniumActions.ScrollToPosition(0, 2600);
            Assert.IsTrue(seleniumActions.IsElementPresent(btn_SaveBusinessRule, 5), "unable to find save button");
            seleniumActions.Wait(2);
            seleniumActions.Click(btn_SaveBusinessRule);
            seleniumActions.Wait(2);
            seleniumActions.Click(btn_DoneBusinessRule);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// chooses a date reason for change and description in change request page
        /// </summary>
        public void ChooseDateAndReasonDescriptionInChangeReqScreen()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            Assert.IsTrue(seleniumActions.IsElementPresent(txt_EffectiveDate, 5), "effective date textbox is not found");
            seleniumActions.ScrollToPosition(0, 1000);
            seleniumActions.Click(txt_EffectiveDate);
            Assert.IsTrue(seleniumActions.IsElementPresent(tblDatePicker_EffectiveDate, 5), "date picker is not visible");
            seleniumActions.Click(lblCurrentDate_DatePicker);
            seleniumActions.Click(txt_ChngDescription);
            seleniumActions.SendKeys(txt_ChngDescription, Constants.Name);
            seleniumActions.Click(txt_ReasonForChange);
            seleniumActions.SendKeys(txt_ReasonForChange, Constants.Name);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// select online document in change request page
        /// </summary>
        public void SelectOnlineDocumentInChangeReqScreen()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            seleniumActions.ScrollToPosition(0, 1000);
            seleniumActions.Click(chk_OnlineDocument);
            seleniumActions.Wait(3);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblOnlineDocTemplates, 5), "online document page is not visible");
            seleniumActions.Click(btnClose_OnlineDocument);
            seleniumActions.Click(btn_Continue_Toc);
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** UA - 02 : Pending Doc Draft - End of TC 05 ************ //

        // *********** UA - 02 : Pending Doc Draft - Start of TC 03 ************ //

        /// <summary>
        /// select attach draft in change request page
        /// </summary>
        public void SelectAttachDraftInChangeReqScreen()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            seleniumActions.ScrollToPosition(0, 1000);
            Assert.IsTrue(seleniumActions.IsElementPresent(chk_AttachDraft), "attach draft checkbox is not visible");
            seleniumActions.Click(chk_AttachDraft);
            seleniumActions.Wait(3);
            seleniumActions.Click(btn_Continue_Toc);
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** UA - 02 : Pending Doc Draft - End of TC 03 ************ //

        // *********** UA - 02 : Pending Doc Draft - Start of TC 02 ************ //

        /// <summary>
        /// Add the comments in Draft Requests Needing Viewing Tab
        /// </summary>
        public void AddNewestCommentDraftRequestsNeedingViewing()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            seleniumActions.Click(lnk_StatusValue);
            seleniumActions.Click(txtAddComment);
            seleniumActions.SendKeys(txtAddComment, Constants.NewComment);
            seleniumActions.Click(btn_Send);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Validate the comments in Pending Document Drafts under Newest comment tab
        /// </summary>
        public void ValidateNewestCommentfromPendingDocumentDrafts()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            seleniumActions.Click(lnk_StatusValue);
            seleniumActions.Click(tbl_NewestComments);
            Assert.IsTrue(seleniumActions.GetText(txtbox_commentsBox).Equals(Constants.NewComment), "Comment is not present in the tab");
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Add the comments in Draft Requests Needing Viewing Tab
        /// </summary>
        public void AddOldCommentDraftRequestsNeedingViewing()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            seleniumActions.Click(lnk_StatusValue);
            seleniumActions.Click(txtAddComment);
            seleniumActions.SendKeys(txtAddComment, Constants.OldComment);
            seleniumActions.Click(btn_Send);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Validate the comments in Pending Document Drafts under Oldest comment tab
        /// </summary>
        public void ValidateOldestCommentFromPendingDocumentDrafts()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            seleniumActions.Click(lnk_StatusValue);
            seleniumActions.Click(tbl_OldestComments);
            Assert.IsTrue(seleniumActions.GetText(txtbox_commentsBox).Equals(Constants.OldComment), "Comment is not present in the tab");
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Click the Upvote in Draft Requests Needing Viewing Tab
        /// </summary>
        public void AddPopularCommentDraftRequestsNeedingViewing()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            seleniumActions.Click(lnk_StatusValue);
            seleniumActions.Click(tbl_NewestComments);
            seleniumActions.Click(btn_Upvote);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Validate the comments in Pending Document Drafts under Newest comment tab
        /// </summary>
        public void ValidatePopularCommentPendingDocumentDrafts()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            seleniumActions.Click(lnk_StatusValue);
            seleniumActions.Click(tbl_PopularComments);
            seleniumActions.Wait(2);
            seleniumActions.Click(tbl_OldestComments);
            seleniumActions.Wait(2);
            seleniumActions.Click(tbl_PopularComments);
            seleniumActions.Wait(2);
            Assert.IsTrue(seleniumActions.GetText(txtbox_commentsBox).Equals(Constants.OldComment), "Comment is not present in the tab");
            seleniumActions.SwitchToDefaultContent();
        }


        /// <summary>
        /// Validate the attach draft button without continue button
        /// </summary>
        public void SelectAttachDraftWithoutClickingContinue()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            seleniumActions.Click(btn_ChangeRequest);
            seleniumActions.ScrollToPosition(0, 1000);
            Assert.IsTrue(seleniumActions.IsElementPresent(chk_AttachDraft), "attach draft checkbox is not visible");
            seleniumActions.Click(chk_AttachDraft);
        }

        // *********** UA - 02 : Pending Doc Draft - End of TC 03 ************ //

        // ********************************************* User Actions - 03 Draft Request Needing Viewing ************************************************ //

        // *********** UA - 03 : Draft Request Viewing - Start of TC 02 ************ //

        /// <summary>
        /// This method is helps to verify the Accept and Reject radio button is not present in the draft details page
        /// </summary>

        public void ValidateAcceptAndRejectRadioIsNotPresent()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            Assert.IsFalse(seleniumActions.IsElementPresent(rdo_Accept, 5), "accept radio button should not be present");
            Assert.IsFalse(seleniumActions.IsElementPresent(rdo_Reject, 5), "reject radio button should not be present");
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// This method is helps to verify the latest comment is present in the draft details page
        /// </summary>

        public void ValidateLatestCommentIsPresent()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            Assert.IsTrue(seleniumActions.IsElementPresent(lnk_DocNumberValue, 5), "link doc number value is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_LatestComment), "latest comment is not present");
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** UA - 03 : Draft Request Viewing - End of TC 03 ************ //

        // *********** UA - 03 : Draft Req Needing Viewing - Start of TC 01 ************ //

        /// <summary>
        /// verifies the user can be added from draft viewer in draft req needing viewing
        /// </summary>
        public void VerifyUserCanBeAddedFromDraftViewerInDraftReqNeedingViewing()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            Assert.IsTrue(seleniumActions.IsElementPresent(svg_DraftViewersIconDraftReqNeedingPage, 5), "Add draft viewers button is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(tbl_OldestComments, 5), "oldest cmnt section tab is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(tbl_NewestComments, 5), "newest cmnt section tab is not found");
            Assert.IsTrue(seleniumActions.IsElementPresent(tbl_PopularComments, 5), "popular cmnt section tab is not found");
            seleniumActions.Click(svg_DraftViewersIconDraftReqNeedingPage);

            seleniumActions.Wait(4);
            seleniumActions.SwitchToIframes(iframe_ifrUsers);
            seleniumActions.Click(phd_Name);
            seleniumActions.SendKeys(phd_Name, "DocPro-Admin");
            seleniumActions.Wait(3);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblTeamLeader_SearchResult));
            Assert.IsTrue(seleniumActions.GetText(lblTeamLeader_SearchResult).Contains(Constants.DocProUsername));
            seleniumActions.Click(chkUsernameInactive);
            Assert.IsTrue(seleniumActions.IsElementPresent(chkUsernameActive, 5), "username was not checked");
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            seleniumActions.Click(btn_Done);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// reject the draft request in draft req needing viewing page
        /// </summary>
        public void ClickOnRejectRadioButtonInDraftReqNeedingViewingPage()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            Assert.IsTrue(seleniumActions.IsElementPresent(rdo_Accept), "accept radio button is not present");
            Assert.IsTrue(seleniumActions.IsElementPresent(rdo_Reject), "reject radio button is not present");
            seleniumActions.Click(rdo_Reject);
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** UA - 03 : Draft Req Needing Viewing - End of TC 01 ************ //

        // *********** UA - 03 : Draft Req Needing Viewing - Start of TC 02 ************ //

        /// <summary>
        /// Click Accept Radio Button
        /// </summary>
        public void ClickOnAcceptRadioButtonInDraftReqNeedingViewingPage()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            Assert.IsTrue(seleniumActions.IsElementPresent(rdo_Accept), "accept radio button is not present");
            seleniumActions.Click(rdo_Accept);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Verify Accept and Reject radio button is disabled
        /// </summary>
        public void ValidateAcceptAndRejectRadioButtonIsDisabled()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            Assert.IsTrue(seleniumActions.IsElementPresent(rdo_Accept_Disabled), "Accept radio button is not disabled");
            Assert.IsTrue(seleniumActions.IsElementPresent(rdo_Reject_Disabled), "Reject radio button is not disabled");
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Verify Accepted badge color
        /// </summary>
        public void ValidateAcceptedBadgeColor()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            string badgeColor = seleniumActions.FindElement(badge_Accepted_Comment).GetCssValue("background-color");
            Assert.IsTrue(badgeColor.Equals(Constants.AcceptedBadgeColorCode));
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Verify Rejected badge color
        /// </summary>
        public void ValidateRejectedBadgeColor()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Actions);
            string badgeColor = seleniumActions.FindElement(badge_Rejected_Comment).GetCssValue("background-color");
            Assert.IsTrue(badgeColor.Equals(Constants.RejectedBadgeColorCode));
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** UA - 03 : Draft Req Needing Viewing - End of TC 03 ************ //

        // ***************** FM - 03 : Level Create and Delete - Start of TC 21854 ******************** //

        /// <summary>
        /// verifies the level is present folder management heading
        /// </summary>
        /// <param name="LevelName"></param>
        public void VerifyLevelHeadingInFolderManagement(string LevelName)
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Click(folderManagement_Tab);
            seleniumActions.SwitchToFrame(iframe_MenuData);
            seleniumActions.Click(phd_SearchByFolder);
            seleniumActions.SendKeys(phd_SearchByFolder, LevelName);
            seleniumActions.Click(btnSearch_SearchByFolder);
            Assert.IsTrue(seleniumActions.IsElementPresent(By.XPath("(//a[@title='" + LevelName + "']//span)[2]")), "Searched level not found");
            seleniumActions.Wait(3);
            seleniumActions.Click(By.XPath("(//a[@title='" + LevelName + "']//span)[2]"));
            seleniumActions.SwitchToFrame(iframe_Tree);
            seleniumActions.Wait(2);
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_FolderManagementHeading), "level heading is not present");
            seleniumActions.SwitchToDefaultContent();
        }

        // ***************** FM - 03 : Level Create and Delete - End of TC 21854 ******************** //

        // *********** FM - 03 : Create and delete levels - Start of TC 04 ************ //

        /// <summary>
        /// Validate delete button should be disable in levels under folder management
        /// </summary>
        public void ValidateDeleteshouldbedisable(String LevelName)
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Click(folderManagement_Tab);
            seleniumActions.SwitchToFrame(iframe_MenuData);
            seleniumActions.Wait(2);
            seleniumActions.Click(phd_SearchByFolder);
            seleniumActions.SendKeys(phd_SearchByFolder, LevelName);
            seleniumActions.Click(btnSearch_SearchByFolder);
            Assert.IsTrue(seleniumActions.IsElementPresent(By.XPath("(//a[@title='" + LevelName + "']//span)[2]")), "Searched level not found");
            seleniumActions.Wait(3);
            seleniumActions.ContextClick(By.XPath("(//a[@title='" + LevelName + "']//span)[2]"));
            string button = seleniumActions.FindElement(btn_delete).GetAttribute("disabled");
            Assert.IsTrue(button.Equals("true"));
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** FM - 03 : Create and delete levels - end of TC 04 ************ //

        // *********** FM - 03 : Create and delete levels - Start of TC 05 ************ //

        /// <summary>
        /// Validate Edit the level by suite administrator
        /// </summary>
        public void ValidateEditTheLevel(String LevelName)
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
            seleniumActions.Click(btn_Edit);
            seleniumActions.SwitchToFrame(iframe_Tree);
            seleniumActions.Wait(3);
            string levelnameheading = seleniumActions.GetText(lbl_FolderManagementHeading);
            Assert.IsTrue(levelnameheading.Contains(LevelName), "Level heading is not display");
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** FM - 03 : Create and delete levels - end of TC 05 ************ //

        // *********** FM - 03 : Create and delete levels - Start of TC 06 ************ //

        /// <summary>
        /// Validate New option button should be disable in levels under folder management
        /// </summary>
        public void ValidateNewOptionshouldbedisable(String LevelName)
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
            string button = seleniumActions.FindElement(btn_New).GetAttribute("disabled");
            Assert.IsTrue(button.Equals("true"));
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** FM - 03 : Create and delete levels - end of TC 06 ************ //

        // *********** FM - 03 : Create and delete levels - Start of TC 21855 ************ //

        /// <summary>
        /// Validate Document Pro heading
        /// </summary>
        public void ValidateDocumentProHeading()
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Click(menu_DocumentManagement);
            seleniumActions.SwitchToIframes(iframe_MenuData, iframe_Tree);
            Assert.IsTrue(seleniumActions.GetText(lbl_FolderManagementDocumentProHeading).Equals("Document Pro"));
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** FM - 03 : Create and delete levels - end of TC 21855 ************ //

        // *********** FM - 03 : Create and delete levels - Start of TC 21870 ************ //

        /// <summary>
        /// Validate module levels are not displayed under Suite setup
        /// </summary>
        public void ValidateModuleLevelsAreNotDisplayed()
        {
            seleniumActions.Wait(5);
            seleniumActions.Click(lblSetup);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblSuiteSetup), "Suite setup is not present");
            seleniumActions.Click(lblSuiteSetup);
            Assert.IsFalse(seleniumActions.IsElementPresent(lnk_ModuleSideSubMenu), "Module element is present");
            seleniumActions.Wait(3);
        }

        // *********** FM - 03 : Create and delete levels - end of TC 21870 ************ //

        // *********** FM - 04 : Revision numbering- Start of TC 22978 ************ //

        /// <summary>
        /// Assign revision date option value
        /// </summary>
        public void AssignRevisionDateOption()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.Wait(2);
            seleniumActions.ScrollToPosition(0, 1000);
            Assert.IsTrue(seleniumActions.IsElementPresent(drp_RevDateOpt), "Dropdown Revision Date Option is not present");
            seleniumActions.Click(drp_RevDateOpt);
            seleniumActions.Click(inp_SearchForRevDateOpt);
            seleniumActions.SendKeys(inp_SearchForRevDateOpt, "User input date");
            seleniumActions.Click(btn_save);
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** FM - 04 : Revision numbering- End of TC 22978 ************ //

        // *********** FM - 04 : Revision numbering- Start of TC 22983 ************ //

        /// <summary>
        /// click records check box
        /// </summary>
        public void ClickRecordsCheckBox()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.Wait(2);
            seleniumActions.ScrollToPosition(0, 1000);
            Assert.IsTrue(seleniumActions.IsElementPresent(chk_Record), "Checkbox Records is not present");
            seleniumActions.Click(chk_Record);
            seleniumActions.Click(btn_save);
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** FM - 04 : Revision numbering- End of TC 22983 ************ //

        // *********** FM - 04 : Revision numbering- Start of TC 22980 ************ //

        /// <summary>
        /// Add level owner and validate the level owner is added
        /// </summary>
        public void AddlevelOwner()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.Wait(2);
            seleniumActions.ScrollToPosition(0, 1000);
            Assert.IsTrue(seleniumActions.IsElementPresent(svg_AddLevelOwner), "Add level owner option is not present");
            seleniumActions.Click(svg_AddLevelOwner);
            seleniumActions.Wait(2);
            seleniumActions.SwitchToFrame(iframe_ifrUsers);
            seleniumActions.SendKeys(hintSearch, "Thani-k");
            seleniumActions.Wait(3);
            seleniumActions.Click(chk_FirstUser);
            seleniumActions.SwitchToParentFrame();
            seleniumActions.ScrollToPosition(0, 1000);
            seleniumActions.Click(btn_UserDone);
            Assert.IsTrue(seleniumActions.GetText(lbl_AddedLevelOwnerName).Equals("Thani-k"));
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Remove level owner and validate the level owner is removed
        /// </summary>
        public void RemoveLevelOwner()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.Wait(2);
            seleniumActions.ScrollToPosition(0, 1000);
            Assert.IsTrue(seleniumActions.IsElementPresent(svg_RemoveLevelOwner), "Remove level owner option is not present");
            seleniumActions.Click(svg_RemoveLevelOwner);
            Assert.IsTrue(string.IsNullOrWhiteSpace(seleniumActions.GetText(lbl_AddedLevelOwnerName)), "It contains some text.");
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** FM - 04 : Revision numbering- End of TC 22980 ************ //

        // *********** FM - 04 : Create and delete levels - Start of TC 22974-75-76 ************ //

        /// <summary>
        /// Validate the user can define the revision option
        /// </summary>
        public void ValidateTheUserCanDefineTheRevisionOption()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.Wait(3);
            string revisionnumber = "Users define revision";
            string revisionValiue = seleniumActions.GetText(inpbox_Revopt);
            if (revisionValiue == revisionnumber)
            {
                seleniumActions.Click(btn_save);
            }
            else
            {
                seleniumActions.ScrollToPosition(0, 1000);
                seleniumActions.Click(ddp_Revopt);
                seleniumActions.SendKeys(inp_Revopt, "Users define revision");
                seleniumActions.Click(inp_docProautoincreby1);
            }
        }

        /// <summary>
        /// Validate the user can define the DocPro automatically increments by 1 option
        /// </summary>
        public void ValidateTheUserCanDefineTheDocumentNumber()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.Wait(3);
            string docproautomaticallyincrements = "DocPro automatically increments by 1";
            string docincrement = seleniumActions.GetText(inpbox_Revopt);
            if (docincrement == docproautomaticallyincrements)
            {
                seleniumActions.Click(btn_save);
            }
            else
            {
                seleniumActions.Click(ddp_Revopt);
                seleniumActions.SendKeys(inp_Revopt, "DocPro automatically increments by 1");
                seleniumActions.Click(inp_docProautoincreby1);
            }
        }

        // *********** FM - 04 : Create and delete levels - end of TC 22974-75-76 ************ //

        // *********** FM - 04 : Create and delete levels - Start of TC 22977 ************ //

        /// <summary>
        /// Validate revision option as Inherit from parent
        /// </summary>
        public void ValidaterevisionOptionasInheritFromParent(String LevelName)
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
            seleniumActions.Click(btn_NewEnable);
            seleniumActions.SwitchToFrame(iframe_Tree);
            seleniumActions.Wait(3);
            Assert.IsTrue(seleniumActions.IsElementPresent(chk_InheritFromParents), "Inherit from parents check box is not present");
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** FM - 04 : Create and delete levels - end of TC 22977 ************ //

        // *********** FM - 04 : Create and delete levels - Start of TC 22979 ************ //

        /// <summary>
        /// Validate revision date option as User input date
        /// </summary>
        public void ValidateRevisionDateOptionasUserInputDate()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.Wait(3);
            string docnumopt = "Last approval date";
            string lastappdate = seleniumActions.GetText(ddp_DateOpt);
            if (lastappdate == docnumopt)
            {
                seleniumActions.Click(btn_save);
            }
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** FM - 04 : Create and delete levels - end of TC 22979 ************ //

        // *********** FM - 04 : Revision numbering- Start of TC 22984 ************ //

        /// <summary>
        /// set the doc reviwed after as day
        /// </summary>
        public void SetDocumentReviewedAfterDropdownAsDay()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.Wait(2);
            seleniumActions.ScrollToPosition(0, 1000);
            Assert.IsTrue(seleniumActions.IsElementPresent(drp_DocumentReviewedAfter), "Document Reviewed After dropdown is not present");
            if (!seleniumActions.GetText(drp_DocumentReviewedAfter).Equals("Day"))
            {
                seleniumActions.Click(drp_DocumentReviewedAfter);
                Assert.IsTrue(seleniumActions.IsElementPresent(inp_SearchForRevDateOpt), "search option is not present");
                seleniumActions.Click(inp_SearchForRevDateOpt);
                seleniumActions.SendKeys(inp_SearchForRevDateOpt, "Day" + Keys.Enter);
            }
            Assert.IsTrue(seleniumActions.GetText(drp_DocumentReviewedAfter).Equals("Day"));
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// set revision value as 1
        /// </summary>
        public void SetRevisionValue()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.Wait(2);
            Assert.IsTrue(seleniumActions.IsElementPresent(inp_RevisionValue), "Revision value field is not present");
            seleniumActions.Click(inp_RevisionValue);
            seleniumActions.SendKeys(inp_RevisionValue, Keys.Clear);
            seleniumActions.SendKeys(inp_RevisionValue, "1");
            seleniumActions.Click(btn_save);
            seleniumActions.SwitchToDefaultContent();
        }

        public void ValidateRevisionValue()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            Assert.AreEqual(seleniumActions.GetAttributeValue(inp_RevisionValue, "value"), "1", "The value is not set as expected.");
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** FM - 04 : Revision numbering- End of TC 22984 ************ //

        // *********** FM - 04 : Create and delete levels - Start of TC-21857,61,63-67,69 ************ //

        /// <summary>
        /// Right click on the level and select new option
        /// </summary>
        /// <param name="LevelName"></param>
        public void RightClickAndSelectNewOptionOnLevel(string LevelName, string option)
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Click(folderManagement_Tab);
            seleniumActions.SwitchToFrame(iframe_MenuData);
            Assert.IsTrue(seleniumActions.IsElementPresent(By.XPath("(//a[@title='" + LevelName + "']//span)[2]")), "Searched level not found");
            seleniumActions.Wait(3);
            seleniumActions.ContextClick(By.XPath("(//a[@title='" + LevelName + "']//span)[2]"));
            seleniumActions.Click(By.XPath("(//li[@id='divNewFolder']//span[contains(text(),'" + option + "')])[1]"));
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Verifies the level heading 
        /// </summary>
        public void VerifyLevelHeading()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            Assert.IsTrue(seleniumActions.VerifyElementIsDisplayed(lblNewLevel), "Label new level is not present");
            Assert.IsTrue(seleniumActions.GetText(lblNewLevel).Equals("New Level"));
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Gives new sub level name and save the level
        /// </summary>
        public void GiveNewSubLevelNameAndClickSave()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.Click(txtSublevelName);
            seleniumActions.SendKeys(txtSublevelName, Constants.SubLevelName);
            seleniumActions.ScrollToPosition(0, 1000);
            seleniumActions.Click(btn_save);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Clicks the folder open arrow to open the sublevel
        /// </summary>
        public void ClickFolderArrowOpen()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData);
            seleniumActions.Wait(3);
            seleniumActions.Click(folder_OpenArrow);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Clicks the sublevel and verifies the level header
        /// </summary>
        public void ClickSubLevelAndVerifyLevelHeader()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblSublevelName), "Sub level is not found");
            seleniumActions.Click(lblSublevelName);
            seleniumActions.SwitchToFrame(iframe_Tree);
            Assert.IsTrue(seleniumActions.GetText(lbl_SubLevelHeader).Equals("Level - " + Constants.SubLevelName));
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Right click on sublevel and select edit option
        /// </summary>
        public void RightClickOnSubLevelAndSelectEditOption(string option)
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData);
            seleniumActions.ContextClick(lblSublevelName);
            seleniumActions.Click(By.XPath("(//span[contains(text(),'" + option + "')])[1]"));
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Right click on sublevel and select delete option
        /// </summary>
        public void RightClickOnSubLevelAndSelectDeleteOption(string option)
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData);
            seleniumActions.Click(lblSublevelName);
            seleniumActions.Wait(3);
            seleniumActions.ContextClick(lblSublevelName);
            seleniumActions.Click(By.XPath("(//span[contains(text(),'" + option + "')])[1]"));
            seleniumActions.Click(popUp_Yes);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblDeletedSuccessMessage), "lbl Deleted success msg is not showing");
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Gives updated sub level name and save the level
        /// </summary>
        public void GiveUpdatedSubLevelNameAndClickSave()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.Click(txtSublevelName);
            seleniumActions.SendKeys(txtSublevelName, Keys.Clear);
            seleniumActions.SendKeys(txtSublevelName, Constants.UpdatedSubLevelName);
            seleniumActions.ScrollToPosition(0, 1000);
            seleniumActions.Click(btn_save);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Clicks the folder open arrow and verify the sublevel is not found
        /// </summary>
        public void ClickFolderArrowOpenAndVerifySublevelIsNotFound()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData);
            Assert.IsFalse(seleniumActions.IsElementPresent(folder_OpenArrow, 5), "Folder open arrow is displaying");
            Assert.IsFalse(seleniumActions.IsElementPresent(lblSublevelName, 5), "Sub level is displaying");
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** FM - 04 : Create and delete levels - End of TC-21857,61,63-67,69 ************ //

        // *********** FM - 05 : Rights for level - Start of TC 21875 ************ //

        /// <summary>
        /// Clicks the Rights for Sites
        /// </summary>
        public void RightForSites(String LevelName)
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
            Assert.IsTrue(seleniumActions.IsElementPresent(drp_RightsForSites), "unable to find Rights for sites option");
            seleniumActions.Click(drp_RightsForSites);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// searches for rightSite in document rights page
        /// </summary>
        public void SearchForRightSiteInDocumentRights()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.Wait(2);
            seleniumActions.Click(inpSearch_RightsForGroup);
            seleniumActions.SendKeys(inpSearch_RightsForGroup, "RightSite");
            seleniumActions.Wait(2);
            Assert.IsTrue(seleniumActions.GetText(lbl_Rights).Equals("RightSite"));
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        ///  click doc management link 
        /// </summary>
        public void ClickDocumentManagementLink()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.Wait(2);
            seleniumActions.Click(img_plusIcon);
            Assert.IsTrue(seleniumActions.IsElementPresent(lnkClick_FullAccess), "document management link is not present");
            seleniumActions.Click(lnkClick_FullAccess);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        ///  Validate the manage site document heading
        /// </summary>
        public void ValidateTheManageSiteDocumentHeading(string LevelName)
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.Wait(2);
            Assert.IsTrue(seleniumActions.GetText(heading_ManageSiteDocument).Equals("Manage Site Document Access - " + LevelName));
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** FM - 05 : Rights for level - End of TC 21875 ************ //

        // *********** FM - 05 : Rights for level - Start of TC 21872 ************ //

        /// <summary>
        /// Validate the inherit option should not be selected by default
        /// </summary>
        public void ValidateInheritOptionShouldNotBeSelectedByDefault()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            Assert.IsTrue(seleniumActions.IsElementPresent(chk_DocumentCreation_Inherit), "Inherit checkbox is not visible");
            seleniumActions.FindElement(chk_DocumentCreation_Inherit).GetAttribute("disabled").Equals("disabled");
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** FM - 05 : Rights for level - End of TC 21872 ************ //

        // *********** FM - 05 : Rights for level - Start of TC 21873 ************ //

        /// <summary>
        /// Right click on sublevel and select rights for site option
        /// </summary>
        public void RightClickOnSubLevelAndSelectRightsForSiteOption(string option)
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData);
            seleniumActions.Click(lblSublevelName);
            seleniumActions.Wait(3);
            seleniumActions.ContextClick(lblSublevelName);
            seleniumActions.Click(By.XPath("(//span[contains(text(),'" + option + "')])[1]"));
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Validate the inherit option should be selected by default
        /// </summary>
        public void ValidateInheritOptionShouldBeSelectedByDefault()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            Assert.IsTrue(seleniumActions.IsElementPresent(chk_DocumentCreation_Inherit), "Inherit checkbox is not visible");
            seleniumActions.FindElement(chk_DocumentCreation_Inherit).GetAttribute("checked").Equals("checked");
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** FM - 05 : Rights for level - End of TC 21873 ************ //

        // *********** FM - 07 : Route - Start of TC 21877_78 ************ //

        /// <summary>
        /// validate the route link is not present
        /// </summary>
        public void ValidateRouteLinkIsNotPresent()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.ScrollToPosition(0, 1000);
            Assert.IsFalse(seleniumActions.VerifyElementIsDisplayed(lnk_InheritFromParent, 5), "Inherit parent link is visible");
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// validate the route link is present after making the level in use
        /// </summary>
        public void ValidateRouteLinkIsPresent()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.ScrollToPosition(0, 1000);
            Assert.IsTrue(seleniumActions.IsElementPresent(lnk_InheritFromParent), "Inherit parent link is not visible");
            Assert.IsTrue(seleniumActions.GetText(lnk_InheritFromParent).Equals("Inherit from parent"));
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** FM - 07 : Route - End of TC 21877_78 ************ //

        // *********** FM - 07 : Route - End of TC 21877_78 ************ //

        /// <summary>
        /// validate UI elements in route page
        /// </summary>
        public void ValidateUIElementsInRoutePage()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.Click(lnk_InheritFromParent);
            seleniumActions.Wait(4);
            seleniumActions.SwitchToIframes(iframe_Routes, iframe_Route);
            Assert.IsTrue(seleniumActions.FindElement(drp_NewRoute).GetAttribute("title").Contains("Inherit from parent"));
            Assert.IsTrue(seleniumActions.FindElement(drp_ExistingRoute).GetAttribute("title").Contains("Inherit from parent"));
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.Click(btn_Close_RoutePage);
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** FM - 07 : Route - End of TC 21877_78 ************ //

        // *********** FM - 09 : Tag Creation search - Start of TC 22986 ************ //

        /// <summary>
        /// Verify Tag selection link is present
        /// </summary>
        public void VerifyTagSelectionLinkIsPresent()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.Wait(2);
            seleniumActions.ScrollToPosition(0, 1000);
            Assert.IsTrue(seleniumActions.IsElementPresent(lnk_TagSelect, 5), "Tag selection link is not present");
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Clicks the Tag selection link
        /// </summary>
        public void ClickTagSelectionLink()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.Wait(2);
            seleniumActions.ScrollToPosition(0, 1000);
            seleniumActions.Click(lnk_TagSelect);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// search and selects the tagname
        /// </summary>
        public void SearchAndSelectTagName()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree, iframe_SelectTags);
            Assert.IsTrue(seleniumActions.IsElementPresent(btnMultiSearch));
            seleniumActions.Click(btnMultiSearch);
            seleniumActions.Wait(4);
            Assert.IsTrue(seleniumActions.IsElementPresent(drpColumn_MultiSearch));
            seleniumActions.Click(drpColumn_MultiSearch);
            seleniumActions.Click(ddl_TagName_MultiSearch);
            seleniumActions.Click(drpCondition_MultiSearch);
            seleniumActions.Click(ddlContains_MultiSearch);
            seleniumActions.Click(inp_MultiSearch);
            seleniumActions.SendKeys(inp_MultiSearch, Constants.Name);
            seleniumActions.Click(btnAdvancedSearch_MultiSearch);
            Assert.IsTrue(seleniumActions.GetText(lbl_TagSearchResult).Equals(Constants.Name));
            seleniumActions.Wait(3);
            seleniumActions.Click(chk_TagNameSelection);
            seleniumActions.Wait(2);
            seleniumActions.Click(btnDone_TagSelection);
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            Assert.IsTrue(seleniumActions.GetText(lnk_TagSelect).Equals(Constants.Name));
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** FM - 07 : Tag Creation search - End of TC 22986 ************ //

        // *********** FM - 05 : Rights for level - Start of TC 21876 ************ //

        /// <summary>
        /// click full access checkbox for document 
        /// </summary>
        public void ClickFullAccessCheckboxForDocument()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.Click(img_plusIcon);
            Assert.IsTrue(seleniumActions.IsElementPresent(chk_FullAccesForDocument), "full access checkbox is not present");
            seleniumActions.Click(chk_FullAccesForDocument);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// validate full access checkbox is clicked
        /// </summary>
        public void GetAttributeAndValidateFullAccessCheckBox()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.Wait(3);
            Assert.IsTrue(seleniumActions.FindElement(chk_FullAccesForDocument).GetAttribute("checked").Equals("true"));
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** FM - 05 : Rights for level - End of TC 21876 ************ //

        // *********** FM - 08 : Site PDF Preference - Start of TC 23015,16 ************ //

        /// <summary>
        ///  Disable enhanced printing checkbox to verify template dropdown is disabled
        /// </summary>
        public void DisableEnhancedPrintingCheckboxToVerifyTemplateDropdown()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            Assert.IsTrue(seleniumActions.FindElement(chk_EnabledEnhancedPrinting).GetAttribute("checked").Equals("true"));
            seleniumActions.Click(lbl_EnableEnhancedPrinting);
            seleniumActions.Wait(2);
            Assert.IsTrue(seleniumActions.FindElement(drp_Template).GetAttribute("disabled").Equals("true"));
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        ///  Enable enhanced printing checkbox to verify template dropdown is enabled
        /// </summary>
        public void EnableEnhancedPrintingCheckboxToVerifyTemplateDropdown()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Click(lbl_EnableEnhancedPrinting);
            seleniumActions.Wait(2);
            string state = seleniumActions.FindElement(drp_Template).GetAttribute("disabled");
            Assert.AreEqual(state, null);
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** FM - 08 : Site PDF Preference - End of TC 23015,16 ************ //

        // *********** FM - 08 : site PDF preference - Start of TC 23020 ************ //

        /// <summary>
        /// Click Include Template checkbox 
        /// </summary>
        public void ClickIncludeTemplateCheckBox()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_IncludeTemplate), "Include Template checkbox is not present");
            if (seleniumActions.FindElement(chk_IncludeTemplate).GetAttribute("checked") == null)
            {
                seleniumActions.Click(lbl_IncludeTemplate);
                seleniumActions.Click(btn_save);
            }
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Verify Include Template checkbox is checked
        /// </summary>
        public void ValidateIncludeTemplateCheckboxIsChecked()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Wait(3);
            Assert.IsTrue(seleniumActions.FindElement(chk_IncludeTemplate).GetAttribute("checked").Equals("true"));
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** FM - 08 : site PDF preference - End of TC 23020 ************ //

        // *********** FM - 08 : site PDF preference - Start of TC 23017,18 ************ //

        /// <summary>
        /// Click Enable Restricted View checkbox 
        /// </summary>
        public void ClickEnableRestrictedViewCheckBox()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Wait(2);
            Assert.IsTrue(seleniumActions.IsElementPresent(chk_EnableRestrickedView), "Enable Restricked View checkbox is not present");
            if (seleniumActions.FindElement(chk_EnableRestrickedView).GetAttribute("checked") == null)
            {
                seleniumActions.Wait(2);
                seleniumActions.Click(lbl_EnableRestrickedView);
                seleniumActions.Click(btn_save);
            }
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Verify Enable Restricted View checkbox is checked
        /// </summary>
        public void ValidateEnableRestrictedViewCheckboxIsChecked()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Wait(3);
            Assert.IsTrue(seleniumActions.FindElement(chk_IncludeTemplate).GetAttribute("checked").Equals("true"));
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** FM - 08 : site PDF preference - End of TC 23017,18 ************ //

        // *********** FM - 08 : site PDF preference - Start of TC 23023-25 ************ //

        /// <summary>
        /// Clicks the multi search button
        /// </summary>
        public void ClickMultiSearchButton()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.WaitForElementToExists(btnMultiSearch);
            seleniumActions.Click(btnMultiSearch);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Validate UI elements of multi search window
        /// </summary>
        public void ValidateMultiSearchWindow()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblSearch_MultiSearch), "search title is not found");
            Assert.IsTrue(seleniumActions.GetText(lblSearch_MultiSearch).Equals("Search (1)"));
            seleniumActions.Click(btnRefresh_MultiSearch);
            Assert.IsTrue(seleniumActions.GetText(lblSearch_MultiSearch).Equals("Search"));
            Assert.IsTrue(seleniumActions.IsElementPresent(btnAdd_MultiSearch), "Add button is not found");
            seleniumActions.Click(btnAdd_MultiSearch);
            seleniumActions.Wait(2);
            seleniumActions.Click(btnAdd_MultiSearch);
            Assert.IsTrue(seleniumActions.GetText(lblSearch_MultiSearch).Equals("Search (2)"));
            seleniumActions.Click(btnRemove_MultiSearch);
            seleniumActions.Wait(2);
            Assert.IsTrue(seleniumActions.GetText(lblSearch_MultiSearch).Equals("Search (1)"));
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// searches the record with doctype and verifies the record size
        /// </summary>
        public void SearchWithDocTypeAndVerifyRecordSize()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Click(drpColumn_MultiSearch);
            seleniumActions.Click(ddl_DocType);
            seleniumActions.Click(drpCondition_MultiSearch);
            seleniumActions.Click(ddlContains_MultiSearch);
            seleniumActions.Click(inp_MultiSearch);
            seleniumActions.SendKeys(inp_MultiSearch, Constants.DocTypeProject);
            seleniumActions.Click(btnAdvancedSearch_MultiSearch);
            seleniumActions.Wait(3);
            IList<IWebElement> rowCount = seleniumActions.FindElements(tblRow);
            int rowSize = rowCount.Count;
            Assert.AreEqual(rowSize, 1);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Clicks the refresh button in Site PDF Preference page
        /// </summary>
        public void ClickRefreshButtonInSitePDFPage()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Click(btnRefresh_PDF);
            seleniumActions.Wait(2);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Verifies all the records are showing after refreshing the page
        /// </summary>
        public void VerifyRecordSizeAfterRefresh()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            IList<IWebElement> rowCount = seleniumActions.FindElements(tblRow);
            int rowSize = rowCount.Count;
            Assert.AreNotEqual(rowSize, 1);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// searches a record with doctype and updates the record
        /// </summary>
        public void SearchDocTypeAndUpdateTheRecord()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Wait(2);
            seleniumActions.SendKeys(inp_MultiSearch, Keys.Clear);
            seleniumActions.SendKeys(inp_MultiSearch, Constants.DocTypeDynamic);
            seleniumActions.Click(btnAdvancedSearch_MultiSearch);
            seleniumActions.Wait(2);
            IList<IWebElement> rowCount = seleniumActions.FindElements(tblRow);
            int rowSize = rowCount.Count;
            Assert.AreEqual(rowSize, 1);
            seleniumActions.Click(chk_SearchResultSitePDF);
            seleniumActions.Click(btnUpdate_PDF);
            seleniumActions.Click(btn_save);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblSuccessMessage), "Success message is not showing");
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** FM - 08 : site PDF preference - End of TC 23023-25 ************ //

        // *********** FM - 02 : level PDF preference - Start of TC 22999 ************ //

        /// <summary>
        /// Verify level PDF preferences link and clicking it
        /// </summary>
        public void VerifyLevelPDFPreferencesLinkAndClickIt()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.Wait(2);
            seleniumActions.ScrollToPosition(0, 1000);
            seleniumActions.Wait(2);
            Assert.IsTrue(seleniumActions.IsElementPresent(lnk_LevelPdfPreference), "level pdf link is not present");
            seleniumActions.Click(lnk_LevelPdfPreference);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Validate level pdf preferences page heading
        /// </summary>
        public void ValidateLevelPDFPreferencesPageHeading()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.Wait(3);
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_LevelPdfPreferencesPageHeading));
            seleniumActions.Wait(2);
            Assert.IsTrue(seleniumActions.GetText(lbl_LevelPdfPreferencesPageHeading).Equals("Level PDF Preferences"));
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Validate level pdf preferences page UI elements
        /// </summary>
        public void ValidateUIElementsInLevelPDFPreferencesPage()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree, iframe_water);
            seleniumActions.Wait(3);
            Assert.IsTrue(seleniumActions.IsElementPresent(drp_TemplateInLevelPDFPreferencesPage), "Template dropdown is not present");
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_RestrictedView), "Enable Restricted View checkbox is not present");
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_IncludeTemplate), "Include Template is not present");
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_EnableEnhancedPrinting), "Enable Enhancing Printing checkbox is not present");
            Assert.IsTrue(seleniumActions.IsElementPresent(btn_LevelPDFRestart), "Restart button is not present");
            Assert.IsTrue(seleniumActions.IsElementPresent(btn_LevelPDFSave), "level PDF preferences page save button is not present");
            Assert.IsTrue(seleniumActions.IsElementPresent(btn_LevelPDFUseSiteDefault), "Use Site Default button is not present");
            Assert.IsTrue(seleniumActions.IsElementPresent(btn_LevelApplyThisToAllSubLevels), "Apply this to all sub levels button is not present");
            Assert.IsTrue(seleniumActions.IsElementPresent(btn_LevelPDFShowSamplePDF), "Show Sample PDF button is not present");
            Assert.IsTrue(seleniumActions.IsElementPresent(drp_LevelPDFSearch), "search is not present in Level PDF Preferences page");
            seleniumActions.Wait(2);
            string dropdownText = seleniumActions.GetText(drp_LevelPDFSearch);
            Assert.IsTrue(dropdownText.Contains("Modules"), "'Modules' option is missing in the search dropdown.");
            Assert.IsTrue(dropdownText.Contains("Document Type"), "'Document Type' option is missing in the search dropdown.");
            Assert.IsTrue(seleniumActions.IsElementPresent(pagination_LevelPDFPagination), "pagination is not presnt in Level PDF Preferences page");
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** FM - 02 : level PDF preference - End of TC 22999 ************ //

        // *********** Smoke Cases - Start of TC 04 ************ //

        /// <summary>
        /// edits the dropdowns in folder management page for a level
        /// </summary>
        public void EditDropdownsInFolderManagement()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.ScrollToPosition(0, 800);
            seleniumActions.Click(drp_DocumentReviewedAfter);
            seleniumActions.Click(ddl_Month);
            seleniumActions.Click(inp_DocReviewedAfter);
            seleniumActions.SendKeys(inp_DocReviewedAfter, Keys.Clear);
            seleniumActions.SendKeys(inp_DocReviewedAfter, "2");
            Assert.IsTrue(seleniumActions.GetText(lbl_RevOptValue).Equals("DocPro automatically increments by 1"));
            Assert.IsTrue(seleniumActions.GetText(lbl_DocNumOptValue).Equals("User Defined Document Number"));
            Assert.IsTrue(seleniumActions.GetText(lbl_RevDateOptValue).Equals("Last approval date"));
            seleniumActions.Click(btn_save);
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** Smoke Cases - End of TC 04 ************ //

        // *********** FM - 10 : Suite Levels - Start of TC 01 - DOC-1400-10-20 ************ //

        /// <summary>
        /// Validates the docpro landing screen after clickking the level
        /// </summary>
        public void ValidateDocProLandingScreen()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_DocumentPro));
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_KeyFeatures));
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** FM - 10 : Suite Levels - End of TC 01 - DOC-1400-10-20 ************ //

        // *********** FM - 10 : Suite Levels - Start of TC 02 - DOC-1400-10-30 ************ //

        /// <summary>
        /// Validates the level color is in gray before making it in use
        /// </summary>
        public void ValidateLevelColorBeforeInUse()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData);
            string levelColor = seleniumActions.FindElement(lbl_LevelNameInFM).GetCssValue("color");
            Assert.AreNotEqual(levelColor, Constants.BlackColor);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Validates the level color is in black before making it in use
        /// </summary>
        public void ValidateLevelColorAfterInUse()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData);
            seleniumActions.ScrollToPosition(1000, 0);
            seleniumActions.Click(btnSearch_SearchByFolder);
            string levelColor = seleniumActions.FindElement(lbl_LevelNameInFM).GetCssValue("color");
            Assert.AreEqual(levelColor, Constants.BlackColor);
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** FM - 10 : Suite Levels - End of TC 02 - DOC-1400-10-30 ************ //

        // *********** FM - 10 : Suite Levels - End of TC 02 - DOC-1400-10-30 ************ //

        /// <summary>
        /// validates only edit option is enabled without making the level in use
        /// </summary>
        public void ValidateEditOptionIsEnabledBeforeLevelInuse()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData);
            seleniumActions.Click(lbl_LevelNameInFM);
            seleniumActions.ContextClick(lbl_LevelNameInFM);
            Assert.IsTrue(seleniumActions.IsElementPresent(ddl_RightForSite_Disabled), "right for site drpdown is enabled");
            Assert.IsTrue(seleniumActions.IsElementPresent(ddl_RightForGroups_Disabled), "right for grps drpdown is enabled");
            Assert.IsTrue(seleniumActions.IsElementPresent(ddl_RightForUsers_Disabled), "right for users drpdown is enabled");
            Assert.IsTrue(seleniumActions.IsElementPresent(ddl_New_Disabled), "New folder drpdown is enabled");
            Assert.IsTrue(seleniumActions.IsElementPresent(ddl_Delete_Disabled), "Delete folder drpdown is enabled");
            Assert.IsTrue(seleniumActions.IsElementPresent(ddl_Edit_Enabled), "Edit folder drpdown is disabled");
            seleniumActions.Wait(2);
            seleniumActions.Click(ddl_Edit_Enabled);
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            seleniumActions.ScrollToPosition(0, 1000);
            Assert.IsTrue(seleniumActions.IsElementPresent(chk_InUse), "In use checkbox is not present");
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** FM - 10 : Suite Levels - End of TC 02 - DOC-1400-10-30 ************ //

        // *********** FM - 10 : Suite Levels - TC02 - DOC-FM-100-020 ************ //
        /// <summary>
        /// validates only edit option is enabled without making the level in use
        /// </summary>
        public void ValidateEditNewOptionIsEnabledBeforeLevelInuse()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData);
            seleniumActions.Click(lbl_LevelNameInFM);
            seleniumActions.ContextClick(lbl_LevelNameInFM);
            Assert.IsTrue(seleniumActions.IsElementPresent(ddl_RightForSite_Disabled), "right for site drpdown is enabled");
            Assert.IsTrue(seleniumActions.IsElementPresent(ddl_RightForGroups_Disabled), "right for grps drpdown is enabled");
            Assert.IsTrue(seleniumActions.IsElementPresent(ddl_RightForUsers_Disabled), "right for users drpdown is enabled");
            Assert.IsTrue(seleniumActions.IsElementPresent(ddl_New_Enabled), "New folder drpdown is disabled");
            Assert.IsTrue(seleniumActions.IsElementPresent(ddl_Delete_Disabled), "Delete folder drpdown is enabled");
            Assert.IsTrue(seleniumActions.IsElementPresent(ddl_Edit_Enabled), "Edit folder drpdown is disabled");
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** FM - 10 : Suite Levels - End of TC02 - DOC-FM-100-020 ************ //

        // *********** FM - 10 : Suite Levels - Start of TC 01 - DOC-FM-100-010************ //

        /// <summary>
        /// Validates the docpro landing screen after clickking the level
        /// </summary>

        public void ValidateLevelRightClicksOPtion(String levelName)
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Click(folderManagement_Tab);
            seleniumActions.SwitchToFrame(iframe_MenuData);
            seleniumActions.Click(phd_SearchByFolder);
            seleniumActions.SendKeys(phd_SearchByFolder, levelName);
            seleniumActions.Click(btnSearch_SearchByFolder);
            Assert.IsTrue(seleniumActions.IsElementPresent(By.XPath("(//a[@title='" + levelName + "']//span)[2]")), "Searched level not found");
            seleniumActions.Wait(3);
            string levelColor = seleniumActions.FindElement(lbl_levelName).GetCssValue("background-color");
            Assert.IsTrue(levelColor.Equals(Constants.LevelWithoutInuseColor));
            seleniumActions.Wait(3);
            seleniumActions.ContextClick(By.XPath("(//a[@title='" + levelName + "']//span)[2]"));
            Assert.IsTrue(seleniumActions.FindElement(btn_delete).GetAttribute("disabled").Equals("true"));
            Assert.IsTrue(seleniumActions.FindElement(drp_RightsForSites).GetAttribute("disabled").Equals("true"));
            Assert.IsTrue(seleniumActions.FindElement(drp_RightsForGroup).GetAttribute("disabled").Equals("true"));
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** FM - 10 : Suite Levels - End of TC 01 - DOC-FM-100-010************ //

        // *********** FM - 10 : Suite Levels - Start of TC 01 - DOC-FM-100-010************ //

        /// <summary>
        /// Validates the docpro landing screen after clickking the level
        /// </summary>

        public void RightClickNewAndCreateSubLevel(String levelName, string subFolderName)
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Click(folderManagement_Tab);
            seleniumActions.SwitchToFrame(iframe_MenuData);
            seleniumActions.Click(phd_SearchByFolder);
            seleniumActions.SendKeys(phd_SearchByFolder, levelName);
            seleniumActions.Click(btnSearch_SearchByFolder);
            Assert.IsTrue(seleniumActions.IsElementPresent(By.XPath("(//a[@title='" + levelName + "']//span)[2]")), "Searched level not found");
            seleniumActions.Wait(3);
            seleniumActions.ContextClick(By.XPath("(//a[@title='" + levelName + "']//span)[2]"));
            Assert.IsTrue(seleniumActions.IsElementPresent(ddl_New_Enabled), "unable to find New option");
            seleniumActions.Click(btn_NewEnable);
            seleniumActions.Wait(3);
            seleniumActions.SwitchToFrame(iframe_Tree);
            seleniumActions.SendKeys(inp_Levelname, subFolderName);
            seleniumActions.Click(btn_save);
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** FM - 10 : Suite Levels - End of TC 01 - DOC-FM-100-010************ //

        // *********** FM - 10 : Suite Levels - TC02 - DOC-FM-100-020 ************ //
        /// <summary>
        /// validates only edit option is enabled without making the level in use
        /// </summary>
        public void ValidateNewDeleteOptionIsDisabledAfterLevelInuse()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData);
            seleniumActions.Click(lbl_LevelNameInFM);
            seleniumActions.ContextClick(lbl_LevelNameInFM);
            Assert.IsTrue(seleniumActions.IsElementPresent(ddl_RightForSite_Enabled), "right for site drpdown is disabled");
            Assert.IsTrue(seleniumActions.IsElementPresent(ddl_RightForGroups_Enabled), "right for grps drpdown is disabled");
            Assert.IsTrue(seleniumActions.IsElementPresent(ddl_RightForUsers_Enabled), "right for users drpdown is disabled");
            Assert.IsTrue(seleniumActions.IsElementPresent(ddl_New_Enabled), "New folder drpdown is Enabled");
            Assert.IsTrue(seleniumActions.IsElementPresent(ddl_Delete_Enable), "Delete folder drpdown is enabled");
            Assert.IsTrue(seleniumActions.IsElementPresent(ddl_Edit_Enabled), "Edit folder drpdown is disabled");
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** FM - 10 : Suite Levels - End of TC02 - DOC-FM-100-020 ************ //

        // *********** FM - 10 : Suite Levels - Edit level before and after In use ************ //

        /// <summary>
        /// Clicks folder management ,  searches the edited level 
        /// </summary>
        public void SearchAndClickEditedLevelInFolderManagement(string editedLevelName)
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Click(folderManagement_Tab);
            seleniumActions.SwitchToFrame(iframe_MenuData);
            seleniumActions.Click(phd_SearchByFolder);
            seleniumActions.SendKeys(phd_SearchByFolder, editedLevelName);
            seleniumActions.Click(btnSearch_SearchByFolder);
            Assert.IsTrue(seleniumActions.IsElementPresent(By.XPath("(//a[@title='" + editedLevelName + "']//span)[2]")), "Searched level not found");
            seleniumActions.Wait(3);
            seleniumActions.Click(By.XPath("(//a[@title='" + editedLevelName + "']//span)[2]"));
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Use this method to Edit the already edited level
        /// </summary>
        /// <param name="editedLevelName"></param>
        /// <returns></returns>
        public String EditLevelAfterInUse(String editedLevelName)
        {
            string reEditedLevel = Constants.EditLevelAfterInuse + utility.CurrentTime();
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Click(btn_refreshLevel);
            seleniumActions.MoveToElement(By.XPath("//table[@class='Tbltitle']//ul[@id='TOCDoclvl']//a[contains(@title,'" + editedLevelName + "')]"));
            seleniumActions.Click(By.XPath("(//table[@class='Tbltitle']//ul[@id='TOCDoclvl']//a[contains(@title,'" + editedLevelName + "')]//following::*[local-name()='svg' and contains(@class,'pencil')])[1]"));
            seleniumActions.SwitchToIframes(iframe_Tree);
            seleniumActions.SendKeys(inp_Levelname, reEditedLevel);
            seleniumActions.Click(btn_save);
            string levelHeader = "Level - " + Constants.EditLevelAfterInuse;
            seleniumActions.IsElementPresent(By.XPath("//h5[contains(text(),'" + levelHeader + "')]"));
            seleniumActions.SwitchToDefaultContent();
            return reEditedLevel;
        }

        /// <summary>
        /// Clicks folder management ,  searches the Re edited level 
        /// </summary>
        public void SearchAndClickReEditedLevelInFolderManagement(string ReEditedLevelName)
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Click(folderManagement_Tab);
            seleniumActions.SwitchToFrame(iframe_MenuData);
            seleniumActions.Click(phd_SearchByFolder);
            seleniumActions.SendKeys(phd_SearchByFolder, ReEditedLevelName);
            seleniumActions.Click(btnSearch_SearchByFolder);
            Assert.IsTrue(seleniumActions.IsElementPresent(By.XPath("(//a[@title='" + ReEditedLevelName + "']//span)[2]")), "Searched level not found");
            seleniumActions.Wait(3);
            seleniumActions.Click(By.XPath("(//a[@title='" + ReEditedLevelName + "']//span)[2]"));
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Deletes the level by hovering on the Re edited level
        /// </summary>
        /// <param name="ReEditedLevelName"></param>
        public void DeleteReEditedLevelByHovering(String ReEditedLevelName)
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Click(btn_refreshLevel);
            seleniumActions.MoveToElement(By.XPath("//table[@class='Tbltitle']//ul[@id='TOCDoclvl']//a[contains(@title,'" + ReEditedLevelName + "')]"));
            seleniumActions.Click(By.XPath("(//table[@class='Tbltitle']//ul[@id='TOCDoclvl']//a[contains(@title,'" + ReEditedLevelName + "')]//following::*[local-name()='svg' and contains(@class,'trash')])[1]"));
            seleniumActions.Click(popUp_Yes);
        }

        // *********** FM - 10 : Suite Levels - Edit level before and after In use ************ //

        // *********** Satrt of EwQIMS_10814_Click on select hyperlink -************ //

        /// <summary>
        /// Use this method to navigate and click edit icon on level
        /// </summary>
        /// <param name="LevelName"></param>
        /// <returns></returns>
        public void NavigateAndClickEditIconForLevels(String LevelName)
        {
            string editedLevel = Constants.Level + "-" + utility.CurrentTime();
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Click(btn_refreshLevel);
            seleniumActions.MoveToElement(By.XPath("//table[@class='Tbltitle']//ul[@id='TOCDoclvl']//a[contains(@title,'" + LevelName + "')]"));
            seleniumActions.Click(By.XPath("(//table[@class='Tbltitle']//ul[@id='TOCDoclvl']//a[contains(@title,'" + LevelName + "')]//following::*[local-name()='svg' and contains(@class,'pencil')])[1]"));
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Verify Tag selection link is present in levels page
        /// </summary>
        public void VerifyTagSelectionLinkIsPresentInLevelsPage()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Tree);
            seleniumActions.Wait(2);
            seleniumActions.ScrollToPosition(0, 1000);
            Assert.IsTrue(seleniumActions.IsElementPresent(lnk_TagSelect, 5), "Tag selection link is not present");
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Clicks the Tag selection link n levels page
        /// </summary>
        public void ClickTagSelectionLinkInLevelsPage()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Tree);
            seleniumActions.Wait(2);
            seleniumActions.ScrollToPosition(0, 1000);
            seleniumActions.Click(lnk_TagSelect);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// search and selects the tagname in levels page
        /// </summary>
        public void SearchAndSelectTagNameInLevelsPage()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Tree, iframe_SelectTags);
            Assert.IsTrue(seleniumActions.IsElementPresent(btnMultiSearch));
            seleniumActions.Click(btnMultiSearch);
            seleniumActions.Wait(4);
            Assert.IsTrue(seleniumActions.IsElementPresent(drpColumn_MultiSearch));
            seleniumActions.Click(drpColumn_MultiSearch);
            seleniumActions.Click(ddl_TagName_MultiSearch);
            seleniumActions.Click(drpCondition_MultiSearch);
            seleniumActions.Click(ddlContains_MultiSearch);
            seleniumActions.Click(inp_MultiSearch);
            seleniumActions.SendKeys(inp_MultiSearch, Constants.Name);
            seleniumActions.Click(btnAdvancedSearch_MultiSearch);
            seleniumActions.Wait(2);
            Assert.IsTrue(seleniumActions.GetText(lbl_TagSearchResult).Equals(Constants.Name));
            seleniumActions.Wait(3);
            seleniumActions.Click(chk_TagNameSelection);
            seleniumActions.Wait(2);
            seleniumActions.Click(btnDone_TagSelection);
            seleniumActions.SwitchToParentFrame();
            seleniumActions.Wait(2);
            seleniumActions.Click(btn_save);
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.Wait(2);
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Tree);
            Assert.IsTrue(seleniumActions.GetText(lnk_TagSelect).Equals(Constants.Name));
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** End of EwQIMS_10814_Click on select hyperlink -************ //

        // *********** Satrt of EwQIMS_10820_Display selected Tags in Folder Management -************ //

        /// <summary>
        /// set the doc reviwed after as month in levels page
        /// </summary>
        public void SetDocumentReviewedAfterDropdownAsMonthInLevelsPage()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Tree);
            seleniumActions.Wait(2);
            seleniumActions.ScrollToPosition(0, 1000);
            Assert.IsTrue(seleniumActions.IsElementPresent(drp_DocumentsReviewdAfterInLevelsPage), "Document Reviewed After dropdown is not present");
            if (!seleniumActions.GetText(drp_DocumentsReviewdAfterInLevelsPage).Equals("Month"))
            {
                seleniumActions.Click(drp_DocumentsReviewdAfterInLevelsPage);
                Assert.IsTrue(seleniumActions.IsElementPresent(inp_SearchForDocumentsReviewdAfterInLevelsPage), "search option is not present");
                seleniumActions.Click(inp_SearchForDocumentsReviewdAfterInLevelsPage);
                seleniumActions.SendKeys(inp_SearchForDocumentsReviewdAfterInLevelsPage, "Month" + Keys.Enter);
            }
            Assert.IsTrue(seleniumActions.GetText(drp_DocumentsReviewdAfterInLevelsPage).Equals("Month"));
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// verify the tag selection is present in the folder management
        /// </summary>
        public void VerifyTagSelectionLinkIsPresentInFolderManagement()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            Assert.IsTrue(seleniumActions.IsElementPresent(lnk_TagSelect), "tag selection is not present");
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** End of EwQIMS_10820_Display selected Tags in Folder Management -************ //

        // *********** Start of EwQIMS_10809_Validate whether the selected Tag can be edited   -************ //

        /// <summary>
        /// this method used to click and uncheck the selected tag in levels page
        /// </summary>
        public void ClickAndUncheckTheSelectedTagInLevelsPage()
        {
            ClickTagSelectionLinkInLevelsPage();
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Tree, iframe_SelectTags);
            Assert.IsTrue(seleniumActions.IsElementPresent(btnMultiSearch));
            seleniumActions.Click(btnMultiSearch);
            seleniumActions.Wait(4);
            Assert.IsTrue(seleniumActions.IsElementPresent(drpColumn_MultiSearch));
            seleniumActions.Click(drpColumn_MultiSearch);
            seleniumActions.Click(ddl_TagName_MultiSearch);
            seleniumActions.Click(drpCondition_MultiSearch);
            seleniumActions.Click(ddlContains_MultiSearch);
            seleniumActions.Click(inp_MultiSearch);
            seleniumActions.SendKeys(inp_MultiSearch, Constants.Name);
            seleniumActions.Click(btnAdvancedSearch_MultiSearch);
            seleniumActions.Wait(2);
            Assert.IsTrue(seleniumActions.GetText(lbl_TagSearchResult).Equals(Constants.Name));
            seleniumActions.Wait(3);
            seleniumActions.Click(chk_TagNameSelection);
            seleniumActions.Wait(2);
            seleniumActions.Click(btnDone_TagSelection);
            seleniumActions.SwitchToParentFrame();
            seleniumActions.Wait(2);
            seleniumActions.Click(btn_save);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// this method used to search and select any other tag in levels page
        /// </summary>
        public void SearchAndSelectOtherTagNameInLevelsPage()
        {
            ClickTagSelectionLinkInLevelsPage();
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Tree, iframe_SelectTags);
            Assert.IsTrue(seleniumActions.IsElementPresent(btnMultiSearch));
            seleniumActions.Click(btnMultiSearch);
            seleniumActions.Wait(4);
            Assert.IsTrue(seleniumActions.IsElementPresent(drpColumn_MultiSearch));
            seleniumActions.Click(drpColumn_MultiSearch);
            seleniumActions.Click(ddl_TagName_MultiSearch);
            seleniumActions.Click(drpCondition_MultiSearch);
            seleniumActions.Click(ddlContains_MultiSearch);
            seleniumActions.Click(inp_MultiSearch);
            seleniumActions.SendKeys(inp_MultiSearch, Constants.TagName);
            seleniumActions.Click(btnAdvancedSearch_MultiSearch);
            seleniumActions.Wait(2);
            Assert.IsTrue(seleniumActions.GetText(lbl_TagSearchResult).Equals(Constants.TagName));
            seleniumActions.Wait(3);
            seleniumActions.Click(chk_TagNameSelection);
            seleniumActions.Wait(2);
            seleniumActions.Click(btnDone_TagSelection);
            seleniumActions.SwitchToParentFrame();
            seleniumActions.Click(btn_save);
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Tree);
            Assert.IsTrue(seleniumActions.GetText(lnk_TagSelect).Equals(Constants.TagName));
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** End of EwQIMS_10809_Validate whether the selected Tag can be edited   -************ //

        // *********** Start of EwQIMS-430_Validate the user can enable allow site modification   -************ //

        /// <summary>
        /// this method used to verify the site modification checkbox is checked
        /// </summary>
        public void VerifyAllowSiteModificationCheckboxIsChecked()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Tree);
            Assert.IsTrue(seleniumActions.IsElementPresent(chk_AllowSiteModificationIsChecked), "The checkbox is not checked");
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** End of EwQIMS-430_Validate the user can enable allow site modification   -************ //

        // *********** Start of EwQIMS-431_Validate the user can disable allow site modification   -************ //

        /// <summary>
        /// this method used to uncheck the Allow Site Modification and verify the checkbox is disabled
        /// </summary>
        public void UncheckAllowSiteModificationCheckboxAndVerifyTheCheckboxIsUnchecked()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Tree);
            seleniumActions.Click(chk_SiteModification);
            seleniumActions.Click(chk_SiteSubLevel);
            seleniumActions.Click(btn_save);
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.Wait(2);
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Tree);
            Assert.IsFalse(seleniumActions.IsElementPresent(chk_AllowSiteModificationIsChecked), "The checkbox is checked");
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** EwQIMS-431_Validate the user can disable allow site modification   -************ //

        // *********** Start of EwQIMS-47452 Validate special characters in level name and Prefix   -************ //

        /// <summary>
        /// this method used to test special character acceptance in prefix field
        /// </summary>
        public void TestSpecialCharacterAcceptanceInPrefixField()
        {
            string specialCharacters = "!@#$%^&*";
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Tree);
            seleniumActions.Click(btn_Prefix);
            seleniumActions.SendKeys(btn_Prefix, specialCharacters);
            string enteredValue = seleniumActions.GetAttributeValue(btn_Prefix, "value");
            Assert.AreEqual(specialCharacters, enteredValue, "The Prefix field does not accept special characters as expected.");
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** End of EwQIMS-47452 Validate special characters in level name and Prefix   -************ //

        // ***********  Start of EwQIMS-47491_validate whether the system accepts the space as a character to create Level name ************ //

        /// <summary>
        /// Validates the level name cannot accept empty space
        /// </summary>
        public void ValidateLevelNameCannotBeEmpty()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Tree);
            seleniumActions.Click(btn_save);
            seleniumActions.VerifyElementIsDisplayed(lbl_Alert_LevelNameNumberCannotBeEmpty);
            seleniumActions.SwitchToDefaultContent();
        }

        // ***********  End of EwQIMS-47491_validate whether the system accepts the space as a character to create Level name ************ //

        // ***********  Start of EwQIMS-47494_To validate whether the system accepts the all special characters to create in the level name ************ //

        /// <summary>
        /// this method used to test special character acceptance in level name field
        /// </summary>
        public string ValidateLevelNameAcceptsSpecialCharacter()
        {
            string specialCharacters = Constants.SpecialCharacters;
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Tree);
            seleniumActions.SendKeys(inp_Levelname, specialCharacters);
            seleniumActions.Click(btn_save);
            seleniumActions.SwitchToDefaultContent();
            return specialCharacters;
        }

        // ***********  End of EwQIMS-47494_To validate whether the system accepts the all special characters to create in the level name ************ //

        // ***********  Start of EwQIMS-15739_To validate whether the system accepts the user can enter alphabet (Upper and Lower) in Level Name/Prefix field ************ //

        /// <summary>
        /// Use this method to test upper and lower character acceptance in level name and prefix field
        /// </summary>
        public String ValidateLevelNameAndPrefixFieldAcceptsUpperAndLowercase()
        {
            string input = "aa Automation-" + utility.CurrentTime();
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Tree);
            seleniumActions.SendKeys(inp_Levelname, input);
            seleniumActions.Click(inpLevelNumber);
            seleniumActions.Click(popUp_Yes);
            seleniumActions.SendKeys(inpLevelNumber, utility.CurrentTime());
            seleniumActions.Click(btn_Prefix);
            seleniumActions.SendKeys(btn_Prefix, input);
            seleniumActions.Click(btn_save);
            seleniumActions.SwitchToDefaultContent();
            return input;
        }

        // ***********  End of EwQIMS-15739_To validate whether the system accepts the user can enter alphabet (Upper and Lower) in Level Name/Prefix field ************ //

        // *********** Start of  EwQIMS-439_Delete validation with dependency   -************ //

        /// <summary>
        /// this method used to test special character acceptance in prefix field
        /// </summary>
        public void VerifyDependencyAlertMessageWhileDeleteLevel()
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_alertLevelDependencyMessage), "This error is not displayed");
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** End of  EwQIMS-439_Delete validation with dependency   -************ //

        // ***********  Start of EwQIMS-10805_Validate Level Number as Blank Space ************ //

        /// <summary>
        /// Validates the level number cannot accept empty space
        /// </summary>
        public void ValidateLevelNumberCannotBeEmpty()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Tree);
            seleniumActions.SendKeys(inp_Levelname, "sample");
            seleniumActions.Click(inpLevelNumber);
            seleniumActions.Click(popUp_Yes);
            seleniumActions.SendKeys(inpLevelNumber, Keys.Clear);
            seleniumActions.Click(btn_save);
            Assert.IsTrue(seleniumActions.VerifyElementIsDisplayed(lbl_Alert_LevelNameNumberCannotBeEmpty));
            seleniumActions.SwitchToDefaultContent();
        }

        // ***********  End of EwQIMS-10805_Validate Level Number as Blank Space ************ //

        // ***********  Start of EwQIMS-15728_Validate Prefix with Special characters ************ //

        /// <summary>
        /// this method used to test special character acceptance in prefix field
        /// </summary>
        public string ValidatePrefixFieldAcceptsSpecialCharacter()
        {
            string prefixWithSpclChrtrLevel = Constants.PrefixwithSpclChrtrLevel + utility.CurrentTime();
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Tree);
            seleniumActions.SendKeys(inp_Levelname, prefixWithSpclChrtrLevel);
            seleniumActions.Click(btn_Prefix);
            seleniumActions.SendKeys(btn_Prefix, Constants.PrefixFieldSpclChrtrInput);
            seleniumActions.Click(btn_save);
            seleniumActions.SwitchToDefaultContent();
            return prefixWithSpclChrtrLevel;
        }

        // ***********  End of EwQIMS-15728_Validate Prefix with Special characters ************ //

        // *********** Start of EwQIMS-15733: Edit Level Number ************ //

        /// <summary>
        /// this method used to test the level num field is disabled
        /// </summary>
        public void ValidateLevelNumberFieldIsDisabled()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Tree);
            seleniumActions.Click(inpLevelNumber);
            seleniumActions.Click(btnNo_PopUp);
            Assert.IsTrue(seleniumActions.VerifyElementIsDisplayed(inp_DisabledLevelNumField));
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** End of EwQIMS-15733: Edit Level Number ************ //

        // *********** Start of EwQIMS-32426: Parent Level Name Hierarchy ************ //

        /// <summary>
        /// Clicks refresh button in levels page
        /// </summary>
        public void ClickRefreshButtonInLevelsPage()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Click(btnRefresh_LevelPage);
            seleniumActions.Wait(3);
            seleniumActions.Click(btnRefresh_LevelPage);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Right clicks the parent level and clicks new
        /// </summary>
        public void RightClickParentLevelAndClickNew(string levelName)
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.MoveToElement(By.XPath("//table[@class='Tbltitle']//ul[@id='TOCDoclvl']//a[contains(@title,'" + levelName + "')]"));
            seleniumActions.Click(By.XPath("(//table[@class='Tbltitle']//ul[@id='TOCDoclvl']//a[contains(@title,'" + levelName + "')]//following::*[local-name()='svg' and contains(@class,'plus')])[1]"));
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Creates a new subfolder level inside the parent level
        /// </summary>
        public string CreateNewSubfolderLevel()
        {
            string subfolder = Constants.SubfolderLevel + utility.CurrentTime();
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Tree);
            seleniumActions.Click(inp_Levelname);
            seleniumActions.SendKeys(inp_Levelname, subfolder);
            seleniumActions.Click(btn_save);
            seleniumActions.SwitchToDefaultContent();
            return subfolder;
        }

        /// <summary>
        /// verifies the subfolder level is created under correct parent level
        /// </summary>
        public void VerifySubFolderIsCreatedInsideParentLevel(string levelName, string subFolderName)
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            Assert.IsTrue(seleniumActions.IsElementPresent(By.XPath("//a[@title='" + levelName + "']//parent::li//child::span[contains(@class,'center_close')]")));
            seleniumActions.ScrollToElement(By.XPath("//a[@title='" + levelName + "']//parent::li//child::span[contains(@class,'center_close')]"));
            seleniumActions.Click(By.XPath("//a[@title='" + levelName + "']//parent::li//child::span[contains(@class,'center_close')]"));
            Assert.IsTrue(seleniumActions.IsElementPresent(By.XPath("//span[contains(text(),'" + subFolderName + "')]")));
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Right clicks the subfolder level and clicks new
        /// </summary>
        public void RightClickSubFolderLevelAndClickNew(string subFolderName)
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.MoveToElement(By.XPath("//table[@class='Tbltitle']//ul[@id='TOCDoclvl']//a[contains(@title,'" + subFolderName + "')]"));
            seleniumActions.Click(By.XPath("(//table[@class='Tbltitle']//ul[@id='TOCDoclvl']//a[contains(@title,'" + subFolderName + "')]//following::*[local-name()='svg' and contains(@class,'plus')])[1]"));
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Creates a new subchild level inside the subfolder level
        /// </summary>
        public string CreateNewSubChildLevel()
        {
            string subchild = Constants.SubChildLevel + utility.CurrentTime();
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Tree);
            seleniumActions.Click(inp_Levelname);
            seleniumActions.SendKeys(inp_Levelname, subchild);
            seleniumActions.Click(btn_save);
            seleniumActions.SwitchToDefaultContent();
            return subchild;
        }

        /// <summary>
        /// verifies the subchild level is created under correct subfolder level
        /// </summary>
        public void VerifySubChildIsCreatedInsideSubFolderLevel(string levelName, string subFolderName, string subChildName)
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Click(By.XPath("//a[@title='" + levelName + "']//parent::li//child::span[contains(@class,'center_close')]"));
            Assert.IsTrue(seleniumActions.VerifyElementIsDisplayed(By.XPath("//a[@title='" + subFolderName + "']//parent::li//child::span[contains(@class,'bottom_close')]")));
            seleniumActions.Click(By.XPath("//a[@title='" + subFolderName + "']//parent::li//child::span[contains(@class,'bottom_close')]"));
            Assert.IsTrue(seleniumActions.VerifyElementIsDisplayed(By.XPath("//span[contains(text(),'" + subChildName + "')]")));
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** End of EwQIMS-32426: Parent Level Name Hierarchy ************ //

        // *********** Start of EwQIMS-32424: Duplicate Level Creation ************ //

        /// <summary>
        /// Validate the duplicate level creation alert
        /// </summary>
        public void ValidateTheDuplicateLevelCreationAlert()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree);
            Assert.IsTrue(seleniumActions.GetText(lbl_FrequencyAlert).Contains(" This level name is already being used"));
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** End of EwQIMS-32424: Duplicate Level Creation ************ //

        // *********** Start of EwQIMS-47529: Parent Level Name blank for creating a new parent level ************ //

        /// <summary>
        /// validate level name field is greyed out before giving any input
        /// </summary>
        public void ValidateLevelNameFieldIsGreyedOutBeforeGivingAnyInput()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_Tree);
            Assert.IsTrue(seleniumActions.VerifyElementIsDisplayed(inpParentLevelName_LevelPage));
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** Start of EwQIMS-47529: Parent Level Name blank for creating a new parent level ************ //

        // *********** Start of EwQIMS-47529: Parent Level Name blank for creating a new parent level ************ //

        public void VerifyTemplateIsSelectedInLevelPDFPreference()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData, iframe_Tree, iframe_water);
            seleniumActions.Wait(3);
            Assert.IsTrue(seleniumActions.IsElementPresent(drp_TemplateInLevelPDFPreferencesPage), "Template dropdown is not present");
            seleniumActions.Click(drp_TemplateInLevelPDFPreferencesPage);
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** Start of EwQIMS-47529: Parent Level Name blank for creating a new parent level ************ //

        // *********** Start of EwQIMS-22144 : DOC - Display selected Template ************ //

        /// <summary>
        /// selects template from dropdown
        /// </summary>
        public void SelectTemplateFromTemplateDropdown()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData);
            seleniumActions.Wait(3);
            seleniumActions.SwitchToIframes(iframe_Tree, iframe_water);
            seleniumActions.Wait(5);
            var dropdown = new WebDriverWait(_driver, TimeSpan.FromSeconds(10))
            .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//label[contains(text(),'Template')]//following::select[@class='custom-select']")));
            if (dropdown.Displayed && dropdown.Enabled)
            {
                dropdown.Click();
            }
            seleniumActions.Wait(3);
            seleniumActions.Click(ddlSuiteDefault_LevelPDFPreference);
            seleniumActions.Click(btn_save);
            Assert.IsTrue(seleniumActions.IsElementPresent(msgPreferencesSavedSuccessfully), "save msg is not present");
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.Wait(3);
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData);
            seleniumActions.Click(btn_refreshLevel);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// verify template is selected and reset to default
        /// </summary>
        public void VerifyTemplateIsSelectedAndResetToDefault()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData);
            seleniumActions.Wait(3);
            seleniumActions.SwitchToIframes(iframe_Tree, iframe_water);
            seleniumActions.Wait(5);
            var dropdown = new WebDriverWait(_driver, TimeSpan.FromSeconds(10))
             .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//label[contains(text(),'Template')]//following::select[@class='custom-select']")));
            if (dropdown.Displayed && dropdown.Enabled)
            {
                dropdown.Click();
            }
            seleniumActions.Wait(3);
            seleniumActions.Click(ddlAutomationTemp_LevelPDFPreference);
            seleniumActions.Click(btn_save);
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** End of EwQIMS-22144 : DOC - Display selected Template ************ //

        // *********** level PDF preference - Start of TC 22153 22154 ************ //

        /// <summary>
        /// Validate level pdf preferences page Refresh action
        /// </summary>
        public void ValidateRefreshsInLevelPDFPreferencesPage()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData);
            seleniumActions.Wait(3);
            seleniumActions.SwitchToIframes(iframe_Tree, iframe_water);
            seleniumActions.Wait(3);
            Assert.IsTrue(seleniumActions.IsElementPresent(btnMultiSearch, 5));
            seleniumActions.Click(btnMultiSearch);
            seleniumActions.Wait(4);
            Assert.IsTrue(seleniumActions.IsElementPresent(drpColumn_MultiSearch, 5));
            seleniumActions.Click(drpColumn_MultiSearch);
            seleniumActions.Click(ddlModules_MultiSearch);
            seleniumActions.Click(drpCondition_MultiSearch);
            seleniumActions.Click(ddlContains_MultiSearch);
            seleniumActions.Click(inp_MultiSearch);
            seleniumActions.SendKeys(inp_MultiSearch, "tfrd");
            seleniumActions.Click(btnAdvancedSearch_MultiSearch);
            seleniumActions.Wait(3);
            Assert.IsTrue(seleniumActions.GetText(lbl_NoRecordsToDisplay).Contains("There are no records to display"));
            seleniumActions.Click(btn_LevelPDFRestart);
            seleniumActions.Wait(3);
            Assert.IsFalse(seleniumActions.IsElementPresent(lbl_NoRecordsToDisplay, 5), "(There are no records to display) text is present");
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** level PDF preference - End of TC 22153 22154 ************ //

        // *********** level PDF preference - Start of TC 22150 ************ //

        /// <summary>
        /// Creates new template in PDF templates page
        /// </summary>
        public void CreateNewTemplateInPDfTemplatePage()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Click(btnAdd_PdfTemplate);

            // Store the current window handle
            string originalWindow = _driver.CurrentWindowHandle;
            // Get all window handles
            IReadOnlyCollection<string> allWindows = _driver.WindowHandles;

            // Switch to the new window
            foreach (string windowHandle in allWindows)
            {
                if (windowHandle != originalWindow)
                {
                    _driver.SwitchTo().Window(windowHandle);
                    break;
                }
            }
            seleniumActions.SendKeys(txtTemplateName, "QATesting");
            seleniumActions.Click(chkIncludeHeader);
            seleniumActions.Click(chkIncludeFooter);
            seleniumActions.Click(chkIncludeCoverPage);

            //EwQIMS - 48801: Position dropdown field
            Assert.IsTrue(seleniumActions.IsElementPresent(drpPositionInTempDetails));
            seleniumActions.Click(drpPositionInTempDetails);
            Assert.IsTrue(seleniumActions.IsElementPresent(ddlPositionTopInTempDetails));
            Assert.IsTrue(seleniumActions.IsElementPresent(ddlPositionBottomInTempDetails));
            Assert.IsTrue(seleniumActions.IsElementPresent(ddlPositionLeftInTempDetails));
            Assert.IsTrue(seleniumActions.IsElementPresent(ddlPositionRightInTempDetails));
            Assert.IsTrue(seleniumActions.IsElementPresent(ddlPositionDiagonalInTempDetails));
            Assert.IsTrue(seleniumActions.IsElementPresent(ddlPositionCenterInTempDetails));

            //EwQIMS - 48812: Dropdown field in Watermark details
            seleniumActions.Click(ddlPositionBottomInTempDetails);
            seleniumActions.Wait(2);
            seleniumActions.Click(drpPositionInTempDetails);
            seleniumActions.Click(ddlPositionLeftInTempDetails);
            seleniumActions.Wait(2);
            seleniumActions.Click(drpPositionInTempDetails);
            seleniumActions.Click(ddlPositionRightInTempDetails);
            seleniumActions.Wait(2);
            seleniumActions.Click(drpPositionInTempDetails);
            seleniumActions.Click(ddlPositionDiagonalInTempDetails);
            seleniumActions.Wait(2);
            seleniumActions.Click(drpPositionInTempDetails);
            seleniumActions.Click(ddlPositionCenterInTempDetails);
            seleniumActions.Wait(2);
            seleniumActions.Click(drpPositionInTempDetails);
            seleniumActions.Click(ddlPositionTopInTempDetails);
            seleniumActions.Wait(2);

            // EwQIMS-48813: Opaqueness field in Watermark details
            seleniumActions.SendKeys(inp_Opaqueness, "1");
            seleniumActions.Click(chkIncludeWatermark);
            seleniumActions.Click(btn_Continue);
            _driver.SwitchTo().Window(originalWindow);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Verify Checkboxes From Template Name 
        /// </summary>
        /// 
        public void VerifyCheckboxesFromTemplateName()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Click(btnAdd_PdfTemplate);
            // Store the current window handle
            string originalWindow = _driver.CurrentWindowHandle;
            // Get all window handles
            IReadOnlyCollection<string> allWindows = _driver.WindowHandles;

            // Switch to the new window
            foreach (string windowHandle in allWindows)
            {
                if (windowHandle != originalWindow)
                {
                    _driver.SwitchTo().Window(windowHandle);
                    break;
                }
            }
            var checkIncludeWatermark = new WebDriverWait(_driver, TimeSpan.FromSeconds(10))
            .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//label[@for='chkIncludeWMark']")));
            if (checkIncludeWatermark.Displayed && checkIncludeWatermark.Enabled)
            {
                checkIncludeWatermark.Click();
            }
            var ChkIncludeHeader = new WebDriverWait(_driver, TimeSpan.FromSeconds(10))
            .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//label[@for='chkIncludeHeader']")));
            if (ChkIncludeHeader.Displayed && ChkIncludeHeader.Enabled)
            {
                ChkIncludeHeader.Click();
            }

            var ChkIncludeFooter = new WebDriverWait(_driver, TimeSpan.FromSeconds(10))
            .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//label[@for='chkIncludeFooter']")));
            if (ChkIncludeFooter.Displayed && ChkIncludeFooter.Enabled)
            {
                ChkIncludeFooter.Click();
            }

            var ChkIncludeCoverPage = new WebDriverWait(_driver, TimeSpan.FromSeconds(10))
            .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//label[@for='chkIncludeCPage']")));
            if (ChkIncludeCoverPage.Displayed && ChkIncludeCoverPage.Enabled)
            {
                ChkIncludeCoverPage.Click();
            }
            seleniumActions.Wait(3);
            Assert.IsTrue(seleniumActions.IsElementPresent(chkIncludeWatermark));
            Assert.IsTrue(seleniumActions.IsElementPresent(chkIncludeHeader));
            Assert.IsTrue(seleniumActions.IsElementPresent(chkIncludeFooter));
            Assert.IsTrue(seleniumActions.IsElementPresent(chkIncludeCoverPage));
            seleniumActions.SwitchToDefaultContent();

        }

        /// <summary>
        /// verifies new template is visible from template dropdown
        /// </summary>
        public void VerifyNewTemplateIsVisibleFromTemplateDropdown()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData);
            seleniumActions.Wait(3);
            seleniumActions.SwitchToIframes(iframe_Tree, iframe_water);
            seleniumActions.Wait(5);
            var dropdown = new WebDriverWait(_driver, TimeSpan.FromSeconds(10))
            .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//label[contains(text(),'Template')]//following::select[@class='custom-select']")));
            if (dropdown.Displayed && dropdown.Enabled)
            {
                dropdown.Click();
            }
            seleniumActions.Wait(3);
            Assert.IsTrue(seleniumActions.IsElementPresent(ddlQATesting_LevelPDFPreference));
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// deletes newly created template in pdf template
        /// </summary>
        public void DeleteNewlyCreatedTemplateInPdfTemplate()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            Assert.IsTrue(seleniumActions.IsElementPresent(btnMultiSearch, 5));
            seleniumActions.Click(btnMultiSearch);
            seleniumActions.Wait(4);
            Assert.IsTrue(seleniumActions.IsElementPresent(drpColumn_MultiSearch, 5));
            seleniumActions.Click(drpColumn_MultiSearch);
            seleniumActions.Click(ddlTempName_MultiSearch);
            seleniumActions.Click(drpCondition_MultiSearch);
            seleniumActions.Click(ddlContains_MultiSearch);
            seleniumActions.Click(inp_MultiSearch);
            seleniumActions.SendKeys(inp_MultiSearch, "QATesting");
            seleniumActions.Click(btnAdvancedSearch_MultiSearch);
            seleniumActions.Wait(3);
            seleniumActions.Click(chk_FirstRowInActive);
            seleniumActions.Wait(4);
            seleniumActions.Click(btnDelete_PdfTemplate);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblDeletedSuccessMessage, 5));
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** level PDF preference - End of TC 22150 ************ //

        // *********** PDF Template - start of TC 17931 ************ //

        /// <summary>
        /// creates new template in pdf template page without saving and verify it is not created
        /// </summary>
        public void CreateANewTemplateInPdfTemplatePageWithoutSavingAndVerifyItIsNotCreated()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Click(btnAdd_PdfTemplate);

            // Store the current window handle
            string originalWindow = _driver.CurrentWindowHandle;
            // Get all window handles
            IReadOnlyCollection<string> allWindows = _driver.WindowHandles;

            // Switch to the new window
            foreach (string windowHandle in allWindows)
            {
                if (windowHandle != originalWindow)
                {
                    _driver.SwitchTo().Window(windowHandle);
                    break;
                }
            }
            seleniumActions.Click(btn_Continue);
            Assert.IsTrue(seleniumActions.GetText(lbl_FrequencyAlert).Contains("Template name cannot be empty"));
            seleniumActions.SendKeys(txtTemplateName, "QATesting");
            seleniumActions.Click(chkIncludeWatermark);
            seleniumActions.Click(chkIncludeHeader);
            seleniumActions.Click(chkIncludeFooter);
            seleniumActions.Click(chkIncludeCoverPage);
            _driver.Close();
            _driver.SwitchTo().Window(originalWindow);
            seleniumActions.SwitchToDefaultContent();

            seleniumActions.SwitchToIframes(iframe_DetailView);
            Assert.IsTrue(seleniumActions.IsElementPresent(btnMultiSearch, 5));
            seleniumActions.Click(btnMultiSearch);
            seleniumActions.Wait(4);
            Assert.IsTrue(seleniumActions.IsElementPresent(drpColumn_MultiSearch, 5));
            seleniumActions.Click(drpColumn_MultiSearch);
            seleniumActions.Click(ddlTempName_MultiSearch);
            seleniumActions.Click(drpCondition_MultiSearch);
            seleniumActions.Click(ddlContains_MultiSearch);
            seleniumActions.Click(inp_MultiSearch);
            seleniumActions.SendKeys(inp_MultiSearch, "QATesting");
            seleniumActions.Click(btnAdvancedSearch_MultiSearch);
            seleniumActions.Wait(3);
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_NoRecordsToDisplay, 5), "(There are no records to display) text is present");
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** PDF Template - start of TC 17931 ************ //

        // *********** PDF Template - start of TC 18034 ************ //

        /// <summary>
        /// edit the existing template and verify the template name is changed in pdf templates page
        /// </summary>
        public void EditAndVerifyExistingPDFTemplate()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            Assert.IsTrue(seleniumActions.IsElementPresent(btnMultiSearch, 5));
            seleniumActions.Click(btnMultiSearch);
            seleniumActions.Wait(4);
            Assert.IsTrue(seleniumActions.IsElementPresent(drpColumn_MultiSearch, 5));
            seleniumActions.Click(drpColumn_MultiSearch);
            seleniumActions.Click(ddlTempName_MultiSearch);
            seleniumActions.Click(drpCondition_MultiSearch);
            seleniumActions.Click(ddlContains_MultiSearch);
            seleniumActions.Click(inp_MultiSearch);
            seleniumActions.SendKeys(inp_MultiSearch, "QATesting");
            seleniumActions.Click(btnAdvancedSearch_MultiSearch);
            seleniumActions.Wait(3);
            seleniumActions.Click(lblTempNameInPdfTempPage);

            // Store the current window handle
            string originalWindow = _driver.CurrentWindowHandle;
            // Get all window handles
            IReadOnlyCollection<string> allWindows = _driver.WindowHandles;

            // Switch to the new window
            foreach (string windowHandle in allWindows)
            {
                if (windowHandle != originalWindow)
                {
                    _driver.SwitchTo().Window(windowHandle);
                    break;
                }
            }
            seleniumActions.SendKeys(txtTemplateName, "Updated QATesting");
            seleniumActions.Click(btn_Continue);
            Assert.IsTrue(seleniumActions.IsElementPresent(btn_YesApplyToAllDoc, 5));
            seleniumActions.Click(btn_YesApplyToAllDoc);
            _driver.SwitchTo().Window(originalWindow);
            seleniumActions.SwitchToDefaultContent();

            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.GetText(lblTempNameInPdfTempPage).Equals("Updated QATesting");
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** PDF Template - end of TC 18034 ************ //

        // *********** PDF Template - start of TC 17929 ************ //

        /// <summary>
        /// The user should be able to view the sample PDF Template with all the details entered.	
        /// </summary>
        public void ValidateShowTemplateScreen()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Click(btnAdd_PdfTemplate);

            // Store the current window handle
            string originalWindow = _driver.CurrentWindowHandle;
            // Get all window handles
            IReadOnlyCollection<string> allWindows = _driver.WindowHandles;

            // Switch to the new window
            foreach (string windowHandle in allWindows)
            {
                if (windowHandle != originalWindow)
                {
                    _driver.SwitchTo().Window(windowHandle);
                    break;
                }
            }
            seleniumActions.SendKeys(txtTemplateName, "QATesting");
            seleniumActions.Click(chkIncludeHeader);
            seleniumActions.Click(chkIncludeFooter);
            seleniumActions.Click(chkIncludeCoverPage);

            //EwQIMS - 48801: Position dropdown field
            Assert.IsTrue(seleniumActions.IsElementPresent(drpPositionInTempDetails));
            seleniumActions.Click(drpPositionInTempDetails);
            Assert.IsTrue(seleniumActions.IsElementPresent(ddlPositionTopInTempDetails));
            Assert.IsTrue(seleniumActions.IsElementPresent(ddlPositionBottomInTempDetails));
            Assert.IsTrue(seleniumActions.IsElementPresent(ddlPositionLeftInTempDetails));
            Assert.IsTrue(seleniumActions.IsElementPresent(ddlPositionRightInTempDetails));
            Assert.IsTrue(seleniumActions.IsElementPresent(ddlPositionDiagonalInTempDetails));
            Assert.IsTrue(seleniumActions.IsElementPresent(ddlPositionCenterInTempDetails));

            //EwQIMS - 48812: Dropdown field in Watermark details
            seleniumActions.Click(ddlPositionBottomInTempDetails);
            seleniumActions.Wait(2);
            seleniumActions.Click(drpPositionInTempDetails);
            seleniumActions.Click(ddlPositionLeftInTempDetails);
            seleniumActions.Wait(2);
            seleniumActions.Click(drpPositionInTempDetails);
            seleniumActions.Click(ddlPositionRightInTempDetails);
            seleniumActions.Wait(2);
            seleniumActions.Click(drpPositionInTempDetails);
            seleniumActions.Click(ddlPositionDiagonalInTempDetails);
            seleniumActions.Wait(2);
            seleniumActions.Click(drpPositionInTempDetails);
            seleniumActions.Click(ddlPositionCenterInTempDetails);
            seleniumActions.Wait(2);
            seleniumActions.Click(drpPositionInTempDetails);
            seleniumActions.Click(ddlPositionTopInTempDetails);
            seleniumActions.Wait(2);

            // EwQIMS-48813: Opaqueness field in Watermark details
            seleniumActions.SendKeys(inp_Opaqueness, "1");
            seleniumActions.Click(chkIncludeWatermark);
            seleniumActions.Click(btn_PDFShowSamplePDF);
            _driver.SwitchTo().Window(originalWindow);
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** PDF Template - end of TC 17929 ************ //

        // *********** PDF Template - start of TC-17938,TC-17939,TC-17941 ************ //

        /// <summary>
        /// navigate to PDF temp creation window and verify data fields under page details
        /// </summary>
        public void NavigateToPDFTempCreationWindowAndVerifyDataFields()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Click(btnAdd_PdfTemplate);

            // Store the current window handle
            string originalWindow = _driver.CurrentWindowHandle;
            // Get all window handles
            IReadOnlyCollection<string> allWindows = _driver.WindowHandles;

            // Switch to the new window
            foreach (string windowHandle in allWindows)
            {
                if (windowHandle != originalWindow)
                {
                    _driver.SwitchTo().Window(windowHandle);
                    break;
                }
            }
            seleniumActions.Click(chkIncludeHeader);
            seleniumActions.Click(chkIncludeFooter);
            seleniumActions.Click(chkIncludeCoverPage);

            seleniumActions.Click(drp_DataFields_Watermark);
            Actions actions = new Actions(_driver);
            actions.SendKeys(Keys.End).Perform();
            for (int i = 0; i <= 4; i++)
            {
                actions.SendKeys(Keys.ArrowUp).Perform();
            }
            actions.SendKeys(Keys.ArrowUp).SendKeys(Keys.Enter).Perform();
            seleniumActions.SwitchToIframes(iframe_ckeEditor_Watermark);
            string txtWatermarkDetails = seleniumActions.GetText(txtHeaderDetails);
            Assert.IsTrue(txtWatermarkDetails.Contains("Next Review Date"));
            seleniumActions.SwitchToDefaultContent();

            seleniumActions.Wait(3);
            seleniumActions.Click(chkIncludeCoverPage);
            seleniumActions.Click(coverPageTab);
            seleniumActions.WaitForElementToExists(drp_DataFields_CoverPage);
            seleniumActions.Click(drp_DataFields_CoverPage);
            actions.SendKeys(Keys.End).Perform();
            for (int i = 0; i <= 3; i++)
            {
                actions.SendKeys(Keys.ArrowUp).Perform();
            }
            actions.SendKeys(Keys.ArrowUp).SendKeys(Keys.Enter).Perform();
           
            seleniumActions.SwitchToFrame(iframe_ckeEditor_CoverPage);
            string txtCoverDetails = seleniumActions.GetText(txtCoverPageDetails);
            Assert.IsTrue(txtCoverDetails.Contains("Review Date"));
            seleniumActions.SwitchToDefaultContent();

            _driver.Close();
            _driver.SwitchTo().Window(originalWindow);
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** PDF Template - end of TC-17938,TC-17939,TC-17941 ************ //

        // *********** PDF Template - start of TC-18039-18041 ************ //

        /// <summary>
        /// enters values in header , footer and cover page details
        /// </summary>
        public void EnterValuesInHeaderFooterAndIncludeCoverPageSection()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            Assert.IsTrue(seleniumActions.IsElementPresent(btnMultiSearch, 5));
            seleniumActions.Click(btnMultiSearch);
            seleniumActions.Wait(4);
            Assert.IsTrue(seleniumActions.IsElementPresent(drpColumn_MultiSearch, 5));
            seleniumActions.Click(drpColumn_MultiSearch);
            seleniumActions.Click(ddlTempName_MultiSearch);
            seleniumActions.Click(drpCondition_MultiSearch);
            seleniumActions.Click(ddlContains_MultiSearch);
            seleniumActions.Click(inp_MultiSearch);
            seleniumActions.SendKeys(inp_MultiSearch, "QATesting");
            seleniumActions.Click(btnAdvancedSearch_MultiSearch);
            seleniumActions.Wait(3);
            seleniumActions.Click(lblTempNameInPdfTempPage);

            // Store the current window handle
            string originalWindow = _driver.CurrentWindowHandle;
            // Get all window handles
            IReadOnlyCollection<string> allWindows = _driver.WindowHandles;

            // Switch to the new window
            foreach (string windowHandle in allWindows)
            {
                if (windowHandle != originalWindow)
                {
                    _driver.SwitchTo().Window(windowHandle);
                    break;
                }
            }
            seleniumActions.Click(chkIncludeHeader);
            seleniumActions.Click(chkIncludeFooter);
            seleniumActions.Click(chkIncludeCoverPage);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblHeaderDetails));

            seleniumActions.Wait(4);
            seleniumActions.SwitchToIframes(iframe_ckeEditor_Header);
            Assert.IsTrue(seleniumActions.IsElementPresent(txtHeaderDetails));
            seleniumActions.SendKeys(txtHeaderDetails, "Test header");
            seleniumActions.SwitchToDefaultContent();

            seleniumActions.Wait(4);
            seleniumActions.SwitchToIframes(iframe_ckeEditor_Footer);
            Assert.IsTrue(seleniumActions.IsElementPresent(txtHeaderDetails));
            seleniumActions.ScrollToElement(txtHeaderDetails);
            seleniumActions.SendKeys(txtHeaderDetails, "Test footer");
            seleniumActions.SwitchToDefaultContent();

            seleniumActions.ScrollToElement(coverPageTab);
            seleniumActions.Click(coverPageTab);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblPosition));

            seleniumActions.Wait(4);
            seleniumActions.SwitchToIframes(iframe_ckeEditor_CoverPage);
            Assert.IsTrue(seleniumActions.IsElementPresent(txtHeaderDetails));
            seleniumActions.ScrollToElement(txtHeaderDetails);
            seleniumActions.SendKeys(txtHeaderDetails, "Test cover page");
            seleniumActions.SwitchToDefaultContent();

            seleniumActions.Click(btn_Continue);
            seleniumActions.Click(btn_YesApplyToAllDoc);

            _driver.SwitchTo().Window(originalWindow);
            seleniumActions.SwitchToDefaultContent();

        }

        /// <summary>
        /// Verifies whether the user can enter values in header , footer and cover page details
        /// </summary>
        public void VerifyValuesInHeaderFooterAndIncludeCoverPageSection()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            Assert.IsTrue(seleniumActions.IsElementPresent(btnMultiSearch, 5));
            seleniumActions.Click(btnMultiSearch);
            seleniumActions.Wait(4);
            Assert.IsTrue(seleniumActions.IsElementPresent(drpColumn_MultiSearch, 5));
            seleniumActions.Click(drpColumn_MultiSearch);
            seleniumActions.Click(ddlTempName_MultiSearch);
            seleniumActions.Click(drpCondition_MultiSearch);
            seleniumActions.Click(ddlContains_MultiSearch);
            seleniumActions.Click(inp_MultiSearch);
            seleniumActions.SendKeys(inp_MultiSearch, "QATesting");
            seleniumActions.Click(btnAdvancedSearch_MultiSearch);
            seleniumActions.Wait(3);
            seleniumActions.Click(lblTempNameInPdfTempPage);

            // Store the current window handle
            string originalWindow = _driver.CurrentWindowHandle;
            // Get all window handles
            IReadOnlyCollection<string> allWindows = _driver.WindowHandles;

            // Switch to the new window
            foreach (string windowHandle in allWindows)
            {
                if (windowHandle != originalWindow)
                {
                    _driver.SwitchTo().Window(windowHandle);
                    break;
                }
            }

            Assert.IsTrue(seleniumActions.IsElementPresent(lblHeaderDetails));

            seleniumActions.Wait(4);
            seleniumActions.SwitchToIframes(iframe_ckeEditor_Header);
            Assert.IsTrue(seleniumActions.IsElementPresent(txtHeaderDetails));
            seleniumActions.GetText(txtHeaderDetails).Equals("Test header");
            seleniumActions.SwitchToDefaultContent();

            seleniumActions.Wait(4);
            seleniumActions.SwitchToIframes(iframe_ckeEditor_Footer);
            Assert.IsTrue(seleniumActions.IsElementPresent(txtHeaderDetails));
            seleniumActions.ScrollToElement(txtHeaderDetails);
            seleniumActions.GetText(txtHeaderDetails).Equals("Test footer");
            seleniumActions.SwitchToDefaultContent();

            seleniumActions.ScrollToElement(coverPageTab);
            seleniumActions.Click(coverPageTab);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblPosition));

            seleniumActions.Wait(4);
            seleniumActions.SwitchToIframes(iframe_ckeEditor_CoverPage);
            Assert.IsTrue(seleniumActions.IsElementPresent(txtHeaderDetails));
            seleniumActions.ScrollToElement(txtHeaderDetails);
            seleniumActions.GetText(txtHeaderDetails).Equals("Test cover page");
            seleniumActions.SwitchToDefaultContent();

            _driver.Close();
            _driver.SwitchTo().Window(originalWindow);
            seleniumActions.SwitchToDefaultContent();
        }

        // *********** PDF Template - end of TC-18039-18041 ************ //

        // *********** PDF Template - start of TC-48814 ************ //

        /// <summary>
        /// click existing template from PDF template page
        /// </summary>
        public void ClickExistingTemplateFromPDFTemplatePage()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            Assert.IsTrue(seleniumActions.IsElementPresent(btnMultiSearch, 5));
            seleniumActions.Click(btnMultiSearch);
            seleniumActions.Wait(4);
            Assert.IsTrue(seleniumActions.IsElementPresent(drpColumn_MultiSearch, 5));
            seleniumActions.Click(drpColumn_MultiSearch);
            seleniumActions.Click(ddlTempName_MultiSearch);
            seleniumActions.Click(drpCondition_MultiSearch);
            seleniumActions.Click(ddlContains_MultiSearch);
            seleniumActions.Click(inp_MultiSearch);
            seleniumActions.SendKeys(inp_MultiSearch, "Automation Template");
            seleniumActions.Click(btnAdvancedSearch_MultiSearch);
            seleniumActions.Wait(3);
            seleniumActions.Click(lblTempNameInPdfTempPage);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// clicks and validates the load previous button page
        /// </summary>
        public void ClickLoadPreviousButton()
        {
            string originalWindow = _driver.CurrentWindowHandle;
            // Get all window handles
            IReadOnlyCollection<string> allWindows = _driver.WindowHandles;

            // Switch to the new window
            foreach (string windowHandle in allWindows)
            {
                if (windowHandle != originalWindow)
                {
                    _driver.SwitchTo().Window(windowHandle);
                    break;
                }
            } 

            seleniumActions.WaitForElementToExists(btnLoadPrevious);
            seleniumActions.Click(btnLoadPrevious);
        }

        /// <summary>
        /// validates the load previous button page
        /// </summary>
        public void ValidateLoadPreviousButtonPage()
        {
            Assert.IsTrue(seleniumActions.IsElementPresent(lblLoadPreviousVersion, 5));
            seleniumActions.SwitchToIframes(iframe_tempLoadPrev);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblTempName_LoadPrev,5));
            Assert.IsTrue(seleniumActions.IsElementPresent(btnShowSamplePDF_LoadPrev,5));
            Assert.IsTrue(seleniumActions.IsElementPresent(tblLoadPrevGrid_LoadPrev,5));
            seleniumActions.SwitchToDefaultContent();
            _driver.Close();
        }

        // *********** PDF Template - end of TC-48814 ************ //

        #endregion
    }
}
