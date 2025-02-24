Feature: 07 - Route

@TC-21877_78
Scenario: TC 21877_78 edit route options and Set auto publish
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I validate the route link is not present
	Then I search and click the random level in folder management page
	Then I make the level in use
	Then I validate the route link is present
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-21879_80
Scenario: TC 21879_80 Validate Default Route Selection
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I make the level in use
	Then I validate the route link is present
	Then I click on the route link and validate the UI elements
	And I assign the route for the level with Assign by admin
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level