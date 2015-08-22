using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            return hand.Cards.Count == 5;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            var firstCardFace = hand.Cards[0].Face;
            var secondCardFace = hand.Cards[1].Face;
            var thirdCardFace = hand.Cards[2].Face;
            var fourthCardFace = hand.Cards[3].Face;
            var fiftCardFace = hand.Cards[4].Face;

            List<int> lst = new List<int>() { firstCardFace,secondCardFace,thirdCardFace,fourthCardFace,fiftCardFace };
            if (lst.Distinct().Count <=2)
            {
                return true;
            }
            return false;

        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            CardSuit firstCardSuit = hand.Cards[0].Suit;
            for (int i = 1; i < hand.Cards.Count; i++)
            {
                if (firstCardSuit != hand.Cards[i].Suit)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }

        public bool ContainsFace(IHand hand, CardFace face)
        {
            for (int j = 0; j < hand.Cards.Count; j++)
            {
                if (hand.Cards[j].Face == face)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
