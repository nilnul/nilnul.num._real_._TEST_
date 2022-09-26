using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.num.real._test._real.approach.convert_._tg.series
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void tg_series()
		{
			var q = 1;
			Debug.WriteLine(
			Math.Tan(
				1
			));

			var tgVal = new nilnul.num._real.approach.convert_._tg.of_._quotient.Series(q);

			for (int i = 0; i < 10; i++)
			{
				Debug.WriteLine(
					nilnul.num.quotient.radix.Dec.FroQuotient(
					tgVal.accumulated
					,4
					)
				);
				tgVal.moveNext();

			}
		}
	}
}
