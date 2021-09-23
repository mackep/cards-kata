# Cards Kata
This project provides a starting point for a programming kata revolving around comparing poker hands.

## Exercise description

A poker deck contains 52 cards - each card has a suit which is one of clubs, diamonds, hearts, or spades (denoted C, D, H, and S). Each card also has a value which is one of 2, 3, 4, 5, 6, 7, 8, 9, 10, jack, queen, king, ace (denoted 2, 3, 4, 5, 6, 7, 8, 9, T, J, Q, K, A). For scoring purposes, the suits are unordered while the values are ordered as given above, with 2 being the lowest and ace the highest value. A poker hand consists of 5 cards dealt from the deck. Poker hands are ranked by the following partial order from lowest to highest:

#### High card
Hands which do not fit any higher category are ranked by the value of their highest card. If the highest cards have the same value, the hands are ranked by the next highest, and so on.

#### Three of a kind
Three of the cards in the hand have the same value. Hands which both contain three of a kind are ranked by the value of the 3 cards.

#### Flush
Hand contains 5 cards of the same suit. Hands which are both flushes are ranked using the rules for High Card.

### Goal
The goal of this task is to rank poker hands and to indicate which, if any, has a higher rank than the others. A good place to start your implementation is [Game.cs](https://github.com/mackep/cards-kata/blob/master/CardsKata/Gameplay/Game.cs). Run the unit tests in [GameTests.cs](https://github.com/mackep/cards-kata/blob/master/CardsKata.Tests/GameTests.cs) to check that your implementation works accordingly.

## Development

### Prerequisites

Requires .NET 5 to be installed: https://dotnet.microsoft.com/download/dotnet/5.0.

### Running the application

#### Within an IDE

In an IDE such as Visual Studio, simply build the solution and run the application in for example debug mode using F5.

#### Command line

Run `dotnet run` in the root folder.

### Running the tests

#### Within an IDE

In an IDE such as Visual Studio, simply build the solution and run all tests using the built-in test runner.

#### Command line

Run `dotnet test` in the root folder.