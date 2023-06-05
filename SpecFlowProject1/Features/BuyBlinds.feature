Feature: BuyBlinds

A short summary of the feature

@tag1
Scenario: Verify can fill Demo QA form
	Given I am on the website "https://demoqa.com/automation-practice-form"
	When I enter firstname "Ray"
	And I enter lastname "Bob"
	And I enter email address "borray24@hotmail.com"
	And I select gender
	And I enter mobile number "7465839517"
	And I enter date of birth "10/01/2010"
	And I enter click to select hobbies
	And I choose file for picture
	And I enter current address "90 oxford street"
	And I select state
	And I select city
	And I click submit button
	Then demoqa registration page is diplayed
	
