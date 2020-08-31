using CardHouse.Deck;
using CardHouse.ManageGame;
using CardHouse.ManageGame.Enums;
using System;
using System.Collections.Generic;

namespace CardHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            DeckOfCards deckOfCards = new DeckOfCards();
            deckOfCards.CreateDeck();
            GameConfiguration configuration = new GameConfiguration();
            GameState gameState = new GameState(deckOfCards);
            TurnToPlay turnsToPlay = new TurnToPlay(gameState, configuration);
            GameManager gameManager = new GameManager(turnsToPlay, gameState, configuration);
            gameManager.AddPlayers(CreateListOfPlayers());


        }

        public static List<Player> CreateListOfPlayers()
        {
            List<Player> playersList = new List<Player>();
            playersList.Add(new Player());
            playersList.Add(new Player());
            return playersList;
        }
    }
}
