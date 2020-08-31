using CardHouse.Enums;
using CardHouse.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardHouse.Deck
{
    public class DeckOfCards : IDeckOfCards
    {
        public List<Card> Deck { get; private set; }
        public DeckOfCards()
        {
            Deck = new List<Card>();
        }
        public void CreateDeck()
        {
            foreach (var color in (CardColor[]) Enum.GetValues(typeof(CardColor)))
            {
                CreateCardsByColor(color);
            }
        }
        private void CreateCardsByColor(CardColor color)
        {
            for (int i = 0; i < 3; i++)
            {
                Deck.Add(new Card(1, color));
            }
            for (int i = 0; i < 2; i++)
            {
                Deck.Add(new Card(2, color));
            }
            for (int i = 0; i < 2; i++)
            {
                Deck.Add(new Card(3, color));
            }
            for (int i = 0; i < 2; i++)
            {
                Deck.Add(new Card(4, color));
            }
            for (int i = 0; i < 1; i++)
            {
                Deck.Add(new Card(5, color));
            }
        }

        public Card GetCard(int cardPlace)
        {
            return Deck[cardPlace];
        }

        public void RemoveCard(int cardPlace)
        {
            Deck.RemoveAt(cardPlace);
        }

        public void RemoveFewCards(int startPlace, int count)
        {
            Deck.RemoveRange(startPlace, count);
        }
    }
}
