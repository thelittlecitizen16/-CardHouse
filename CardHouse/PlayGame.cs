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
        public void Play()
        {
            GameManager.StartGame();
            
        }
    }
}
