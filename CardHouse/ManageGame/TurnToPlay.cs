using CardHouse.Deck;
using CardHouse.ManageGame.Enums;
using CardHouse.ManageGame.TurnOptions;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CardHouse.ManageGame
{
    public class TurnToPlay
    {
        public GameState GameState { get; private set; }
        private Clue _clue;
        private PutDownCard _putDownCard;
        private TrowCard _trowCard;
        public TurnToPlay(GameState gameState, GameConfiguration gameConfiguration)
        {
            GameState = gameState;
            _clue = new Clue(gameState, gameConfiguration);
            _putDownCard = new PutDownCard(gameState, gameConfiguration);
            _trowCard = new TrowCard(gameState, gameConfiguration);
        }
        public void MakeTurn(TurnOption turnOption, Player player, int cardPlace)
        {
            switch (turnOption)
            {
                case TurnOption.GETCLUE:
                    GetClue(player, cardPlace);
                    break;
                case TurnOption.TROWCARD:
                    TrowPlayerCard(player, cardPlace);
                    break;
                case TurnOption.PUTDOWNCARD:
                    PutDowncardToBoard(player, cardPlace);
                    break;
                default:
                    break;
            }
        }
        private Card GetClue(Player player, int cardPlace)
        {
            int playerPlace = GameState.Players.IndexOf(player);
            return _clue.GetClue(playerPlace, cardPlace);
        }
        private void PutDowncardToBoard(Player player, int cardPlace)
        {
            int playerPlace = GameState.Players.IndexOf(player);
            _putDownCard.PutDowncardToBoard(playerPlace, cardPlace);
        }
        private void TrowPlayerCard(Player player, int cardPlace)
        {
            int playerPlace = GameState.Players.IndexOf(player);
            _trowCard.TrowPlayerCard(playerPlace, cardPlace);
        }
    }
}
