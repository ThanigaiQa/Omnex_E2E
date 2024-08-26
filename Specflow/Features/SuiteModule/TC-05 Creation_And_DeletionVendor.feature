Feature: TC-05 Creation_And_DeletionVendor

A short summary of the feature

@TC-05
Scenario: TC05 Creation And Deletion Vendor
	Given Login to the application with 'thani' user
	When I Navigate to Vendor / Registrar page
	Then I create a vendor
	Then I add address,contact and verify the address and contact is added
	Then I refresh the page
    When I Navigate to Vendor / Registrar page
    Then I change the page record size
    And I delete the vendor
