using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.num._real_._TEST_.stream_.slider.series_.arcsin_.ofPortion
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var expected = "0.523598776";
			ofOriginIndex(expected);
		}

		public void ofOriginIndex(string origin)
		{


			var dec = nilnul.num.quotient_.radix_.Dec1.Parse(origin);

			var dotPosition = dec.dotPosition;

			var precision = dec.significandInRadix.abs.digits.Count - dotPosition;

			var quotient = nilnul.num.quotient.op_.unary_._IndexX.RetQuotient(
				10,
				-precision + 2
				);

			var slider = new nilnul.num.real.stream_.slider.series_.arcsin_.OfPortion(
				nilnul.num.Quotient1.CreateHalf()
			);


			slider.Clamp(
				quotient
			);



			var discrepancy = slider.current.ToReal() - dec.toQ();

			var discrepancyAbs = nilnul.num.real.op_.unary_.Abs.Singleton.op_retReal(discrepancy);

			

			var real2dec = nilnul.num.real.to_._RadixX._Clamp2Dec_DigitsAftDot(slider.current, precision);

			Debug.WriteLine(
				real2dec
			);

			var discrepancy2dec = nilnul.num.real.to_._RadixX._Clamp2Dec_DigitsAftDot(discrepancyAbs, precision);


			nilnul.bit.vow_.true_.Unacceptable.Singleton.vow(
				discrepancyAbs < quotient
			);
		}
	}
}
