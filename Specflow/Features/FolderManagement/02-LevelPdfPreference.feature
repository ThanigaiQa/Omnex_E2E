Feature: 02 - Level PDF Preference

@TC-22999
Scenario: EwQIMS_22999_Validate Display of Level PDF preferences
	Given Login to the application with 'admin' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then I give sublevel access for the level
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I make the level in use
	Then I click the Level PDF preferences link
	Then I validate the Level PDF Preferences page heading
	Then I verify all UI elements on the Level PDF Preferences page
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-22144
Scenario: EwQIMS_22144_Validate to select the template from drop down in level pdf preference.
	Given Login to the application with 'admin' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I make the level in use
	Then I click the Level PDF preferences link
	Then I select template from the dropdown
	Then I search and click the random level in folder management page
	Then I click the Level PDF preferences link
	Then I verify the template is selected and reset to default
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-22149
Scenario: EwQIMS_22149_Check box unselecting
	Given Login to the application with 'admin' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then I give sublevel access for the level
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I make the level in use
	Then I click the Level PDF preferences link
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level
 
@TC-22153_22154
Scenario: EwQIMS_22153_22154_Validate Refresh from pdf preference
	Given Login to the application with 'admin' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then I give sublevel access for the level
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I make the level in use
	Then I click the Level PDF preferences link
	Then I Validate the Refresh action
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

#PDF Template - Test cases covered
@TC-22150,17924,17925,17927,17930,17931,18035,48801,48812,48813
Scenario: EwQIMS_22150_Validate Refresh from pdf preference
	Given Login to the application with 'admin' user
	When I Navigate to PDF Templates in system Page
	Then I create a new template in Pdf template page without saving and verify it is not created
	Then I create a new template in Pdf template page
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I make the level in use
	Then I click the Level PDF preferences link
	Then I verify the newly created template is visible in the template dropdown
	Then I refresh the page
	When I Navigate to PDF Templates in system Page
	Then I delete the newly created template in Pdf template page
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-18038
Scenario: EwQIMS_18038_Save the Watermark details
	Given Login to the application with 'admin' user
	When I Navigate to PDF Templates in system Page
	Then I create a new template in Pdf template page
	Then I verify the header , footer and include cover page details on pdf template screen
	Then I delete the newly created template in Pdf template page

@TC-18034
Scenario: EwQIMS_18034_Edit the Template in PDF Template
	Given Login to the application with 'admin' user
	When I Navigate to PDF Templates in system Page
	Then I create a new template in Pdf template page
	Then I edit the existing template and verify template in Pdf template page
	Then I delete the newly created template in Pdf template page

@TC-17938,TC-17939,TC-17941
Scenario: EwQIMS_17938_Admin to set the Data field in PDF Template
	Given Login to the application with 'admin' user
	When I Navigate to PDF Templates in system Page
	Then I navigate to create PDF Template window and verify the user can set review date,next review date in data field

@TC-18039To18041
Scenario: EwQIMS_18039_To_18041_Save the Header details
	Given Login to the application with 'admin' user
	When I Navigate to PDF Templates in system Page
	Then I create a new template in Pdf template page
	Then I verify the header , footer and include cover page details on pdf template screen
	Then I delete the newly created template in Pdf template page

@TC-18024
Scenario:EwQIMS_18024_Checkboxes in PDF Template 
	Given Login to the application with 'admin' user
	When I Navigate to PDF Templates in system Page
	Then I validate User can check the checkboxes in Include Water Mark, Include header, footer, Cover page

@TC-17929
Scenario: EwQIMS_17929 Validate user can view the sample PDF after entering the Template Details 
	Given Login to the application with 'admin' user
	When I Navigate to PDF Templates in system Page
	Then I create a new template in Pdf template page
	Then I Validate Show template screen view the sample PDF Template with all the details entered
	Then I delete the newly created template in Pdf template page
	
@TC-48814
Scenario:EwQIMS_48814_Validate the Load Previous version button
	Given Login to the application with 'admin' user
	When I Navigate to PDF Templates in system Page
	Then I click on the already existing pdf template
	Then I click on load previous button and validate the load previous button page
	

	

