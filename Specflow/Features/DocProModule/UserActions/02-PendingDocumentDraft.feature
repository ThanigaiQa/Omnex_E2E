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
	When I click the status value link
	Then I add comment in the draft
	When I click on Pending Document Drafts menu
	Then I search the document
	Then I add and verify the user can be added from the draft viewer
	Then I verify the user can be removed from the draft viewer
	When I click on Pending Document Drafts menu
	Then I search the document
	When I click the status value link
	Then I Terminate the document
	Then I click on the hamburger menu
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-02
Scenario: TC 02 : DOC_2500_20_200_230_250_300_330
	Given Login to the application with 'fsqa' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I make the random level in use
	Then Navigate to New Document Draft in Documents Page
	Then I validate the New Document Draft in Documents Page
	And I choose existing level and upload new document in pending doc draft page
	When I click on Draft Request Needing Viewing menu
	Then I search the document
	Then I Click on Reply button to add new comment
	Then I refresh the page
	Then Navigate to Actions in Documents Page
	When I click on Pending Document Drafts menu
	Then I validate pending doc draft menu
	Then I search the document
	Then I Click on In Process button to Validate newest comment
	Then I refresh the page
	Then Navigate to Actions in Documents Page
	When I click on Draft Request Needing Viewing menu
	Then I search the document
	Then I Click on Reply button to add old comment
	Then I refresh the page
	Then Navigate to Actions in Documents Page
	When I click on Pending Document Drafts menu
	Then I validate pending doc draft menu
	Then I search the document
	Then I Click on In Process button to Validate oldest comment
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
	And  I Validate the Change Request screen
	Then I refresh the page
	Then Navigate to Actions in Documents Page
	When I click on Pending Document Drafts menu
	Then I search the document
	When I click the status value link
	Then I Terminate the document
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level
	

@TC-03
Scenario: TC 03 : DOC_2500_20_310
 Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I make the random level in use
	Then Navigate to New Document Draft in Documents Page
	Then I validate the New Document Draft in Documents Page
	And I choose existing level and upload new document in pending doc draft page
	When I click on Pending Document Drafts menu
	Then I validate pending doc draft menu
	Then I search the document
	Then I click on the hamburger menu
	And I verify the status value of the document as In Process
	When I click the status value link
    Then I click on change request button in pending doc draft menu
	Then I choose the date and enter the reason for change , description in change request screen
	Then I select Attach Draft in change request screen
	Then I click on the hamburger menu
	When Navigate to DocPro Setup in suite setup Page
	Then I Open the Right for Group for the level
	Then I search for rights in document rights page
	Then I give full access for the document
	Then Navigate to Documents in Documents Page
	Then I choose the random level and select change request
	Then I delete the document in document toc
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-04
Scenario: TC 04  : DOC_2500_20_340
	Given Login to the application with 'thani' user
	When Navigate to Business Rule in suite setup Page
	Then I validate the Business rule page
	Then I enable the Interface Agreement button in business rule page
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I make the random level in use
	Then Navigate to New Document Draft in Documents Page
	Then I validate the New Document Draft in Documents Page
	And I choose existing level and upload new document in pending doc draft page
	When I click on Pending Document Drafts menu
	Then I validate pending doc draft menu
	Then I search the document
	Then I click on the hamburger menu
	And I verify the status value of the document as In Process
	When I click the status value link
    Then I click on change request button in pending doc draft menu
	Then I choose the date and enter the reason for change , description in change request screen
	Then I select Attach Draft in change request screen
	Then I click on the hamburger menu
	When Navigate to DocPro Setup in suite setup Page
	Then I Open the Right for Group for the level
	Then I search for rights in document rights page
	Then I give full access for the document
	Then Navigate to Documents in Documents Page
	Then I choose the random level and select change request
	Then I delete the document in document toc
	When Navigate to Business Rule in suite setup Page
	Then I validate the Business rule page
	Then I disable the Interface Agreement button in business rule page
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level


@TC-05
Scenario: TC 05 : DOC_2500_20_350
	Given Login to the application with 'thani' user
	When Navigate to Business Rule in suite setup Page
	Then I validate the Business rule page
	Then I enable the Interface Agreement button in business rule page
	Then I refresh the page
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
	When I click the status value link
	Then I click on change request button in pending doc draft menu
	Then I choose the date and enter the reason for change , description in change request screen
	Then I select online document in change request screen
	Then I click on the hamburger menu
	When I click on Pending Requests menu
	Then I validate pending requests menu
	Then I search the document
	And I verify the status value of the document as Need Attachment
	Then Navigate to Administrator Actions in Documents Page
	Then I validate assign author menu
	Then I search the document
	And I verify the status value of the document as Assign
	Then Assign the author for the created document
	Then Logout from the application
	Then Login to the application with 'docpro' user
	Then Navigate to Actions in Documents Page
	Then I validate the Documents needing revision menu
	Then I search the document
	And I verify the status value of the document as Attach Document
	And I Attach the document
	When Navigate to DocPro Setup in suite setup Page
	Then I Open the Right for Group for the level
	Then I search for rights in document rights page
	Then I give full access for the document
	Then Navigate to Documents in Documents Page
	Then I choose the random level and select change request
	Then I delete the document in document toc
	When Navigate to Business Rule in suite setup Page
	Then I validate the Business rule page
	Then I disable the Interface Agreement button in business rule page
	Then I refresh the page
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level

@TC-06
Scenario: TC 06 : DOC_2500_20_190
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
	When I click the status value link
	Then I verify the user who already commented on the draft is not present in draft viewer
	When I click on Pending Document Drafts menu
	Then I search the document
	When I click the status value link
	Then I Terminate the document
	Then I click on the hamburger menu
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level
	
@TC-07
Scenario: TC 07 : DOC_2500_20_50
    Given Login to the application with 'right' user
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Create random Level
	Then I refresh the page
	When Navigate to DocPro Setup in suite setup Page
	Then I make the random level in use
	Then Navigate to New Document Draft in Documents Page
	Then I validate the New Document Draft in Documents Page
	And I choose existing level and upload new document in pending doc draft page
	When I click on Pending Document Drafts menu
	Then I validate pending doc draft menu
	Then I search the document
	Then I click on the hamburger menu
	And I Validate the status column placed at the right most end
	And I verify the status value of the document as In Process
	When I click the status value link
	Then I Terminate the document
	Then I click on the hamburger menu
	When Navigate to Levels in suite setup Page
	Then I validate the Levels page
	Then Delete the Level





	