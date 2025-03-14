﻿Feature: Draft Request Needing Viewing

@TC-01
Scenario: TC 01 : DOC-2500-40-10-50
	Given Login to the application with 'thani' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I make the level in use
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
	Then I add comment in the draft
	Then Logout from the application
	Then Login to the application with 'thani' user
	When I click on Pending Document Drafts menu
	Then I search the document
	Then I click on the hamburger menu
	And I verify the status value of the document as In Process
	Then I Terminate the document
	Then I click on the hamburger menu
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-02
Scenario: TC 02 : DOC-2500-40-60-100
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I make the level in use
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

@TC-03
Scenario: TC 03 : DOC-2500-40-110-130
    Given Login to the application with 'thani' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I make the level in use
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
	Then I add and verify the user can be added from the draft viewer in draft req needing viewing
	Then Logout from the application
	Then Login to the application with 'docpro' user
	Then Navigate to Actions in Documents Page
	Then I validate the Actions in Documents Page
	When I click on Draft Request Needing Viewing menu
	Then I click on the hamburger menu
	Then I search the document
	And I verify the status value of the document as Reply
	When I click the status value link
	And I click the Accept radio button
	Then I add comment in the draft
	Then I Validate the Accept and Reject radio is disabled or not
	Then I Validate the background color of Accepted badge
	Then Logout from the application
	Then Login to the application with 'thani' user
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
	Then I add and verify the user can be added from the draft viewer in draft req needing viewing
	Then Logout from the application
	Then Login to the application with 'docpro' user
	Then Navigate to Actions in Documents Page
	Then I validate the Actions in Documents Page
	When I click on Draft Request Needing Viewing menu
	Then I click on the hamburger menu
	Then I search the document
	And I verify the status value of the document as Reply
	When I click the status value link
	Then I reject the draft request in Draft Request Needing Viewing menu
	Then I add comment in the draft
	Then I Validate the background color of Rejected badge

@TC-04
Scenario: TC 04 : DOC-2500-40-50-010
	Given Login to the application with 'fsqa' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I make the level in use
	Then Navigate to New Document Draft in Documents Page
	Then I validate the New Document Draft in Documents Page
	And I choose existing level and upload new document in pending doc draft page
	When I click on Draft Request Needing Viewing menu
	Then I search the document
	Then I Click on Reply button to add old comment
	Then I refresh the page
	Then Navigate to Actions in Documents Page
	When I click on Draft Request Needing Viewing menu
	Then I search the document
	Then I Click on Reply button to add upvote to the comment
	Then I refresh the page
	Then Navigate to Actions in Documents Page
	When I click on Pending Document Drafts menu
	Then I validate pending doc draft menu
	Then I search the document
	Then I Click on In Process button to Validate upvote comment
	Then I refresh the page
	Then Navigate to Actions in Documents Page
	When I click on Pending Document Drafts menu
	Then I search the document
	When I click the status value link
	Then I Terminate the document
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-05
Scenario: TC 05 : DOC-2500-40-020
	Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I search and click the random level in folder management page
	Then I make the level in use
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
		


	
	
