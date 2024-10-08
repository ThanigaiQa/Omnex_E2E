Feature:TC-SM01 : Create Supplier Evaluation Request

@TC-SM02
Scenario:01_Create Supplier Evaluation request
	Given Login to the application with 'kaalaa' user
	And Navigate to SupplierManagement Platform
	When Navigate to SupplierSetup
	Then Set Supplier Evaluation BusinessRule
	And I Navigate to innermenu 'Supplier Management' and 'Supplier Onboarding' and 'Suppliers'
	And Fill supplier Evaluation without Route