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
	Then I search and click the random level in folder management page
	Then I make the level in use
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-21858
Scenario: TC 21858 : Validate Delete should be Disabled
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

@TC-21859
Scenario: TC 21859 : Validate Edit the level by suite administrator
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I Edit the level by suite administrator
	Then I search and click the random level in folder management page
	Then I make the level in use
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-21860
Scenario: TC 21860 : Validate New Option should be Disabled
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

@TC-21870
Scenario: TC 21870 : Validate module levels are not displayed
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then Logout from the application
	Then Login to the application with 'dummy' user
	And Validate module levels are not displayed under suite setup
	Then Logout from the application
	Then Login to the application with 'right' user
	When Navigate to DocPro Setup in suite setup Page
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-21857,61,63-67,69
Scenario: TC 21861,63,64,65,66,67,69,57 : validate New Option and Sub level create, Edit and Delete
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then I give sublevel access for the level  
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page