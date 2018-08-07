using System;

namespace BasketGame.GameField
{
    public abstract class Player
    {
        private static Random _random = new Random();

        public int RandomAttempt(int min, int max) => _random.Next(min, max);

        public void PrintAttempt(string playerName, int value) 
        {
            System.Console.WriteLine("Player {0}, sad: {1}", playerName, value);
        } 

        public virtual void DoAttempt() { Console.WriteLine("polimorph test"); }
    }
}
