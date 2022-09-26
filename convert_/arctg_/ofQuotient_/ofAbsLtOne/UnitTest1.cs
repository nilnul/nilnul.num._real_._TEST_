using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.num._real_._TEST_.convert_.arctg_.ofQuotient_.ofAbsLtOne
{

	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var mapping = new Dictionary<nilnul.num.Quotient1, string>()
			{
				
				[-new nilnul.num.Quotient1(1, 2)] = "-.463647609"//this takes long
				,
				[0] = ".00000"
				,
				[new nilnul.num.Quotient1(1, 2)] = "0.463647609"//this takes long

				


			};

			mapping.ForEach(
				kv =>
				ofOriginIndex(kv.Value, kv.Key)
			);
			//ofOriginIndex("0.0000", 0);
			//ofOriginIndex("0.463647609", new nilnul.num.Quotient1(1, 2)); //this takes long
			//ofOriginIndex("0.66577375", nilnul.num.real_.TauX.Eighth);

			//ofOriginIndex("0.785398163", 1);

			//ofOriginIndex("1.26262726", nilnul.num.real_.TauX.Half);




		}

		//public void ofOriginIndex(string origin, nilnul.num.Real index)
		//{
		//	ofOriginIndex(origin, index as RealI);
		//}
		public void ofOriginIndex(string origin, nilnul.num.Quotient1 index)
		{
			var dec = nilnul.num.quotient_.radix_.Dec1.Parse(origin);
			var dotPosition = dec.dotPosition;
			var precision = dec.significandInRadix.abs.digits.Count - dotPosition;

			var quotient = nilnul.num.quotient.op_.unary_._IndexX.RetQuotient(
				10, -precision + 2
			);

			var r = nilnul.num.real.convert_.arctg_._OfQuotientX._ofAbsLtOne(index).ToReal();

			var discrepancy = r - dec.toQ();

			var discrepancyAbs = nilnul.num.real.op_.unary_.Abs.Singleton.op_retReal(discrepancy);

			var real2dec = nilnul.num.real.to_._RadixX._Clamp2Dec_DigitsAftDot(r, precision);


			var discrepancy2dec = nilnul.num.real.to_._RadixX._Clamp2Dec_DigitsAftDot(discrepancyAbs, precision);

			Debug.WriteLine(real2dec);
			nilnul.bit.vow_.true_.Unacceptable.Singleton.vow(
				discrepancyAbs < quotient
			);
		}

	}
}
