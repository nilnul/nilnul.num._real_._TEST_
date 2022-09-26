using System;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.num._real_._TEST_.op_.binary_.pow.radicN_.indexQ_
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var radic = new nilnul.num.Quotient1( 2);
			var index = new nilnul.num.Quotient1( 1,2);



			ofOriginIndex("1.41421356237", radic, index);
			
		}
		public void ofOriginIndex(string origin, nilnul.num.Quotient1 radic, nilnul.num.Quotient1 index)
		{
			

			var dec = nilnul.num.quotient_.radix_.Dec1.Parse(origin);
			var dotPosition = dec.dotPosition;
			var precision = dec.significandInRadix.abs.digits.Count - dotPosition;

			var quotient = nilnul.num.quotient.op_.unary_._IndexX.RetQuotient(
				10, -precision + 2
				);


			var r = nilnul.num.real.co_.starT_.positive._PowX.RetReal(radic, index);

			var discrepancy = r - dec.toQ();

			var discrepancyAbs = nilnul.num.real.op_.unary_.Abs.Singleton.op_retReal(discrepancy);
			var real2dec = nilnul.num.real.to_._RadixX._Clamp2Dec_DigitsAftDot(r, precision);


			var discrepancy2dec = nilnul.num.real.to_._RadixX._Clamp2Dec_DigitsAftDot(discrepancyAbs, precision);



			nilnul.bit.vow_.true_.Unacceptable.Singleton.vow(
				discrepancyAbs < quotient
			);
		}

	}
}