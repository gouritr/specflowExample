Feature: Addition
	As a customer,I should be able to signup
	
@mytag
Scenario: Using all fields customer should be able to signup
	Given I am signing up
    When I enter all details
    Then I should see success message
    

