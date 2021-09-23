using System;
using System.Linq;

namespace CardsKata.Gameplay
{
    public record CardSuit
    {
        private static readonly char[] ValidSuits = {
            'C', 'D', 'H', 'S'
        };

        public CardSuit(char suit)
        {
            if (!ValidSuits.Contains(suit))
                throw new ArgumentException("Invalid suit");

            Suit = suit;
        }

        public char Suit { get; set; }

        public static implicit operator char(CardSuit suit) => suit.Suit;

        public static implicit operator CardSuit(char c) => new(c);

        public override string ToString()
        {
            return Suit.ToString();
        }
    }
}