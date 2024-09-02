Feature: TC  - 14 : Verify whether the user is able to create, search and delete user

@TC-14
Scenario: 14 Verify whether the user is able to create, search and delete user
	Given Login to the application with 'right' user
	When I navigate to Users Page
	Then I create an user
	Then I refresh the page
	When I navigate to Users Page
	Then I search and validate user
	Then I delete the user

	
