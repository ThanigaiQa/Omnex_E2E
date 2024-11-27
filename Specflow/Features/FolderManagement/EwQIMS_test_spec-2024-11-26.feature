Feature: EwQIMS_test_spec-2024-11-26

@TC-01
Scenario: TC01_DOC_1400_10_20
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then Logout from the application
	Given Login to the application with 'noaccess' user
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I validate the DocPro landing screen is showing instead of displaying level details
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level
	
