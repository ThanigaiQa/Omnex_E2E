Feature: TC-12 : Verify the Forgot password functionality

@TC-12
Scenario: 12 Verify the Forgot password functionality
	Given Login to the application with 'docpro' user
	When I navigate to Users Page
	Then I create an user and change password
	Then Login to the application with 'docpro' user
	When I navigate to Users Page
	Then I search and validate user
	Then I delete the user
