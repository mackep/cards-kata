using CardsKata.Gameplay;
using CardsKata.Output;

namespace CardsKata
{
    internal class Program
    {
        private static void Main()
        {
            var output = new ConsoleOutput();

            var players = new[]
            {
                new Player("Blondie"),
                new Player("Ugly Tuco"),
                new Player("Angel Eyes")
            };

            var cardsPerPlayer = new Dealer().DealCardsFor(players);

            output.Report(cardsPerPlayer);

            var result = new Game().Play(cardsPerPlayer);

            output.Report(result);
        }
    }
}