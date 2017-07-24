using System;
using NUnit.Framework;
using ExercisesForProgrammers; //TipCalculator project

namespace TipCalculator.Tests
{
    [TestFixture]
    public class FunctionalTests
    {
        [Test]
        public void BillAndTipSetupWithRealisticValues_ShouldCalculateTipAmountAndTotal()
        {
            //arrange

            //input
            double billAmount = 10.00; //dollars
            int tipRate = 15; //percent (of subtotal)

            double expectedTipAmount = 1.50; //dollars
            double expectedTotalAmount = 11.50; //dollars

            //act
            var tip = new Tip();
            double actualTipAmount = tip.Calculate(billAmount, tipRate);

            var bill = new Bill() { Tip = tip };
            var actualTotalAmount = bill.Total;

            //assert
            Assert.AreEqual(expectedTipAmount, actualTipAmount, "Actual tip amount does not equal expected tip amount.");
            Assert.AreEqual(expectedTotalAmount, actualTotalAmount, "Actual total amount does not equal expected total amount.");
        }

        [Test]
        public void GoodTest_OutputFormatting()
        {
            //arrange
            string expectedTipFormat = "$1.50";
            double tipAmount = 1.50d;

            //act
            var actualTipFormatted = tipAmount.ToString("C");

            //assert
            Assert.AreEqual(expectedTipFormat, actualTipFormatted);
        }

        [Test]
        public void Test_ZeroTipPercentageInput()
        {
			throw new NotImplementedException();
        }

        /// <summary>
        /// Defines the current requirement 
        /// -- might be nice to have a minimum tip in the future.
        /// </summary>
        [Test]
        public void Test_ZeroSubtotalInput()
        {
			throw new NotImplementedException();
        }

        [Test]
        public void BadCase_NonNumericInput_ShouldOutputErrorMessage() {
            throw new NotImplementedException();    
        }

        [Test]
        public void BaseCase_NegativeTipPercentage_ShouldOutputErrorMessage() {
            throw new NotImplementedException();
        }

		[Test]
		public void BaseCase_NegativeSubtotal_ShouldOutputErrorMessage()
		{
			throw new NotImplementedException();
		}

    }
}
