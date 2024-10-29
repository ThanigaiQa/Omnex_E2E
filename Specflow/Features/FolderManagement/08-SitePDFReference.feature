Feature: 08 Site PDF Reference

@TC-23015,16
Scenario: TC 23015_16 Validate the enable enhanced printing
	Given Login to the application with 'right' user
	When Navigate to PDF Preferences in suite setup Page
	Then I disable the Enhanced printing checkbox to verify the template is option is disabled
	Then I enable the Enhanced printing checkbox to verify the template is option is enabled
