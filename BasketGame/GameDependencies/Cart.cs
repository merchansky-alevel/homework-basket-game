using BasketGame.Interfaces;
using System;

namespace BasketGame.GameField
{
    class Cart : ISingletonModuleStarter
    {
        private Cart()
        {
            
        }

        private int SecretWeight() => new Random().Next(40, 140);

        public int Run(int playersAmount)
        {
            if (playersAmount == 0 || playersAmount < 1)
            {
                Console.WriteLine("Sorry, invalid amount of players :(");
                return 0;
            }
            else
            {
                return SecretWeight();
            }
        }

        public static Cart Instance()
        {
            return new Cart();
        }
    }
}
