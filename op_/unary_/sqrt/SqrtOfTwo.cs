using System;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using nilnul.num.rational.float_.based;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace nilnul.num.real._test.op
{
	[TestClass]
	public class SqrtOfTwo_testClass
	{

		[TestMethod]
		public void SqrtOfTwo()
		{






			





		}

		public rational.Rational_InheritFraction2 ToRationa(RealI_withAccuracy2 real, BigInteger accuracy) {

			real.makeAccurate(

				nilnul.num.rational.Accuracy2.CreateSymmetricOpen(
					nilnul.num.rational.op.InverseX.Inverse(
						accuracy
					)

				)	
					
			);

			return real.rational;
		
		}

		


		
	}
}
