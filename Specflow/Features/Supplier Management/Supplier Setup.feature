Feature: Supplier Setups

@TC-01 
#Scenario:TC 01 : Create Supplier Route
Scenario:TC 01
	Given Login to the application with 'kaalaa' user
	And Navigate to SupplierManagement Platform
	And I Navigate to innermenu 'Setup' and 'Suite Setup' and 'Document Route'
	And Create a new Document route


@TC-02
#Scenario:TC 02 : Add Approvers for Supplier Route
Scenario:TC 02
	Given Login to the application with 'kaalaa' user
	And Navigate to SupplierManagement Platform
	And I Navigate to innermenu 'Setup' and 'Suite Setup' and 'Document Route'
	When Open the Supplier Route
	Then Assign approvers for the route
	
	
@TC-03
#Scenario:TC 03 : Remove Approvers for Supplier Route
Scenario:TC 03
	Given Login to the application with 'kaalaa' user
	And Navigate to SupplierManagement Platform
	And I Navigate to innermenu 'Setup' and 'Suite Setup' and 'Document Route'
	When Open the Supplier Route
	Then Remove Approver from Route

@TC-04
#Scenario:TC 04 : Delete Supplier Route
Scenario:TC 04
	Given Login to the application with 'kaalaa' user
	And Navigate to SupplierManagement Platform
	And I Navigate to innermenu 'Setup' and 'Suite Setup' and 'Document Route'
	When Open the Supplier Route
	Then Delete from Route

@TC-05
#Scenario:TC 05 : Create Supplier Group
Scenario:TC 05
	Given Login to the application with 'kaalaa' user
	And Navigate to SupplierManagement Platform
	And I Navigate to innermenu 'Setup' and 'Suite Setup' and 'Groups'
	And Select SupplierManagement Module
	And Create a new Group

@TC-06
#Scenario:TC 06 : Assign Rights and user for Supplier Group
Scenario:TC 06
	Given Login to the application with 'kaalaa' user
	And Navigate to SupplierManagement Platform
	And I Navigate to innermenu 'Setup' and 'Suite Setup' and 'Groups'
	And Select SupplierManagement Module
	When Select the Automation Group
	Then Assign User for Automation Group

@TC-07
#Scenario:TC 07 : Remove user from Supplier Group
Scenario:TC 07
	Given Login to the application with 'kaalaa' user
	And Navigate to SupplierManagement Platform
	And I Navigate to innermenu 'Setup' and 'Suite Setup' and 'Groups'
	And Select SupplierManagement Module
	When Select the Automation Group
	Then Remove User from Automation Group

@TC-08
#Scenario:TC 08 : Delete Supplier Group
Scenario:TC 08 
	Given Login to the application with 'kaalaa' user
	And Navigate to SupplierManagement Platform
	And I Navigate to innermenu 'Setup' and 'Suite Setup' and 'Groups'
	And Select SupplierManagement Module
	And Delete Automation Group

@TC-09
#Scenario:TC 09 : Create a Supplier Type
Scenario:TC 09
	Given Login to the application with 'kaalaa' user
	And Navigate to SupplierManagement Platform
	When Navigate to SupplierSetup
	Then Create Supplier Type


@TC-10
#Scenario:TC 10 : Edit a Supplier Type
Scenario:TC 10
	Given Login to the application with 'kaalaa' user
	And Navigate to SupplierManagement Platform
	When Navigate to SupplierSetup
	Then Edit Supplier Type

@TC-11
#Scenario:TC 11 : Create a Part Type
Scenario:TC 11
	Given Login to the application with 'kaalaa' user
	And Navigate to SupplierManagement Platform
	When Navigate to SupplierSetup
	Then Create a Part Type

@TC-12
#Scenario:TC 12 : Edit a Part Type
Scenario:TC 12
	Given Login to the application with 'kaalaa' user
	And Navigate to SupplierManagement Platform
	When Navigate to SupplierSetup
	Then Edit Part Type

@TC-13
#Scenario:TC 13 : Create a level for Supplier Management 
Scenario:TC 13
	Given Login to the application with 'kaalaa' user
	And Navigate to SupplierManagement Platform
	And I Navigate to innermenu 'Setup' and 'Suite Setup' and 'Levels'
	Then I validate the Levels page
	Then Create SupplierManagement Level
	Then I refresh the page
	And I Navigate to innermenu 'Setup' and 'Suite Setup' and 'DocPro Setup'
	Then I make the SupplierManagement level in use

@TC-14
#Scenario:TC 14 : Set Level for Supplier Management
Scenario:TC 14
	Given Login to the application with 'kaalaa' user
	And Navigate to SupplierManagement Platform
	When Navigate to SupplierSetup
	Then Set Level for Supplier Management

