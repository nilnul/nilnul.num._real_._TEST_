using System;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.real.op.sqrt;
using nilnul.num.rational.float_.based;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using Q = nilnul.num.rational.Rational_InheritFraction2;
using q = nilnul.num.quotient;
using System.Diagnostics;

namespace nilnul.num.real._test.op
{
	[TestClass]
	public class Exp_ofEuler
	{

		

		

		[TestMethod]
		public void ExpOfEuler()
		{
			//var a=E_ToRational(0);
			var a1 = _ToRational_tillInverseOf(1);
			var a2 = _ToRational_tillInverseOf(2);
			var a3 = _ToRational_tillInverseOf(3);
			var a4 = _ToRational_tillInverseOf(4);
			var a10 = _ToRational_tillInverseOf(10);
			var a100 = _ToRational_tillInverseOf(100);
			var a1000 = _ToRational_tillInverseOf(1000);
			//var a1000_000_000 =
                ; Debug.WriteLine( q._radix.Dec.FroQ( _ToRational_tillInverseOf(1000000000), 10));
			//var a1000_000_000_000_000_000 = _ToRational_tillInverseOf(BigInteger.Parse("1000000000000000000"));
			//var a1000_000_000_000_000_000_000 = _ToRational_tillInverseOf(BigInteger.Parse("1000000000000000000000"));





		}
		//private RealI3 _e= 		 new nilnul.num.real.E4();

		private RealI_posConverge2NonEmpty _expOfEuler;

		public Exp_ofEuler()
		{
			_expOfEuler=  nilnul.num.real.op.Exp.Eval(new nilnul.num.real._subtypeS._eulerConst.Macys_poly12_());


		}


		private nilnul.num.rational.Rational_InheritFraction2 _ToRational_tillInverseOf(BigInteger i) {


			_expOfEuler.converge(
				new nilnul.num.rational.be.Positive.Asserted(
					nilnul.num.rational.op.InverseX.Inverse(
						i
					)
				
				)	
			);

			return _expOfEuler.interval.midpoint;

			
		}


		
	}
}
