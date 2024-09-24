Feature: Pending Document Draft

@TC-01
Scenario: TC 01 : DOC_2500_20_10_80_120_180
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I make the random level in use
	Then I refresh the page
	Then Navigate to New Document Draft in Documents Page
	Then I validate the New Document Draft in Documents Page
	And I choose existing level and upload new document in pending doc draft page
	Then I refresh the page
	Then Navigate to Actions in Documents Page
	Then I validate the Actions in Documents Page
	When I click on Pending Document Drafts menu
	Then I validate pending doc draft menu
	Then I search the document
	Then I click on the hamburger menu
	And I verify the status value of the document as In Process
	Then I verify the color code of In Process link
	When I click on Draft Request Needing Viewing menu
	Then I search the document
	And I verify the status value of the document as Reply
	Then I add comment in the draft
	When I click on Pending Document Drafts menu
	Then I search the document
	Then I add and verify the user can be added from the draft viewer
	Then I verify the user can be removed from the draft viewer
	When I click on Pending Document Drafts menu
	Then I search the document
	Then I Terminate the document
	Then I click on the hamburger menu
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level
	


	