using CardHouse.Deck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardHouse.ManageGame.TurnOptions
{
    public class PutDownCard
    {
        private GameState _gameState;
        private GameConfiguration _gameConfiguration;

        public PutDownCard(GameState gameState, GameConfiguration gameConfiguration)
        {
            _gameState = gameState;
            _gameConfiguration = gameConfiguration;
        }

        public void PutDowncardToBoard(int player, int cardPlace)
        {
            if (player > 0 && player < _gameState.Players.Count)
            {
                if (cardPlace > 0 && cardPlace < _gameState.Players[player].Cards.Count)
                {
                    Card playerCard = _gameState.Players[player].Cards[cardPlace];
                    _gameState.Players[player].RemoveCard(cardPlace);
                    if (!IsLegal(playerCard))
                    {
                        _gameConfiguration.CurrentDisqualification++;
                        if (_gameConfiguration.CurrentDisqualification == _gameConfiguration.MaxDisqualification)
                        {
                            _gameConfiguration.EndGame = true;
                        }
                       
                    }

                    Card newCard = _gameState.DeckOfCards.GetCard(0);
                    _gameState.DeckOfCards.RemoveCard(0);
                    _gameState.Players[player].AddCard(newCard);
                }
            }
        }
        private bool IsLegal(Card playerCard)
        {
            if (playerCard.Number == 1)
            {
                if (!_gameState.CardsOnBoard.Contains(playerCard))
                {
                    return true;
                }

            }
            else if (_gameState.CardsOnBoard.Where(c=>c.Color == playerCard.Color).Where(c=>c.Number == playerCard.Number-1).Any())
            {
                return true;
            }

            return false;
        }
    }
}
