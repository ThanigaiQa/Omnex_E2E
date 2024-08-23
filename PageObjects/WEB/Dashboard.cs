
using OMNEX.AUTOMATION.Data.WEB;
using OMNEX.AUTOMATION.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Reflection.Metadata;
using System.Diagnostics;

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
        By lblTeamLeader_SearchResult => By.XPath("//table[@id='userListingGridControl']//td[@class='sorting_1']");
        By chkTeamLeaderInactive => By.XPath("//table[@id='userListingGridControl']//tr[@class='odd']//input[@type='checkbox']");
        By chkTeamLeaderActive => By.XPath("//table[@id='userListingGridControl']//tr[@class='odd selected']//input[@type='checkbox']");
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
        By btnNew_shiftPage => By.XPath("//li[@id='dbtnadd']//button[@title='New']");

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
        By hintSearch_ShiftPage => By.XPath("//input[@type='search']");
        By lblShift_ElementPresent => By.XPath("//tr[@role='row']//td/a[@href]");
        By chk_ShiftNameInActive => By.XPath("//tbody//tr[@role='row' and @class='odd']//input[@type='checkbox']");
        By chk_ShiftNameActive => By.XPath("//tbody//tr[@role='row' and @class='odd selected']//input[@type='checkbox']");
        By btnDelete_shift => By.XPath("//li[@id='dbtndelete']//button[@title='Delete']");
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

        /***************TC13 Xpaths**********************/

        By inp_CountryName => By.XPath("//input[@id='txtCountryName']");

        /***************TC13 Xpaths**********************/
        By chk_PreferredManufacturer => By.XPath("//label[@for='chkPreManuf']");
        By ddlManufacturerName_MultiSearch => By.XPath("(//div[@class='dtsb-criteria']//select//option[contains(text(),'Manufacturer Name')])[1]");


        #endregion

        #region Iframe
        static By iframe_DetailView => By.XPath("//iframe[@name='Detailview']");
        static By iframe_Tree => By.XPath("//iframe[@id='iframeTree']");
        static By iframe_ifrUsers => By.XPath("//iframe[@id='ifrUsers']");

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
                seleniumActions.Click(lblSetup);
                seleniumActions.Click(lblSuiteSetup);
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
        public void CreateTeam()
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
            seleniumActions.Click(txtTeamName);
            seleniumActions.SendKeys(txtTeamName, Constants.Name);
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
        }

        /// <summary>
        /// Verify the newly created team is showing in the teams list
        /// </summary>
        public void VerifyTeamIsCreated()
        {
            seleniumActions.ScrollToElement(btnClose_TeamsPage);
            seleniumActions.Click(btnClose_TeamsPage);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblAddedTeam));
            Assert.IsTrue(seleniumActions.GetText(lblAddedTeam).Equals(Constants.Name));
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
            seleniumActions.Click(btnNew_shiftPage);
            seleniumActions.SendKeys(inp_ShiftName, shiftName);
            seleniumActions.Click(dtp_FromTime);
            seleniumActions.Click(tbl_FromTime);
            seleniumActions.Click(dtp_ToTime);
            seleniumActions.Click(tbl_ToTime);
            seleniumActions.Click(btn_Save);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblSuccess_Message));
            seleniumActions.Click(btnClose_SuccessMessage);
            seleniumActions.Click(hintSearch_ShiftPage);
            seleniumActions.SendKeys(hintSearch_ShiftPage, shiftName);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblShift_ElementPresent));
        }

        /// <summary>
        ///  Delete the newly created shift 
        /// </summary>
        public void DeleteShift()
        {
            seleniumActions.Click(chk_ShiftNameInActive);
            seleniumActions.Click(btnDelete_shift);
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
            seleniumActions.WaitForElementToExists(lblShift_ElementPresent);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblShift_ElementPresent));
            seleniumActions.Click(chk_ShiftNameInActive);
            seleniumActions.Click(btnDelete_shift);
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
            seleniumActions.Click(btnNew_shiftPage);
            seleniumActions.Click(inp_CountryName);
            seleniumActions.SendKeys(inp_CountryName, countryName);
            seleniumActions.Click(btn_Save);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblSuccess_Message));
            seleniumActions.Click(btnClose_SuccessMessage);
            seleniumActions.Click(hintSearch_ShiftPage);
            seleniumActions.SendKeys(hintSearch_ShiftPage, countryName);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblShift_ElementPresent));
        }

        /// <summary>
        ///  Delete the newly created country 
        /// </summary>
        public void DeleteCountry()
        {
            seleniumActions.Click(chk_ShiftNameInActive);
            seleniumActions.Click(btnDelete_shift);
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
            seleniumActions.WaitForElementToExists(lblShift_ElementPresent);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblShift_ElementPresent));
            seleniumActions.Click(chk_ShiftNameInActive);
            seleniumActions.Click(btnDelete_shift);
            seleniumActions.Click(btnYes_Popup);
            seleniumActions.Wait(5);
            seleniumActions.Click(btnYes_Popup);
            Assert.IsTrue(seleniumActions.IsElementPresent(lblDeletedSuccessMessage));
            seleniumActions.SwitchToDefaultContent();
        }

        // ***************** End of TC 07 ************ //

        #endregion
    }
}
