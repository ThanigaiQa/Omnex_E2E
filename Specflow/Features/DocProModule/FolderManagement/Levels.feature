Feature: Levels

@Create-Delete-Level
Scenario: Create Delete Level
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I make the random level in use
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level
	
@CreateLevel-AttachDocument-DeleteLevel
Scenario: Create level Attach Document Delete Level
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I make the random level in use
	And I assign the route for the level with Assign by admin
	Then I refresh the page
	Then Navigate to New Document Request in Documents Page
	Then I validate the New Document Request in Documents Page
	And I choose existing level and upload new document in doc request page
	Then I refresh the page
	Then Navigate to Actions in Documents Page
	Then I validate the Actions in Documents Page