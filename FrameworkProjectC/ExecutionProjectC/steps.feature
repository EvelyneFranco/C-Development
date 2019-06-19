Feature: Test amazon page 
	

@mytag
Scenario: Validate amazon flow
	Given the login in amazon page 
	And user search and select samsung
	Then price result should match with selected samsung
	Given samsung in car 
	Then price should march with first price and car price 
	Then items in car should be one 
	Given user search fo Alien 
	And select the product and add the alien to the car 
	Then car number should contains two items 

	 