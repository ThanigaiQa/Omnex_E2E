Feature: Suite Module 03

Create the state.verify and delete the state

@TC-03
Scenario: 03_Create & Delete States
Given Login to the application
When I Navigate to State / Province Page
Then I Select "Algeria" and add the "Kerala" 
When I Navigate to State / Province Page
Then I Validate the newely created "Algeria" and "Kerala"
Then I delete the state

