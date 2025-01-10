Feature: Suite Administrator can create the levels

@TC-01
Scenario: EwQIMS_15729_Reset button
	Given Login to the application with 'admin' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Validate the Reset button

@TC-02
Scenario: EwQIMS_10816_Frequency Validation	`
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
	Then I navigate to levels and click edit icon
	Then I verify the tag selection link is present in levels page
	Then I click on the tag selection link in levels page
	Then I search and select the tagname in levels page
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

@TC-11
Scenario: EwQIMS-47452_Validate special characters in level name and Prefix
	Given Login to the application with 'admin' user
	When Navigate to Levels in suite setup Page
	And I validate the Levels page
	And Create random Level
	Then I navigate to levels and click edit icon
	Then I enter special characters into the Prefix field and verify that it accepts them
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-12
Scenario: EwQIMS-439_Delete validation with dependency
	Given Login to the application with 'admin' user
	When Navigate to Levels in suite setup Page
	And I validate the Levels page
	And Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I make the level in use
	Then I refresh the page
	Then Navigate to New Document Draft in Documents Page
	Then I validate the New Document Draft in Documents Page
	And I choose existing level and upload new document in pending doc draft page
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I navigate to levels and click edit icon
	Then I validate the Levels page
	Then Delete the Level
	Then I validate that the level is not deleted and a dependency alert message is displayed

@TC-13
Scenario: EwQIMS-47491_Validate whether the system accepts the space as a character to create Level name
	Given Login to the application with 'admin' user
	When Navigate to Levels in suite setup Page
	And I validate the Levels page
	Then I validate the level name field should not accept blank space as input

@TC-14
Scenario: EwQIMS-47494_To validate whether the system accepts the all special characters to create in the level name
	Given Login to the application with 'admin' user
	When Navigate to Levels in suite setup Page
	And I validate the Levels page
	Then I validate the level name field should is accepting special characters as input
	Then I delete the level name with special characters

@TC-15
Scenario: EwQIMS-15739_To validate whether the system accepts the user can enter alphabet (Upper and Lower) in Level Name/Prefix field
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	And I validate the Levels page
	Then I validate the level name and prefix field should is accepting upper and lower characters characters as input
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then I delete the level name with Upper and lower character

@TC-16
Scenario: EwQIMS-10805_Validate Level Number as Blank Space
	Given Login to the application with 'admin' user
	When Navigate to Levels in suite setup Page
	And I validate the Levels page
	Then I validate the level number field should not accept blank space as input

@TC-17
Scenario: EwQIMS-15728_Validate Prefix with Special characters
	Given Login to the application with 'admin' user
	When Navigate to Levels in suite setup Page
	And I validate the Levels page
	Then I validate the prefix field should is accepting special characters as input
	Then I delete the prefix with special characters

@TC-18
Scenario: EwQIMS-15733_Validate whether the system accepts the user can create/Edit the 'Level Number' field
	Given Login to the application with 'admin' user
	When Navigate to Levels in suite setup Page
	And I validate the Levels page
	Then I validate the level number field is disabled after clicking no in level num alert popup

@TC-19
Scenario: EwQIMS-32426_Validate the system should show correct parent level name when creating subchild level
	Given Login to the application with 'admin' user
	When Navigate to Levels in suite setup Page
	And I validate the Levels page
	Then I give sublevel access for the level 
	Then Create random Level
	When I click on the refresh button in level page
	Then I right click the random level and click new option
	Then I give sublevel access for the level 
	Then I create a new subfolder level 
	When I click on the refresh button in level page
	Then I verify the subfolder is created for the parent level
	Then I right click the subfolder level and click new option
	Then I create new Subchild level
	When I click on the refresh button in level page
	Then I verify the Subchild level is created for the subfolder
	When I click on the refresh button in level page
	Then Delete the Level

@TC-20
Scenario: EwQIMS-32424_To validate the system should not duplicate the subfolders when creating
	Given Login to the application with 'admin' user
	When Navigate to Levels in suite setup Page
	And I validate the Levels page
	Then I give sublevel access for the level 
	Then Create random Level
	When I click on the refresh button in level page
	Then I right click the random level and click new option
	Then I create a new subfolder level 
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then  Right click the level and select the new button to create the sublevel
	Then I Validate the level name is already being used warning for duplicate level creation

@TC-21
Scenario: EwQIMS-47529_Validate whether the parent level name field displays with empty and grey out initially
	Given Login to the application with 'admin' user
	When Navigate to Levels in suite setup Page
	And I validate the Levels page
	Then I validate the parent level name field is greyed out before giving input


	