Feature: GitHubRepoTest
	In order to check my github repo present in or not
	As a public user
	I want to able to see the repo hosted in github 

@github
Scenario: Check this project repo in github present or not
	Given I have a github repo url
	And I entered the 'https://github.com/pksivanantham'
	And I cliked on the Repository tab
	When I Search with repo name 'Selenium_App'
	Then I should able to see the repo page in github with the name 'Selenium_App'
	Then I add the following data
	| key     | value  |
	| ewpoName | 'Selenium_App' |
