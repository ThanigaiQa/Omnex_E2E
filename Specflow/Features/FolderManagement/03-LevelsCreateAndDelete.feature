Feature: 03-LevelsCreateAndDelete

@TC-21854
Scenario: TC 21854 Validate view levels created by suite administrator
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I verify the random level heading in Folder management menu
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-21856
Scenario: TC 21856 Validate activate the levels for the specific site
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
@TC-04
Scenario: TC 04 : _21858_Validate Delete should be Disabled
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I Validate the Delete should be Disabled
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-05
Scenario: TC 05 : _21859_Validate Edit the level by suite administrator
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I Edit the level by suite administrator
	Then I make the random level in use
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-06
Scenario: TC 06 : _21860_Validate New Option should be Disabled
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I Validate the New Option should be Disabled
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-21855
Scenario: TC 21855 : Validate user should not view levels created by suite administrator
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I verify the random level heading in Folder management menu
	And I validate the document pro heading in document management page
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level
