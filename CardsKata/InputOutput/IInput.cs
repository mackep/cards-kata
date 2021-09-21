using System.Collections.Generic;

namespace CardsKata.InputOutput
{
    public interface IInput
    {
        IReadOnlyList<string> GetCardsFor(int numberOfPlayers);
    }
}