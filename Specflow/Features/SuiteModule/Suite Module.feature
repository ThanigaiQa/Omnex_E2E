Feature: Suite Module

@TC-01
Scenario: 01 Verify remember me functionality
	Given Login to the application with 'thani' user
	When Logout from the application
	Then Validate the remember me option

@TC-02
Scenario: 02 Create, Modify & Delete Tags
	Given Login to the application with 'docpro' user
	When Navigate to 'Master Folder Tags' in suite setup Page
	Then I click on the add button and Create new tag
	Then I click the newly created tag and rename the tagname
	And I click on the newly created tag and delete the tag

@TC-03
Scenario: 03 Create & Delete States
	Given Login to the application with 'thani' user
	When I Navigate to 'State / Province' in system Page
	Then I Select "Anguilla" and add the "Kerala"
	When I Navigate to State / Province in system Page
	Then I Validate the newely created "Anguilla" and "Kerala"
	Then I delete the state

@TC-04
Scenario: 04 Create And Delete Shift
	Given Login to the application with 'thani' user
	When I Navigate to Shift in system Page
	Then I Create shift and I verify the shift is created
	And I Delete the shift

@TC-05
Scenario: 05 Creation And Deletion Vendor
	Given Login to the application with 'thani' user
	When I Navigate to Vendor / Registrar in system Page
	Then I create a vendor
	Then I add address,contact and verify the address and contact is added
	Then I refresh the page
	When I Navigate to Vendor / Registrar in system Page
	Then I change the page record size
	And I delete the vendor

@TC-06
Scenario: 06 Verify Create and Delete Suplier
	Given Login to the application with 'docpro' user
	When I Navigate to Supplier Information in system Page
	Then Create Supplier
	And I refresh the page
	Then I Navigate to Supplier Information in system Page
	And Delete the Supplier

@TC-07
Scenario: 07 Verify the User is able to create,delete manufacturer
	Given Login to the application with 'Thani' user
	When I Navigate to Manufacturer in system Page
	Then I create a manufacturer
	Then I add address,contact and verify the address and contact is added
	Then I refresh the page
	When I Navigate to Manufacturer in system Page
	Then I change the page record size
	And I delete the manufacturer

@TC-08
Scenario: 08 Verify the User is able to create,delete Customer
	Given Login to the application with 'Right' user
	When I Navigate to Customers in system Page
	Then I create a customer
	Then I add address,contact and verify the address and contact is added
	Then I refresh the page
	When I Navigate to Customers in system Page
	Then I change the page record size
	And I delete the customer

@TC-09
Scenario: 09 Verify the User is able to create, delete Team
	Given Login to the application with 'Right' user
	When I Navigate to Teams in system Page
	Then I create the team
	Then I verify the team is created
	Then I delete the team and verify the alert message

@TC-10
Scenario: 10 Verify the User is able to creat and delete meetings
	Given Login to the application with 'thani' user
	When I Navigate to Meetings in system Page
	Then Create Meetings
	And I refresh the page
	Then I Navigate to Meetings in system Page
	And Delete the meetings

@TC-11
Scenario: 11 Create And Delete Position
	Given Login to the application with 'thani' user
	When I Navigate to Positions in system Page
	And I create a position for site 'Corporate'
	Then verify the position is created
	And I Delete the position

@TC-12
Scenario: 12 Verify the Forgot password functionality
	Given Login to the application with 'docpro' user
	When I navigate to Users in users Page
	Then I create an user and change password
	Then Login to the application with 'docpro' user
	When I navigate to Users in users Page
	Then I search and validate user
	Then I delete the user

@TC-13
Scenario: 13 Creation And Deletion Country
	Given Login to the application with 'thani' user
	When I Navigate to Country / Region in system Page
	Then I Create country and I verify the country is created
	And I Delete the country

@TC-14
Scenario: 14 Verify whether the user is able to create, search and delete user
	Given Login to the application with 'right' user
	When I navigate to Users in users Page
	Then I create an user
	Then I refresh the page
	When I navigate to Users in users Page
	Then I search and validate user
	Then I delete the user

@TC-15
Scenario: 15 Verify whether the user is able to change password from preferences
	Given Login to the application with 'thani' user
	When I navigate to Users in users Page
	Then I create an user and update change Password preferences
	Then Login to the application with 'thani' user
	When I navigate to Users in users Page
	Then I search and validate user
	Then I delete the user

@TC-16
Scenario: 16 Verify the User preferences functionalities
	Given Login to the application with 'thani' user
	When I navigate to Users in users Page
	Then I create an user and update user preferences
	Then Login to the application with 'thani' user
	When I navigate to Users in users Page
	Then I search and validate user
	Then I delete the user

@TC-17
Scenario: 17 Verify the User is able to create,Modify,delete groups and add and remove users
	Given Login to the application with 'Thani' user
	When Navigate to 'Groups' in suite setup Page
	Then I click on the add button and Create new group
	Then I add user for the created group
	Then I refresh the page
	When Navigate to 'Groups' in suite setup Page
	Then I remove the added user for the group
	Then I refresh the page
	When Navigate to 'Groups' in suite setup Page
	Then I click the newly created group and rename the groupName
	And I click on the newly created group and delete the group

@TC-18
Scenario: 18 Verify The User able to Add and Remove the User for Module
	Given Login to the application with 'docpro' user
	When Navigate to 'Modules' in suite setup Page
	Then Add User for Module Page
	And Validate the newely added user
	Then Remove the Added user

@TC-19
Scenario: 19 Verify the unlock user functionality
	Given Login to the application with 'Right' user
	When I navigate to Unlock Users in users Page
	And I unlock the 'Thani' user
	Then I verify the user is unlocked

@TC-20
Scenario: 20 creation and deletion city
	Given Login to the application with 'thani' user
	When I Navigate to City in system Page
	Then I Select country "Pondy" and add the city "Madurai"
	When I Navigate to City in system Page
	Then I Validate the newely created "Pondy" and the city "Madurai"
	Then I delete the city

@TC-21
Scenario: 21 Update data and Validate in Organization profile
	Given Login to the application with 'thani' user
	When I Navigate to Organization Profile in system Page
	Then Update the Organization profile details

@TC-22
Scenario: 22 Update data and Validate in Admin Setting
	Given Login to the application with 'right' user
	When Navigate to 'Administrator Settings' in suite setup Page
	Then Update the Admin Setting details
	Then Logout from the application
	Then Login to the application with 'right' user
	When Navigate to 'Administrator Settings' in suite setup Page
	Then Update the Admin Setting details
	Then Logout from the application

@TC-23
Scenario: 23 Create Country, State, and City functionalities
	Given Login to the application with 'right' user
	When I Navigate to Country / Region in system Page
	Then I create country
	Then I refresh the page
	When I Navigate to State / Province in system Page
	Then I create state
	Then I refresh the page
	When I Navigate to City in system Page
	Then I create city
	Then I refresh the page
	When I Navigate to City in system Page
	Then I delete city
	Then I refresh the page
	When I Navigate to State / Province in system Page
	Then I delete state
	Then I refresh the page
	When I Navigate to Country / Region in system Page
	Then I delete country

