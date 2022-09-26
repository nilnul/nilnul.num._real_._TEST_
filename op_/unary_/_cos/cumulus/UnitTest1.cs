using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.num._real_._TEST_.op_.unary_._cos.cumulus
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var slider = new nilnul.num.real.op_.unary_._cos.of_._quotient.Cumulus(1);


			nilnul.obj.StreamX2.Fetch(slider, 20).ForEach(x => Debug.WriteLine(x));

				
			var slider1 = new nilnul.num.real.op_.unary_._cos.of_._quotient.Cumulus(29);


			nilnul.obj.StreamX2.Fetch(slider1, 20).ForEach(x => Debug.WriteLine(x));


		}
	}
}
