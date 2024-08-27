Feature: TC11_Creation_And_Deletion_Position

A short summary of the feature

@TC-11
Scenario: TC-11 Create And Delete Position
	Given Login to the application with 'thani' user
	When I Navigate to Positions page
    And I create a position for site 'Corporate' 
	Then verify the position is created
	And I Delete the position

