Feature: Shopping Website

Scenario: Order Tshirt
Given User Login to the website with userNmae "JuhiH@gmail.com" and Password "Juhi01"
When User navigates to the Tshirt tab
Then User selects the Tshirt
And User book the Tshirt from the shopping kart
Then User verify the order History "$18.51"


Scenario:Update personal Information in My account
Given User Login to the website with userNmae "JuhiH@gmail.com" and Password "Juhi01"
When User Navigates to Personal Information
Then User fills the details "Test" "User"
