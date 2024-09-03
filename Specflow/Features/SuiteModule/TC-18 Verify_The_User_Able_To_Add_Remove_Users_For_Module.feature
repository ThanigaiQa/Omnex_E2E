Feature: TC - 18:Verify The User able to Add and Remove the User for Module

@TC-18
Scenario:18_Verify The User able to Add and Remove the User for Module
	Given Login to the application with 'docpro' user
	When  Navigate to Modules Page
	Then Add User for Module Page 
	And Validate the newely added user
	Then Remove the Added user
	

