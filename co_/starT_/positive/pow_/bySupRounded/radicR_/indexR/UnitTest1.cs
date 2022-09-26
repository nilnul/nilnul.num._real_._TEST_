using System;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.num._real_._TEST_.co_.starT_.positive.pow_.bySupRounded.radicR_.indexR_
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var radic = nilnul.num.real_.Euler.Singleton;
			var index = nilnul.num.real_.Euler.Singleton;



			ofOriginIndex("15.1542622415", radic, index);
			
		}
		public void ofOriginIndex(string origin, nilnul.num.RealI radic, nilnul.num.RealI index)
		{
			

			var dec = nilnul.num.quotient_.radix_.Dec1.Parse(origin);
			var dotPosition = dec.dotPosition;
			var precision = dec.significandInRadix.abs.digits.Count - dotPosition;

			var quotient = nilnul.num.quotient.op_.unary_._IndexX.RetQuotient(
				10, -precision + 2
				);


			var r =  nilnul.num.real.co_.starT_.positive.pow_._BySupRoundedX.RetReal(radic, index);

			var discrepancy = r - dec.toQ();

			var discrepancyAbs = nilnul.num.real.op_.unary_.Abs.Singleton.op_retReal(discrepancy);


			nilnul.bit.vow_.True.Singleton.vow(
				discrepancyAbs < quotient
			);
		}

	}
}
