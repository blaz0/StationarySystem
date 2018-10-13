Feature: AcceptanceTesting
	In order to access the system
	As a user
	I want to be able to login

@T01
Scenario: valid_login
	Given I have entered a username
	And I have also entered a password
	When I press log in
	Then the system should display the home page
