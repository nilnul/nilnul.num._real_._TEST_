﻿using System;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.num._real_._TEST_.co_.starT_.positive.pow_.byOpSupBorder.radicR_.indexQ_.unital
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var radic = nilnul.num.real_.Euler.Singleton;
			var index =  nilnul.num.real_.Quotient.CreateByDivide
				(1,3);



			ofOriginIndex("1.39561242509", radic, index);
			
		}
		public void ofOriginIndex(string origin, nilnul.num.RealI radic, nilnul.num.RealI index)
		{
			

			var dec = nilnul.num.quotient_.radix_.Dec1.Parse(origin);
			var dotPosition = dec.dotPosition;
			var precision = dec.significandInRadix.abs.digits.Count - dotPosition;

			var quotient = nilnul.num.quotient.op_.unary_._IndexX.RetQuotient(
				10, -precision + 2
				);


			var r =  nilnul.num.real.co_.starT_.positive.pow_._ByOpSupBorderX.RetReal(radic, index);

			var discrepancy = r - dec.toQ();

			var discrepancyAbs = nilnul.num.real.op_.unary_.Abs.Singleton.op_retReal(discrepancy);


			nilnul.bit.vow_.True.Singleton.vow(
				discrepancyAbs < quotient
			);
		}

	}
}
