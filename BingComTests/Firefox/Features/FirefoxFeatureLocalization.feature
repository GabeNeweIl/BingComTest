@FFLocalization
Feature: Firefox Feature Localization
Change of localization and language
on bing.com in Firefox

@language
Scenario: Change language
Given Webpage bing.com
And I click menu bar link
And I click settings link
And I click language link
When I click on link of english localization
Then Images link should be 'Images'

@Location
Scenario: Change location
Given Webpage bing.com
And I click menu bar link
And I click settings link
And I click location link
When I click on link to change location
Then I should see carousel with trends