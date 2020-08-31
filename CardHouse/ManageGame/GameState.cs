using CardHouse.Deck;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CardHouse.ManageGame
{
    public class GameState
    {
        public DeckOfCards DeckOfCards { get; private set; }
        public List<Player> Players { get; private set; }
        public CardsOnBoard CardsOnBoard { get; private set; }
        public GameState(DeckOfCards deckOfCards)
        {
            Players = new List<Player>();
            CardsOnBoard = new CardsOnBoard();
            DeckOfCards = deckOfCards;
        }
        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }
        public void AddCardToBoard(Card card)
        {
            CardsOnBoard.CardsOnBoardDict[card.Color].Add(card);
        }
    }
}
