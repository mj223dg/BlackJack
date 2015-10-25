using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.controller
{
    class PlayGame:model.IBlackJackObserver
    {
        private model.Game m_game;
        private view.IView m_view;

        public PlayGame(model.Game a_game, view.IView a_view)
        {
            m_game = a_game;
            m_view = a_view;
            m_view.DisplayWelcomeMessage();
        }

        public bool Play()
        {
            m_game.Dealer.Subscribe(this);
            m_game.Player.Subscribe(this);

            if (m_game.IsGameOver())
            {
                m_view.DisplayGameOver(m_game.IsDealerWinner());
            }
            
           


            view.GameChoice input = m_view.GetInput();

            if (input == view.GameChoice.NewGame)
            {
                m_game.NewGame();
            }
            else if (input == view.GameChoice.Hit)
            {
                m_game.Hit();
            }
            else if (input == view.GameChoice.Stand)
            {
                m_game.Stand();
            }

            return input != view.GameChoice.Quit;
        }

        public void CardDealt()
        {
            m_view.DisplayWelcomeMessage();
            m_view.DisplayDealerHand(m_game.GetDealerHand(), m_game.GetDealerScore());
            m_view.DisplayPlayerHand(m_game.GetPlayerHand(), m_game.GetPlayerScore());
        }
    }
}
