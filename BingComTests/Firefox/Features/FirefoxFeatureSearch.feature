@FFSearch
Feature: Firefox Feature Search
Search on bing.com in Firefox

@Search star wars episode vi
Scenario: Search on bing.com
Given Webpage bing.com
And I enter the following text
	| Search query         |
	| star wars episode vi |
When I click search button
Then Title of page must be 'star wars episode vi - Bing' 

@Related searches
Scenario: Reletad searches 
Given Webpage bing.com
And I enter the following text
	| Search query         |
	| star wars episode vi |
When I click search button
Then The number of related searches should be 8

@Search result
Scenario: Search result
Given Webpage bing.com
And I enter the following text
	| Search query         |
	| star wars episode vi |
When I click search button
Then The number of search result should be 9