using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using r = nilnul.num.real;
using q = nilnul.num.quotient;
using System.Numerics;

namespace nilnul.num.real._test.subS
{
	[TestClass]
	public class UnitTest1
	{
		static public double Approximate = 0.57721566490153286060651209008240243104215933593992;

		[TestMethod]
		public void Euler_macsys()
		{
			var euler = new r.sub._eulerConst.Macys_nSquare();
			euler.ConvergeToUnitFraction(100);
			Debug.WriteLine(
					q._radix.Dec.FroQ(
						euler.interval.midpoint
						,10
					)
			);

			euler.ConvergeToUnitFraction(1000);	;
			Debug.WriteLine(
					q._radix.Dec.FroQ(
						euler.interval.midpoint
						,10
					)
			);

		}
		[TestMethod]
		public void Euler_macsys_quotic()
		{
			var euler = new r.sub._eulerConst.Macys_quatic();
			euler.ConvergeToUnitFraction(100);
			Debug.WriteLine(
					q._radix.Dec.FroQ(
						euler.interval.midpoint
						,10
					)
			);

			euler.ConvergeToUnitFraction(1000);	;
			Debug.WriteLine(
					q._radix.Dec.FroQ(
						euler.interval.midpoint
						,10
					)
			);

		}
		[TestMethod]
		public void Euler_macsys_quatic_mil()
		{
			var euler = new r.sub._eulerConst.Macys_quatic();
			euler.ConvergeToUnitFraction(100);	;
			Debug.WriteLine(
					q._radix.Dec.FroQ(
						euler.interval.midpoint
						,10
					)
			);

			euler.ConvergeToUnitFraction(1000);	;
			Debug.WriteLine(
					q._radix.Dec.FroQ(
						euler.interval.midpoint
						,10
					)
			);
			euler.ConvergeToUnitFraction(1000000);	;
			Debug.WriteLine(
					q._radix.Dec.FroQ(
						euler.interval.midpoint
						,7
					)
			);

		}

		[TestMethod]
		public void Euler_macsys_quatic_10e10()
		{
			var euler = new r.sub._eulerConst.Macys_quatic();
			euler.ConvergeToUnitFraction(100);	;
			Debug.WriteLine(
					q._radix.Dec.FroQ(
						euler.interval.midpoint
						,10
					)
			);

			euler.ConvergeToUnitFraction(1000);	;
			Debug.WriteLine(
					q._radix.Dec.FroQ(
						euler.interval.midpoint
						,10
					)
			);
			euler.ConvergeToUnitFraction(10000000000);	;
			Debug.WriteLine(
					q._radix.Dec.FroQ(
						euler.interval.midpoint
						,11
					)
			);

		}
		[TestMethod]
		public void Euler_macsys_poly12_10e10()
		{
			var euler = new r.sub._eulerConst.Macys_poly12_();
	
			euler.ConvergeToUnitFraction(10000000000);	;
			Debug.WriteLine(
					q._radix.Dec.FroQ(
						euler.interval.midpoint
						,11
					)
			);

		}
		[TestMethod]
		public void Euler_macsys_poly12_10e12()
		{
			var euler = new r.sub._eulerConst.Macys_poly12_();
	
			euler.ConvergeToUnitFraction(BigInteger.Pow(10, 12));	;
			Debug.WriteLine(
					q._radix.Dec.FroQ(
						euler.interval.midpoint
						,13
					)
			);

		}

		[TestMethod]
		public void Euler_macsys_poly12_10e20()
		{

			_Euler_macsys_poly12_10e_x(20);

		}

		[TestMethod]
		[Obsolete("too slow. use ^12, or 10e12")]
		public void Euler_macsys_poly12_10e30()
		{

			_Euler_macsys_poly12_10e_x(30);

		}

		public void _Euler_macsys_poly12_10e_x( int x)
		{
			var euler = new r.sub._eulerConst.Macys_poly12_();
	
			euler.ConvergeToUnitFraction(BigInteger.Pow(10, x));	;
			Debug.WriteLine( r.sub._eulerConst.EulerConstant.DecStr);
			Debug.WriteLine(
					q._radix.Dec.FroQ(
						euler.interval.midpoint
						,x+1
					)
			);

		}
			[TestMethod]
		public void Euler_macsys_poly12_10e8()
		{
			var euler = new r.sub._eulerConst.Macys_poly12_();
	
			euler.ConvergeToUnitFraction(BigInteger.Pow(10,8));	;
			Debug.WriteLine(
					q._radix.Dec.FroQ(
						euler.interval.midpoint
						,9
					)
			);

		}
			[TestMethod]
		public void Euler_macsys_poly12_10e7()
		{
			var euler = new r.sub._eulerConst.Macys_poly12_();
	
			euler.ConvergeToUnitFraction(BigInteger.Pow(10,7));	;
			Debug.WriteLine(
					q._radix.Dec.FroQ(
						euler.interval.midpoint
						,8
					)
			);

		}

		[TestMethod]
		public void Euler_macsys_poly12_10e6()
		{
			var euler = new r.sub._eulerConst.Macys_poly12_();
	
			euler.ConvergeToUnitFraction(BigInteger.Pow(10,6));	;
			Debug.WriteLine(
					q._radix.Dec.FroQ(
						euler.interval.midpoint
						,11
					)
			);

		}
			[TestMethod]
		public void Euler_macsys_poly12()
		{
			var euler = new r.sub._eulerConst.Macys_poly12_();
			euler.ConvergeToUnitFraction(100);	;
			Debug.WriteLine(
					q._radix.Dec.FroQ(
						euler.interval.midpoint
						,10
					)
			);

			euler.ConvergeToUnitFraction(1000);	;
			Debug.WriteLine(
					q._radix.Dec.FroQ(
						euler.interval.midpoint
						,10
					)
			);
			

		}

			[TestMethod]
		public void Euler_macsys_poly12_myriad()
		{
			var euler = new r.sub._eulerConst.Macys_poly12_();
			euler.ConvergeToUnitFraction(100);	;
			Debug.WriteLine(
					q._radix.Dec.FroQ(
						euler.interval.midpoint
						,10
					)
			);

			euler.ConvergeToUnitFraction(10000);	;
			Debug.WriteLine(
					q._radix.Dec.FroQ(
						euler.interval.midpoint
						,10
					)
			);
			

		}
	[TestMethod]
		[Obsolete("too slow to be useful. see Euler_macsys_quatic")]
		public void Euler_macsys_mil()
		{
			var euler = new r.sub._eulerConst.Macys_nSquare();
			euler.ConvergeToUnitFraction(100);	;
			Debug.WriteLine(
					q._radix.Dec.FroQ(
						euler.interval.midpoint
						,10
					)
			);

			euler.ConvergeToUnitFraction(1000);	;
			Debug.WriteLine(
					q._radix.Dec.FroQ(
						euler.interval.midpoint
						,10
					)
			);
			euler.ConvergeToUnitFraction(1000000);	;
			Debug.WriteLine(
					q._radix.Dec.FroQ(
						euler.interval.midpoint
						,10
					)
			);

		}
		[TestMethod]
		public void Euler_macsys_myriad()
		{
			var euler = new r.sub._eulerConst.Macys_nSquare();
			//euler.ConvergeToUnitFraction(100);	;
			//Debug.WriteLine(
			//		q._radix.Dec.FroQ(
			//			euler.interval.midpoint
			//			,10
			//		)
			//);

			//euler.ConvergeToUnitFraction(1000);	;
			//Debug.WriteLine(
			//		q._radix.Dec.FroQ(
			//			euler.interval.midpoint
			//			,10
			//		)
			//);
			euler.ConvergeToUnitFraction(10000);	;
			Debug.WriteLine(
					q._radix.Dec.FroQ(
						euler.interval.midpoint
						,5
					)
			);

		}
		[TestMethod]
		public void Euler_macsys_quatic_myriad()
		{
			var euler = new r.sub._eulerConst.Macys_quatic();
			//euler.ConvergeToUnitFraction(100);	;
			//Debug.WriteLine(
			//		q._radix.Dec.FroQ(
			//			euler.interval.midpoint
			//			,10
			//		)
			//);

			//euler.ConvergeToUnitFraction(1000);	;
			//Debug.WriteLine(
			//		q._radix.Dec.FroQ(
			//			euler.interval.midpoint
			//			,10
			//		)
			//);
			euler.ConvergeToUnitFraction(10000);	;
			Debug.WriteLine(
					q._radix.Dec.FroQ(
						euler.interval.midpoint
						,5
					)
			);

		}


	}
}
