using System;
using System.Diagnostics;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.num._real_._TEST_.op_.unary_.exp.of_.neg_.ofReal
{
	[TestClass]
	public class UnitTest111
	{
		[TestCategory("passed")]
		[TestMethod]
		public void TestMethod1()
		{
			var index = nilnul.num.real_.nonneg.op_.unary_._SqrtX.RetRealI(2);
			ofOriginIndex("4.11325037878", index );
			
		}
		public void ofOriginIndex( string origin, RealI index)
		{
			//var origin = "0.13533528323";
			//var index = -2;

			var dec = nilnul.num.quotient_.radix_.Dec1.Parse(origin);
			var dotPosition = dec.dotPosition;
			var precision = dec.significandInRadix.abs.digits.Count - dotPosition;

			var quotient = nilnul.num.quotient.op_.unary_._IndexX.RetQuotient(
				10, - precision + 2
				);


			var r = nilnul.num.real.op_.unary_.Exp.Singleton.op_retReal(index);

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
