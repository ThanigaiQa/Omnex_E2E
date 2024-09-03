Feature: TC - 06: Create and Delete Supplier

@TC-06
Scenario:06_Verify Create and Delete Suplier
	Given Login to the application with 'docpro' user
	When I Navigate to Supplier Information Page
	Then Create Supplier
	And I refresh the page
	Then I Navigate to Supplier Information Page
	And Delete the Supplier
