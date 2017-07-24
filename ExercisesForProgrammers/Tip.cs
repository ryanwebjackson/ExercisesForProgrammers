using System;

namespace ExercisesForProgrammers
{
    public class Tip
    {
        public double Value { get; private set; }

        // Feels a bit weird, as subtotal of a bill is not really part of a tip.
        // Including it here, because it is needed to calculate a tip's value,
        //   and can be used for program consistency checking.
        private double _subtotal;
        public double Subtotal {
			get
			{
				return _subtotal;
			}
			set
			{
                this.Calculate(value, _percentageOfSubtotal);
				_subtotal = value;
			}        
        }

        private int _percentageOfSubtotal;
        public int PercentageOfSubtotal { 
            get {
                return _percentageOfSubtotal;
            }
            set {
                this.Calculate(_subtotal, value);
                _percentageOfSubtotal = value;
            }
        }

        public Tip()
        {
        }

        public Tip(double subtotal, int percentageOfSubtotal) {
            this.Value = this.Calculate(subtotal, percentageOfSubtotal);
        }

        public double Calculate(double subtotal, int percentageOfSubtotal) {
            this._subtotal = subtotal;
            this._percentageOfSubtotal = percentageOfSubtotal;

            var result = ((double)percentageOfSubtotal / 100d);
            result = subtotal * result;

            this.Value = result;
            return result;
        }
    }
}
