using CardHouse.Deck;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardHouse.ManageGame.TurnOptions
{
    public class TrowCard
    {
        private GameState _gameState;
        private GameConfiguration _gameConfiguration;

        public TrowCard(GameState gameState, GameConfiguration gameConfiguration)
        {
            _gameState = gameState;
            _gameConfiguration = gameConfiguration;
        }

        public void TrowPlayerCard(int player, int cardPlace)
        {

            if (player > 0 && player < _gameState.Players.Count)
            {
                if (cardPlace > 0 && cardPlace < _gameState.Players[player].Cards.Count)
                {
                    if (_gameConfiguration.CurrentCluesNumber < _gameConfiguration.MaxCluesNumber)
                    {
                        _gameConfiguration.CurrentCluesNumber++;              
                    }

                    _gameState.Players[player].RemoveCard(cardPlace);
                     Card newCard = _gameState.DeckOfCards.GetCard(0);
                    _gameState.DeckOfCards.RemoveCard(0);
                    _gameState.Players[player].AddCard(newCard);
                }
            }
        }
    }
}
