using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public override string ToString()
        {
            //>[Ace of Clubs][Ace of Diamonds][Ace of Hearts][Ace of Spades][Jack of Spades]<
            StringBuilder builder = new StringBuilder();
            builder.Append(">");
            foreach (var card in Cards)
            {
                builder.Append(card.ToString());
            }
            builder.Append("<");
            return builder.ToString();
            throw new NotImplementedException();
        }
    }
}
