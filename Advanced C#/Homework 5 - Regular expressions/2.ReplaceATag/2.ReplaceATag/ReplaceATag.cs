using System;
using System.Text.RegularExpressions;

namespace ReplaceATag
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string userInput = Console.ReadLine();
			string pattern = @"<a\s+href=([""']*http://\w+.[a-zA-Z]{2,4}[""']*)>(\w+)</a>"; // * -> to work without "" or ''
			string replace = "[URL href=$1]$2[/URL]";

			Console.WriteLine (Regex.Replace (userInput, pattern, replace));
		}
	}
}

