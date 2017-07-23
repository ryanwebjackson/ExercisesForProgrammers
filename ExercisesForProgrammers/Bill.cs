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
	            this.Tip.Calculate(value, this.Tip.PercentageOfSubtotal);
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
			{ //TODO: Write a test for this.
                this.Subtotal = value.Subtotal;
                this.Total = _subtotal + value.Value;
                _tip = value;
			}
        }

        public double Total { get; private set; }


        public Bill()
        {
            this.Tip = new Tip();
        }

		public Bill(double subtotal, Tip tip)
        {
            this._subtotal = subtotal;

            if (subtotal.CompareTo(tip.Subtotal) == 0 || tip.Value.CompareTo(0D) == 0)
            {
                this._tip = tip;
            }
            else
            {
                throw new ArgumentException("Tip given not calculated against given subtotal");
            }
        }
    }
}
