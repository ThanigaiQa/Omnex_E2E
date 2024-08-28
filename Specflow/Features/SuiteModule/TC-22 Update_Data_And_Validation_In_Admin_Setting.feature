Feature: TC - 22 : Update data and Validate in Admin Setting
A short summary of the feature

@TC-22
Scenario:22_Update data and Validate in Admin Setting
	Given Login to the application with 'right' user
	When Navigate to Administrator Settings Page
	Then  Update the Admin Setting details 
	Then Logout from the application
	Then Login to the application with 'right' user
	When Navigate to Administrator Settings Page
	Then  Update the Admin Setting details 
	Then Logout from the application
