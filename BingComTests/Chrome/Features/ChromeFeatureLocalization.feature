@CFLocalization @Chrome
Feature: Chrome Feature Localization
Change of localization and language
on bing.com in Google Chrome

@language
Scenario: When I go to the language menu and change language on "English" then the browser localization changed
Given I go to webpage bing.com
And I click menu bar link
And I click settings link
And I click language link
When I click on link of english localization
Then Images link should be 'Images'

@Location
Scenario: When I Go to the location menu and change location on "USA" then the browser modifies query results based on the specified location
Given I go to webpage bing.com
And I click menu bar link
And I click settings link
And I click location link
When I click on link to change location
Then I should see carousel with trends