Feature: TMFeature

A a Turnup portal admin user
I would like to create, edit and delete time and material records
So that i can manage employees time and materials successfully

@regression
Scenario: create time record with valid data
	Given I logged into turnup portal sucessfully
	When I navigate to Time and Mtaerial page
	When I create time record
	Then the code should be created successfully
