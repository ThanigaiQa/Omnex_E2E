Feature: Level creation scenarios for Suite/Module Admin & Group Rights

@TC-01
Scenario:EwQIMS_49033_TC01_DOC-FM-100-010
	Given Login to the application with 'admin' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	And I gave the access for site modification site sub level creation
	Then Logout from the application
	Given Login to the application with 'admin' user
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	And I Validate the Right click options 
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level
	
