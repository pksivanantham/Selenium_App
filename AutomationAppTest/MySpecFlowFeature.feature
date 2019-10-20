Feature: MySpecFlowFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have also entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

Scenario:Open a browser
	Given I have a website url
	When I launch the browser
	Then It should navigate to the given url
	




