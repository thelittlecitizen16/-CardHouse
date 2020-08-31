using CardHouse.Deck;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardHouse.ManageGame
{
    public class GameManager
    {
        private TurnToPlay _turnToPlay;
        private GameState _gameState;
        private GameConfiguration _gameConfiguration;
        public GameManager(TurnToPlay turnToPlay,  GameState gameState, GameConfiguration gameConfiguration)
        {
            _turnToPlay = turnToPlay;
            _gameState = gameState;
            _gameConfiguration = gameConfiguration;
        }
        public void AddPlayers(List<Player> players)
        {
            if (players.Count >=_gameConfiguration.PlayersNumberStart && players.Count<= _gameConfiguration.PlayersNumberEnd)
            {
                foreach (var player in players)
                {
                    _gameState.Players.Add(player);
                }
            }     
        }
        public void StartGame()
        {

        }
        public Dictionary<Player, List<Card>> ShowCardsOfOthers()
        {
            Dictionary<Player, List<Card>> othersCards = new Dictionary<Player, List<Card>>();
            foreach (var player in _gameState.Players)
            {
                othersCards.Add(player, player.Cards);
            }
            return othersCards;
        }
        public void TurnPlayer()
        {
            
        }
        public void StatusAfterTurn()
        {

        }
        public int EndGameStatus()
        {
            return _gameState.CardsOnBoard.Count;
        }
    }
}
