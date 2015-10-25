using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class EqualScorePlayerWins : IEqualScoreStrategy
    {
        public bool winner(Player a_player, Player a_dealer, int maxScore)
        {
            if (a_player.CalcScore() > maxScore)
            {
                return true;
            }
            else if (a_dealer.CalcScore() > maxScore)
            {
                return false;
            }
            return !(a_dealer.CalcScore() >= a_player.CalcScore());
        }
    }
}
