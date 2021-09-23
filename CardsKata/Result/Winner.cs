using CardsKata.Gameplay;

namespace CardsKata.Result
{
    public record Winner : IResult
    {
        private readonly Player _player;
        private readonly string _winningHandDescription;

        public Winner(Player player, string winningHandDescription)
        {
            _player = player;
            _winningHandDescription = winningHandDescription;
        }

        public string GetDescription()
        {
            return $"{_player} wins - {_winningHandDescription}";
        }
    }
}