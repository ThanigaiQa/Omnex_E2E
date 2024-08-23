Feature: TC - 07 : Verify the User is able to create,delete manufacturer

@TC-07
Scenario: 07 Verify the User is able to create,delete manufacturer
	Given Login to the application with 'Thani' user
	When I Navigate to Manufacturer Page
	Then I create a manufacturer
	Then I add address,contact and verify the address and contact is added
	Then I refresh the page
	When I Navigate to Manufacturer Page
    Then I change the page record size
	And I delete the manufacturer