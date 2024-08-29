
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
        By btnNew => By.XPath("//li[@id='dbtnadd']//button[@title='New']");

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
        By hintSearch => By.XPath("//input[@type='search']");
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



        // ***************TC11 Xpaths********************** //
        By txtEntityName => By.XPath("//input[@id='tblEntityName']");
        By svgAddContactPersonIcon => By.XPath("//*[local-name()='svg' and @data-icon='user-plus']");
        By tbl_GeoLocationOwers => By.XPath("(//div[@id='divMultiSelectTree'])[1]");
        By imgPlusIcon_EntityPage => By.XPath("//img[@id='plusimg3']");
        By lblDeleteRightClick_EntityPage => By.XPath("//ul[@id='contextmenu']//li[@id='liDelete']");
        By ddlHighlightedCountry => By.XPath("//li[contains(@class,'option--highlighted')]");
        By btnDelete_Country => By.XPath("//button[@id='btnDeleteCountry']");
        By lblTeamSortAscending => By.XPath("(//th[@aria-sort='ascending'])[1]"); 

        #endregion

        #region Iframe
        static By iframe_DetailView => By.XPath("//iframe[@name='Detailview']");
        static By iframe_Tree => By.XPath("//iframe[@id='iframeTree']");
        static By iframe_ifrUsers => By.XPath("//iframe[@id='ifrUsers']");
        static By iframe_ifrAlbum => By.XPath("(//iframe[@id='ifrAlbum'])[1]");
        


        //static By[] iframes = { iframe_DetailView, iframe_Tree };

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
        public void ClickAddButtonAndCreateNewTag()
        {
            seleniumActions.SwitchToIframes(iframe_DetailView);
            Assert.IsTrue(seleniumActions.IsElementPresent(btnAdd_MasterFolderTags));
            seleniumActions.Click(btnAdd_MasterFolderTags);
            Assert.IsTrue(seleniumActions.IsElementPresent(tblAddPopup));
            seleniumActions.SendKeys(phd_TagName, Constants.TagName + utility.CurrentTime());
            seleniumActions.Click(btnSave_TagPopup);
        }

        /// <summary>
        /// Click pencil icon and rename the existing tagname
        /// </summary>
        public void RenameTagName()
        {
            seleniumActions.Wait(2);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblTag));
            seleniumActions.Click(chkTagname_Inactive);
            seleniumActions.Wait(3);
            seleniumActions.Click(btnPencilIcon);
            seleniumActions.SendKeys(phd_TagName, Keys.Clear);
            seleniumActions.SendKeys(phd_TagName, "Updated " + Constants.TagName + utility.CurrentTime());
            seleniumActions.Click(btnSave_TagPopup);
            seleniumActions.Wait(4);
            String tagName = seleniumActions.GetText(lblTag);
            seleniumActions.Wait(3);
            Assert.IsTrue(tagName.Contains("Updated"));
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
            //Assert.IsFalse(seleniumActions.VerifyElementIsDisplayed(lblTag));
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
            string custName = Constants.TagName+ utility.CurrentTime();
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
            seleniumActions.SendKeys(txtStreet,"Street");
            seleniumActions.Click(drpCountry_AddAddress);
            seleniumActions.ScrollToElement(ddlIndia_AddAddress);
            seleniumActions.Click(ddlIndia_AddAddress);
            seleniumActions.Click(drpState_AddAddress);
            seleniumActions.Click(ddlTamilnadu_AddAddress);
            seleniumActions.Click(drpCity_AddAddress);
            seleniumActions.Click(ddlChennai_AddAddress);
            seleniumActions.Click(txtZipCode_AddAddress);
            seleniumActions.SendKeys(txtZipCode_AddAddress,"600012");
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
            seleniumActions.SendKeys(inp_MultiSearch,custName);
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
            seleniumActions.SendKeys(inp_VendorName,vendorName);
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
            seleniumActions.SendKeys(ddl_PaswordOption,Keys.Clear);
            seleniumActions.SendKeys(ddl_PaswordOption,"Alphanumeric");
            seleniumActions.SendKeys(txt_PasswordLength, Keys.Clear);
            seleniumActions.SendKeys(txt_PasswordLength, "2");
            string fcDefaultValue=seleniumActions.GetText(drp_FirstCombobox);
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
            seleniumActions.Click("(//ul[contains(@id,'Tree_Benchmark')]//span[contains(text(),'" + entityName +"')])[1]");
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
        /// /// <param name="countryName"></param>
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

        #endregion
    }
}
