using CardHouse.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardHouse.Deck
{
    public class Card
    {
        public int Number { get; private set; }
        public CardColor Color { get; private set; }

        public Card(int number, CardColor color)
        {
            Number = number;
            Color = color;
        }
    }
}
