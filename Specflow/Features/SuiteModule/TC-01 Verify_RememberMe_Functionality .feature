Feature:TC - 01 : Verify Remember me functionality

@TC-01
Scenario:01_Verify remember me functionality
	Given Login to the application with 'thani' user
	When Logout from the application
	Then Validate the remember me option
