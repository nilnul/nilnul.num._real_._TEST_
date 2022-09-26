using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.real.double_.interval.duo;
using System.Diagnostics;


namespace nilnul.num.real._test.double_.interval.duo
{
	[TestClass]
	public class MutualPosition_testClass
	{
		[TestMethod]
		public void MutualPosition_test()
		{

			Debug.Assert(
				MutualPosition.Eval(
					nilnul.num.real.double_.Interval3._CreateClosed(1, 2)
					,
					real.double_.Interval3._CreateClosed(1, 2)
				) == 0
			);
			Debug.Assert(
				MutualPosition.Eval(
					nilnul.num.real.double_.Interval3._CreateClosed(1, 2)
					,
					real.double_.Interval3._CreateClopen(1, 2)
				) == 0
			);

			
			Debug.Assert(
				MutualPosition.Eval(
					nilnul.num.real.double_.Interval3._CreateClosed(1, 1)
					,
					real.double_.Interval3._CreateClosed(1, 1)
				) == 0
			);



			Debug.Assert(
				MutualPosition.Eval(
					nilnul.num.real.double_.Interval3._CreateClosed(1, 1)
					,
					real.double_.Interval3._CreateClopen(1, 2)
				) == 0
			);
			Debug.Assert(
				MutualPosition.Eval(

					real.double_.Interval3._CreateClopen(1, 2)
,
					nilnul.num.real.double_.Interval3._CreateClosed(1, 1)

				) == 0
			);



			Debug.Assert(
				MutualPosition.Eval(
					nilnul.num.real.double_.Interval3._CreateClosed(1, 1)
					,
					real.double_.Interval3._CreateOpenClose(1, 2)
				) < 0
			);
			Debug.Assert(
				MutualPosition.Eval(


					real.double_.Interval3._CreateOpenClose(1, 2)
					,
					nilnul.num.real.double_.Interval3._CreateClosed(1, 1)


				) >0
			);




			Debug.Assert(
				MutualPosition.Eval(
					nilnul.num.real.double_.Interval3._CreateClosed(1, 1)
					,
					real.double_.Interval3._CreateOpen(1, 2)
				) < 0
			);

			Debug.Assert(
				MutualPosition.Eval(
					
					real.double_.Interval3._CreateOpen(1, 2)
					,
					nilnul.num.real.double_.Interval3._CreateClosed(1, 1)

				) > 0
			);


		}
	}
}
