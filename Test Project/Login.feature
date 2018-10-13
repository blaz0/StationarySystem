Feature: Login
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: login_valid
	Given I have entered my username
	And I have also entered my password
	When I press log in
	Then the system should log me in
