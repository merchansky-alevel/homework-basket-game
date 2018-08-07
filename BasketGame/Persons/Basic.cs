using BasketGame.GameDependencies;
using BasketGame.GameField;

namespace BasketGame.Persons
{
    public class Basic : Player
    {
        public override void DoAttempt()
        {
            int result = this.RandomAttempt(40, 140);
            base.PrintAttempt("BASIC", result);
            FieldForGame.Attempts.Add(result);
        }
    }
}
