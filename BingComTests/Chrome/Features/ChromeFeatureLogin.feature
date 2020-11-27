@CFLogin @Chrome
Feature: Chrome Features Login
Login on bing.com in Google Chrome and Logout

@loign
Scenario: When I enter UserName and Password on site it should be possible to interact with my account settings
And I go to webpage bing.com
And I click login link
And I enter the following details
	| Email               | Password      |
	| smeni0nik@gmail.com | 28012000artem |
And i click login button
Then I should see UserName 'Сойка'


@Logout
Scenario: When I log out, it should be possible to log in again
Given I go to webpage bing.com
And I Click logout link
When I click logout button
Then We should get the login link

