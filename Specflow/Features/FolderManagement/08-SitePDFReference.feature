Feature: 08 Site PDF Reference

@TC-23015,16
Scenario: TC 23015_16 Validate the enable enhanced printing
	Given Login to the application with 'right' user
	When Navigate to PDF Preferences in suite setup Page
	Then I disable the Enhanced printing checkbox to verify the template is option is disabled
	Then I enable the Enhanced printing checkbox to verify the template is option is enabled

@TC-23020
Scenario: TC-23020 Validate Incude Template checkbox
	Given Login to the application with 'right' user
	When Navigate to PDF Preferences in suite setup Page
	And I Click the Include Template checkbox
	Then I refresh the page
	When Navigate to PDF Preferences in suite setup Page
	Then I validate The Include Template checkBox is checked

@TC-23017,18
Scenario: TC-23017_18 Validate Restricted View Checkbox
	Given Login to the application with 'right' user
	When Navigate to PDF Preferences in suite setup Page
	And I Click the Enable Restricked view checkbox
	Then I refresh the page
	When Navigate to PDF Preferences in suite setup Page
	Then I validate The Enable Restricked view checkBox is checked

