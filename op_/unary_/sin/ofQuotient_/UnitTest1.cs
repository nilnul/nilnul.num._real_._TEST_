﻿using System;
using System.Diagnostics;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.num._real_._TEST_.op_.unary_.sin.ofQuotient_
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var arg = 0;


			ofOriginIndex("0", arg);
			


			ofOriginIndex("0.8414709848", 1);
			ofOriginIndex("0.90929742682", 2);

			ofOriginIndex("0.14112000806", 3);
			ofOriginIndex("-0.7568024953", 4);
			ofOriginIndex("-0.95892427466", 5);

			ofOriginIndex("-0.27941549819", 6);

			ofOriginIndex("0.65698659871", 7);

			ofOriginIndex("0.98935824662", 8);

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
