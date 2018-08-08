using BasketGame.GameField;
using System;

namespace BasketRoot
{
    class Program
    {
        static void Main(string[] args)
        {            
            int PlayersAmount = Int32.Parse(args[0]);

            int Process = GameStart.Instance().Run(PlayersAmount);

            if (Process == 1)
            {
                Console.Read();
            }
            else
            {
                Console.WriteLine("Goodbye!");

                Environment.Exit(Process);
            }            
        }
    }
}
