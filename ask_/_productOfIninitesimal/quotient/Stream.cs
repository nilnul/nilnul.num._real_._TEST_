using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._real_._TEST_.ask_._productOfIninitesimal.quotient
{
	public class Stream:nilnul.num.quotient.StreamI6
	{
		public nilnul.Num1 index;

		 BigInteger _increment=0;

		public Stream(nilnul.Num1 index)
		{
			this.index = index;
		}

		public Quotient1 next()
		{
			_increment++;

			if (_increment<index.en)
			{
				return 1;
			}
			if (_increment== index.en)
			{
				return nilnul.num.op_.binary_.Pow.Singleton.op(
					_increment,
					_increment-1
				);
			}
			return nilnul.num.Quotient1.CreateUnit(_increment);
		}
	}
}
