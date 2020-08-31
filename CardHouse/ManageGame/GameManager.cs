using CardHouse.Deck;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardHouse.ManageGame
{
    public class GameManager
    {
        private readonly Random random = new Random();
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
        public void GiveEachPlayerCards()
        {
            foreach (var player in _gameState.Players)
            {
                for(int i=0; i<5; i++)
                {
                    // Each Player gets 5 random cards
                    player.AddCard(_gameState.DeckOfCards.GetCard(random.Next(0, _gameState.DeckOfCards.Deck.Count)));
                }
            }
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
