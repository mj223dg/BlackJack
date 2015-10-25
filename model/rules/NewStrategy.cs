using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    abstract class NewStrategy
    {
        protected void DealNewCards(Player a_player, Deck a_deck, bool show)
        {
            var c = a_deck.GetCard();
            c.Show(show);
            a_player.DealCard(c);
        }
    }
}
