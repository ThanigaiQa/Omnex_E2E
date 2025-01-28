﻿Feature: 02 - Level PDF Preference

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
Scenario: EwQIMS_22144:_Validate to select the template from drop down in level pdf preference.
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
Scenario: EwQIMS-22149 Check box unselecting
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
Scenario: EwQIMS-22153_22154 Validate Refresh from pdf preference
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
Scenario: EwQIMS-22150 Validate Refresh from pdf preference
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

