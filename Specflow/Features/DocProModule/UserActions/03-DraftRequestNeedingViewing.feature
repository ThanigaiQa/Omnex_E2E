Feature: Draft Request Needing Viewing

@TC-01
Scenario: TC 01 : DOC-2500-40-10-50
	Given Login to the application with 'thani' user
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
	When I click on Draft Request Needing Viewing menu
	Then I search the document
	Then I click on the hamburger menu
	And I verify the status value of the document as Reply
	When I click the status value link
	Then I add and verify the user can be added from the draft viewer in draft req needing viewing
	Then Logout from the application
	Then Login to the application with 'docpro' user
	Then Navigate to Actions in Documents Page
	When I click on Draft Request Needing Viewing menu
	Then I search the document
	Then I click on the hamburger menu
	And I verify the status value of the document as Reply
	When I click the status value link
	Then I reject the draft request in Draft Request Needing Viewing menu
	Then I refresh the page
	When I click on Draft Request Needing Viewing menu
	Then I search the document
	Then I click on the hamburger menu
	And I verify the status value of the document as Reply
	When I click the status value link
	Then I add comment in the draft
	Then Logout from the application
	Then Login to the application with 'thani' user
	#When I click on Pending Document Drafts menu
	#Then I search the document
	#Then I click on the hamburger menu
	#And I verify the status value of the document as In Process
	#Then I Terminate the document
	#Then I click on the hamburger menu
	#When Navigate to Levels in suite setup Page
	#Then I validate the Levels page
	#Then Delete the Level

@TC-02
Scenario: TC 02 : DOC-2500-40-60-100
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
	When I click on Draft Request Needing Viewing menu
	Then I click on the hamburger menu
	Then I search the document
	And I verify the status value of the document as Reply
	When I click the status value link
	Then I add comment in the draft
	Then I validate the Accept and Reject radio button is not present
	When I click on Pending Document Drafts menu
	Then I validate pending doc draft menu
	Then I search the document
	And I verify the status value of the document as In Process
	When I click the status value link
	Then I validate the latest comment is present in the draft details page
	Then I refresh the page
	Then Navigate to Actions in Documents Page
	When I click on Pending Document Drafts menu
	Then I validate pending doc draft menu
	Then I search the document
	Then I click on the hamburger menu
	When I click the status value link
	Then I Terminate the document
	Then I click on the hamburger menu
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level
	
	
	
