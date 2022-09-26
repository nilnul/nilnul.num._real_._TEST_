using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.num._real_._TEST_.op_.unary_.exp.of_
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var r = nilnul.num.real.op_.unary_.Exp.Singleton.op_retReal(0);

			nilnul.bit.vow_.true_.Unacceptable.Singleton.vow(r==1);

			//var limit = nilnul.num.real.to_._RadixX._Clamp2Dec_DigitsAftDot(
			//   r
			//   ,
			//   10
		 //  );

			//Debug.WriteLine(
			//	limit
			//);
		}
	}
}
