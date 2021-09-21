using FluentAssertions;
using Xunit;

namespace CardsKata.Tests
{
    public class GameTests
    {
        [Theory]
        [InlineData(Inputs.HighCardAce, Inputs.HighCardKing, "Player 1 wins - High card")]
        [InlineData(Inputs.HighCardKing, Inputs.HighCardAce, "Player 2 wins - High card")]
        [InlineData(Inputs.HighCardAce, Inputs.AnotherHighCardAce, "Tie - High card")]
        [InlineData(Inputs.ThreeOfAKindTwos, Inputs.HighCardAce, "Player 1 wins - Three of a kind")]
        [InlineData(Inputs.ThreeOfAKindTwos, Inputs.ThreeOfAKindThrees, "Player 2 wins - Three of a kind")]
        [InlineData(Inputs.ThreeOfAKindAces, Inputs.ThreeOfAKindTwos, "Player 1 wins - Three of a kind")]
        [InlineData(Inputs.ThreeOfAKindAces, Inputs.FlushWithClubs, "Player 2 wins - Flush")]
        [InlineData(Inputs.FlushWithHighCard, Inputs.FlushWithLowCard, "Player 1 wins - Flush")]
        [InlineData(Inputs.FlushWithLowCard, Inputs.FlushWithHighCard, "Player 2 wins - Flush")]
        [InlineData(Inputs.FlushWithClubs, Inputs.FlushWithHearts, "Tie - Flush")]
        public void Result_is_calculated_correctly(string player1, string player2, string expectedDescription)
        {
            var result = new Game().Play(new []
            {
                player1, player2
            });

            result.As<IResult>().GetDescription().Should().Be(expectedDescription);
        }
    }
}