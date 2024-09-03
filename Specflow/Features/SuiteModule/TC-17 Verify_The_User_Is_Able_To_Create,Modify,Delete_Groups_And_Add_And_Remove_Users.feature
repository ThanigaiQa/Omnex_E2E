Feature: TC-17 Verify_The_User_Is_Able_To_Create,Modify,Delete_Groups_And_Add_And_Remove_Users

A short summary of the feature

@TC-17
Scenario: TC-17 Verify the User is able to create,Modify,delete groups and add and remove users

	Given Login to the application with 'Thani' user
	When Navigate to Groups Page
	Then I click on the add button and Create new group
	Then I add user for the created group 
	Then I refresh the page
	When Navigate to Groups Page
	Then I remove the added user for the group
	Then I refresh the page
	When Navigate to Groups Page
	Then I click the newly created group and rename the groupName
	And I click on the newly created group and delete the group
