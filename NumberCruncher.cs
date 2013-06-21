using System;

namespace uk.co.timwise.NumberCruncher
{
	public class NumberCruncher
	{
		int number;
		
		public NumberCruncher (int number)
		{
			this.number = number;
		}
		
		public override string ToString ()
		{
			return string.Format ("[NumberCruncher]");
		}
	}
}

