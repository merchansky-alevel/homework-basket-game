using BasketGame.GameField;
using System;
using System.Collections.Generic;

namespace BasketGame.GameDependencies
{
    public class FieldForGame
    {
        private int i = 0;
        public static List<int> Attempts = new List<int>();
        
        public int Run(List<Player> players, int secretWeight, int finishPoint)
        {
            while (i < finishPoint)
            {
                foreach (Player player in players)
                {
                    player.DoAttempt();
                }

                for (int z = 0; z < Attempts.Count; z++)
                {
                    if (secretWeight == Attempts[z])
                    {
                        i = 101;
                        Console.WriteLine("finished with: " + Attempts[z] + ", secret weigth is: " + secretWeight);
                        System.Threading.Thread.Sleep(3000);
                        return 0;
                    }
                }
                i++;
            }

            Console.WriteLine("Sorry, but we dont have winnder :(");
            
            return 1;
        }
    }
}
