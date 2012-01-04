Feature: An object with a nullable enum property
	In order to test all of my application
	As a SpecFlow user
	I want to be be able to set nullable enum properties in my tests

Scenario: Set a nullable enum property via table
	Given I have a new TestEntity with the following values
		| Property      | Value  |
		| Test Property | Value2 |
	Then the value should be set to Value2
