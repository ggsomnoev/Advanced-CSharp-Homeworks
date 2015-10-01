using System;
using System.Text.RegularExpressions;

namespace SentenceExtractor
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string keyword = Console.ReadLine();
			string text = Console.ReadLine();

			string pattern = string.Format(@"[^!.?]*\b{0}\b[^!.?]*[!.?]", keyword);
			MatchCollection foundMatches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

			foreach (Match sentence in foundMatches)
			{
				Console.WriteLine(sentence.ToString().Trim(' '));
			}
		}
	}
}
