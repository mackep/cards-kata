namespace CardsKata.Result
{
    public class Tie : IResult
    {
        private readonly string _commonBestHandDescription;

        public Tie(string commonBestHandDescription)
        {
            _commonBestHandDescription = commonBestHandDescription;
        }

        public string GetDescription()
        {
            return $"Tie - {_commonBestHandDescription}";
        }
    }
}