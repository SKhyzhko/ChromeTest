Feature: ChromeBrowser
	Testing chrome browser


@ToDoApp
Scenario: Verify titles include substring 
	Given Navigate ChromeTest
	And Open Gooogle Search page 
	And Enter "Automation" in search field 
	When Press enter button
	Then Verify that 5 first results contains needed keyword 