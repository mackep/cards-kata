using System.Linq;
using CardsKata.Gameplay;

namespace CardsKata.Tests
{
    public static class TestExtensions
    {
        public static Cards AsCards(this string str)
        {
            var cards = new Cards();

            foreach (var card in str.Split(" "))
            {
                cards.Add(new Card(new CardValue(card.First()), new CardSuit(card.Last())));
            }

            return cards;
        }
    }
}