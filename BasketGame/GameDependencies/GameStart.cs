using BasketGame.GameDependencies;
using BasketGame.Interfaces;
using System;
using System.Collections.Generic;

namespace BasketGame.GameField
{
    public class GameStart : ISingletonModuleStarter
    {
        private GameStart() { }

        private int _finishPoint = 100;

        private int _starting(List<Player> Players, int secretWeight, int finishPoint)
        {
            return new FieldForGame().Run(Players, secretWeight, finishPoint);
        }

        public int Run(int PlayersAmount) 
        {
            int SecretCartWeight = Cart.Instance().Run(PlayersAmount);

            if (SecretCartWeight != 0)
            {
                // start game ...            
                Console.WriteLine("Secret Cart Weight is: " + SecretCartWeight);
                
                List<Player> Players = new PlayersInitializer().InitPlayers(PlayersAmount);

                return this._starting(Players, SecretCartWeight, this._finishPoint);
            }
            else
            {
                return 0; 
            }
        }

        public static GameStart Instance()
        {
            return new GameStart();
        }
    }
}
