using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.num.real._test._real.approach_.tau_._odd_PositiveSquare__UnderEight.odd_PositiveSquare.underFour
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void PI_ContinuedFrac_Odd_PositiveSquare()
		{

			var slider = new nilnul.num._real.approach_.tau_._one__Plus__OddSince3_PositiveSquare___UnderEight.oddSince3_PositiveSquare.PlusOne_UnderEight();
			for (int i = 0; i < 100; i++)
			{
				slider.moveNext();
			}

			Debug.WriteLine(
				nilnul.num.quotient.radix.DecX.ToDec(

				slider.current
				,
				100
				)
			);
		}
	}
}
