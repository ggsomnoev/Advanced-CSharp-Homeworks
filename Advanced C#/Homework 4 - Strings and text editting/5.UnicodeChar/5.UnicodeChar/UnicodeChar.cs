using System;
using System.Collections.Generic;
using System.Text;

namespace UnicodeChar
{
	class MainClass
	{
		public static void Main (string[] args)
		{				
			string userInput = Console.ReadLine ();
			StringBuilder unicodeRep = new StringBuilder ();

			for (int i = 0; i < userInput.Length; i++) {
				unicodeRep.Append (GetEscapeSequence (userInput [i]));
			}
			Console.WriteLine (unicodeRep);
		}
		public static string GetEscapeSequence(char c)
		{
			return "\\u" + ((int)c).ToString("X4");
		}
	}
}
