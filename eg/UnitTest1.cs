using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using r = nilnul.num.real;
using System.Linq;
using System.Linq.Expressions;
using System.Diagnostics;

namespace nilnul.num.real._test._real.eg
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void WallisProduct()
		{
			new r._real.eg.WallisProduct().Take(100).ForEach(x=>Debug.WriteLine( nilnul.num.quotient.Radix._FroQuotient(10, x,10)));
			

		}
	}
}
