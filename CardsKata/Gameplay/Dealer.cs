using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsKata.Gameplay
{
    public class Dealer
    {
        private readonly IList<Card> _deck;
        private readonly Random _random;

        public Dealer()
        {
            _deck = new List<Card>();
            _random = new Random();
            var suits = new[] {'C', 'D', 'H', 'S'};
            var values = new[] {'2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K', 'A'};

            foreach (var suit in suits)
            {
                foreach (var value in values)
                {
                    _deck.Add(new Card(new CardValue(value), new CardSuit(suit)));
                }
            }
        }

        public IReadOnlyCollection<PlayerWithCards> DealCardsFor(IEnumerable<Player> players)
        {
            return players
                .Select(player => new PlayerWithCards(player, RandomCardsFromDeck()))
                .ToList();
        }

        public Cards RandomCardsFromDeck()
        {
            return new()
            {
                RandomCardFromDeck(),
                RandomCardFromDeck(),
                RandomCardFromDeck(),
                RandomCardFromDeck(),
                RandomCardFromDeck()
            };
        }

        public Card RandomCardFromDeck()
        {
            var card = _deck[_random.Next(0, _deck.Count - 1)];

            _deck.Remove(card);

            return card;
        }
    }
}