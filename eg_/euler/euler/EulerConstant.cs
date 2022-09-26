using System;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.real.op.sqrt;
using nilnul.num.rational.float_.based;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Diagnostics;

namespace nilnul.num.real._test._instanceS
{
	[TestClass]
	public class EulerConstant
	{

		
		
		

		[TestMethod]
		public void EulerConstant_ToRational_accuracy()
		{

			//var a=E_ToRational(0);
			var a1 = E_ToRational_accuracy(1);
			Debug.WriteLine(a1);
			var a2 = E_ToRational_accuracy(2);
			Debug.WriteLine(a2);
			var a3 = E_ToRational_accuracy(3);
			Debug.WriteLine(a3);
			var a4 = E_ToRational_accuracy(4);
			var a10 = E_ToRational_accuracy(10);
			var a100 = E_ToRational_accuracy(100);
			Debug.WriteLine(a100);
			Debug.WriteLine(quotient.radix.Recur.Q2Recur_decimal(a100,10) );


			var a1000 = E_ToRational_accuracy(1000);

			Debug.WriteLine(quotient.radix.Recur.Q2Recur_decimal(a1000,10) );




			//var a1000_000_000 = E_ToRational_accuracy(1000000000);
			//var a1000_000_000_000_000_000 = E_ToRational_accuracy(BigInteger.Parse("1000000000000000000"));
			//var a1000_000_000_000_000_000_000 = E_ToRational_accuracy(BigInteger.Parse("1000000000000000000000"));





		}

		
		private nilnul.num.real._instanceS.EulerConstant e5 = new real._instanceS.EulerConstant();

		private nilnul.num.rational.Rational_InheritFraction2 E_ToRational_accuracy(BigInteger n)
		{

			e5.converge(
				new nilnul.num.rational.be.Positive.Asserted(nilnul.num.rational.op.InverseX.Inverse(n))
			);

			return e5.interval.midpoint;



		}


		
	}
}
