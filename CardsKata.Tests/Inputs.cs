namespace CardsKata.Tests
{
    internal static class Inputs
    {
        public const string HighCardAce = "2C 3H 4S 8C AH";
        public const string AnotherHighCardAce = "2D 3C 4H 8H AD";
        public const string HighCardKing = "2H 3D 5S 9C KD";
        public const string ThreeOfAKindTwos = "2C AH 2S 3D 2D";
        public const string ThreeOfAKindThrees = "QC 3H 3S 3D JD";
        public const string ThreeOfAKindAces = "AC AH AS 3D JD";
        public const string FlushWithClubs = "2C 4C 8C TC KC";
        public const string FlushWithHearts = "2H 4H 8H TH KH";
        public const string FlushWithHighCard = "2C 3C 4C 5C AC";
        public const string FlushWithLowCard = "9C TC JC QC KC";
    }
}
