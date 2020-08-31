using CardHouse.Deck;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardHouse.ManageGame
{
    public class Player
    {
        public List<Card> Cards { get; private set; }
        public Player()
        {
            Cards = new List<Card>();
        }

        public void RemoveCard(int cardPlace)
        {
            Cards.RemoveAt(cardPlace);
        }
        public void AddCard(Card card)
        {
            Cards.Add(card);
        }
    }
}
