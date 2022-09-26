using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.num._real_._TEST_.eg_.goldenRation
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var r =  nilnul.num.real_.GoldenRatio.Singleton;

			

			_this.Contrast.ofOriginIndex("1.6180339887", r);

		}


	}
}
