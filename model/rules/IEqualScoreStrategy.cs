using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
        interface IEqualScoreStrategy
        {
            bool Winner(int a_dealerScore, int a_playerScore);
        }
}
