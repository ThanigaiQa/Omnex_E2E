Feature: TC - 04 : Create And Delete Shift


@TC-04
Scenario: 04 Create And Delete Shift
	Given Login to the application with 'thani' user
	When I Navigate to Shift page
	Then I Create shift and I verify the shift is created
	And I Delete the shift
