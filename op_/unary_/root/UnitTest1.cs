using System;
using System.Diagnostics;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.num._real_._TEST_.op_.unary_.root
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var arg = 3;
			var degree = 3;

			var degreeAsNUm = new nilnul.Num1(degree);


			ofOriginIndex("1.44224957031", arg, degreeAsNUm);
			
		}

		public void ofOriginIndex(string origin, nilnul.num.Real index, nilnul.Num1 poly)
		{
			ofOriginIndex(origin, index as RealI, poly);
		}
		public void ofOriginIndex(string origin,  nilnul.num.RealI index,nilnul.Num1 poly)
		{
			var dec = nilnul.num.quotient_.radix_.Dec1.Parse(origin);
			var dotPosition = dec.dotPosition;
			var precision = dec.significandInRadix.abs.digits.Count - dotPosition;

			var quotient = nilnul.num.quotient.op_.unary_._IndexX.RetQuotient(
				10, -precision + 2
			);

			var r = new nilnul.num.real.op_.unary_.Root(poly).op_retReal( index);

			var discrepancy = r - dec.toQ();

			var discrepancyAbs = nilnul.num.real.op_.unary_.Abs.Singleton.op_retReal(discrepancy);

			var real2dec = nilnul.num.real.to_._RadixX._Clamp2Dec_DigitsAftDot(r,precision);


			var discrepancy2dec = nilnul.num.real.to_._RadixX._Clamp2Dec_DigitsAftDot(discrepancyAbs, precision);

			Debug.WriteLine(real2dec);
			nilnul.bit.vow_.true_.Unacceptable.Singleton.vow(
				discrepancyAbs < quotient
			);
		}

	}
}
