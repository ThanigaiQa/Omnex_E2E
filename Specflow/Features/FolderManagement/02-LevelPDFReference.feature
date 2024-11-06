﻿Feature: 02-LevelPDFReference

@TC-22999
Scenario: TC-22999 Validate Display of Level PDF preferences
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

