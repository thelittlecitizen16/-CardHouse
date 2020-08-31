using CardHouse.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardHouse.Deck
{
    public class CardsOnBoard
    {
        public Dictionary<CardColor, List<Card>> CardsOnBoardDict { get; private set; }
        public CardsOnBoard()
        {
            CardsOnBoardDict = new Dictionary<CardColor, List<Card>>();
            CreateNewCardsBoard();
        }
        public void CreateNewCardsBoard()
        {
            CardsOnBoardDict.Add(CardColor.BLUE, new List<Card>());
            CardsOnBoardDict.Add(CardColor.GREEN, new List<Card>());
            CardsOnBoardDict.Add(CardColor.RED, new List<Card>());
            CardsOnBoardDict.Add(CardColor.YELLOW, new List<Card>());
            CardsOnBoardDict.Add(CardColor.WHITE, new List<Card>());
        }
    }
}
