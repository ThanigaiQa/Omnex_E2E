Feature:TC-SM01 : Supplier PPAP

@TC-01
Scenario:TC 01
#Scenario:01_Create Supplier
#Prerequestie: Create a pillar 'Supplier PPAP' and Add a part 'Test Part'
	Given Login to the application with 'kaalaa' user
	And Navigate to SupplierManagement Platform
	And I Navigate to innermenu 'Supplier Management' and 'Supplier Onboarding' and 'Suppliers'
	And Create a New Supplier
	And Logout


@TC-02
Scenario:TC 02
	Given Login to the application with 'kaalaa' user
	And Navigate to SupplierManagement Platform
	And I Navigate to innermenu 'Supplier Management' and 'Supplier Onboarding' and 'Suppliers'
	Then Search for Supplier and open it
	When Add Part for the Supplier
	Then Add Location for the Part
	Then uncheck SAM and SEM for Part
	And Logout


@TC-03
Scenario:TC 03
	Given Login to the application with 'kaalaa' user
	And Navigate to SupplierManagement Platform
	And I Navigate to innermenu 'Supplier Management' and 'Supplier Onboarding' and 'Suppliers'
	Then Search for Supplier and open it	
	And create a new Project for Supplier
	And Add Task deatils for the Project
	And Add Input Documents for FirstTask
	And Add Input Documents for Second Task
	And Publish the Project
	And Logout



@TC-04 
Scenario:TC 04
#Scenario:01_Search Supplier and Add parts
	Given Login to the application as Primary Supplier user
	And I Navigate to innermenu 'Supplier Management' and 'APQP/PPAP' and 'Projects'
	And Select the ProjectName and open the task for 'PrimaryUser'
	And Attach Output document for the task
	And Update the task Completion Percentage as '100'
	And Logout
	
@TC-05
Scenario:TC 05
	Given Login to the application as Secondary Supplier user
	And I Navigate to innermenu 'Supplier Management' and 'APQP/PPAP' and 'My Deliverable List'
	And Navigate to Deliverable info Page
	And Attach Output document for the Secondary user
	And Update the task Completion for secondary user
	And Logout


@TC-06
Scenario:TC 06
	Given Login to the application with 'kaalaa' user
	And Navigate to SupplierManagement Platform
	And I Navigate to innermenu 'Supplier Management' and 'Supplier Onboarding' and 'Suppliers'
	Then Search for Supplier and open it
	And Update the Status of the Project as Completed.


#@TC-07
#Scenario:TC 07
	#Given Login to the application with 'kaalaa' user
	#And Navigate to SupplierManagement Platform
	#And Write into Json

	