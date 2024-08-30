Feature: TC - 10: Verify the User is able to creat and delete meetings

@TC-10
Scenario:10_Verify the User is able to creat and delete meetings
	Given Login to the application with 'thani' user
	When I Navigate to Meetings Page
	Then Create Meetings
	And I refresh the page
	Then I Navigate to Meetings Page
	And Delete the meetings
