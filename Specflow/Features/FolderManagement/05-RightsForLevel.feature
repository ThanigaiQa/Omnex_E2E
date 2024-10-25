Feature: 05 - Rights For Level

@TC-21875
Scenario: TC 21875 Validate Document management Link
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
	Then validate the manage site document heading
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-21872
Scenario: TC 21872 Validate Inherit Option should not selected by default
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
	Then I validate the inherit option should not be selected by default
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-21873
Scenario: TC 21873 Validate Inherit option is selected by default for Child level
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then I give sublevel access for the level
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I make the level in use
	Then I right click on the random level and select New option
	Then I verify the level heading
	Then I give sub level name and save the level
	Then I search and click the random level in folder management page
	Then I click on the sub level and verify the level header
	Then I right click on the sublevel and select Rights for sites option
	Then I search for rightsite in document rights page
	Then I validate the inherit option should be selected by default
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-21876
Scenario: TC-21876 Validate Document management Link access
	Given Login to the application with 'thani' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I make the level in use
	Then I refresh the page
	Then Navigate to New Document Request in Documents Page
	Then I validate the New Document Request in Documents Page
	And I choose existing level and upload new document in doc request page
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I Open the Right for Sites for the level
	Then I search for rightsite in document rights page
	And I click the document management link
	Then validate the manage site document heading
	Then I click plus icon and I give the full access for the document
	Then I get the attribute and validate the full access checkbox
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

	
