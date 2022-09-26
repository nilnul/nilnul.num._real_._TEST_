using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.num._real_._TEST_.op_.unary_.exp.of_.neg_
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var origin = "0.36787944117";

			var dec = nilnul.num.quotient_.radix_.Dec1.Parse(origin);
			var dotPosition = dec.dotPosition;
			var precision = dec.significandInRadix.abs.digits.Count - dotPosition;

			var quotient = nilnul.num.quotient.op_.unary_._IndexX.RetQuotient(
				10, - precision + 2
				);


			var r = nilnul.num.real.op_.unary_.Exp.Singleton.op_retReal(-1);

			var discrepancy = r - dec.toQ();

			var discrepancyAbs = nilnul.num.real.op_.unary_.Abs.Singleton.op_retReal(discrepancy);

			nilnul.bit.vow_.true_.Unacceptable.Singleton.vow(
				discrepancyAbs < quotient
			);
		}
	}
}
