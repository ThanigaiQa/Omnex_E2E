Feature: TC-16 : Verify the User preferences functionalities

@TC-16
Scenario: 16 Verify the User preferences functionalities
	Given Login to the application with 'thani' user
	When I navigate to Users Page
	Then I create an user and update user preferences
	Then Login to the application with 'thani' user
	When I navigate to Users Page
	Then I search and validate user
	Then I delete the user