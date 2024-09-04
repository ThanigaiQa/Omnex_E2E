Feature: TC-19 Verify_The_Unlock_User_Functionality

A short summary of the feature

@TC-19
Scenario: Verify the unlock user functionality
	Given Login to the application with 'Right' user
	When I navigate to Unlock Users Page
	And I unlock the 'Thani' user
	Then I verify the user is unlocked
	
