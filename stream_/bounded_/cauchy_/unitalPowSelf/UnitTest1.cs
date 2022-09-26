using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace nilnul.num._real_._TEST_.stream_.bounded_.cauchy_.unitalPowSelf
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var s = new nilnul.num.real.stream_.bounded_.cauchy_.UnitalPowSelf();

			var i = 1000000;
			while (i-- > 0)
			{
				Debug.WriteLine(
					nilnul.num.real.to_._RadixX._Clamp2Dec_DigitsAftDot(
						s.current
						,
						7
					)
				);

				s.moveNext();
			}
		}
	}
}
