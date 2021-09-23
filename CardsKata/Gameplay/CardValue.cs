using System;
using System.Linq;

namespace CardsKata.Gameplay
{
    public record CardValue
    {
        private static readonly char[] ValidValues = {
            '2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K', 'A'
        };

        public CardValue(char value)
        {
            if (!ValidValues.Contains(value))
                throw new ArgumentException("Invalid value");

            Value = value;
        }

        public char Value { get; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}