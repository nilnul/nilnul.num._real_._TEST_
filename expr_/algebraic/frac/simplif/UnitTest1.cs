using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num._real_._TEST_.expr_.algebraic.frac.simplif
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			/// a^3 * b + a^2 * b^2
			/// /
			/// a*b^3
			/// where ab is the common divisor
			/// and dividing ab for both numerator and denominator
			/// we get:
			///		a^2  + ab
			///		/
			///		b^2
		}

		public void t()
		{
			/// ac-bc
			/// /
			/// a^2 - b^2
			///
			/// =>
			/// (a-b)c
			/// /
			/// (a-b)(a+b)
			///
			/// =>
			/// c/(a+b)
		}

	}
}
