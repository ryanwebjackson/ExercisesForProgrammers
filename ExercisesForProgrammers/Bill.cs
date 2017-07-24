using System;
namespace ExercisesForProgrammers
{
    public class Bill
    {
        private double _subtotal;
        public double Subtotal { 
            get {
				return _subtotal;
			}
			set {
                if (this._tip == null) {
                    this._tip = new Tip();
                }
                this._tip.Calculate(value, this._tip.PercentageOfSubtotal);
				_subtotal = value;
			}
        }

        private Tip _tip;
        public Tip Tip
        {
			get
			{
                return _tip;
			}
			set
			{
                _tip = value;
				this.Subtotal = value.Subtotal;
            }
        }

        public double Total
        { 
            get
            {
                return _subtotal + this._tip.Value;
            }
        }

    }
}
