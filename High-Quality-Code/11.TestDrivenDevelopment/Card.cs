using System;
using System.Text;

namespace Poker
{
    public class Card : ICard
    {
        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("[");
            builder.Append(Face.ToString());
            builder.Append(" of ");
            builder.Append(Suit.ToString());
            builder.Append("]");
            return builder.ToString();
        }
    }
}
