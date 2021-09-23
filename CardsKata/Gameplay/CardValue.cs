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

        public int NumericValue
        {
            get
            {
                return Value switch
                {
                    'T' => 10,
                    'J' => 11,
                    'Q' => 12,
                    'K' => 13,
                    'A' => 14,
                    _ => int.Parse(Value.ToString())
                };
            }
        }

        public static implicit operator char(CardValue value) => value.Value;

        public static implicit operator CardValue(char c) => new(c);

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}