namespace CardsKata.Gameplay
{
    public record PlayerWithCards
    {
        public Player Player { get; }
        public Cards Cards { get; }

        public PlayerWithCards(Player player, Cards cards)
        {
            Player = player;
            Cards = cards;
        }

        public override string ToString()
        {
            return $"{Player.Name}:\t{Cards}";
        }
    }
}