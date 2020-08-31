using CardHouse.Deck;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardHouse.Interfaces
{
    public interface IDeckOfCards
    {
        List<Card> Deck { get; }
        void CreateDeck();
        Card GetCard(int cardPlace);
        void RemoveCard(int cardPlace);
        void RemoveFewCards(int startPlace, int count);
    }
}
