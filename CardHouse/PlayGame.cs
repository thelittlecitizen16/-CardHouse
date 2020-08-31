using CardHouse.Deck;
using CardHouse.ManageGame;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardHouse
{
    public class PlayGame
    {
        public GameManager GameManager { get; }

        public PlayGame(TurnToPlay turnToPlay, GameState gameState, GameConfiguration gameConfiguration)
        {
            GameManager = new GameManager(turnToPlay, gameState, gameConfiguration);
        }
        public void Play(List<Player> players)
        {
            GameManager.AddPlayers(players);
            GameManager.GiveEachPlayerCards();
        }


        public void PrintOthersCards()
        {
            Dictionary<Player, List<Card>> playersCards = GameManager.ShowCardsOfOthers();
            foreach (var pair in playersCards)
            {
                Console.WriteLine($"Player {pair.Key} has {pair.Value.Count} cards");
                foreach (var card in pair.Value)
                {
                    Console.WriteLine($"The cards are: {card.Color} {card.Number}");
                }
            }
        }
    }
}
