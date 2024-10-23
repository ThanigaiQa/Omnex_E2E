Feature: 05-RightsForLevel


@TC-21875
Scenario: TC-21875 Validate Document management Link
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I make the level in use
	Then I Open the Right for Sites for the level
	Then I search for rightsite in document rights page
	And I click the document management link
	#Then validate the document management link heading
	#When Navigate to Levels in suite setup Page
	#Then I validate the Levels page
	#Then Delete the Level


	
