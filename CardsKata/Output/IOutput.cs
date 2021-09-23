using CardsKata.Result;

namespace CardsKata.Output
{
    public interface IOutput
    {
        void Report(IResult result);
    }
}