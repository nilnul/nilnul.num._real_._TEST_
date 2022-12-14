using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.num.real_.tau
{
	[TestClass]
	public class UnitTest11
	{
		[TestMethod]
		public void TestMethod1()
		{

			ofOriginIndex("3.14159265358979323846264338327950288");
			

		}

	
		public void ofOriginIndex(string origin)
		{
			

			var dec = nilnul.num.quotient_.radix_.Dec1.Parse(origin);
			var dotPosition = dec.dotPosition;
			var precision = dec.significandInRadix.abs.digits.Count - dotPosition;

			var quotient = nilnul.num.quotient.op_.unary_._IndexX.RetQuotient(
				10, -precision + 2
				);


			var r = nilnul.num.real_.Tau.Singleton.Half().ToReal();//.SingletonAsReal;

			var discrepancy = r - dec.toQ();

			var discrepancyAbs = nilnul.num.real.op_.unary_.Abs.Singleton.op_retReal(discrepancy);

			var real2dec = nilnul.num.real.to_._RadixX._Clamp2Dec_DigitsAftDot(r, precision);
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
