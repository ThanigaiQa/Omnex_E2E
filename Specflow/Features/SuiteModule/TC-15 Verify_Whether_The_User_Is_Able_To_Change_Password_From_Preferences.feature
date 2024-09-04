Feature: TC-15 : Verify whether the user is able to change password from preferences

@TC-15
Scenario: 15 Verify whether the user is able to change password from preferences
	Given Login to the application with 'thani' user
	When I navigate to Users Page
	Then I create an user and update change Password preferences
	Then Login to the application with 'thani' user
	When I navigate to Users Page
	Then I search and validate user
	Then I delete the user