Feature: SpecFlowFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Check right path
	Given I write path d:
	When I press Add
	Then the result should be path d: in the first listBox

@second
Scenario: Check bad path
	Given I write bad path d:/
	When I press Add
	Then the result should be path d:/ in the second listBox 

@mytag
Scenario: Check empty path
	Given I am not writing path
	When I press Add
	Then the result should be messageBox

@mytag
Scenario: Delete path in first List
	Given I am selecting listItem in the first list
	When I press Delete in the first list
	Then the result should be selected item have to be deleted

@mytag
Scenario: Delete path in second List
	Given I am selecting listItem in the second list
	When I press Delete in the second list
	Then the result should be selected item have to be deleted
	
@mytag
Scenario: slide path from first List in second list
	Given I am selecting listItem in the first list
	When I press Slide in the first list
	Then the result item deleted in the fitst list and aded to the second list

@mytag
Scenario: return path from second List int textBox
	Given I am selecting listItem in the second list
	When I press return in the second list
	Then the result item deleted in the second list and aded to the textbox

@mytag
Scenario: return empty path from second List in the textbox
	When I press retirn in the second list
	Then the result message box with error