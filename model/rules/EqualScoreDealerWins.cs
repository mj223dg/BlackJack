using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class EqualScoreDealerWins : IEqualScoreStrategy
    {
        public bool winner(Dealer a_dealer, Player a_player, int maxScore)
        {
            if (a_player.CalcScore() > maxScore)
            {
                return true;
            }
            else if (a_dealer.CalcScore() > maxScore)
            {
                return false;
            }
            return a_dealer.CalcScore() >= a_dealer.CalcScore();
        }
    }
}
