using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.num._real_._TEST_.op_.unary_.ln
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var r = nilnul.num.real.op_.unary_.Ln.Singleton.op(1);

			var limit = nilnul.num.real.to_._RadixX._Clamp2Dec_DigitsAftDot(
			   r
			   ,
			   10
		   );

			Debug.WriteLine(
				limit
			);
		}
	}
}
