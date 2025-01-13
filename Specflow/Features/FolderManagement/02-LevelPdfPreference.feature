Feature: 02 - Level PDF Preference

@TC-01
Scenario: EwQIMS_22999_Validate Display of Level PDF preferences
	Given Login to the application with 'thani' user
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

@TC-02
Scenario: EwQIMS_22144:_Validate to select the template from drop down in level pdf preference.
	Given Login to the application with 'thani' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I make the level in use
	Then I click the Level PDF preferences link
	Then I select template from the dropdown and verify the template is selected
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

