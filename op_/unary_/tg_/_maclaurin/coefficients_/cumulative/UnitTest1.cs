using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.num._real_._TEST_.op_.unary_.tg_._maclaurin.coefficients_.cumulative
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var coefficients = new nilnul.num.real.op_.unary_.tg_._maclaurin.coefficients_.Cumulative();
			for (int i = 0; i < 10; i++)
			{
				Trace.WriteLine(coefficients.current);
				coefficients.moveNext();

			}

			
		}
	}
}
