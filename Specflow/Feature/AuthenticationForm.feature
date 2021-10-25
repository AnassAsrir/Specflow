@ui
Feature: Authentication form
  As a user I want to test authentication service

  Scenario: Authenticate using correct login and password
    Given user lands on The Internet Herokuapp application
    Given user opens the "Form Authentication" page
    When I type "tomsmith" and "SuperSecretPassword!"
    When I click login button
    Then the "You logged into a secure area!" should be displayed