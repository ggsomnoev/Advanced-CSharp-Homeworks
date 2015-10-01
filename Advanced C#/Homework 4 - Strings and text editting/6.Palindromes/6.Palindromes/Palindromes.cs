using System;
using System.Collections.Generic;

namespace Palindromes
{
	class MainClass
	{
		public static void Main ()
		{
			string[] userInputWords = Console.ReadLine ().Split (new char[] { ' ', ',', '.', '!', '?' },
			StringSplitOptions.RemoveEmptyEntries);
			SortedSet<string> palindromes = new SortedSet<string> ();

			for (int i = 0; i < userInputWords.Length; i++) {
				char[] characters = userInputWords [i].ToCharArray ();
				Array.Reverse (characters);
				string wordReversed = new string (characters);

				if(wordReversed == userInputWords[i]) {
					palindromes.Add (userInputWords [i]);
				}
			}

			Console.WriteLine (String.Join(", ", palindromes));
		}
	}
}
