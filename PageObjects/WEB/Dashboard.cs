
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
using Amazon.DynamoDBv2.DocumentModel;
using OpenQA.Selenium.Interactions;
using Amazon.DynamoDBv2.Model;
using AventStack.ExtentReports.Gherkin.Model;
using TechTalk.SpecFlow.CommonModels;
using Amazon.SecretsManager.Model.Internal.MarshallTransformations;

namespace OMNEX.AUTOMATION.PageObjects.WEB
{
    public class Dashboard
    {
        #region Declaration
        private IWebDriver _driver;
        private SeleniumActions seleniumActions;
        public Utilities utility;


        #endregion

        #region Constructor
        public Dashboard(IWebDriver driver)
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
        By btnAdd_MasterFolderTags => By.XPath("(//button[@id='btn_add_hold'])[1]");
        By tblAddPopup => By.XPath("//div[@id='AddRow']");
        By phd_TagName => By.XPath("//input[@name='TagName']");
        By btnSave_TagPopup => By.XPath("//button[contains(@class,'btn-success')]");
        By lblTag => By.XPath("(//td[@class='sorting_1'])[1]");
        By btnPencilIcon => By.XPath("(//span[@class='clsbtnedit'])[1]");
        By chkTagname_Inactive => By.XPath("(//input[@name='FldrTagsGrid_selectCheck'])[1]");
        By btn_DeleteTag => By.XPath("(//span[@alt='Delete'])[1]");
        By btnYes_Popup => By.XPath("//button[@id='popup_ok']");
        By lblSystem => By.XPath("//div[@class='sub-menu']//span[contains(text(),'System')]");
        By btnNew_TeamsPage => By.XPath("(//div[@id='TeamsListGrid']//button[@Title='New'])[1]");
        By btnSelectTeamLeader => By.XPath("(//input[@id='leaderName']//following::span[@class='input-group-text'])[1]");
        By rdoUserBasedSearchChecked => By.XPath("//input[@id='rdUserBaseSearch' and @checked='checked']");
        By phd_Name => By.XPath("//div[@id='userListingGridControl_wrapper']//input[@type='search']");
        By lblTeamLeader_SearchResult => By.XPath("(//table[@id='userListingGridControl']//td[@class='sorting_1'])[1]");
        By chkTeamLeaderInactive => By.XPath("(//table[@id='userListingGridControl']//tr[@class='odd']//input[@type='checkbox'])[1]");
        By chkTeamLeaderActive => By.XPath("(//table[@id='userListingGridControl']//tr[@class='odd selected']//input[@type='checkbox'])[1]");
        By btn_Done => By.XPath("//button[@title='Done']");
        By txtTeamName => By.XPath("//input[@id='team']");
        By lblTeamLeader => By.XPath("//label[text()='Team Leader']");
        By btnAdd_TeamsPage => By.XPath("(//button[@id='AddExtMem'])[1]");
        By txtExternalMemberName => By.XPath("(//input[@class='ClsExtMemberName'])[1]");
        By txtExternalMemberMail => By.XPath("(//input[@class='ClsExtMemberMail'])[1]");
        By btnAddMembers_TeamsPage => By.XPath("//button[@title='Add Members']");
        By lblAddedTeam => By.XPath("(//tr[@role='row']//td[@class='sorting_1']//a)[1]");
        By chkTeamInactive => By.XPath("(//table[@id='Grid_TeamListing']//tr[@class='odd']//input[@type='checkbox'])[1]");
        By chkTeamActive => By.XPath("(//table[@id='Grid_TeamListing']//tr[@class='odd selected']//input[@type='checkbox'])[1]");
        By btnDelete_TeamsPage => By.XPath("(//button[@id='btnDelete'])[1]");
        By lblDeletedSuccessMessage => By.XPath("//div[contains(@class,'alert-dismissible')]");
        By btnClose_TeamsPage => By.XPath("//button[@title='Close']");
        By tblRow => By.XPath("//tbody/tr[@role='row']");
        By btnNew => By.XPath("");

        By lblSuitSetUp => By.XPath("//div[@class='sub-menu']//span[contains(text(),'Suit Setup')]");

        /***************TC03 Xpaths**********************/

        By drpCountry => By.XPath("//span[contains(@id,'Country') or @id='select2-ddl_Site-container']");
        By txtSearchCountry => By.XPath("//*[@class='select2-search__field']");
        By btnAddState => By.XPath("//li[@id='dbtnadd']");
        By txtState => By.Id("txtNewState");
        By btnSave => By.Id("btnStateSave");
        By msgSaveSuccessfully => By.XPath("//div[contains(text(),'Saved successfully')]");
        By lblStateName => By.XPath("(//td[@class='sorting_1']//a)[1]");
        By chkState => By.XPath("//input[@name='Grid_StateListing_selectCheck']");
        By btnYes => By.Id("popup_ok");
        By btnDelete => By.Id("dbtndelete");

        /***************TC04 Xpaths**********************/

        By inp_ShiftName => By.XPath("//input[@id='txtShiftName']");
        By dtp_FromTime => By.XPath("//div[@class='input-group-append']//span[contains(@onClick,'txtFromTime')]");
        By dtp_ToTime => By.XPath("//div[@class='input-group-append']//span[contains(@onClick,'txtToTime')]");
        By tbl_FromTime => By.XPath("(//table[@class='ClsTable']//tbody//tr//td)[7]");
        By tbl_ToTime => By.XPath("(//table[@class='ClsTable']//tbody//tr//td)[10]");
        By btn_Save => By.XPath("//button[@title='Save']");
        By lblSuccess_Message => By.XPath("//div[contains(@class,'alert-success')]//strong");
        By btnClose_SuccessMessage => By.XPath("//a[@aria-label='close']");
        By hintSearch => By.XPath("(//input[@type='search'])[1]");
        By hintSearch2 => By.XPath("(//input[@type='search'])[2]");
        By lblFirstRow_ElementPresent => By.XPath("//tr[@role='row']//td/a[@href]");
        By chk_FirstRowInActive => By.XPath("//tbody//tr[@role='row' and @class='odd']//input[@type='checkbox']");
        By chk_FirstRowActive => By.XPath("//tbody//tr[@role='row' and @class='odd selected']//input[@type='checkbox']");
        By btnNew_CustomersPage => By.XPath("//button[@id='btnadd']");
        By txtCustName => By.XPath("//input[@id='txtName']");
        By txtCodeName => By.XPath("//input[@id='txtCode']");
        By tblAddAddress => By.XPath("//div[@id='AddRow']");
        By txtStreet => By.XPath("//textarea[@name='Street']");
        By drpCountry_AddAddress => By.XPath("//select[@name='Country']");
        By ddlIndia_AddAddress => By.XPath("//select[@name='Country']//option[contains(text(),'India') and @value=99]");
        By drpState_AddAddress => By.XPath("//select[@name='State']");
        By ddlTamilnadu_AddAddress => By.XPath("//select[@name='State']//option[contains(text(),'TamilNadu') and @value=4]");
        By drpCity_AddAddress => By.XPath("//select[@name='City']");
        By ddlChennai_AddAddress => By.XPath("//select[@name='City']//option[contains(text(),'CHennai') and @value=4]");
        By txtZipCode_AddAddress => By.XPath("//input[@name='Zipcode']");
        By btnSave_AddAddress => By.XPath("//button[contains(@class,'btn-success')]");
        By lblIndia_SavedAddress => By.XPath("//tbody//tr[@role='row']//td[contains(text(),'India')]");
        By svgContactIcon => By.XPath("//*[local-name()='svg' and @title='Contact']");
        By btnAdd_AddContact => By.XPath("//button[@onclick='AddDatatable(SUContactGridControl);']");
        By lblContact => By.XPath("//h5[contains(text(),'Contact')]");
        By txtFirstName_AddContact => By.XPath("//input[@name='FName']");
        By txtLastName_AddContact => By.XPath("//input[@name='LName']");
        By txtEmail_AddContact => By.XPath("//input[@name='ContEmail']");
        By btnSave_AddContact => By.XPath("//button[contains(@id,'btnSaveDetails_SUContactGridControl')]");
        By drpPageSize => By.XPath("//div[@class='dataTables_length']//select");
        By ddlValue_Hundred => By.XPath("//div[@class='dataTables_length']//select//option[@value=100]");
        By btnMultiSearch => By.XPath("//a[@title='Multi Search']");
        By lblSearch_MultiSearch => By.XPath("//div[@class='dtsb-title']");
        By drpColumn_MultiSearch => By.XPath("(//div[@class='dtsb-criteria']//select)[1]");
        By ddlCustomerName_MultiSearch => By.XPath("(//div[@class='dtsb-criteria']//select//option[contains(text(),'Customer Name')])[1]");
        By drpCondition_MultiSearch => By.XPath("(//div[@class='dtsb-criteria']//select)[2]");
        By ddlContains_MultiSearch => By.XPath("//div[@class='dtsb-criteria']//select//option[@value='contains']");
        By inp_MultiSearch => By.XPath("//input[@class='dtsb-value dtsb-input']");
        By btnAdvancedSearch_MultiSearch => By.XPath("//button[@title='Advanced Search']");

        /*************** TC01 Xpaths**********************/

        By btnUserIconProfile => By.XPath("//li[@id='profiledrop']/a/img");
        By btnLogout => By.XPath("//*[@id='logout']");
        By lblRememberme => By.XPath("//label[@for='chkremup']");
        By chk_PreferredManufacturer => By.XPath("//label[@for='chkPreManuf']");
        By ddlManufacturerName_MultiSearch => By.XPath("(//div[@class='dtsb-criteria']//select//option[contains(text(),'Manufacturer Name')])[1]");

        /***************TC13 Xpaths**********************/

        By inp_CountryName => By.XPath("//input[@id='txtCountryName']");

        /***************TC05 Xpaths**********************/

        By inp_VendorName => By.XPath("//input[@id='txtName']");
        By inp_VendorCode => By.XPath("//input[@id='txtCode']");
        By chk_PreferredVendor => By.XPath("//label[contains(text(), 'Preferred Vendor')]");
        By ddl_VendorNameMultiSearch => By.XPath("(//div[@class='dtsb-criteria']//select//option[contains(text(),'Vendor Name')])[1]");

        /***************TC21Xpaths**********************/

        By btn_CompanyLogoLarge => By.XPath("(//label[contains(text(),'Recommended Dimensions: 380 x 133 pixels')]//parent::div)[1]//following::button[@id='btnAttachCompanylogolarge']");
        By btn_CompanyLogomedium => By.XPath("//*[contains(@id,\"btnAttachCompanylogomedium\")]");
        By btn_ChooseFile => By.XPath("//input[@id='LocalImg']");
        By btn_DoneFile => By.XPath("//button[@id='butSave']");
        By btn_ProductLogo => By.XPath("//*[@id = 'btnAttachProductlogo'][1]");

        /***************TC11 Xpaths**********************/

        By btn_Add => By.XPath("//button[@id='btnSave']");
        By drp_Site => By.XPath("//select[@id='selectSiteId']");
        By inp_RightSite => By.XPath("//select[@id='selectSiteId']//option[3]");
        By inp_Position => By.XPath("//input[@id='txtPosition']");
        By inp_Description => By.XPath("//div//textarea[@id='txtDescription']");
        By btn_SaveForPosition => By.XPath("(//button[@id='btnSave'])[2]");

        /***************TC22 Xpaths**********************/

        /***************TC20 Xpaths**********************/

        By txt_City => By.Id("City");
        By inp_CountrySearch => By.XPath("//input[contains(@class, 'search')]");
        By drp_PaswordFormat => By.XPath("//*[contains(@id,'ddlListPwdFormat-container')]");
        By ddl_PaswordOption => By.XPath("//*[@type='search']");
        By txt_PasswordLength => By.XPath("//*[@id = 'PWDLen']");
        By drp_FirstCombobox => By.XPath("//*[@id = 'select2-drpNameFormat1-container']");
        By ddl_FCFirstName => By.XPath("//ul[@id='select2-drpNameFormat1-results']//li[contains(text(),'First Name')]");
        By ddl_FCLasttName => By.XPath("//ul[@id='select2-drpNameFormat1-results']//li[contains(text(),'Last Name')]");
        By drp_SecondCombobox => By.XPath("//*[contains(@id,'drpNameFormat1-container')]");
        By drp_ThirdCombobox => By.XPath("//*[contains(@id,'drpNameFormat2-container')]");
        By drp_FoutrhCombobox => By.XPath("//*[contains(@id,'drpNameFormatDelimit2-container')]");
        By drp_LastCombobox => By.XPath("//*[contains(@id,'drpNameFormat3-container')]");
        By ddl_LCFirstName => By.XPath("//ul[contains(@id,\"drpNameFormat3\")]//li[contains(text(),'First Name')]");
        By ddl_LCLastName => By.XPath("//ul[contains(@id,\"drpNameFormat3\")]//li[contains(text(),'Last Name')]");
        By btn_NewMeetings => By.XPath("//button[@id='btnDel']");
        By inp_MeetingDate => By.XPath("//input[@id='txtdate']");
        By tbl_DatePicker => By.XPath("//td[@class='today day']");
        By inp_Location => By.XPath("//input[@id='txtvenue']");
        By inp_MeetingSub => By.XPath("//textarea[@id='txtsubject']");
        By ddp_Category => By.XPath("//select[@id='ddlMeetingCategories']");
        By ddl_Categoryddl => By.XPath("//select[@id='ddlMeetingCategories']//option[contains(text(),'Business')]");
        By ddp_FromTime => By.XPath("//input[@id='txtFromTime']");
        By ddp_ToTime => By.XPath("//input[@id='txtToTime']");
        By tbl_FromTimeMeet => By.XPath("//span[@id='timePickerContent']//td[text()='12:15am']");
        By tbl_FromToMeet => By.XPath("//span[@id='timePickerContent']//td[text()='03:15am']");
        By btn_MeetingMinutes => By.XPath("//*[local-name()='svg' and @id='selMeeting']");
        By txt_MeetingMinutesBox => By.XPath("//*[@class = 'cke_editable cke_editable_themed cke_contents_ltr']");
        By btn_Title => By.XPath("//div[@id='MeetingMinutes']//*[@title='Close']");
        By btn_TeamIcon => By.XPath("//*[@id = 'selTeam']");
        By chk_ExisitingTeam => By.XPath("(//*[@name = 'ExistingTeam_selectCheck'])[1]");
        By chk_EmployeeSelect1 => By.XPath("(//tr[not(contains(@class,'selected'))]/td/input[@name='TeamLeader_selectCheck'])[1]");
        By chk_EmployeeSelect10 => By.XPath("(//tr[not(contains(@class,'selected'))]/td/input[@name='TeamLeader_selectCheck'])[2]");
        By btn_TeamSave => By.XPath("//*[@id = 'btnTeamSave']");
        By btn_CloseMinuteBox => By.XPath("//span[@class='close_button_popup']");
        By txt_AgendaTopic => By.XPath("//input[@name='sTopic']");
        By txt_AgendaDescription => By.XPath("//input[@name='sDesc']");
        By txt_AgendaFrmTime => By.XPath("//input[@name='FromTime']");
        By txt_AgendaToTime => By.XPath("//input[@name='ToTime']");
        By tbl_AgendaFromTime => By.XPath("//span[@id='timePickerContent']//td[text()='01:15am']");
        By tbl_AgendaToTime => By.XPath("//span[@id='timePickerContent']//td[text()='02:15am']");
        By tbl_AgendaUsericon => By.XPath("//span[@id='imgrep']");
        By chk_AgendaUser => By.XPath("(//input[@name='userListingGridControl_selectCheck'])[1]");
        By btn_UserDone => By.XPath("//button[contains(text(), 'Done')]");
        By txt_AgendaDate => By.XPath("//input[@name='sDate']");
        By lbl_TitleAgenda => By.XPath("//div[@id='headingMeetingagenda']");
        By chk_Meeting1 => By.XPath("(//input[@name='meetinitial_selectCheck'])[1]");

        // ***************TC11 Xpaths********************** //
        By txtEntityName => By.XPath("//input[@id='tblEntityName']");
        By svgAddContactPersonIcon => By.XPath("//*[local-name()='svg' and @data-icon='user-plus']");
        By tbl_GeoLocationOwers => By.XPath("(//div[@id='divMultiSelectTree'])[1]");
        By imgPlusIcon_EntityPage => By.XPath("//img[@id='plusimg3']");
        By lblDeleteRightClick_EntityPage => By.XPath("//ul[@id='contextmenu']//li[@id='liDelete']");
        By ddlHighlightedCountry => By.XPath("//li[contains(@class,'option--highlighted')]");
        By btnDelete_Country => By.XPath("//button[@id='btnDeleteCountry']");
        By lblTeamSortAscending => By.XPath("(//th[@aria-sort='ascending'])[1]");
        By lblUsers => By.XPath("(//div[@class='sub-menu']//span[contains(text(),'Users')])[1]");
        By txtEmpCode => By.XPath("(//input[@id='txtcode'])[1]");
        By txtFirstName => By.XPath("(//input[@id='txtfirstname'])[1]");
        By txtLastName => By.XPath("(//input[@id='txtlastname'])[1]");
        By txtEmail => By.XPath("(//input[@id='txtbusinessmail'])[1]");
        By txtUsername => By.XPath("(//input[@id='txtusername'])[1]");
        By lblCountryRegion => By.XPath("(//label[@for='Country_Region'])[1]");
        By txtPassword => By.XPath("(//input[@id='txtpassword'])[1]");
        By txtConfirmPassword => By.XPath("(//input[@id='txtconfirmpassword'])[1]");
        By chkChangePasswordNextLogOn => By.XPath("(//label[@for='Changelogin'])[1]");
        By ddlCode_MultiSearch => By.XPath("(//div[@class='dtsb-criteria']//select//option[contains(text(),'Code')])[1]");
        By lblSite => By.XPath("(//label[@for='Site'])[1]");
        By txt_Date => By.Id("datepicker_dtpDate");
        By txt_ManufacturerName => By.Id("txtSupplierName");
        By txt_ManufacturerCode => By.Id("txtSupplierCode");
        By txt_ContactPersonMail => By.Id("txtCPMaId");
        By txt_ManufactureAddress => By.Id("txtAddress");
        By ddp_Supplier => By.XPath("//span[@id='select2-cmbCategory-container']");
        By ddl_Supplier => By.XPath("(//span[contains(text(), 'Trader')])[2]");
        By txt_ContactPersonName => By.Id("txtContactPersonname");
        By txt_ContactPersonNo => By.Id("txtCPMNo");
        By ddp_Route => By.XPath("//span[@id='select2-cmbRoute-container']");
        By ddl_Route => By.XPath("(//span[contains(text(), 'Module Auto approval')])[2]");
        By txt_Material => By.Id("txtMaterial");
        By txt_NaturofPropsed => By.Id("txtNaturofPropsed");
        By txt_AssessmentDate => By.Id("datepicker_dtpAssessmentDate");
        By txt_ActualDate => By.XPath("//input[@id='datepicker_dtpActualDate']");
        By txt_BuyerName => By.Id("txtBuyerNames");
        By txt_BuyerMailId => By.Id("txtBuyerMailid");
        By ddp_tdPreparedBy => By.XPath("(//div[@id='tdPreparedBy']//following::span[@title='Select User'])[1]");
        By ddp_tdPreparedBy2 => By.XPath("(//div[@id='tdPreparedBy']//following::span[@title='Select User'])[2]");
        By ddp_tdPreparedBy3 => By.XPath("(//div[@id='tdPreparedBy']//following::span[@title='Select User'])[3]");
        By ddp_tdPreparedBy4 => By.XPath("(//div[@id='tdPreparedBy']//following::span[@title='Select User'])[4]");
        By ddp_SupplierSearchDropdown => By.Id("filtercolumn_SuSupplierGridViewControl");
        By ddl_SupplierSearchDropdown => By.XPath("//select[@id='filtercolumn_SuSupplierGridViewControl']//following::option[@value='Name']");
        By lnkForgotPassword => By.XPath("//a[@onclick='ValidatePasswordDialog()']");
        By txtUsername_ForgotPwd => By.XPath("//input[@id='fgtUsername']");
        By txtEmpCode_ForgotPwd => By.XPath("//input[@id='fgtEmpcode']");
        By txtEmail_ForgotPwd => By.XPath("//input[@id='fgEmail']");
        By btnValidateUser_ForgotPwd => By.XPath("//button[@onclick='ValidateUser()']");
        By txtNewPwd_ForgotPwd => By.XPath("//input[@id='fgtNewPswd']");
        By txtCnfrmNewPwd_ForgotPwd => By.XPath("//input[@id='fgtCnfmNewPswd']");
        By btnSubmit_ForgotPwd => By.XPath("//button[@onclick='ResetPassword()']");
        By msgPwdSavedSuccess => By.XPath("//div[contains(@Class,'alert-success')]");
        By btnLogin => By.XPath("(//button[@type='button'])[2]");
        By txtEmailLogin => By.XPath("//input[@id='txtUsername']");
        By txtPasswordLogin => By.XPath("//input[@id='txtPassword']");

        // ***************TC17 Xpaths********************** //
        By btn_AddGroup => By.XPath("//button[@id='btn_add_hold']");
        By inp_GroupName => By.XPath("//input[@id='0_groupname']");
        By btn_SaveGroup => By.XPath("//button[@id='btnSaveDetails_SuGroupsGridViewControl']");
        By lbl_FirstGroupElement => By.XPath("//tbody/tr[@role='row']");
        By svg_AddUserIcon => By.XPath("//*[local-name()='svg' and contains(@onclick,'LoadUserDetailPopup')]");
        By chk_firstUser => By.XPath("(//table[@id='userListingGridControl']//th[@class]//following::input[@name='userListingGridControl_selectCheck'])[1]");
        By btn_SaveUser => By.XPath("//button[@title='Save']");
        By lbl_UserAddedSuccessMessage => By.XPath("//div[contains(text(),'Saved successfully')]");
        By btn_closeMessage => By.XPath("//a[@id='alert_ok']");
        By svg_AddedUserIcon => By.XPath("//*[local-name()='svg'and contains(@data-icon,'eye')]");
        By chk_firstGroup => By.XPath("//input[contains(@id,'Chk')]");
        By chk_firstGroupDelete => By.XPath("//table[@id='SuGrpsUserGridViewControl']//input[contains(@id,'Chk')]");
        By phd_GroupName => By.XPath("//input[@name='groupname']");
        By lbl_UpdatedSuccessMessage => By.XPath("//div[contains(text(),' : Updated Successfully')]");
        By ddp_Module => By.XPath("//span[@id='select2-ddl_Module-container'][1]");
        By ddl_ModuleDocpro => By.XPath(" //li[@role='treeitem']//span[contains(text(),'Document Pro')]");
        By ddp_ModuleSearch => By.XPath("(//select[@id='filtercolumn_SuAdminGridViewControl'])[1]");
        By ddl_ModuleSearchUserName => By.XPath("(//select[@id='filtercolumn_SuAdminGridViewControl'])[1]//option[@value='Fullname'][1]");
        By txtSessionTimeOut => By.XPath("//input[@id='txtSessionTimeOut']");
        By txtPageSize => By.XPath("//input[@id='txtPageSize']");
        By imgDateArrowDown => By.XPath("(//select[contains(@id,'CmbDateFormat')])[1]");
        By ddl_DD_DateFormat => By.XPath("(//select[contains(@id,'CmbDateFormat')])[1]//option[@value='DD']");
        By imgMonthArrowDown => By.XPath("(//select[contains(@id,'CmbDateFormat')])[2]");
        By ddl_MM_DateFormat => By.XPath("(//select[contains(@id,'CmbDateFormat')])[2]//option[@value='MM']");
        By lblSavedSuccessfully => By.XPath("//div[contains(@class,'alert-success')]");

        // ***************TC19 Xpaths********************** //
        By drp_UnlockUserSearch => By.XPath("//select[contains(@id,'UnlockUsersListing')]");
        By ddlUsername_UnlockUser => By.XPath("//select[contains(@id,'UnlockUsersListing')]//option[@value='username']");
        By btn_UnlockUsers => By.XPath("//button[@title='Unlock Users']");
        By lbl_NoRecords => By.XPath("//tr//td[contains(text(),'no records')]");
        By changeUserNamePwd_Tab => By.XPath("//a[@title='Change Username & Password']//span[@class='tab-title']");
        By txtNewPassword_Preferences => By.Id("txtNewPassword");
        By txtConfirmPassword_Preferences => By.Id("txtConfirmPassword");
        By chkChangeLoginPwdActive_Preferences => By.XPath("//input[@id='EnableLoginPW' and @checked='checked']");
        By btnSave_Preferences => By.XPath("(//button[@title='Save'])[2]");
        By lblPreferences => By.XPath("(//ul[@class='inner_submenu']//a[@title='Preferences']//span[contains(text(),'Preferences')])[2]");


        #endregion

        #region Iframe
        static By iframe_DetailView => By.XPath("//iframe[@name='Detailview']");
        static By iframe_Tree => By.XPath("//iframe[@id='iframeTree']");
        static By iframe_ifrUsers => By.XPath("//iframe[@id='ifrUsers']");
        static By iframe_ifrAlbum => By.XPath("(//iframe[@id='ifrAlbum'])[1]");
        static By iframe => By.XPath("//iframe[contains(@class,'cke_reset')]");
        static By iframe_MenuData => By.XPath("//iframe[@id='MenuData']");

        #endregion

        #region pageActions

        /// <summary>
        /// Upon reaching the Licensed Candidates screen, verify the presence of the "Licensed Candidates" text on that page.
        /// </summary>
        public void VerifyLicensedCandidatesPage()
        {
            Assert.IsTrue(seleniumActions.IsElementPresent(lblHeader));
        }

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
                //seleniumActions.Click(lblLevelsPage);
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
            //seleniumActions.Click("txt");
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
            seleniumActions.SendKeys(inp_Levelname, Constants.Level); ;
            seleniumActions.Click(btn_save);
            //seleniumActions.VerifyElementIsDisplayed(By.XPath("//h5[contains(text(),'Level - "+Constants.Level+""));
            seleniumActions.SwitchToDefaultContent();
            return Constants.Level;
            //(//table[@class='Tbltitle']//ul[@id='TOCDoclvl']//a[contains(@title,'AAA')]//following::*[local-name()='svg' and contains(@class,'pencil')])[1]
        }

        public void DeleteLevelByHovering(String LevelName)
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Click(btn_refreshLevel);
            seleniumActions.MoveToElement(By.XPath("//table[@class='Tbltitle']//ul[@id='TOCDoclvl']//a[contains(@title,'" + LevelName + "')]"));
            seleniumActions.Click(By.XPath("(//table[@class='Tbltitle']//ul[@id='TOCDoclvl']//a[contains(@title,'" + LevelName + "')]//following::*[local-name()='svg' and contains(@class,'trash')])[1]"));
            seleniumActions.Click(popUp_Yes);
        }

        /// <summary>
        /// This method help us to navigate into teams page inside the system
        /// </summary>
        public void NavigateToSystemPage(String SubHead)
        {
            if (seleniumActions.IsElementPresent(sideMenuContainer))
            {
                seleniumActions.Wait(5);
                seleniumActions.Click(lblSetup);
                seleniumActions.Click(lblSystem);
                seleniumActions.Wait(2);
                seleniumActions.ScrollToElement(By.XPath("(//a[@class='submenu_list_link has-arrow']//following-sibling::ul[@class='inner_submenu']//span[contains(text(),'" + SubHead + "')])[2]"));
                seleniumActions.Click(By.XPath("(//a[@class='submenu_list_link has-arrow']//following-sibling::ul[@class='inner_submenu']//span[contains(text(),'" + SubHead + "')])[2]"));
            }
        }

        // ***************** Start of TC 02 ************ //

        /// <summary>
        /// Clicks add button and creates a new tag
        /// </summary>
        /// <returns> Tag name </returns>
        public string ClickAddButtonAndCreateNewTag()
        {
            string tagName = Constants.TagName + utility.CurrentTime();
            seleniumActions.SwitchToIframes(iframe_DetailView);
            Assert.IsTrue(seleniumActions.IsElementPresent(btnAdd_MasterFolderTags));
            seleniumActions.Click(btnAdd_MasterFolderTags);
            Assert.IsTrue(seleniumActions.IsElementPresent(tblAddPopup));
            seleniumActions.SendKeys(phd_TagName, tagName);
            seleniumActions.Click(btnSave_TagPopup);
            return tagName;
        }

        /// <summary>
        /// Click pencil icon and rename the existing tagname
        /// </summary>
        public void RenameTagName(string tagName)
        {
            seleniumActions.Wait(2);
            string updatedTag = "Updated " + tagName;
            Assert.IsTrue(seleniumActions.IsElementPresent(lblTag));
            seleniumActions.Click(hintSearch);
            seleniumActions.SendKeys(hintSearch, tagName);
            seleniumActions.Wait(2);
            seleniumActions.Click(chkTagname_Inactive);
            seleniumActions.Wait(2);
            seleniumActions.Click(btnPencilIcon);
            seleniumActions.SendKeys(phd_TagName, Keys.Clear);
            seleniumActions.SendKeys(phd_TagName, updatedTag);
            seleniumActions.Click(btnSave_TagPopup);
            seleniumActions.Wait(4);

            string newTag = seleniumActions.GetText(By.XPath("//tbody//tr[@role='row']//td[contains(text(),'" + updatedTag + "')]"));
            seleniumActions.Wait(3);
            Assert.IsTrue(newTag.Contains("Updated"));
        }

        /// <summary>
        /// Delete the newly created Tag 
        /// </summary>
        public void DeleteTag()
        {
            seleniumActions.Wait(3);
            seleniumActions.Click(chkTagname_Inactive);
            seleniumActions.Click(btn_DeleteTag);
            seleniumActions.Click(btnYes_Popup);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblDeletedSuccessMessage));
            seleniumActions.SwitchToDefaultContent();
        }

        // ***************** End of TC 02 ************ //

        // ***************** Start of TC 09 ************ //

        /// <summary>
        /// Create team in teams page under System page
        /// </summary>
        public string CreateTeam()
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Wait(4);
            Assert.IsTrue(seleniumActions.IsElementPresent(btnNew_TeamsPage));
            seleniumActions.Click(btnNew_TeamsPage);
            seleniumActions.WaitForElementToExists(btnSelectTeamLeader);
            Assert.IsTrue(seleniumActions.IsElementPresent(btnSelectTeamLeader));
            seleniumActions.Click(btnSelectTeamLeader);

            seleniumActions.SwitchToIframes(iframe_ifrUsers);
            Assert.IsTrue(seleniumActions.IsElementPresent(rdoUserBasedSearchChecked));
            seleniumActions.Click(phd_Name);
            seleniumActions.SendKeys(phd_Name, "Right");
            seleniumActions.Wait(3);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblTeamLeader_SearchResult));
            Assert.IsTrue(seleniumActions.GetText(lblTeamLeader_SearchResult).Equals(Constants.RightUsername));
            seleniumActions.Click(chkTeamLeaderInactive);

            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Click(btn_Done);
            string teamName = Constants.Name + utility.CurrentTime();
            seleniumActions.Click(txtTeamName);
            seleniumActions.SendKeys(txtTeamName, teamName);
            seleniumActions.Click(lblTeamLeader);
            Assert.IsTrue(seleniumActions.IsElementPresent(btnAdd_TeamsPage));
            seleniumActions.Click(btnAdd_TeamsPage);
            seleniumActions.Click(txtExternalMemberName);
            seleniumActions.SendKeys(txtExternalMemberName, Constants.Name);
            seleniumActions.Click(txtExternalMemberMail);
            seleniumActions.SendKeys(txtExternalMemberMail, Constants.TagName + utility.CurrentTime() + "@gmail.com");
            seleniumActions.Click(btnAddMembers_TeamsPage);

            seleniumActions.SwitchToIframes(iframe_ifrUsers);
            Assert.IsTrue(seleniumActions.IsElementPresent(rdoUserBasedSearchChecked));
            seleniumActions.Click(phd_Name);
            seleniumActions.SendKeys(phd_Name, "Administrator");
            seleniumActions.Wait(3);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblTeamLeader_SearchResult));
            Assert.IsTrue(seleniumActions.GetText(lblTeamLeader_SearchResult).Contains(Constants.AdminUsername));
            seleniumActions.Click(chkTeamLeaderInactive);
            seleniumActions.Click(chkTeamLeaderActive);
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Click(btn_Done);
            return teamName;
        }

        /// <summary>
        /// Verify the newly created team is showing in the teams list
        /// </summary>
        public void VerifyTeamIsCreated(string teamName)
        {
            seleniumActions.ScrollToElement(btnClose_TeamsPage);
            seleniumActions.Click(btnClose_TeamsPage);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblAddedTeam));
            Assert.IsTrue(seleniumActions.IsElementPresent(lblTeamSortAscending));
            seleniumActions.Click(lblTeamSortAscending);
            seleniumActions.Wait(3);
            Assert.IsTrue(seleniumActions.GetText(lblAddedTeam).Equals(teamName));
        }

        /// <summary>
        /// Delete the newly created team and verify the alert message
        /// </summary>
        public void VerifyTeamIsDeleted()
        {
            seleniumActions.Click(chkTeamInactive);
            seleniumActions.Click(btnDelete_TeamsPage);
            seleniumActions.Click(btnYes_Popup);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblDeletedSuccessMessage));
            seleniumActions.SwitchToDefaultContent();
        }

        // ***************** End of TC 09 ************ //

        // ***************** Start of TC 03 ************ //

        /// <summary>
        /// Clicks add button and creates a new State
        /// </summary>
        public void ClickAddButtonAndCreateNewState(String Country, String State)
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.IsElementPresent(drpCountry);
            seleniumActions.Click(drpCountry);
            seleniumActions.Wait(3);
            seleniumActions.SendKeys(txtSearchCountry, Country + Keys.Enter);
            seleniumActions.WaitForElementToExists(btnAddState);
            seleniumActions.Click(btnAddState);
            seleniumActions.SendKeys(txtState, State);
            seleniumActions.Click(btnSave);
            seleniumActions.VerifyElementIsDisplayed(msgSaveSuccessfully);
            seleniumActions.Wait(3);
            seleniumActions.NavigateBack();
            seleniumActions.Refresh();
        }

        /// <summary>
        /// Validate the recently created State from State page
        /// </summary>
        public void ValidateStateCreation(String Country, String State)
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.IsElementPresent(drpCountry);
            seleniumActions.Click(drpCountry);
            seleniumActions.SendKeys(txtSearchCountry, Country + Keys.Enter);
            seleniumActions.Wait(3);
            string Statename = seleniumActions.GetText(lblStateName);
            Assert.IsTrue(Statename.Equals("Kerala"));
        }

        /// <summary>
        /// Delete the recently created state
        /// </summary>
        public void DeleteState()
        {
            seleniumActions.Wait(3);
            seleniumActions.Click(chkState);
            seleniumActions.Click(btnDelete);
            seleniumActions.Click(btnYes_Popup);
            seleniumActions.SwitchToDefaultContent();
        }

        // ***************** End of TC 03 ************ //

        // ***************** Start of TC 04 ************ //

        /// <summary>
        /// Clicks new button and creates a new shift
        /// </summary>
        public void CreateNewShift()
        {
            string shiftName = Constants.shiftName + utility.CurrentTime();
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Wait(3);
            seleniumActions.Click(btnNew);
            seleniumActions.SendKeys(inp_ShiftName, shiftName);
            seleniumActions.Click(dtp_FromTime);
            seleniumActions.Click(tbl_FromTime);
            seleniumActions.Click(dtp_ToTime);
            seleniumActions.Click(tbl_ToTime);
            seleniumActions.Click(btn_Save);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblSuccess_Message));
            seleniumActions.Click(btnClose_SuccessMessage);
            seleniumActions.Click(hintSearch);
            seleniumActions.SendKeys(hintSearch, shiftName);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblFirstRow_ElementPresent));
        }

        /// <summary>
        ///  Delete the newly created shift 
        /// </summary>
        public void DeleteShift()
        {
            seleniumActions.Click(chk_FirstRowInActive);
            seleniumActions.Click(btnDelete);
            seleniumActions.Click(btnYes_Popup);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblDeletedSuccessMessage));
        }

        // ***************** End of TC 04 ************ //

        // ***************** Start of TC 08 ************ //

        /// <summary>
        /// Creates customer by giving cust name and cust code
        /// </summary>
        public string CreateCustomer()
        {
            string custName = Constants.TagName + utility.CurrentTime();
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Click(btnNew_CustomersPage);
            Assert.IsTrue(seleniumActions.IsElementPresent(txtCustName));
            seleniumActions.Click(txtCustName);
            seleniumActions.SendKeys(txtCustName, custName);
            Assert.IsTrue(seleniumActions.IsElementPresent(txtCodeName));
            seleniumActions.Click(txtCodeName);
            seleniumActions.SendKeys(txtCodeName, "T - " + utility.CurrentTime());
            seleniumActions.Click(txtCustName);
            seleniumActions.WaitForElementToExists(btnAdd_MasterFolderTags);
            return custName;
        }

        /// <summary>
        /// Adds address of the newly created user / customer / supplier / vendor
        /// </summary>
        public void AddAddress()
        {
            seleniumActions.Click(btnAdd_MasterFolderTags);
            Assert.IsTrue(seleniumActions.IsElementPresent(tblAddAddress));
            seleniumActions.Click(txtStreet);
            seleniumActions.SendKeys(txtStreet, "Street");
            seleniumActions.Click(drpCountry_AddAddress);
            seleniumActions.ScrollToElement(ddlIndia_AddAddress);
            seleniumActions.Click(ddlIndia_AddAddress);
            seleniumActions.Click(drpState_AddAddress);
            seleniumActions.Click(ddlTamilnadu_AddAddress);
            seleniumActions.Click(drpCity_AddAddress);
            seleniumActions.Click(ddlChennai_AddAddress);
            seleniumActions.Click(txtZipCode_AddAddress);
            seleniumActions.SendKeys(txtZipCode_AddAddress, "600012");
            seleniumActions.Click(btnSave_AddAddress);
            Assert.IsTrue(seleniumActions.IsElementPresent(msgSaveSuccessfully));
            Assert.IsTrue(seleniumActions.IsElementPresent(lblIndia_SavedAddress));
        }

        /// <summary>
        /// Adds contact of the newly created user / customer / supplier / vendor
        /// </summary>
        public void AddContact()
        {
            Assert.IsTrue(seleniumActions.IsElementPresent(svgContactIcon));
            seleniumActions.Click(svgContactIcon);
            seleniumActions.WaitForElementToExists(lblContact);
            seleniumActions.Click(btnAdd_AddContact);
            seleniumActions.Click(txtFirstName_AddContact);
            seleniumActions.SendKeys(txtFirstName_AddContact, Constants.Name);
            seleniumActions.Click(txtLastName_AddContact);
            seleniumActions.SendKeys(txtLastName_AddContact, Constants.Name);
            seleniumActions.Click(txtEmail_AddContact);
            seleniumActions.SendKeys(txtEmail_AddContact, "Test" + utility.CurrentTime() + "@gmail.com");
            seleniumActions.Click(btnSave_AddContact);
            Assert.IsTrue(seleniumActions.IsElementPresent(msgSaveSuccessfully));
        }

        /// <summary>
        /// Refresh the page
        /// </summary>
        public void Refresh()
        {
            seleniumActions.Refresh();
            seleniumActions.Wait(3);
        }

        /// <summary>
        /// Changes the record size to '100'
        /// </summary>
        public void ChangePageRecordSize()
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.WaitForElementToExists(drpPageSize);
            seleniumActions.Click(drpPageSize);
            seleniumActions.WaitForElementToExists(ddlValue_Hundred);
            seleniumActions.Click(ddlValue_Hundred);
        }

        /// <summary>
        /// Deletes the customer form the records
        /// </summary>
        public void DeleteCustomerFromTheRecords(string custName)
        {
            Assert.IsTrue(seleniumActions.IsElementPresent(btnMultiSearch));
            seleniumActions.Click(btnMultiSearch);
            Assert.IsTrue(seleniumActions.IsElementPresent(drpColumn_MultiSearch));
            seleniumActions.Click(drpColumn_MultiSearch);
            seleniumActions.Click(ddlCustomerName_MultiSearch);
            seleniumActions.Click(drpCondition_MultiSearch);
            seleniumActions.Click(ddlContains_MultiSearch);
            seleniumActions.Click(inp_MultiSearch);
            seleniumActions.SendKeys(inp_MultiSearch, custName);
            seleniumActions.Click(btnAdvancedSearch_MultiSearch);
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.WaitForElementToExists(lblFirstRow_ElementPresent);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblFirstRow_ElementPresent));
            seleniumActions.Click(chk_FirstRowInActive);
            seleniumActions.Click(btnDelete);
            seleniumActions.Click(btnYes_Popup);
            seleniumActions.Wait(5);
            seleniumActions.Click(btnYes_Popup);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblDeletedSuccessMessage));
            seleniumActions.SwitchToDefaultContent();
        }

        // ***************** End of TC 08 ************ //

        // ***************** Start of TC 13 ************ //

        /// <summary>
        /// Clicks new button and creates a new country
        /// </summary>
        public void CreateNewCountry()
        {
            string countryName = Constants.countryName + utility.CurrentTime();
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Wait(3);
            seleniumActions.Click(btnNew);
            seleniumActions.Click(inp_CountryName);
            seleniumActions.SendKeys(inp_CountryName, countryName);
            seleniumActions.Click(btn_Save);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblSuccess_Message));
            seleniumActions.Click(btnClose_SuccessMessage);
            seleniumActions.Click(hintSearch);
            seleniumActions.SendKeys(hintSearch, countryName);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblFirstRow_ElementPresent));
        }

        /// <summary>
        ///  Delete the newly created country 
        /// </summary>
        public void DeleteCountry()
        {
            seleniumActions.Click(chk_FirstRowInActive);
            seleniumActions.Click(btnDelete);
            seleniumActions.Click(btnYes_Popup);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblDeletedSuccessMessage));
        }

        // ***************** End of TC 13 ************ //

        // ***************** Start of TC 07 ************ //

        /// <summary>
        /// Creates manufacturer by giving manufacturer name and manufacturer code
        /// </summary>
        public string CreateManufacturer()
        {
            string custName = Constants.TagName + utility.CurrentTime();
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Click(btnNew_CustomersPage);
            Assert.IsTrue(seleniumActions.IsElementPresent(txtCustName));
            seleniumActions.Click(txtCustName);
            seleniumActions.SendKeys(txtCustName, custName);
            Assert.IsTrue(seleniumActions.IsElementPresent(txtCodeName));
            seleniumActions.Click(txtCodeName);
            seleniumActions.SendKeys(txtCodeName, "T - " + utility.CurrentTime());
            seleniumActions.Click(chk_PreferredManufacturer);
            seleniumActions.Click(txtCustName);
            seleniumActions.WaitForElementToExists(btnAdd_MasterFolderTags);
            return custName;
        }

        /// <summary>
        /// Deletes the manufacturer form the records
        /// </summary>
        public void DeleteManufacturerFromTheRecords(string custName)
        {
            Assert.IsTrue(seleniumActions.IsElementPresent(btnMultiSearch));
            seleniumActions.Click(btnMultiSearch);
            Assert.IsTrue(seleniumActions.IsElementPresent(drpColumn_MultiSearch));
            seleniumActions.Click(drpColumn_MultiSearch);
            seleniumActions.Click(ddlManufacturerName_MultiSearch);
            seleniumActions.Click(drpCondition_MultiSearch);
            seleniumActions.Click(ddlContains_MultiSearch);
            seleniumActions.Click(inp_MultiSearch);
            seleniumActions.SendKeys(inp_MultiSearch, custName);
            seleniumActions.Click(btnAdvancedSearch_MultiSearch);
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.WaitForElementToExists(lblFirstRow_ElementPresent);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblFirstRow_ElementPresent));
            seleniumActions.Click(chk_FirstRowInActive);
            seleniumActions.Click(btnDelete);
            seleniumActions.Click(btnYes_Popup);
            seleniumActions.Wait(5);
            seleniumActions.Click(btnYes_Popup);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblDeletedSuccessMessage));
            seleniumActions.SwitchToDefaultContent();
        }

        // ***************** End of TC 07 ************ //

        //  ***************** Start of TC 01 ********* //

        /// <summary>
        ///  Logout the appliaction
        /// </summary>
        public void LogoutApplication()
        {
            seleniumActions.Click(btnUserIconProfile);
            //seleniumActions.Wait(5);
            seleniumActions.Click(btnLogout);
            seleniumActions.Click(btnYes_Popup);
        }

        /// <summary>
        /// Validate the remember me functionality
        /// </summary>
        public void ValidateTheRememberme()
        {
            seleniumActions.IsElementPresent(lblRememberme);
            Assert.IsTrue(seleniumActions.GetText(lblRememberme).Equals("Remember me"));
        }

        //  ***************** End of TC 01 ********* //

        // ***************** Start of TC 05 ************ //

        /// <summary>
        /// Creates vendor by giving vendor name and vendor code
        /// </summary>
        public string CreateVendor()
        {
            string vendorName = Constants.vendorName + utility.CurrentTime();
            string vendorCode = Constants.vendorCode + utility.CurrentTime();
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Wait(3);
            seleniumActions.Click(btnNew);
            seleniumActions.Click(inp_VendorName);
            seleniumActions.SendKeys(inp_VendorName, vendorName);
            seleniumActions.Click(inp_VendorCode);
            seleniumActions.SendKeys(inp_VendorCode, vendorCode);
            seleniumActions.Click(chk_PreferredVendor);
            return vendorName;
        }

        /// <summary>
        ///  Delete the newly created vendor 
        /// </summary>
        public void DeleteVendor(string vendorName)
        {
            Assert.IsTrue(seleniumActions.IsElementPresent(btnMultiSearch));
            seleniumActions.Click(btnMultiSearch);
            Assert.IsTrue(seleniumActions.IsElementPresent(drpColumn_MultiSearch), "Multi Search field is not available");
            seleniumActions.Click(drpColumn_MultiSearch);
            seleniumActions.Click(ddl_VendorNameMultiSearch);
            seleniumActions.Click(drpCondition_MultiSearch);
            seleniumActions.Click(ddlContains_MultiSearch);
            seleniumActions.Click(inp_MultiSearch);
            seleniumActions.SendKeys(inp_MultiSearch, vendorName);
            seleniumActions.Click(btnAdvancedSearch_MultiSearch);
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.WaitForElementToExists(lblFirstRow_ElementPresent);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblFirstRow_ElementPresent));
            seleniumActions.Click(chk_FirstRowInActive);
            seleniumActions.Click(btnDelete);
            seleniumActions.Click(btnYes_Popup);
            seleniumActions.Wait(5);
            seleniumActions.Click(btnYes_Popup);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblDeletedSuccessMessage));
            seleniumActions.SwitchToDefaultContent();

        }

        // ***************** End of TC 05 ************ //

        // ***************** Starts of TC 21 ************ //

        /// <summary>
        ///  Update Organization details update
        /// </summary>
        public void OrganizationDetailsUpdate()
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Click(btn_CompanyLogoLarge);
            seleniumActions.SwitchToFrame(iframe_ifrAlbum);
            Assert.IsTrue(seleniumActions.IsElementPresent(btn_ChooseFile), "Choose file button is not available");
            var path = new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath;
            var actualPath = path.Substring(0, path.LastIndexOf("bin"));
            var projectPath = new Uri(actualPath).LocalPath;
            seleniumActions.SendKeys(btn_ChooseFile, projectPath.ToString() + "\\Data\\Big_ClientLogo_Omnex.png");
            seleniumActions.Click(btn_DoneFile);
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Click(btn_CompanyLogomedium);
            seleniumActions.SwitchToFrame(iframe_ifrAlbum);
            Assert.IsTrue(seleniumActions.IsElementPresent(btn_ChooseFile), "Choose file button is not available");
            seleniumActions.SendKeys(btn_ChooseFile, projectPath.ToString() + "\\Data\\small_ClientLogo_Omnex.png");
            seleniumActions.Click(btn_DoneFile);
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Click(btn_ProductLogo);
            seleniumActions.SwitchToFrame(iframe_ifrAlbum);
            Assert.IsTrue(seleniumActions.IsElementPresent(btn_ChooseFile), "Choose file button is not available");
            seleniumActions.SendKeys(btn_ChooseFile, projectPath.ToString() + "\\Data\\EWQIMS-Logo.png");
            seleniumActions.Click(btn_DoneFile);
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Click(btn_Save);
            Assert.IsTrue(seleniumActions.IsElementPresent(msgSaveSuccessfully));
            seleniumActions.SwitchToDefaultContent();

        }

        // ***************** End of TC 21 ************ //

        // ***************** Start of TC 11 ************ //

        /// <summary>
        /// Creates position by giving position name and description
        /// </summary>
        public string CreatePosition(string site)
        {
            string position = Constants.position + utility.CurrentTime();
            string description = Constants.description + utility.CurrentTime();
            if (site != "Corporate")
            {
                seleniumActions.SwitchToIframes(iframe_DetailView);
                seleniumActions.Click(drp_Site);
                seleniumActions.Click(inp_RightSite);
                seleniumActions.Wait(3);
                seleniumActions.SwitchToDefaultContent();
            }
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Wait(3);
            seleniumActions.Click(btn_Add);
            seleniumActions.Wait(3);
            seleniumActions.Click(inp_Position);
            seleniumActions.SendKeys(inp_Position, position);
            seleniumActions.Click(inp_Description);
            seleniumActions.SendKeys(inp_Description, description);
            seleniumActions.Click(btn_SaveForPosition);
            seleniumActions.SwitchToDefaultContent();
            return position;
        }

        /// <summary>
        /// Verify the position is created or not
        /// </summary>
        public void VerifyPosition(string position)
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblSuccess_Message));
            seleniumActions.Click(btnClose_SuccessMessage);
            seleniumActions.Click(hintSearch);
            seleniumActions.SendKeys(hintSearch, position);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblFirstRow_ElementPresent));
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Delete the created position
        /// </summary>
        public void DeletePosition()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Wait(5);
            seleniumActions.Click(chk_FirstRowInActive);
            seleniumActions.Click(btnDelete);
            seleniumActions.Click(btnYes_Popup);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblDeletedSuccessMessage));
            seleniumActions.SwitchToDefaultContent();
        }

        // ***************** End of TC 11 ************ //

        // ****************** Starts of TC 22 ********* //

        /// <summary>
        /// Update and Validate Datas from Admin Setting
        /// </summary>
        public void updateAndValidateAdminSetting()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Click(drp_PaswordFormat);
            seleniumActions.SendKeys(ddl_PaswordOption, Keys.Clear);
            seleniumActions.SendKeys(ddl_PaswordOption, "Alphanumeric");
            seleniumActions.SendKeys(txt_PasswordLength, Keys.Clear);
            seleniumActions.SendKeys(txt_PasswordLength, "2");
            string fcDefaultValue = seleniumActions.GetText(drp_FirstCombobox);
            string lcDefaultValue = seleniumActions.GetText(drp_LastCombobox);

            if (fcDefaultValue == "First Name")
            {

                seleniumActions.Click(drp_FirstCombobox);
                seleniumActions.Click(ddl_FCLasttName);
                seleniumActions.Click(drp_SecondCombobox);
                seleniumActions.Click(drp_ThirdCombobox);
                seleniumActions.Click(drp_FoutrhCombobox);


                if (lcDefaultValue == "Last Name")
                {
                    seleniumActions.Click(drp_LastCombobox);
                    seleniumActions.Click(ddl_LCFirstName);
                    seleniumActions.Click(btn_Save);
                    Assert.IsTrue(seleniumActions.IsElementPresent(lblSuccess_Message), "Success smessage not display");

                }
            }
            else if (fcDefaultValue == "Last Name")
            {
                seleniumActions.Click(drp_FirstCombobox);
                seleniumActions.Click(ddl_FCFirstName);
                seleniumActions.Click(drp_SecondCombobox);
                seleniumActions.Click(drp_ThirdCombobox);
                seleniumActions.Click(drp_FoutrhCombobox);


                if (lcDefaultValue == "First Name")
                {
                    seleniumActions.Click(drp_LastCombobox);
                    seleniumActions.Click(ddl_LCLastName);
                    seleniumActions.Click(btn_Save);
                    Assert.IsTrue(seleniumActions.IsElementPresent(lblSuccess_Message), "Success smessage not display");
                }

            }
            seleniumActions.SwitchToDefaultContent();

        }

        // ****************** End of TC 22 ********* //

        // ************** Start Of TC 20 ***************** //
        /// <summary>
        /// Creates city by giving country, state and city name
        /// </summary>
        public void CreateCity(string country, string city)
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.IsElementPresent(drpCountry);
            seleniumActions.Click(drpCountry);
            seleniumActions.Wait(3);
            seleniumActions.SendKeys(inp_CountrySearch, country + Keys.Enter);
            seleniumActions.Click(btnNew);
            seleniumActions.Click(txt_City);
            seleniumActions.SendKeys(txt_City, city);
            seleniumActions.Click(btnSave);
            seleniumActions.VerifyElementIsDisplayed(msgSaveSuccessfully);
            seleniumActions.Wait(3);
            seleniumActions.NavigateBack();
            seleniumActions.Refresh();

        }

        /// <summary>
        /// Verify the city is created or not
        /// </summary>
        public void VerifyCity(string country, string city)
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.IsElementPresent(drpCountry);
            seleniumActions.Click(drpCountry);
            seleniumActions.SendKeys(inp_CountrySearch, country + Keys.Enter);
            seleniumActions.Wait(3);
            seleniumActions.Click(hintSearch);
            seleniumActions.SendKeys(hintSearch, city);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblFirstRow_ElementPresent));
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Delete the created city
        /// </summary>
        public void DeleteCity()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Wait(5);
            seleniumActions.Click(chk_FirstRowInActive);
            seleniumActions.Click(btnDelete);
            seleniumActions.Click(btnYes_Popup);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblDeletedSuccessMessage));
            seleniumActions.SwitchToDefaultContent();
        }

        // ***************** End of TC 20 ************ //

        // ***************** Start of TC 24 ************ //

        /// <summary>
        /// This method help us to navigate into Entity and entity owner page inside the suite setup
        /// </summary>
        public void NavigateToEntityAndOwnerPage(String SubHead)
        {
            if (seleniumActions.IsElementPresent(sideMenuContainer))
            {
                seleniumActions.Wait(5);
                seleniumActions.Click(lblSetup);
                seleniumActions.Click(lblSuiteSetup);
                seleniumActions.Wait(2);
                seleniumActions.ScrollToElement(By.XPath("(//a[@class='submenu_list_link has-arrow']//following-sibling::ul[@class='inner_submenu']//span[contains(text(),'Master Folder Tags')])[2]"));
                if (SubHead.Equals("Entity"))
                {
                    seleniumActions.Wait(2);
                    seleniumActions.Click(By.XPath("//div[@class='sub-menu']//li[contains(@onclick,'MenuCustomCLick')]//span[text()='" + SubHead + "']"));
                }
                else if (SubHead.Equals("Entity Owners"))
                {
                    seleniumActions.Wait(2);
                    seleniumActions.Click(By.XPath("//div[@class='sub-menu']//li[contains(@onclick,'MenuCustomCLick')]//span[text()='" + SubHead + "']"));
                }
            }
        }

        /// <summary>
        /// Creates a new entity in entity page
        /// </summary>
        public string CreateEntity()
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            string entityName = Constants.TagName + utility.CurrentTime();
            seleniumActions.Click(txtEntityName);
            seleniumActions.SendKeys(txtEntityName, entityName);
            seleniumActions.ScrollToElement(svgAddContactPersonIcon);
            seleniumActions.Click(svgAddContactPersonIcon);
            seleniumActions.Wait(5);
            seleniumActions.SwitchToFrame(iframe_ifrUsers);
            seleniumActions.Wait(3);
            seleniumActions.Click(phd_Name);
            seleniumActions.SendKeys(phd_Name, "donot-Delete");
            seleniumActions.Wait(3);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblTeamLeader_SearchResult));
            seleniumActions.Click(chkTeamLeaderInactive);
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Click(btn_Done);
            seleniumActions.Click(btn_Save);
            Assert.IsTrue(seleniumActions.IsElementPresent(msgSaveSuccessfully));
            return entityName;
        }

        /// <summary>
        /// Assign owner to the entity
        /// </summary>
        public void AssignOwnerToEntity(string entityName)
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Click(tbl_GeoLocationOwers);
            seleniumActions.Wait(2);
            seleniumActions.Click("(//ul[contains(@id,'Tree_Benchmark')]//span[contains(text(),'" + entityName + "')])[1]");
            seleniumActions.Click("(//ul[contains(@id,'Tree_Benchmark')]//span[contains(text(),'" + entityName + "')]//img)[1]");

            seleniumActions.SwitchToIframes(iframe_ifrUsers);
            seleniumActions.Wait(3);
            seleniumActions.Click(phd_Name);
            seleniumActions.SendKeys(phd_Name, "donot-Delete");
            seleniumActions.Wait(2);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblTeamLeader_SearchResult));
            seleniumActions.Click(chkTeamLeaderInactive);

            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Click(btn_Done);
            seleniumActions.Click(btn_Save);
        }

        /// <summary>
        /// Deletes the new entity from the entity page
        /// </summary>
        public void DeleteEntity(string entityName)
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            Assert.IsTrue(seleniumActions.IsElementPresent(imgPlusIcon_EntityPage));
            seleniumActions.Click(imgPlusIcon_EntityPage);
            seleniumActions.Click("//ul[@id='Folder3']//a[contains(text(),'" + entityName + "')]");
            seleniumActions.ContextClick(By.XPath("//ul[@id='Folder3']//a[contains(text(),'" + entityName + "')]"));
            seleniumActions.Click(lblDeleteRightClick_EntityPage);
            seleniumActions.Click(btnYes_Popup);
            seleniumActions.Wait(2);
            seleniumActions.Click(btnYes_Popup);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblDeletedSuccessMessage));
            seleniumActions.SwitchToDefaultContent();
        }

        // ***************** End of TC 24 ************ //

        // ***************** Start of TC 23 ************ //

        /// <summary>
        /// Creates a country in country / region page
        /// </summary>
        /// <returns> country name </returns>
        public string CreateCountry()
        {
            string countryName = Constants.countryName + utility.CurrentTime();
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Wait(3);
            seleniumActions.Click(btnNew);
            seleniumActions.Click(inp_CountryName);
            seleniumActions.SendKeys(inp_CountryName, countryName);
            seleniumActions.Click(btn_Save);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblSuccess_Message));
            seleniumActions.Click(btnClose_SuccessMessage);
            seleniumActions.Click(hintSearch);
            seleniumActions.SendKeys(hintSearch, countryName);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblFirstRow_ElementPresent));
            return countryName;
        }

        /// <summary>
        /// Creates a state in state / province page
        /// </summary>
        /// <param name="countryName"></param>
        public void CreateState(string countryName)
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.IsElementPresent(drpCountry);
            seleniumActions.Click(drpCountry);
            seleniumActions.Wait(3);
            seleniumActions.SendKeys(txtSearchCountry, countryName);
            seleniumActions.Click(ddlHighlightedCountry);
            seleniumActions.WaitForElementToExists(btnAddState);
            seleniumActions.Click(btnAddState);
            seleniumActions.SendKeys(txtState, "Lawspet");
            seleniumActions.Click(btnSave);
            seleniumActions.VerifyElementIsDisplayed(msgSaveSuccessfully);
        }

        /// <summary>
        /// Creates a city in city page 
        /// </summary>
        /// <param name="countryName"></param>
        public void CreateCity(string countryName)
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.IsElementPresent(drpCountry);
            seleniumActions.Click(drpCountry);
            seleniumActions.Wait(3);
            seleniumActions.SendKeys(inp_CountrySearch, countryName + Keys.Enter);
            seleniumActions.Click(btnNew);
            seleniumActions.Click(txt_City);
            seleniumActions.SendKeys(txt_City, "ssv");
            seleniumActions.Click(btnSave);
            seleniumActions.VerifyElementIsDisplayed(msgSaveSuccessfully);
            seleniumActions.Wait(3);
            seleniumActions.Click(btnClose_SuccessMessage);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblFirstRow_ElementPresent));
        }

        /// <summary>
        /// Deletes the city in city page
        /// </summary>
        /// <param name="countryName"></param>
        public void DeleteCity(string countryName)
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Wait(3);
            seleniumActions.IsElementPresent(drpCountry);
            seleniumActions.Click(drpCountry);
            seleniumActions.Wait(3);
            seleniumActions.SendKeys(inp_CountrySearch, countryName + Keys.Enter);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblFirstRow_ElementPresent));
            seleniumActions.Click(chk_FirstRowInActive);
            seleniumActions.Click(btnDelete);
            seleniumActions.Click(btnYes_Popup);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblDeletedSuccessMessage));
        }

        /// <summary>
        /// Deleted the state in state / province page
        /// </summary>
        /// <param name="countryName"></param>
        public void DeleteState(string countryName)
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Wait(3);
            seleniumActions.IsElementPresent(drpCountry);
            seleniumActions.Click(drpCountry);
            seleniumActions.Wait(2);
            seleniumActions.SendKeys(inp_CountrySearch, countryName + Keys.Enter);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblFirstRow_ElementPresent));
            seleniumActions.Wait(2);
            seleniumActions.Click(chkState);
            seleniumActions.Click(btnDelete);
            seleniumActions.Click(btnYes_Popup);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblDeletedSuccessMessage));
        }

        /// <summary>
        /// Deleted the country in country / region page
        /// </summary>
        /// <param name="countryName"></param>
        public void DeleteCountry(string countryName)
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Click(hintSearch);
            seleniumActions.SendKeys(hintSearch, countryName);
            seleniumActions.Wait(5);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblFirstRow_ElementPresent));
            seleniumActions.Click(lblFirstRow_ElementPresent);
            seleniumActions.Click(btnDelete_Country);
            seleniumActions.Click(btnYes_Popup);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblDeletedSuccessMessage));
        }

        // ***************** End of TC 23 ************ //

        // ***************** Start of TC 10 ************ //

        /// <summary>
        /// Create the Meeting
        /// </summary>
        public void CreateMeetings()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Wait(2);
            seleniumActions.Click(btn_NewMeetings);
            Assert.IsTrue(seleniumActions.IsElementPresent(inp_MeetingDate));
            seleniumActions.Click(inp_MeetingDate);
            seleniumActions.Click(tbl_DatePicker);
            seleniumActions.SendKeys(inp_Location, Constants.Location);
            seleniumActions.SendKeys(inp_MeetingSub, Constants.Name);
            seleniumActions.Click(ddp_Category);
            seleniumActions.Click(ddl_Categoryddl);
            seleniumActions.Click(ddp_FromTime);
            seleniumActions.Click(tbl_FromTimeMeet);
            seleniumActions.Click(ddp_ToTime);
            seleniumActions.Click(tbl_ToTime);
            seleniumActions.Click(btn_MeetingMinutes);
            seleniumActions.SwitchToIframes(iframe);
            Assert.IsTrue(seleniumActions.IsElementPresent(txt_MeetingMinutesBox));
            seleniumActions.Click(txt_MeetingMinutesBox);
            seleniumActions.SendKeys(txt_MeetingMinutesBox, Constants.Name);
            seleniumActions.SwitchToParentFrame();
            seleniumActions.Click(btn_CloseMinuteBox);
            Assert.IsTrue(seleniumActions.IsElementPresent(btn_TeamIcon));
            seleniumActions.Click(btn_TeamIcon);
            seleniumActions.Wait(2);
            seleniumActions.SwitchToDefaultContent();
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
            seleniumActions.Wait(3);
            seleniumActions.Click(chk_ExisitingTeam);
            seleniumActions.Wait(2);
            seleniumActions.SendKeys(hintSearch2, "Administrator-Administrator");
            seleniumActions.Wait(2);
            seleniumActions.Click(chk_EmployeeSelect1);
            seleniumActions.SendKeys(hintSearch2, "dummy-User");
            seleniumActions.Wait(2);
            seleniumActions.Click(chk_EmployeeSelect1);
            seleniumActions.SendKeys(hintSearch2, "kaalaa-kaalaa");
            seleniumActions.Wait(2);
            seleniumActions.Click(chk_EmployeeSelect1);
            seleniumActions.Click(btn_TeamSave);
            _driver.SwitchTo().Window(originalWindow);
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Click(lbl_TitleAgenda);
            seleniumActions.SendKeys(txt_AgendaTopic, Constants.Name);
            seleniumActions.SendKeys(txt_AgendaDescription, Constants.Name);
            seleniumActions.Click(txt_AgendaFrmTime);
            seleniumActions.Click(tbl_AgendaFromTime);
            seleniumActions.Click(txt_AgendaToTime);
            seleniumActions.Click(tbl_AgendaToTime);
            seleniumActions.Click(tbl_AgendaUsericon);
            seleniumActions.Wait(3);
            seleniumActions.SwitchToFrame(iframe_ifrUsers);
            seleniumActions.Click(chk_AgendaUser);
            seleniumActions.SwitchToParentFrame();
            seleniumActions.Click(btn_UserDone);
            seleniumActions.Click(txt_AgendaDate);
            seleniumActions.Click(tbl_DatePicker);
            seleniumActions.Click(btn_Save);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Delete the Meeting
        /// </summary>
        public void DeleteMeeting()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Click(chk_Meeting1);
            seleniumActions.Click(btnDelete);
            seleniumActions.Click(btnYes_Popup);
            seleniumActions.SwitchToDefaultContent();
        }

        // ***************** End of TC 10 ************ //

        // ***************** Starts of TC 06 ************ //

        /// <summary>
        /// Create the Supplier
        /// </summary>
        public void CreateSupplier()
        {
            seleniumActions.Wait(3);
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Click(btnNew_CustomersPage);
            seleniumActions.Click(txt_Date);
            seleniumActions.Click(tbl_DatePicker);
            seleniumActions.SendKeys(txt_ManufacturerName, Constants.Name);
            seleniumActions.SendKeys(txt_ManufacturerCode, "AT" + utility.RandomNumberGenerator(5));
            seleniumActions.Click(ddp_Supplier);
            seleniumActions.Click(ddl_Supplier);
            seleniumActions.SendKeys(txt_ManufactureAddress, Constants.Location);
            seleniumActions.SendKeys(txt_ContactPersonName, Constants.Name);
            seleniumActions.SendKeys(txt_ContactPersonNo, utility.RandomPhoneNumber());
            seleniumActions.SendKeys(txt_ContactPersonMail, Constants.Name + "@email.com");
            seleniumActions.Click(ddp_Route);
            seleniumActions.Click(ddl_Route);
            seleniumActions.SendKeys(txt_NaturofPropsed, Constants.Name);
            seleniumActions.SendKeys(txt_Material, Constants.Name);
            seleniumActions.ScrollToElement(txt_BuyerMailId);
            seleniumActions.Click(txt_AssessmentDate);
            seleniumActions.Click(tbl_DatePicker);
            seleniumActions.SendKeys(txt_BuyerName, Constants.Name + "ss");
            seleniumActions.SendKeys(txt_BuyerMailId, Constants.Name + "@email.com");
            seleniumActions.Wait(3);
            seleniumActions.ScrollToElement(ddp_tdPreparedBy4);
            seleniumActions.IsElementPresent(txt_ActualDate);
            seleniumActions.Click(txt_ActualDate);
            seleniumActions.Click(tbl_DatePicker);
            seleniumActions.Click(ddp_tdPreparedBy);
            seleniumActions.Wait(3);
            seleniumActions.SwitchToFrame(iframe_ifrUsers);
            seleniumActions.SendKeys(hintSearch, "Thani-k");
            seleniumActions.Click(chk_AgendaUser);
            seleniumActions.SwitchToParentFrame();
            seleniumActions.Click(btn_UserDone);
            seleniumActions.Click(ddp_tdPreparedBy2);
            seleniumActions.Wait(3);
            seleniumActions.SwitchToFrame(iframe_ifrUsers);
            seleniumActions.SendKeys(hintSearch, "Thani-k");
            seleniumActions.Click(chk_AgendaUser);
            seleniumActions.SwitchToParentFrame();
            seleniumActions.Click(btn_UserDone);
            seleniumActions.Wait(3);
            Actions actions = new Actions(_driver);
            actions.SendKeys(Keys.PageDown).Perform();
            seleniumActions.Wait(3);
            seleniumActions.Click(ddp_tdPreparedBy3);
            seleniumActions.Wait(3);
            seleniumActions.SwitchToFrame(iframe_ifrUsers);
            seleniumActions.SendKeys(hintSearch, "Thani-k");
            seleniumActions.Click(chk_AgendaUser);
            seleniumActions.SwitchToParentFrame();
            seleniumActions.Click(btn_UserDone);
            seleniumActions.Click(ddp_tdPreparedBy4);
            seleniumActions.Wait(3);
            seleniumActions.SwitchToFrame(iframe_ifrUsers);
            seleniumActions.SendKeys(hintSearch, "Thani-k");
            seleniumActions.Click(chk_AgendaUser);
            seleniumActions.SwitchToParentFrame();
            seleniumActions.Click(btn_UserDone);
            seleniumActions.Click(btn_Save);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Delete the Supplier
        /// </summary>
        public void DeleteSupplier()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Click(ddp_SupplierSearchDropdown);
            seleniumActions.Click(ddl_SupplierSearchDropdown);
            seleniumActions.SendKeys(hintSearch, Constants.Name);
            seleniumActions.Wait(3);
            seleniumActions.Click(chk_FirstRowInActive);
            seleniumActions.Click(btnDelete_TeamsPage);
            seleniumActions.Click(btnYes_Popup);
            seleniumActions.SwitchToDefaultContent();
        }

        // ***************** End of TC 06 ************ //

        // ***************** Start of TC 14 ************ //

        /// <summary>
        /// Navigates to the users page within users page
        /// </summary>
        /// <param name="SubHead"></param>
        public void NavigateToUsersPage(String SubHead)
        {
            if (seleniumActions.IsElementPresent(sideMenuContainer))
            {
                seleniumActions.Wait(5);
                seleniumActions.Click(lblSetup);
                seleniumActions.Click(lblUsers);
                seleniumActions.Wait(2);
                seleniumActions.ScrollToElement(By.XPath("(//ul[@class='inner_submenu']//a[@title='" + SubHead + "']//span[contains(text(),'" + SubHead + "')])[2]"));
                seleniumActions.Click(By.XPath("(//ul[@class='inner_submenu']//a[@title='" + SubHead + "']//span[contains(text(),'" + SubHead + "')])[2]"));
            }
        }

        /// <summary>
        /// Creates an user in Users page
        /// </summary>
        /// <returns> employee code </returns>
        public string CreateNewUser()
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            string empCode = utility.CurrentTime();
            seleniumActions.Wait(3);
            seleniumActions.Click(btnAddState);
            Assert.IsTrue(seleniumActions.IsElementPresent(txtEmpCode));
            seleniumActions.Click(txtEmpCode);
            seleniumActions.Wait(4);
            seleniumActions.SendKeys(txtEmpCode, empCode);
            seleniumActions.Click(txtFirstName);
            seleniumActions.SendKeys(txtFirstName, Constants.TagName);
            seleniumActions.Click(txtLastName);
            seleniumActions.SendKeys(txtLastName, utility.CurrentTime());
            seleniumActions.Click(txtEmail);
            seleniumActions.SendKeys(txtEmail, "Test" + empCode + "@gmail.com");
            seleniumActions.Wait(2);
            seleniumActions.ScrollToElement(lblCountryRegion);
            seleniumActions.Click(txtUsername);
            seleniumActions.SendKeys(txtUsername, "TestScenario" + utility.GenerateRandomText(2));
            seleniumActions.Click(txtPassword);
            seleniumActions.SendKeys(txtPassword, "d1");
            seleniumActions.Wait(2);
            seleniumActions.ScrollToElement(lblSite);
            seleniumActions.Wait(3);
            seleniumActions.Click(txtConfirmPassword);
            seleniumActions.SendKeys(txtConfirmPassword, "d1");
            seleniumActions.ScrollToPosition(0, 1000);
            seleniumActions.Click(chkChangePasswordNextLogOn);
            seleniumActions.Wait(3);
            seleniumActions.Click(btn_Save);
            Assert.IsTrue(seleniumActions.IsElementPresent(msgSaveSuccessfully));
            return empCode;
        }

        /// <summary>
        /// Validate the created new user in present in the user grid
        /// </summary>
        /// <param name="empCode"></param>
        public void SearchAndValidateUser(string empCode)
        {
            seleniumActions.SwitchToFrame(iframe_DetailView);
            Assert.IsTrue(seleniumActions.IsElementPresent(btnMultiSearch));
            seleniumActions.Click(btnMultiSearch);
            Assert.IsTrue(seleniumActions.IsElementPresent(drpColumn_MultiSearch));
            seleniumActions.Click(drpColumn_MultiSearch);
            seleniumActions.Click(ddlCode_MultiSearch);
            seleniumActions.Click(drpCondition_MultiSearch);
            seleniumActions.Click(ddlContains_MultiSearch);
            seleniumActions.Click(inp_MultiSearch);
            seleniumActions.SendKeys(inp_MultiSearch, empCode);
            seleniumActions.Click(btnAdvancedSearch_MultiSearch);
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.SwitchToFrame(iframe_DetailView);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblFirstRow_ElementPresent));
        }

        /// <summary>
        /// Deletes the user from the grid
        /// </summary>
        /// <param name="empCode"></param>
        public void DeleteUserFromGrid(string empCode)
        {
            seleniumActions.Click(chk_FirstRowInActive);
            seleniumActions.Click(btnDelete);
            IAlert alert = _driver.SwitchTo().Alert();
            alert.Accept();
            Assert.IsTrue(seleniumActions.IsElementPresent(lblDeletedSuccessMessage));
            seleniumActions.SwitchToDefaultContent();
        }

        // ***************** End of TC 14 ************ //

        // ***************** Start of TC 12 ************ //

        /// <summary>
        /// Creates an user in Users page and changes the password
        /// </summary>
        /// <returns> employee code </returns>
        public string CreateNewUserAndChangePassword()
        {
            // ** Creating user ** //
            seleniumActions.SwitchToFrame(iframe_DetailView);
            string empCode = utility.CurrentTime();
            string email = "Test" + empCode + "@gmail.com";
            var userLogin = "TestScenario" + utility.GenerateRandomText(2);
            seleniumActions.Wait(3);
            seleniumActions.Click(btnAddState);
            Assert.IsTrue(seleniumActions.IsElementPresent(txtEmpCode));
            seleniumActions.Click(txtEmpCode);
            seleniumActions.Wait(4);
            seleniumActions.SendKeys(txtEmpCode, empCode);
            seleniumActions.Click(txtFirstName);
            seleniumActions.SendKeys(txtFirstName, Constants.TagName);
            seleniumActions.Click(txtLastName);
            seleniumActions.SendKeys(txtLastName, utility.CurrentTime());
            seleniumActions.Click(txtEmail);
            seleniumActions.SendKeys(txtEmail, email);
            seleniumActions.Wait(2);
            seleniumActions.ScrollToElement(lblCountryRegion);
            seleniumActions.Click(txtUsername);
            seleniumActions.SendKeys(txtUsername, userLogin);
            seleniumActions.Click(txtPassword);
            seleniumActions.SendKeys(txtPassword, "d1");
            seleniumActions.Wait(2);
            seleniumActions.ScrollToElement(lblSite);
            seleniumActions.Wait(3);
            seleniumActions.Click(txtConfirmPassword);
            seleniumActions.SendKeys(txtConfirmPassword, "d1");
            seleniumActions.ScrollToPosition(0, 1000);
            seleniumActions.Click(chkChangePasswordNextLogOn);
            seleniumActions.Wait(3);
            seleniumActions.Click(btn_Save);
            Assert.IsTrue(seleniumActions.IsElementPresent(msgSaveSuccessfully));

            // ** Logging out of application ** //
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.Click(btnUserIconProfile);
            seleniumActions.Wait(5);
            seleniumActions.Click(btnLogout);
            seleniumActions.Wait(2);
            seleniumActions.Click(btnYes_Popup);

            // ** Validating forgot pwd functionality ** //
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.Wait(3);
            Assert.IsTrue(seleniumActions.IsElementPresent(lnkForgotPassword));
            seleniumActions.Click(lnkForgotPassword);
            Assert.IsTrue(seleniumActions.IsElementPresent(txtUsername_ForgotPwd));
            seleniumActions.Click(txtUsername_ForgotPwd);
            seleniumActions.SendKeys(txtUsername_ForgotPwd, userLogin);
            seleniumActions.Click(txtEmpCode_ForgotPwd);
            seleniumActions.SendKeys(txtEmpCode_ForgotPwd, empCode);
            seleniumActions.Click(txtEmail_ForgotPwd);
            seleniumActions.SendKeys(txtEmail_ForgotPwd, email);
            seleniumActions.Click(btnValidateUser_ForgotPwd);
            Assert.IsTrue(seleniumActions.IsElementPresent(txtNewPwd_ForgotPwd));
            seleniumActions.Click(txtNewPwd_ForgotPwd);
            seleniumActions.SendKeys(txtNewPwd_ForgotPwd, "d2");
            seleniumActions.Click(txtCnfrmNewPwd_ForgotPwd);
            seleniumActions.SendKeys(txtCnfrmNewPwd_ForgotPwd, "d2");
            seleniumActions.Click(btnSubmit_ForgotPwd);
            Assert.IsTrue(seleniumActions.IsElementPresent(msgPwdSavedSuccess));

            // ** Log in with newly created user ** //
            seleniumActions.Refresh();
            seleniumActions.Wait(4);
            seleniumActions.Click(txtEmailLogin);
            seleniumActions.SendKeys(txtEmailLogin, userLogin);
            seleniumActions.Click(txtPasswordLogin);
            seleniumActions.SendKeys(txtPasswordLogin, "d2");
            seleniumActions.Click(btnLogin);
            seleniumActions.Wait(3);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblSetup));
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.Click(btnUserIconProfile);
            seleniumActions.Wait(5);
            seleniumActions.Click(btnLogout);
            seleniumActions.Wait(2);
            seleniumActions.Click(btnYes_Popup);
            return empCode;
        }

        // ***************** End of TC 12 ************ //

        // ***************** Start of TC 17 ************ //

        /// <summary>
        /// Create the group
        /// </summary>
        public string CreateGroup()
        {
            string groupName = Constants.TagName + utility.CurrentTime();
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.SwitchToIframes(iframe_MenuData);
            seleniumActions.IsElementPresent(btn_AddGroup);
            seleniumActions.Wait(3);
            seleniumActions.Click(btn_AddGroup);
            seleniumActions.Click(inp_GroupName);
            seleniumActions.SendKeys(inp_GroupName, groupName);
            seleniumActions.Click(btn_SaveGroup);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblSuccess_Message));
            seleniumActions.Click(btnClose_SuccessMessage);
            seleniumActions.Click(hintSearch);
            seleniumActions.SendKeys(hintSearch, groupName);
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_FirstGroupElement));
            seleniumActions.SwitchToParentFrame();
            return groupName;
        }

        /// <summary>
        /// Create the new user for group
        /// </summary>
        public void CreateUserForGroup()
        {
            seleniumActions.Wait(3);
            seleniumActions.SwitchToIframes(iframe_MenuData);
            seleniumActions.Click(svg_AddUserIcon);
            seleniumActions.Wait(3);
            seleniumActions.SwitchToIframes(iframe_ifrUsers);
            seleniumActions.Wait(5);
            seleniumActions.Click(chk_firstUser);
            seleniumActions.SwitchToParentFrame();
            seleniumActions.Click(btn_SaveUser);
            seleniumActions.SwitchToIframes(iframe_ifrUsers);
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_UserAddedSuccessMessage));
            seleniumActions.Click(btn_closeMessage);
            seleniumActions.SwitchToParentFrame();
        }

        /// <summary>
        /// Delete the added user for the group
        /// </summary>
        public void DeleteUserForGroup(string groupName)
        {
            seleniumActions.Wait(6);
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData);
            seleniumActions.Wait(3);
            seleniumActions.Click(hintSearch);
            seleniumActions.SendKeys(hintSearch, groupName);
            seleniumActions.Wait(5);
            seleniumActions.Click(svg_AddedUserIcon);
            seleniumActions.Wait(6);
            seleniumActions.Click(chk_firstGroupDelete);
            seleniumActions.Wait(3);
            seleniumActions.Click(btnDelete);
            seleniumActions.Click(popUp_Yes);
            seleniumActions.IsElementPresent(lblDeletedSuccessMessage);
            seleniumActions.Click(btn_closeMessage);
            seleniumActions.SwitchToParentFrame();
        }

        /// <summary>
        /// Update the groupName
        /// </summary>
        public string UpdateGroup(string groupName)
        {
            seleniumActions.Wait(3);
            seleniumActions.SwitchToIframes(iframe_DetailView, iframe_MenuData);
            seleniumActions.Wait(5);
            seleniumActions.Click(hintSearch);
            seleniumActions.SendKeys(hintSearch, groupName);
            seleniumActions.Wait(5);
            seleniumActions.Click(chk_firstGroup);
            seleniumActions.Click(btnPencilIcon);
            seleniumActions.Wait(3);
            seleniumActions.SendKeys(phd_GroupName, Keys.Clear);
            seleniumActions.SendKeys(phd_GroupName, "Updated " + groupName);
            seleniumActions.Wait(3);
            seleniumActions.Click(btnSave_TagPopup);
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_UpdatedSuccessMessage));
            seleniumActions.Click(btn_closeMessage);
            String existingGroupName = seleniumActions.GetText(By.XPath("//tbody//tr[@role='row']//td[contains(text(),'" + groupName + "')]"));
            seleniumActions.Wait(3);
            Assert.IsTrue(existingGroupName.Contains("Updated"));
            seleniumActions.SwitchToParentFrame();
            return existingGroupName;
        }

        /// <summary>
        /// Delete the created group
        /// </summary>
        public void deleteGroup(string existingGroupName)
        {
            seleniumActions.Wait(3);
            seleniumActions.SwitchToIframes(iframe_MenuData);
            seleniumActions.Wait(3);
            seleniumActions.Click(hintSearch);
            seleniumActions.SendKeys(hintSearch, Keys.Clear);
            seleniumActions.Wait(3);
            seleniumActions.SendKeys(hintSearch, existingGroupName);
            seleniumActions.Wait(3);
            seleniumActions.Click(chk_firstGroup);
            seleniumActions.Click(btn_DeleteTag);
            seleniumActions.Click(btnYes_Popup);
            seleniumActions.IsElementPresent(lblDeletedSuccessMessage);
            seleniumActions.Click(btn_closeMessage);
            seleniumActions.SwitchToParentFrame();
        }

        // ***************** End of TC 17 ************ //

        // ***************** Start of TC 18 ************ //

        /// <summary>
        /// Add the User For Module
        /// </summary>
        public void AddUserForModule()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Wait(3);
            seleniumActions.Click(ddp_Module);
            seleniumActions.Click(ddl_ModuleDocpro);
            seleniumActions.Click(btnAddState);
            seleniumActions.Wait(3);
            seleniumActions.SwitchToFrame(iframe_ifrUsers);
            seleniumActions.SendKeys(hintSearch, "Thani-k");
            seleniumActions.Click(chk_AgendaUser);
            seleniumActions.SwitchToParentFrame();
            seleniumActions.Click(btn_UserDone);
            seleniumActions.SwitchToDefaultContent();
        }

        /// <summary>
        /// Validate The Newely Added User
        /// </summary>
        public void ValidateTheNewelyAddedUser()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Click(ddp_Module);
            seleniumActions.Click(ddl_ModuleSearchUserName);
            seleniumActions.SendKeys(hintSearch, "Thani");
        }

        /// <summary>
        /// Remove The Added user
        /// </summary>
        public void RemoveTheAddeduser()
        {
            seleniumActions.Click(chk_FirstRowInActive);
            seleniumActions.Click(btnDelete);
            seleniumActions.Click(btnYes_Popup);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblDeletedSuccessMessage));
            seleniumActions.SwitchToDefaultContent();
        }

        // ***************** End of TC 18 ************ //

        // ***************** Start of TC 16 ************ //

        /// <summary>
        /// Creates an user in Users page and updates the prefrences in user page
        /// </summary>
        /// <returns> employee code </returns>
        public string CreateNewUserAndUpdateUserPreferences()
        {
            // ** Creating user ** //
            seleniumActions.SwitchToFrame(iframe_DetailView);
            string empCode = utility.CurrentTime();
            string email = "Test" + empCode + "@gmail.com";
            var userLogin = "TestScenario" + utility.GenerateRandomText(2);
            seleniumActions.Wait(3);
            seleniumActions.Click(btnAddState);
            Assert.IsTrue(seleniumActions.IsElementPresent(txtEmpCode));
            seleniumActions.Click(txtEmpCode);
            seleniumActions.Wait(4);
            seleniumActions.SendKeys(txtEmpCode, empCode);
            seleniumActions.Click(txtFirstName);
            seleniumActions.SendKeys(txtFirstName, Constants.TagName);
            seleniumActions.Click(txtLastName);
            seleniumActions.SendKeys(txtLastName, utility.CurrentTime());
            seleniumActions.Click(txtEmail);
            seleniumActions.SendKeys(txtEmail, email);
            seleniumActions.Wait(2);
            seleniumActions.ScrollToElement(lblCountryRegion);
            seleniumActions.Click(txtUsername);
            seleniumActions.SendKeys(txtUsername, userLogin);
            seleniumActions.Click(txtPassword);
            seleniumActions.SendKeys(txtPassword, "d1");
            seleniumActions.Wait(2);
            seleniumActions.ScrollToElement(lblSite);
            seleniumActions.Wait(3);
            seleniumActions.Click(txtConfirmPassword);
            seleniumActions.SendKeys(txtConfirmPassword, "d1");
            seleniumActions.ScrollToPosition(0, 1000);
            seleniumActions.Click(chkChangePasswordNextLogOn);
            seleniumActions.Wait(3);
            seleniumActions.Click(btn_Save);
            Assert.IsTrue(seleniumActions.IsElementPresent(msgSaveSuccessfully));

            // ** Logging out of application ** //
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.Click(btnUserIconProfile);
            seleniumActions.Wait(5);
            seleniumActions.Click(btnLogout);
            seleniumActions.Wait(2);
            seleniumActions.Click(btnYes_Popup);

            // ** Log in with newly created user ** //
            seleniumActions.Refresh();
            seleniumActions.Wait(4);
            seleniumActions.Click(txtEmailLogin);
            seleniumActions.SendKeys(txtEmailLogin, userLogin);
            seleniumActions.Click(txtPasswordLogin);
            seleniumActions.SendKeys(txtPasswordLogin, "d1");
            seleniumActions.Click(btnLogin);
            seleniumActions.Wait(3);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblSetup));
            seleniumActions.Wait(5);
            seleniumActions.Click(lblSetup);
            seleniumActions.Click(lblUsers);
            seleniumActions.Wait(2);
            seleniumActions.ScrollToElement(lblPreferences);
            seleniumActions.Click(lblPreferences);

            // ** Updating preferences ** //
            seleniumActions.SwitchToFrame(iframe_DetailView);
            Assert.IsTrue(seleniumActions.IsElementPresent(txtSessionTimeOut));
            seleniumActions.Click(txtSessionTimeOut);
            seleniumActions.SendKeys(txtSessionTimeOut, Keys.Clear);
            seleniumActions.SendKeys(txtSessionTimeOut, "30");
            seleniumActions.Click(txtPageSize);
            seleniumActions.SendKeys(txtPageSize, Keys.Clear);
            seleniumActions.SendKeys(txtPageSize, "20");
            seleniumActions.Wait(2);
            seleniumActions.Click(imgDateArrowDown);
            seleniumActions.Click(ddl_DD_DateFormat);
            seleniumActions.Click(imgMonthArrowDown);
            seleniumActions.Click(ddl_MM_DateFormat);
            seleniumActions.Click(btn_Save);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblSavedSuccessfully));

            seleniumActions.SwitchToDefaultContent();
            seleniumActions.Click(btnUserIconProfile);
            seleniumActions.Wait(5);
            seleniumActions.Click(btnLogout);
            seleniumActions.Wait(2);
            seleniumActions.Click(btnYes_Popup);
            return empCode;
        }

        // ***************** End of TC 16 ************ //

        // ***************** Start of TC 19 ************ //

        /// <summary>
        /// Unlock the user in user page
        /// </summary>
        public string UnlockUser(string user)
        {
            seleniumActions.Wait(5);
            seleniumActions.SwitchToIframes(iframe_DetailView);
            seleniumActions.Click(drp_UnlockUserSearch);
            seleniumActions.Click(ddlUsername_UnlockUser);
            seleniumActions.Click(hintSearch);
            seleniumActions.SendKeys(hintSearch, user);
            seleniumActions.Click(chk_FirstRowInActive);
            seleniumActions.Click(btn_UnlockUsers);
            seleniumActions.Click(popUp_Yes);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblSuccess_Message));
            seleniumActions.Click(btnClose_SuccessMessage);
            return user;
        }

        /// <summary>
        /// Validate the user is unlocked or not
        /// </summary>
        public void ValidateUserUnlock(string user)
        {
            seleniumActions.Click(hintSearch);
            seleniumActions.SendKeys(hintSearch, Keys.Clear);
            seleniumActions.SendKeys(hintSearch, user);
            Assert.IsTrue(seleniumActions.IsElementPresent(lbl_NoRecords), "user is present");
        }

        // ***************** End of TC 19 ************ //

        // ***************** Start of TC 15 ************ //

        /// <summary>
        /// Creates an user in Users page and change password from prefrences in user page
        /// </summary>
        /// <returns> employee code </returns>
        public string CreateNewUserAndUpdateChangePwdPreferences()
        {
            // ** Creating user ** //
            seleniumActions.SwitchToFrame(iframe_DetailView);
            string empCode = utility.CurrentTime();
            string email = "Test" + empCode + "@gmail.com";
            var userLogin = "TestScenario" + utility.GenerateRandomText(2);
            seleniumActions.Wait(3);
            seleniumActions.Click(btnAddState);
            Assert.IsTrue(seleniumActions.IsElementPresent(txtEmpCode));
            seleniumActions.Click(txtEmpCode);
            seleniumActions.Wait(4);
            seleniumActions.SendKeys(txtEmpCode, empCode);
            seleniumActions.Click(txtFirstName);
            seleniumActions.SendKeys(txtFirstName, Constants.TagName);
            seleniumActions.Click(txtLastName);
            seleniumActions.SendKeys(txtLastName, utility.CurrentTime());
            seleniumActions.Click(txtEmail);
            seleniumActions.SendKeys(txtEmail, email);
            seleniumActions.Wait(2);
            seleniumActions.ScrollToElement(lblCountryRegion);
            seleniumActions.Click(txtUsername);
            seleniumActions.SendKeys(txtUsername, userLogin);
            seleniumActions.Click(txtPassword);
            seleniumActions.SendKeys(txtPassword, "d1");
            seleniumActions.Wait(2);
            seleniumActions.ScrollToElement(lblSite);
            seleniumActions.Wait(3);
            seleniumActions.Click(txtConfirmPassword);
            seleniumActions.SendKeys(txtConfirmPassword, "d1");
            seleniumActions.ScrollToPosition(0, 1000);
            seleniumActions.Click(chkChangePasswordNextLogOn);
            seleniumActions.Wait(3);
            seleniumActions.Click(btn_Save);
            Assert.IsTrue(seleniumActions.IsElementPresent(msgSaveSuccessfully));

            // ** Logging out of application ** //
            seleniumActions.SwitchToDefaultContent();
            seleniumActions.Click(btnUserIconProfile);
            seleniumActions.Wait(5);
            seleniumActions.Click(btnLogout);
            seleniumActions.Wait(2);
            seleniumActions.Click(btnYes_Popup);

            // ** Log in with newly created user ** //
            seleniumActions.Refresh();
            seleniumActions.Wait(4);
            seleniumActions.Click(txtEmailLogin);
            seleniumActions.SendKeys(txtEmailLogin, userLogin);
            seleniumActions.Click(txtPasswordLogin);
            seleniumActions.SendKeys(txtPasswordLogin, "d1");
            seleniumActions.Click(btnLogin);
            seleniumActions.Wait(3);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblSetup));
            seleniumActions.Wait(5);
            seleniumActions.Click(lblSetup);
            seleniumActions.Click(lblUsers);
            seleniumActions.Wait(2);
            seleniumActions.ScrollToElement(lblPreferences);
            seleniumActions.Click(lblPreferences);

            // ** change password from preferences ** //
            seleniumActions.SwitchToFrame(iframe_DetailView);
            seleniumActions.Click(changeUserNamePwd_Tab);
            Assert.IsTrue(seleniumActions.IsElementPresent(txtPasswordLogin));
            seleniumActions.Wait(3);
            seleniumActions.Click(txtPasswordLogin);
            seleniumActions.SendKeys(txtPasswordLogin, "d1");
            seleniumActions.Click(txtNewPassword_Preferences);
            seleniumActions.SendKeys(txtNewPassword_Preferences, "d2");
            seleniumActions.Click(txtConfirmPassword_Preferences);
            seleniumActions.SendKeys(txtConfirmPassword_Preferences, "d2");
            Assert.IsTrue(seleniumActions.IsElementPresent(chkChangeLoginPwdActive_Preferences));
            seleniumActions.Click(btnSave_Preferences);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblSavedSuccessfully));

            seleniumActions.SwitchToDefaultContent();
            seleniumActions.Click(btnUserIconProfile);
            seleniumActions.Wait(5);
            seleniumActions.Click(btnLogout);
            seleniumActions.Wait(2);
            seleniumActions.Click(btnYes_Popup);
            return empCode;
        }

        // ***************** End of TC 15 ************ //

        #endregion
    }
}
