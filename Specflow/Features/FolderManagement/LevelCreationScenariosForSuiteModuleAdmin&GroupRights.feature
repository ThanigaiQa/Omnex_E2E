Feature: Level creation scenarios for Suite/Module Admin & Group Rights

@TC-01
Scenario:EwQIMS_49033_TC01_DOC-FM-100-010
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
Scenario:EwQIMS_49037_TC02_DOC-FM-100-020
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
Scenario:EwQIMS_49039_DOC_FM_100_030
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
Scenario:EwQIMS-49040: DOC-FM-100-040
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