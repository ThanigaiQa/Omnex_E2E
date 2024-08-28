Feature: TC - 03 : Create & Delete States

Create the state.verify and delete the state

@TC-03
Scenario: 03_Create & Delete States
Given Login to the application with 'thani' user
When I Navigate to State / Province Page
Then I Select "Anguilla" and add the "Kerala" 
When I Navigate to State / Province Page
Then I Validate the newely created "Anguilla" and "Kerala"
Then I delete the state

