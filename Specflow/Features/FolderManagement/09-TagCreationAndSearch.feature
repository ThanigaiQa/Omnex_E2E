Feature: 09 Tag Creation And Search

@TC-22986
Scenario: TC 22986 Validate the Tag selection option is displayed
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then I give sublevel access for the level  
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I make the level in use
	Then I verify the tag selection link is present
	Then I click on the tag selection link
	Then I search and select the tagname
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level