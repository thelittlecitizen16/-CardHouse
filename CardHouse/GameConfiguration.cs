using System;
using System.Collections.Generic;
using System.Text;

namespace CardHouse
{
    public class GameConfiguration
    {
        public int PlayersNumberStart{get; private set;}
        public int PlayersNumberEnd { get; private set; }
        public int CardsNumberEachPlayer { get; private set; }
        public int CurrentCluesNumber { get; set; }
        public int MaxCluesNumber { get; private set; }
        public int CurrentDisqualification { get; set; }
        public int MaxDisqualification { get; private set; }
        public bool EndGame { get;  set; }

        public GameConfiguration()
        {
            PlayersNumberStart = 2;
            PlayersNumberEnd = 4;
            CardsNumberEachPlayer = 5;
            CurrentCluesNumber = 5;
            MaxCluesNumber = 5;
            MaxDisqualification = 4;
            CurrentDisqualification = 0;
            EndGame = false;
        }
    }
}
