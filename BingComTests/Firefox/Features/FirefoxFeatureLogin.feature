@FFLogin
Feature: Firefox Feature Login
Change of localization and language
on bing.com in Firefox

@loign
Scenario: Login on bing.com
Given Webpage bing.com
And I click login link
And I enter the following details
	| Email               | Password      |
	| smeni0nik@gmail.com | 28012000artem |
And i click login button
Then I should see UserName 'Сойка'

@Logout
Scenario: Logout on bing.com
Given Webpage bing.com
And I Click logout link
When I click logout button
Then We should get the login link