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
			{
                this.Total = value.Value;
				_subtotal = value;
			}
        }

        public double Total { get; private set; }


        public Bill()
        {
            this.Tip = new Tip();
        }
    }
}
