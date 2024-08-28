Feature: TC-20 Creation_And_Deletion_City

A short summary of the feature

@TC-20
Scenario: TC-20 creation and deletion city
	Given Login to the application with 'thani' user
	When I Navigate to City Page
    Then I Select country "Pondy" and add the city "Madurai"
    When I Navigate to City Page
    Then I Validate the newely created "Pondy" and the city "Madurai"
    Then I delete the city

