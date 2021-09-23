namespace CardsKata.Gameplay
{
    public record Player
    {
        public string Name { get; }

        public Player(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}