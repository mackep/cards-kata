using System.Collections.Generic;
using System.Linq;

namespace CardsKata.Gameplay
{
    public class Cards : HashSet<Card>
    {
        public override string ToString()
        {
            return string.Join(" ", this.Select(c => c.ToString()));
        }
    }
}