using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CardsKata.InputOutput
{
    public class ConsoleInputOutput : IInput, IOutput
    {
        private readonly Regex _validationRegex;

        public ConsoleInputOutput()
        {
            _validationRegex =
                new Regex(
                    "^[1-9_TJQKA][CDHS]\\s[1-9_TJQKA][CDHS]\\s[1-9_TJQKA][CDHS]\\s[1-9_TJQKA][CDHS]\\s[1-9_TJQKA][CDHS]$");
        }

        public IReadOnlyList<string> GetCardsFor(int numberOfPlayers)
        {
            var cardsPerPlayer = new List<string>();

            for (var playerNumber = 1; playerNumber <= 2; playerNumber++)
                cardsPerPlayer.Add(GetCards(playerNumber));

            return cardsPerPlayer;
        }

        public void Report(IResult result)
        {
            WriteConsole(result.GetDescription(), ConsoleColor.Green);
        }

        private string GetCards(int playerNumber)
        {
            while (true)
            {
                var cards = ReadCards(playerNumber);

                if (InvalidInput(cards))
                {
                    RaiseError(GetInputErrorMessage());
                    continue;
                }

                if (HasDuplicateCards(cards))
                {
                    RaiseError(GetDuplicateCardsErrorMessage());
                    continue;
                }

                return cards;
            }
        }

        private static string ReadCards(int playerNumber)
        {
            Console.Write($"Player {playerNumber} cards: ");

            return Console.ReadLine();
        }

        private static void RaiseError(string msg)
        {
            WriteConsole(msg, ConsoleColor.Red);
        }

        private static void WriteConsole(string msg, ConsoleColor color)
        {
            var previousColor = Console.ForegroundColor;

            Console.ForegroundColor = color;
            Console.WriteLine(msg);
            Console.ForegroundColor = previousColor;
        }

        private bool InvalidInput(string cards)
        {
            return !_validationRegex.IsMatch(cards);
        }

        private static bool HasDuplicateCards(string cards)
        {
            return cards.Split(" ").Distinct().Count() < 5;
        }

        private static string GetInputErrorMessage()
        {
            return
                "Invalid cards, input must be in format vs vs vs vs vs, where\n - v indicates the card value (2, 3, 4, 5, 6, 7, 8, 9, T, J, Q, K, A)\n - s indicates the suite (C - cloves, D - diamonds, H - hearts, S - spades)\nFor example: 2D TH AC 9S KH\n";
        }

        private static string GetDuplicateCardsErrorMessage()
        {
            return "Invalid cards, the same card cannot occur multiple times\n";
        }
    }
}