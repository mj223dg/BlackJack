using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class Soft17Strategy : IHitStrategy
    {
        private const int g_hitLimit = 17;

        //När dealerns hand är lika med 17 
        public bool DoHit(model.Player a_dealer)
        {

            if (a_dealer.CalcScore() == g_hitLimit)
            {
                return DealerHasAce(a_dealer.GetHand());
            }
            return a_dealer.CalcScore() < g_hitLimit;
        }

        //returnerar true när dealern har ett ess i handen.
        private bool DealerHasAce(IEnumerable<Card> a_hand)
        {
            foreach (var card in a_hand)
            {
                if(card.GetValue() == BlackJack.model.Card.Value.Ace)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
