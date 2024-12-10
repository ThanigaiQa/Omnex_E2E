Feature: In Use - Activate the suite levels in Doc pro

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
	
@TC-02
Scenario: TC02_DOC_1400_10_30
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I validate the level color 'before' making the level in use
	Then I search and click the random level in folder management page
	Then I make the level in use
	Then I validate the level color 'after' making the level in use
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-03
Scenario: TC03_DOC_2500_10_80
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I validate only edit option is enabled without making the level in use
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-04
Scenario: Edit the level name before and after In use
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	When Edit the Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click edited level in the folder management page
	Then I make the level in use
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	When Edit the Level after in use
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click ReEdited level in the folder management page
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Re Edited Level

