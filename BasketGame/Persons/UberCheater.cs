using BasketGame.GameDependencies;
using BasketGame.GameField;

namespace BasketGame.Persons
{
    public class UberCheater : Player
    {
        private int _initialInt = 40;

        public override void DoAttempt()
        {
            foreach (int value in FieldForGame.Attempts.ToArray())
            {
                this._initialInt = this._initialInt + 1;
                
                if (this._initialInt != value)
                {
                    FieldForGame.Attempts.Add(this._initialInt);
                    base.PrintAttempt("UBER-CHEATER", this._initialInt);
                }
            }
        }  
    }
}
