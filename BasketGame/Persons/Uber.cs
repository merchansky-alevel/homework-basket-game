using BasketGame.GameDependencies;
using BasketGame.GameField;

namespace BasketGame.Persons
{
    public class Uber : Player
    {
        private int _initialInt = 40;

        public override void DoAttempt()
        {
            FieldForGame.Attempts.Add(this._initialInt);
            base.PrintAttempt("UBER", this._initialInt);
            this._initialInt = this._initialInt + 1;
        }
    }
}
