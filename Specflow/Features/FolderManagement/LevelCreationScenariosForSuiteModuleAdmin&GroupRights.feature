﻿Feature: Level creation scenarios for Suite/Module Admin & Group Rights

@TC-01
Scenario:EwQIMS_49033_The levels created under the Suite for Suite admin (Administrator login) 
	Given Login to the application with 'admin' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	And I gave the access for site modification site sub level creation
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I validate the level color 'before' making the level in use
	And I Validate the Right click options
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I make the level in use
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-02
Scenario:EwQIMS_49037_Suite admin for the levels created under Folder management
	Given Login to the application with 'admin' user
	When Navigate to Levels in suite setup Page
	And  I validate the Levels page
	And  Create random Level
	And  I gave the access for site modification site sub level creation
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	And  I search and click the random level in folder management page
	And  I validate the level color 'before' making the level in use
	And  I Validate the Right click options new and edit enable
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I make the level in use
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	And  Right click the level and select the new button to create the sublevel
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level


@TC-03
Scenario:EwQIMS_49039_The Suite Admin can create new Parent levels under Folder management
	Given Login to the application with 'admin' user
	When Navigate to Levels in suite setup Page
	And  I validate the Levels page
	And  Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	And  I search and click the random level in folder management page
	Then I make the level in use
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	And  I Validate the New and Delete option disable in Right click options
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level


@TC-04
Scenario:EwQIMS_49040_Suite Admin can create new Sub levels under Folder management
	Given Login to the application with 'admin' user
	When Navigate to Levels in suite setup Page
	And  I validate the Levels page
	And  Create random Level
	And  I gave the access for site modification site sub level creation
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I make the level in use
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	And  Right click the level and select the new button to create the sublevel
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

