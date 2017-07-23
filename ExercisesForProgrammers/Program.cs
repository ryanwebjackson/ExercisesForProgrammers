using System;

namespace ExercisesForProgrammers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is the bill amount? ");
			string billInput = Console.ReadLine();
            var newBill = new Bill() { Subtotal = Convert.ToDouble(billInput.Trim()) };

            Console.WriteLine("What is the tip percentage? ");
            string tipInput = Console.ReadLine();
            var percentageOfSubtotal = Convert.ToInt32(tipInput.Trim());
            var newTip = new Tip(newBill.Subtotal, percentageOfSubtotal); //Assignment of subtotal is a bit odd here.
            newBill.Tip = newTip;

            Console.WriteLine($"The tip is {newTip.Value}. ");

            Console.WriteLine($"The total is {newBill.Total}. ");

            Console.ReadLine(); // Wait for user to end program.
        }
    }
}
