Feature: Suite Administrator can create the levels

@TC-01
Scenario: EwQIMS_15729_Reset button
	Given Login to the application with 'admin' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Validate the Reset button

@TC-02
Scenario: EwQIMS_10816_Frequency Validation
	Given Login to the application with 'admin' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Validate Review frequency must be numeric

@TC-03
Scenario: EwQIMS_49926_Days_Validation
	Given Login to the application with 'admin' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Validate whether the system can accept the Document reviewed after greater than 9999 Days

@TC-04
Scenario: EwQIMS_10814_Click on select hyperlink
	Given Login to the application with 'admin' user
	When Navigate to Levels in suite setup Page
	And I validate the Levels page
	And Create random Level
	Then I navigate to levels and click edit icon
	Then I verify the tag selection link is present in levels page
	Then I click on the tag selection link in levels page
	Then I search and select the tagname in levels page
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-05
Scenario: EwQIMS_432_With enable Sub level creation
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

@TC-06
Scenario: EwQIMS_10820_Display selected Tags in Folder Management
	Given Login to the application with 'admin' user
	When Navigate to Levels in suite setup Page
	And I validate the Levels page
	And Create random Level
	Then I set the Document Reviewed After dropdown value to Month in levels page
	Then I verify the tag selection link is present in levels page
	Then I click on the tag selection link in levels page
	Then I search and select the tagname in levels page
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I make the level in use
	Then I verify the tag selection is present in folder Management
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-07
Scenario: EwQIMS-10807_The levels can create along with the Tag selection
	Given Login to the application with 'admin' user
	When Navigate to Levels in suite setup Page
	And I validate the Levels page
	And Create random Level
	Then I set the Document Reviewed After dropdown value to Month in levels page
	Then I verify the tag selection link is present in levels page
	Then I click on the tag selection link in levels page
	Then I search and select the tagname in levels page
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-08
Scenario: EwQIMS-10809_Validate whether the selected Tag can be edited
	Given Login to the application with 'admin' user
	When Navigate to Levels in suite setup Page
	And I validate the Levels page
	And Create random Level
	Then I navigate to levels and click edit icon
	Then I verify the tag selection link is present in levels page
	Then I click on the tag selection link in levels page
	Then I search and select the tagname in levels page
	Then I Click and uncheck the selected tag in levels page
	Then I search and select any other tagname in levels page
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-09
Scenario: EwQIMS-430_Validate the user can enable allow site modification
	Given Login to the application with 'admin' user
	When Navigate to Levels in suite setup Page
	And I validate the Levels page
	And Create random Level
	Then I navigate to levels and click edit icon
	And I gave the access for site modification site sub level creation
	Then I Verify the site modification checkbox is enabled
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-10
Scenario: EwQIMS-431_Validate the user can disable allow site modification
	Given Login to the application with 'admin' user
	When Navigate to Levels in suite setup Page
	And I validate the Levels page
	And Create random Level
	Then I navigate to levels and click edit icon
	And I gave the access for site modification site sub level creation
	Then I uncheck the site modification checkbox and verify the checkbox is Unchecked
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

