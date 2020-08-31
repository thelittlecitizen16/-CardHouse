using CardHouse.Deck;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardHouse.ManageGame.TurnOptions
{
    public class Clue
    {
        private GameState _gameState;
        private GameConfiguration _gameConfiguration;

        public Clue(GameState gameState, GameConfiguration gameConfiguration)
        {
            _gameState = gameState;
            _gameConfiguration = gameConfiguration;
        }

        public Card GetClue(int player, int cardPlace)
        {
            if (_gameConfiguration.CurrentCluesNumber > 0)
            {
                if (player> 0 && player < _gameState.Players.Count )
                {
                    if (cardPlace > 0 && cardPlace < _gameState.Players[player].Cards.Count)
                    {
                        _gameConfiguration.CurrentCluesNumber--;

                        return _gameState.Players[player].Cards[cardPlace];
                    }    
                }   
            }

            return null;
        }
    }
}
