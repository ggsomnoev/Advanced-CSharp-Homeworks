using System;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string userInput = Console.ReadLine();
			string emailPattern = @"([\w.]*\w+@\w+.[\w.]*[a-zA-Z]{2,4})";

			MatchCollection matches = Regex.Matches(userInput, emailPattern);
			foreach (Match match in matches)
			{
				Console.WriteLine(match.Value);
			}
		}
	}
}

