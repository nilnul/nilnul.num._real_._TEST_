using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.num.quotient.stream_.cauchy_._wallis.approach
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var approach = new nilnul.num._real.cauchy_._wallis.Approach();

			var r=nilnul.num.quotient.stream_._cauchy.ApproachX.Dec_digitsAftDot(approach,4);
			Debug.WriteLine(r);
		}
	}
}
