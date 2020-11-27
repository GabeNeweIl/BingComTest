@FFSearch Firefox
Feature: Firefox Feature Search
Search on bing.com in Firefox

@Search data
Scenario: When I enter data into the search bar, the search results should be information related to my query
Given I go to webpage bing.com
And I enter the following text
	| Search query         |
	| star wars episode vi |
When I click search button
Then Title of page must be 'star wars episode vi - Bing' 

@Related searches
Scenario: When I enter data into the search bar, the search system should offer a selection of 8 more related queries
Given I go to webpage bing.com
And I enter the following text
	| Search query         |
	| star wars episode vi |
When I click search button
Then The number of related searches should be 8

@Search result
Scenario: When I enter data into the search bar, the search system should give me 9 default search results
Given I go to webpage bing.com
And I enter the following text
	| Search query         |
	| star wars episode vi |
When I click search button
Then The number of search result should be 9