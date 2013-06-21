using System;
using NUnit.Framework;

namespace uk.co.timwise.NumberCruncher
{
	[TestFixture()]
	public class CruncherTests
	{
		[TestCase(1, "one")]
		[TestCase(21, "twenty one")]
		[TestCase(105, "one hundred and five")]
		[TestCase(56945781, "fifty six million nine hundred and forty five thousand seven hundred and eighty one")]
		public void TestCruncherMapping (int number, string expectedEnglish)
		{
			// arrange
			var cruncher = new NumberCruncher(number);
			// act
			var actualEnglish = cruncher.ToString();
			// assert
			Assert.AreEqual(expectedEnglish, actualEnglish);
		}
	}
}

