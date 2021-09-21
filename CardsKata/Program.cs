using CardsKata.InputOutput;

namespace CardsKata
{
    internal class Program
    {
        private static void Main()
        {
            var io = new ConsoleInputOutput();

            var cards = io.GetCardsFor(2);

            var result = new Game().Play(cards);

            io.Report(result);
        }
    }
}