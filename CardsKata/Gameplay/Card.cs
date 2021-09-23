namespace CardsKata.Gameplay
{
    public record Card
    {
        public Card(CardValue value, CardSuit suit)
        {
            Value = value;
            Suit = suit;
        }

        public CardSuit Suit { get; set; }

        public CardValue Value { get; set; }

        public override string ToString()
        {
            return $"{Value}{Suit}";
        }
    }
}