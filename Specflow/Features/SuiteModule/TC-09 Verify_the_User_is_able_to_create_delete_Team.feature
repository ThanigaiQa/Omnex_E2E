Feature: TC - 09 : Verify the User is able to create, delete Team

@TC-09
Scenario: 09 Verify the User is able to create, delete Team
Given Login to the application with 'Right' user
When I Navigate to Teams Page
Then I create the team
Then I verify the team is created
Then I delete the team and verify the alert message
