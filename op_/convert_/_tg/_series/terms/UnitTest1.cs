using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.num.real._test._real.approach.convert_._tg._series.terms
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void tg_terms()
		{
			var terms = new nilnul.num._real.approach.convert_._tg.of_._quotient._series.TermsGivenByUnreliableSrc(1);

			for (int i = 0; i < 10; i++)
			{
				
				Debug.WriteLine(
					terms.current.toTxt()
					
				);
				terms.moveNext();

			}
		}
	}
}
