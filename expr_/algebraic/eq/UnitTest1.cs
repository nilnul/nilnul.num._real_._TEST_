using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.real.expr_._algebraic;
using System;
using System.Diagnostics;

namespace nilnul.num._real_._TEST_.expr_.algebraic.eq
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var a = new nilnul.num.real.expr_.Var1("a");
			var b = new nilnul.num.real.expr_.Var1("b");
			var c = new nilnul.num.real.expr_.Var1("c");
			var d = new nilnul.num.real.expr_.Var1("d");

			//var one=new nilnul.num.real_.Quotient(1);
			var one=new nilnul.num.real.expr_._algebraic.pows.prod.Scaled_powIndexPositive(1);

			var p = ( a.AsPow() + b) *(a.AsPow()+b);
			var pSimplified = p.asSimplify();
			Debug.WriteLine(pSimplified);

			var p2 = new nilnul.num.real.expr_._algebraic.Pow_indexPositive(a, 2)
				+

				2*one *a*b
				+
new nilnul.num.real.expr_._algebraic.Pow_indexPositive(b, 2)
				;

			Debug.WriteLine(p);
			Debug.WriteLine(p2);

			var minus = p - p2;
			Debug.WriteLine("minused:");
			Debug.WriteLine(minus);

			Debug.WriteLine("minused simplified:");
			Debug.WriteLine(minus.asSimplify());

			Debug.Assert(
				num.real.expr_.algebraic.Eq.Singleton.Equals(p,p2)
			);



		}
	}
}
