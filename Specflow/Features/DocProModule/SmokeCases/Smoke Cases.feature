Feature: Smoke Cases

@TC01
Scenario: TC 01_Verify the user is able to Create, Edit and Delete levels
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-04
Scenario: TC 04_New document creation with Assign admin
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I make the level in use
	Then I edit dropdown values for the level in folder management page
	And I Add the level owner and validate the level owner is added
	And I assign the route for the level with Assign by admin
	Then I refresh the page
	Then Navigate to New Document Request in Documents Page
	Then I validate the New Document Request in Documents Page
	And I choose existing level and upload new document in doc request page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	And I assign the route for the level with Module Auto approval
	Then Navigate to Actions in Documents Page
	Then I validate the Actions in Documents Page
	When I click on Pending Requests menu
	Then I validate pending requests menu
	Then I search the document
	And I verify the status value of the document as In Process
	When I click the status value link
	Then I Terminate the document
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level
