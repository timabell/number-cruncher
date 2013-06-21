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
			return NumberToWords(number);
		}
		
		// sourced from http://stackoverflow.com/a/2730393/10245 because I'm not a fan of tedious repetition of already solved problems.
		private string NumberToWords(int number)
		{
		    if (number == 0)
		        return "zero";
		
		    if (number < 0)
		        return "minus " + NumberToWords(Math.Abs(number));
		
		    string words = "";
		
		    if ((number / 1000000) > 0)
		    {
		        words += NumberToWords(number / 1000000) + " million ";
		        number %= 1000000;
		    }
		
		    if ((number / 1000) > 0)
		    {
		        words += NumberToWords(number / 1000) + " thousand ";
		        number %= 1000;
		    }
		
		    if ((number / 100) > 0)
		    {
		        words += NumberToWords(number / 100) + " hundred ";
		        number %= 100;
		    }
		
		    if (number > 0)
		    {
		        if (words != "")
		            words += "and ";
		
		        var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
		        var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
		
		        if (number < 20)
		            words += unitsMap[number];
		        else
		        {
		            words += tensMap[number / 10];
		            if ((number % 10) > 0)
		                words += " " + unitsMap[number % 10];
		        }
		    }
		
		    return words;
		}
	}
}

