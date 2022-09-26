using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Linq;

namespace nilnul.num._real_._TEST_.expr_.algebraic.matrix_.sq_.vandermonde.determinant
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var n = 10;
			var vars= Enumerable.Range(0,n).Select(i=> new nilnul.num.real.expr_.Var1()).ToArray();

			Debug.Assert(

				nilnul.num.real.expr_.algebraic.Eq.Singleton.Equals(
					//nilnul.num.real.expr_.algebraic.matrix_.square_.
					nilnul.num.real.expr_.algebraic.matrix_.square_.vandermonde._DeterminantX.DeterminantOfVars(vars)
					,
nilnul.num.real.expr_.algebraic.matrix_.square_.vandermonde._DeterminantX.DeterminantOfVars_byProduct(vars)

				)
			); ;
		}
	}
}
