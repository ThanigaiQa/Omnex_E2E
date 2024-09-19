Feature: Levels

@Create-Delete-Level
Scenario: Create Delete Level
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I make the random level in use
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level
	
@TC-02
Scenario: TC 02 : DOC_2500_10_40_100_110_140_180_To_210
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I make the random level in use
	And I assign the route for the level with Assign by admin
	Then I refresh the page
	Then Navigate to New Document Request in Documents Page
	Then I validate the New Document Request in Documents Page
	And I choose existing level and upload new document in doc request page
	Then I refresh the page
	Then Navigate to Actions in Documents Page
	Then I validate the Actions in Documents Page
	Then I validate pending requests menu
	Then I search the document
	And I verify the status value of the document as In Process
	Then I Terminate the document
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-06
Scenario: TC 06 : DOC_2500_10_50_300
	Given Login to the application with 'docpro' user
	When Navigate to Business Rule in suite setup Page
	Then I validate the Business rule page
	Then I enable the DCN button in business rule page
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I make the random level in use
	And I assign the route for the level with Assign by admin
	Then I refresh the page
	Then Navigate to New Document Request in Documents Page
	Then I validate the New Document Request in Documents Page
	And I choose existing level and upload new document with DCN option in doc request page
	Then I refresh the page
	Then Navigate to Actions in Documents Page
	Then I validate the Actions in Documents Page
	Then I validate pending requests menu
	Then I search the document
	And I verify the status value of the document as In Process
	Then I terminate the DCN enabled document
	When Navigate to Business Rule in suite setup Page
	Then I validate the Business rule page
	Then I disable the DCN button in business rule page
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-03
Scenario: TC 03 : DOC_2500_10_30_40_90
	Given Login to the application with 'docpro' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I make the random level in use
	And I assign the route for the level with DocProAdmin
	Then Logout from the application
	Then Login to the application with 'right' user
	Then Navigate to New Document Request in Documents Page
	Then I validate the New Document Request in Documents Page
	And I choose existing level and upload new document in doc request page
	Then I refresh the page
	Then Navigate to Actions in Documents Page
	Then I validate the Actions in Documents Page
	Then I validate pending requests menu
	Then I search the document
	And I verify the status value of the document as In Process
	Then I Terminate the document
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-05
Scenario: TC 05: DOC_2500_10_100
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I make the random level in use
	Then I Open the Right for Group for the level
	Then I Set Attach Rights for the New Document Creation
	Then I Set View Only permission for New Document Access
	Then I refresh the page
	Then Navigate to New Document Request in Documents Page
	Then I validate the New Document Request in Documents Page
	And I choose existing level and create new document in doc request page
	Then I refresh the page
	Then Navigate to Actions in Documents Page
	Then I validate the Actions in Documents Page
	Then I validate pending requests menu

@TC-01
Scenario: TC 01 : DOC_2500_10_10
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I make the random level in use
	Then I refresh the page
	Then Navigate to New Document Request in Documents Page
	Then I validate the New Document Request in Documents Page
	And I choose existing level and upload new document in doc request page
	Then I refresh the page
	Then Navigate to Actions in Documents Page
	Then I validate the Actions in Documents Page
	Then I verify the document is not present in pending request menu
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	#And I select rights for group for the level
	Then I give full access for the document
	Then Navigate to Documents in Documents Page
	Then I choose the random level and select change request
	Then I delete the document in document toc
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-07
Scenario: TC 07 : DOC_2500_10_70_80
	Given Login to the application with 'Thani' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I make the random level in use
	And I assign the route for the level with PositionBasedRoute
	Then I refresh the page
	Then Navigate to New Document Request in Documents Page
	Then I validate the New Document Request in Documents Page
	And I choose existing level and upload new document in doc request page
	Then I refresh the page
	Then Navigate to Actions in Documents Page
	Then I validate the Actions in Documents Page
	Then I validate pending requests menu
	Then I search the document
	And I verify the status value of the document as In Process
	Then Logout from the application
	Then Login to the application with 'docpro' user
	Then Navigate to Actions in Documents Page
	Then I validate Requests Needing Approval menu
	Then I search the document
	And I verify the status value of the document as Reply
	Then I reject the document by providing Second Password
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level