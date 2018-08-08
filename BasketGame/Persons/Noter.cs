using BasketGame.GameDependencies;
using BasketGame.GameField;
using System.Collections.Generic;

namespace BasketGame.Persons
{
    public class Noter : Player
    {
        private List<int> _previousValues = new List<int>();

        private void _setValue(int result)
        {
            this._previousValues.Add(result);
            base.PrintAttempt("NOTER", result);
            FieldForGame.Attempts.Add(result);
        }

        public override void DoAttempt()
        {
            int result = base.RandomAttempt(40, 140);

            if (_previousValues.Count != 0)
            {
                foreach (int item in _previousValues.ToArray())
                {
                    if (item != result)
                    {
                        this._setValue(result);
                    }
                }
            }
            else
            {
                this._setValue(result);
            }
        }
    }
}
