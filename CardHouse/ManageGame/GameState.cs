using CardHouse.Deck;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardHouse.ManageGame
{
    public class GameState
    {
        public DeckOfCards DeckOfCards { get; private set; }
        public List<Player> Players { get; private set; }
        public List<Card> CardsOnBoard { get; private set; }
        public GameState(DeckOfCards deckOfCards)
        {
            Players = new List<Player>();
            CardsOnBoard = new List<Card>();
            DeckOfCards = deckOfCards;
        }
        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }
        public void AddCardToBoard(Card card)
        {
            CardsOnBoard.Add(card);
        }
    }
}
