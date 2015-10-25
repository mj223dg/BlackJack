using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class InternationalNewGameStrategy : NewStrategy, INewGameStrategy
    {

        public bool NewGame(Deck a_deck, Dealer a_dealer, Player a_player)
        {
            DealNewCards(a_player, a_deck, true);

            DealNewCards(a_dealer, a_deck, true);

            DealNewCards(a_player, a_deck, true);


            return true;
        }
    }
}
