using BasketGame.Persons;
using System;
using System.Collections.Generic;

namespace BasketGame.GameField
{
    class PlayersInitializer : Player
    {
        private List<Player> _players = new List<Player>();

        public List<Player> InitPlayers(int value)
        {
            List<Player> updatedPlayers = new List<Player>();

            this._players.Add(new Basic());
            this._players.Add(new Noter());
            this._players.Add(new Uber());
            this._players.Add(new Cheater());
            this._players.Add(new UberCheater());

            for (int i = 0; i < value; i++)
            {
                try
                {
                    updatedPlayers.Add(this._players[i]);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    updatedPlayers.Add(this._players[this.RandomAttempt(40, 140)]);
                }
            }

            return updatedPlayers;
        }
    }
}
