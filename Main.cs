using System;

namespace uk.co.timwise.NumberCruncher
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			while (true){
				Console.Write("Enter digits: ");
				var input = Console.ReadLine();
				int number = 0;
				if (!int.TryParse(input, number)) {
					Console.WriteLine("not a valid number");
					continue;
				}
				var cruncher = new NumberCruncher(number);
				Console.WriteLine("You entered " + cruncher.ToString());
			}
		}
	}
}
