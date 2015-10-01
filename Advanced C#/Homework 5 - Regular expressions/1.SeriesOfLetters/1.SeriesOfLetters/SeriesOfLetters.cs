using System;
using System.Text.RegularExpressions;

namespace SeriesOfLetters
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string userInput = Console.ReadLine();
			Console.WriteLine(Regex.Replace(userInput, @"(\w)\1+", "$1"));
		}
	}
}
// INFO:

///(\w)\1+/
//	1st Capturing group (\w)
//		\w match any word character [a-zA-Z0-9_]
//		\1+ matches the same text as most recently matched by the 1st capturing group
//		Quantifier: + Between one and unlimited times, as many times as possible, giving back as needed [greedy]


//
///$1/
//	$ assert position at end of the string
//		1 matches the character 1 literally