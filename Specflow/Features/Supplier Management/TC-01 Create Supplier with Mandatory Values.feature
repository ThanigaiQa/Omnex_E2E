Feature:TC-SM01 : Create Supplier

@TC-SM01
Scenario:01_Create Supplier
	Given Login to the application with 'kaalaa' user
	And Navigate to SupplierManagement Platform
	And I Navigate to innermenu 'Supplier Management' and 'Supplier Onboarding' and 'Suppliers'
	When Create a New Supplier
	
