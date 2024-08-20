Feature: Suite Module 09

@TC-09
Scenario: 09 Verify the User is able to create, delete Team
Given Login to the application
When I Navigate to Teams Page
Then I create team and verify the team is created
When I Navigate to Teams Page
Then I delete the team
