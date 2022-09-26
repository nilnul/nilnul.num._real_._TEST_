using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num._real_._TEST_.eq.ofDbl
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var d = 3.3d;
			var d2l=BitConverter.DoubleToInt64Bits(d);


		}
	}
}
