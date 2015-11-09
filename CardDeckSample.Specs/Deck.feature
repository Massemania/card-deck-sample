Feature: Basic deck functionality

Scenario: Deck setup
	Given An unshuffled deck
	Then the deck should have 52 cards
	And the deck should have 13 cards in 4 suits
	And the deck should not have duplicate cards