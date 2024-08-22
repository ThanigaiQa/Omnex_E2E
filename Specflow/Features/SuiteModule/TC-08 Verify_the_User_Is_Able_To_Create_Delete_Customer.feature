Feature: TC - 08 : Verify the User is able to create,delete Customer

@TC-08
Scenario: 08 Verify the User is able to create,delete Customer
Given Login to the application with 'Right' user
When I Navigate to Customers Page
Then I create a customer
Then I add address,contact and verify the address and contact is added
Then I refresh the page
When I Navigate to Customers Page
Then I change the page record size
And I delete the customer