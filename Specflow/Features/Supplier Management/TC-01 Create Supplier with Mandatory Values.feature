Feature:TC-SM01 : Create Supplier

@TC-01 
Scenario:TC 01
#Scenario:01_Create Supplier
	Given Login to the application with 'kaalaa' user
	And Navigate to SupplierManagement Platform
	#When Navigate to SupplierSetup
	#Then Set Supplier Evaluation BusinessRule as No
	#Then Set Audit against Part as Yes
	And I Navigate to innermenu 'Supplier Management' and 'Supplier Onboarding' and 'Suppliers'
	And Create a New Supplier
	And Navigate to SupplierManagement Platform
	And I Navigate to innermenu 'Supplier Management' and 'Supplier Onboarding' and 'Suppliers'
	Then Search for Supplier and open it
	When Add Part for the Supplier
	Then Add Location for the Part
	Then uncheck SAM and SEM for Part
	And create a new Project for Supplier
	

@TC-02 
Scenario:TC 02
#Scenario:01_Search Supplier and Add parts
	Given Login to the application with 'kaalaa' user
	And Navigate to SupplierManagement Platform
	And I Navigate to innermenu 'Supplier Management' and 'Supplier Onboarding' and 'Suppliers'
	Then Search for Supplier and open it
	#When Add Part for the Supplier
	#Then Add Location for the Part
	#Then uncheck SAM and SEM for Part
	And create a new Project for Supplier
