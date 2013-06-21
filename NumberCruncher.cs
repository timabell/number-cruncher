using System;
using System.Text;

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
			var english = new StringBuilder();
			english.Append(number);
			return english.ToString();
		}
	}
}

