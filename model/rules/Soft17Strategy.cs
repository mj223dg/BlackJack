using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class Soft17Straegy : IHitStrategy
    {
        private const int g_hitLimit = 17;

        public bool DoHit(model.Player a_dealer)
        {
            if (a_dealer.CalcScore() == g_hitLimit)
            {
                return;
            }
            return a_dealer.CalcScore() < g_hitLimit;
        }

        private bool DealerHasAce(IEnumerable<Card> a_hand)
        {
            foreach (var card in a_hand)
            {
                if()
            } 
        }

    }
}
