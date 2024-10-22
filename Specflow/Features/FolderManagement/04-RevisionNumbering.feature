Feature: 04-RevisionNumbering

@TC-22983
Scenario: TC 22983 Validate Enable Records option
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I make the level in use
	Then I Click the records checkbox
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-22978
Scenario: TC 22978 Validate revision date option as laat approval date
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I make the level in use
	And I assiging value for Revision Date option
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-22980
Scenario: TC 22980 Validate define level owner
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I make the level in use
	And I Add the level owner and validate the level owner is added
	Then I remove the level owner and verify the level owner is removed
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level


@TC-22974-75-76
Scenario: TC 22974-75-76 Validate the user can define the revision_document number option
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I make the level in use
	Then Validate the user can define the Document number option
	Then I refresh the page
	Then Navigate to New Document Request in Documents Page
	Then I validate the New Document Request in Documents Page
	And I choose existing level and upload new document in doc request page
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then Validate the user can define the revision option
	Then I refresh the page
	Then Navigate to New Document Request in Documents Page
	Then I validate the New Document Request in Documents Page
	And I choose existing level and upload new document in doc request page
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-22977
Scenario: TC 22977 Validate revision option as Inherit from parent
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I give sublevel access for the level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I Right click the New button and validate the inherit from parent option present under Revision
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then I validate the Levels page
	Then Delete the Level

@TC-22979
Scenario: TC 22979  Validate revision date option as User input date
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I give sublevel access for the level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I make the level in use
	Then I Validate revision date option as user input date
	Then I refresh the page
	Then Navigate to New Document Request in Documents Page
	Then I validate the New Document Request in Documents Page
	And I choose existing level and upload new document in doc request page
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-22984
Scenario: TC 22984 Validate frequency of documentation reviewed
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I make the level in use
	Then I set the Document Reviewed After dropdown value as day
	Then I set the Revision Value
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

