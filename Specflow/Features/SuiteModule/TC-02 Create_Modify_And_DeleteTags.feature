Feature: Suite Module


#@10674
#Scenario: 01_Create & Delete level
#
#    Given  Login to the application
#    When Navigate to Levels Page
#    And Create Random Level
#    And Edit the Level
#    Then Delete the Level

@TC-02
Scenario: 02_Create, Modify & Delete Tags
Given Login to the application
When Navigate to Master Folder Tags Page
Then I click on the add button and Create new tag
Then I click the newly created tag and rename the tagname
And I click on the newly created tag and delete the tag



   
