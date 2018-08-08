using BasketGame.GameDependencies;
using BasketGame.GameField;

namespace BasketGame.Persons
{
    public class Cheater : Player
    {
        public override void DoAttempt()
        {
            int result = base.RandomAttempt(40, 140);

            foreach (int value in FieldForGame.Attempts.ToArray())
            {
                
                if (value != result)
                {
                    FieldForGame.Attempts.Add(result);
                    base.PrintAttempt("CHEATER", result);
                }
            }
        }
    }
}
