Feature: TC-23 Create_Country_State_And_City_Functionalities

@TC-23
Scenario: 23 Create Country, State, and City functionalities
	Given Login to the application with 'right' user
	When I Navigate to Country / Region Page
	Then I create country
	Then I refresh the page
	When I Navigate to State / Province Page
	Then I create state
	Then I refresh the page
	When I Navigate to City Page
	Then I create city
	Then I refresh the page
	When I Navigate to City Page
	Then I delete city
	Then I refresh the page
	When I Navigate to State / Province Page
	Then I delete state
	Then I refresh the page
	When I Navigate to Country / Region Page
	Then I delete country
	
