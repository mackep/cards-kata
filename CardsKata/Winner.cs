namespace CardsKata
{
    public record Winner : IResult
    {
        private readonly int _playerNumber;
        private readonly string _winningHandDescription;

        public Winner(int playerNumber, string winningHandDescription)
        {
            _playerNumber = playerNumber;
            _winningHandDescription = winningHandDescription;
        }

        public string GetDescription()
        {
            return $"Player {_playerNumber} wins - {_winningHandDescription}";
        }
    }
}