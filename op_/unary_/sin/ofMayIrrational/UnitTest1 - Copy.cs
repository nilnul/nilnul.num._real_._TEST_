using System;
using System.Diagnostics;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.num._real_._TEST_.op_.unary_.sin
{
	[TestClass]
	public class UnitTest11
	{
		[TestMethod]
		public void TestMethod1()
		{

			ofOriginIndex("0.70710678118", num.real_.Tau.Singleton.ToReal()/8);

			ofOriginIndex("1.000000", num.real_.Tau.Singleton.ToReal()/4);
			ofOriginIndex("0.000000", num.real_.Tau.Singleton.ToReal()/2);
			ofOriginIndex("0.000000", num.real_.Tau.Singleton);
			ofOriginIndex("0.58778525229", num.real_.Tau.Singleton*new num.real_. Quotient(11,10));

			ofOriginIndex("0.95105651629", num.real_.Tau.Singleton*new num.real_. Quotient(12,10));
			ofOriginIndex("0.95105651629", num.real_.Tau.Singleton*new num.real_. Quotient(13,10));

			ofOriginIndex("-0.80901699437", num.real_.Tau.Singleton*new num.real_. Quotient(13,20));
			ofOriginIndex("1.000000000", num.real_.Tau.Singleton*new num.real_. Quotient(25,20));



			ofOriginIndex("-0.80901699437", num.real_.Tau.Singleton*new num.real_. Quotient(73,20));
			//t0o large//ofOriginIndex("0.80901699437", num.real_.Tau.Singleton*new num.real_. Quotient(403,20));

		}

		public void ofOriginIndex(string origin, nilnul.num.Real index)
		{
			ofOriginIndex(origin, index as RealI);
		}
		public void ofOriginIndex(string origin,  nilnul.num.RealI index)
		{
			var dec = nilnul.num.quotient_.radix_.Dec1.Parse(origin);
			var dotPosition = dec.dotPosition;
			var precision = dec.significandInRadix.abs.digits.Count - dotPosition;

			var quotient = nilnul.num.quotient.op_.unary_._IndexX.RetQuotient(
				10, -precision + 2
			);

			var r =  nilnul.num.real.op_.unary_.Sin.Singleton.op( index).ToReal();

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
