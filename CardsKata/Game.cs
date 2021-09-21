using System;
using System.Collections.Generic;

namespace CardsKata
{
    public class Game
    {
        /// <summary>
        ///     Calculate which one of the provided inputs has the best poker hand according to the provided rules.
        /// </summary>
        /// <param name="inputs">A collection strings containing the cards for each player, e.g. "2H 3D 5S 9C KD", "2S 8S AS QS 3S"</param>
        /// <returns>Result indicating either a winner or a tie</returns>
        public IResult Play(IReadOnlyList<string> inputs)
        {
            /*
             * A poker deck contains 52 cards - each card has a suit which is one of clubs, diamonds, hearts, or spades (denoted C, D, H, and S in the input data).
             * Each card also has a value which is one of 2, 3, 4, 5, 6, 7, 8, 9, 10, jack, queen, king, ace (denoted 2, 3, 4, 5, 6, 7, 8, 9, T, J, Q, K, A).
             * For scoring purposes, the suits are unordered while the values are ordered as given above, with 2 being the lowest and ace the highest value.
             * A poker hand consists of 5 cards dealt from the deck. Poker hands are ranked by the following partial order from lowest to highest.
             *
             * High card
             *   Hands which do not fit any higher category are ranked by the value of their highest card. If the highest cards have the same value, the hands are
             *   ranked by the next highest, and so on.
             *
             * Three of a kind
             *   Three of the cards in the hand have the same value. Hands which both contain three of a kind are ranked by the value of the 3 cards.
             *
             * Flush
             *   Hand contains 5 cards of the same suit. Hands which are both flushes are ranked using the rules for High Card.
             *
             * Your job is to rank pairs of poker hands and to indicate which, if either, has a higher rank.
             * Note that it is possible to receive tie as result.
             *
             * For more details and examples, see GameTests.cs.
             */

            throw new NotImplementedException();
        }
    }
}