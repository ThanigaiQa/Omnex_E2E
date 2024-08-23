Feature: TC13-CreationAndDeletionCountry

A short summary of the feature

@TC-13
Scenario: TC13 Creation And Deletion Country
	Given Login to the application with 'thani' user
	When I Navigate to Country / Region page
	Then I Create country and I verify the country is created
	And I Delete the country
