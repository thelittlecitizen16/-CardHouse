using System;
using System.Collections.Generic;
using System.Text;

namespace CardHouse.ManageGame
{
    public class GameManager
    {
        private TurnToPlay _turnToPlay;
        private GameState _gameState;
        public GameManager(TurnToPlay turnToPlay,  GameState gameState)
        {
            _turnToPlay = turnToPlay;
            _gameState = gameState\;
        }
    }
}
