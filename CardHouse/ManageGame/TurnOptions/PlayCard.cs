using System;
using System.Collections.Generic;
using System.Text;

namespace CardHouse.ManageGame.TurnOptions
{
    public class PlayCard
    {
        private GameState _gameState;
        private GameConfiguration _gameConfiguration;
        public PlayCard(GameState gameState, GameConfiguration gameConfiguration)
        {
            _gameState = gameState;
            _gameConfiguration = gameConfiguration;
        }

    }
}
