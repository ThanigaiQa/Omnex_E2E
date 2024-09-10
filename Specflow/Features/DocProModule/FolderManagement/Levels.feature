Feature: Levels

@CreateDeleteLevel
Scenario: Create Delete Level
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	When Navigate to DocPro Setup in suite setup Page
	Then I make the random level in use
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level
	
