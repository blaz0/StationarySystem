Feature: Login
	In order to access the system
	As a user
	I want to login with my credentials

@login_valid
Scenario: login_valid
	Given I have an account in the system
	And I have also entered the correct details
	When I press login
	Then the system should take me to the home screen
