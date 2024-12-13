Feature: Suite Administrator can create the levels

@TC-01
Scenario:EwQIMS_15729_Reset button
	Given Login to the application with 'admin' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Validate the Reset button

@TC-02
Scenario:EwQIMS_10816_Frequency Validation 
	Given Login to the application with 'admin' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Validate Review frequency must be numeric

@TC-03
Scenario:EwQIMS_49926_Days_Validation 
	Given Login to the application with 'admin' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Validate whether the system can accept the Document reviewed after greater than 9999 Days 

@TC-04
Scenario: EwQIMS_10814_Click on select hyperlin
	Given Login to the application with 'admin' user
	When Navigate to Levels in suite setup Page
	And I validate the Levels page
	And Create random Level
	Then I refresh the page
	Then I verify the tag selection link is present
	Then I click on the tag selection link
	Then I search and select the tagname
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level
